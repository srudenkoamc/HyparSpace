using Elements;
using Elements.Geometry;
using Elements.Geometry.Solids;

namespace Elements
{
    public partial class Door
    {
        public const double DOOR_THICKNESS = 0.125;
        public const double DOOR_FRAME_THICKNESS = 0.15;
        public const double DOOR_FRAME_WIDTH = 2 * 0.0254; //2 inches

        public Door(WallCandidate wall, Vector3 position, DoorType type, double width, double height) :
            this(WidthWithoutFrame(width, type), type, wall, height, material: new Material("Door material", Colors.White))
        {
            OriginalPosition = position;
            var adjustedPosition = GetClosestValidDoorPos(wall.Line);
            Transform = new Transform(adjustedPosition, wall.Line.Direction(), Vector3.ZAxis);
        }

        public Vector3 OriginalPosition
        {
            get; private set;
        }

        public static bool CanFit(Line wallLine, DoorType type, double width)
        {
            var doorWidth = WidthWithoutFrame(width, type) + DOOR_FRAME_WIDTH * 2;
            return wallLine.Length() - doorWidth > DOOR_FRAME_WIDTH * 2;
        }

        public override bool TryToGraphicsBuffers(out List<GraphicsBuffers> graphicsBuffers, out string id, out glTFLoader.Schema.MeshPrimitive.ModeEnum? mode)
        {
            List<Vector3> points = new List<Vector3>();
            points.AddRange(CollectSchematicVisualizationLines(true, false, 90));
            if( Type == DoorType.Double)
            {
                points.AddRange(CollectSchematicVisualizationLines(false, false, 90));
            }

            GraphicsBuffers buffer = new GraphicsBuffers();
            Color color = Colors.Black;
            for (int i = 0; i < points.Count; i++)
            {
                buffer.AddVertex(points[i], default, default, color);
                buffer.AddIndex((ushort)i);
            }

            id = $"{this.Id}_door";
            // Only one type is allowed, since line are not linked into one loop, LINES is used.
            // This mean that each line segment need both endpoints stored, often duplicated.
            mode = glTFLoader.Schema.MeshPrimitive.ModeEnum.LINES;
            graphicsBuffers = new List<GraphicsBuffers> { buffer };
            return true;
        }

        private List<Vector3> CollectSchematicVisualizationLines(bool leftSide, bool inside, double angle)
        {
            var doorWidth = Type == DoorType.Double ? ClearWidth / 2 : ClearWidth;

            // Depending on which side door in there are different offsets.
            var doorOffset = leftSide ? ClearWidth / 2 : -ClearWidth / 2;
            var horizontalOffset = leftSide ? DOOR_THICKNESS : -DOOR_THICKNESS;
            var verticalOffset = inside ? DOOR_THICKNESS : -DOOR_THICKNESS;
            var widthOffset = inside ? doorWidth : -doorWidth;

            // Draw open door silhouette rectangle.
            Vector3 corner = Vector3.XAxis * doorOffset;
            var c0 = corner + Vector3.YAxis * verticalOffset;
            var c1 = c0 + Vector3.YAxis * widthOffset;
            var c2 = c1 - Vector3.XAxis * horizontalOffset;
            var c3 = c0 - Vector3.XAxis * horizontalOffset;

            // Rotate silhouette is it's need to be drawn as partially open.
            if (!angle.ApproximatelyEquals(90))
            {
                double rotation = 90 - angle;
                if (!leftSide)
                {
                    rotation = -rotation;
                }

                if (!inside)
                {
                    rotation = -rotation;
                }

                Transform t = new Transform();
                t.RotateAboutPoint(c0, Vector3.ZAxis, rotation);
                c1 = t.OfPoint(c1);
                c2 = t.OfPoint(c2);
                c3 = t.OfPoint(c3);
            }
            List<Vector3> points = new List<Vector3>() { c0, c1, c1, c2, c2, c3, c3, c0 };

            // Calculated correct arc angles based on door orientation.
            double adjustedAngle = inside ? angle : -angle;
            double anchorAngle = leftSide ? 180 : 0;
            double endAngle = leftSide ? 180 - adjustedAngle : adjustedAngle;
            if (endAngle < 0)
            {
                endAngle = 360 + endAngle;
                anchorAngle = 360;
            }

            // If arc is constructed from bigger angle to smaller is will have incorrect domain 
            // with max being smaller than min and negative length.
            // ToPolyline will return 0 points for it.
            // Until it's fixed angles should be aligned manually.
            bool flipEnds = endAngle < anchorAngle;
            if (flipEnds)
            {
                (anchorAngle, endAngle) = (endAngle, anchorAngle);
            }
            
            // Draw the arc from closed door to opened door.
            Arc arc = new Arc(c0, doorWidth, anchorAngle, endAngle);
            var tessalatedArc = arc.ToPolyline((int)(Math.Abs(angle) / 2));
            for (int i = 0; i < tessalatedArc.Vertices.Count - 1; i++)
            {
                points.Add(tessalatedArc.Vertices[i]);
                points.Add(tessalatedArc.Vertices[i + 1]);
            }

            return points;
        }

        public override void UpdateRepresentations()
        {
            Vector3 left = Vector3.XAxis * ClearWidth / 2;
            Vector3 right = Vector3.XAxis.Negate() * ClearWidth / 2;

            var doorPolygon = new Polygon(new List<Vector3>() {
                left + Vector3.YAxis * DOOR_THICKNESS, 
                left - Vector3.YAxis * DOOR_THICKNESS,
                right - Vector3.YAxis * DOOR_THICKNESS,
                right + Vector3.YAxis * DOOR_THICKNESS});
            var doorExtrude = new Extrude(new Profile(doorPolygon), ClearHeight, Vector3.ZAxis);

            var frameLeft = left + Vector3.XAxis * DOOR_FRAME_WIDTH;
            var frameRight = right - Vector3.XAxis * DOOR_FRAME_WIDTH;
            var frameOffset = Vector3.YAxis * DOOR_FRAME_THICKNESS;
            var doorFramePolygon = new Polygon(new List<Vector3>() {
                left + Vector3.ZAxis * ClearHeight - frameOffset,
                left - frameOffset,
                frameLeft - frameOffset,
                frameLeft + Vector3.ZAxis * (ClearHeight + DOOR_FRAME_WIDTH) - frameOffset,
                frameRight + Vector3.ZAxis * (ClearHeight + DOOR_FRAME_WIDTH) - frameOffset,
                frameRight - frameOffset,
                right - frameOffset,
                right + Vector3.ZAxis * ClearHeight - frameOffset });
            var doorFrameExtrude = new Extrude(new Profile(doorFramePolygon), DOOR_FRAME_THICKNESS * 2, Vector3.YAxis);

            Representation = new Representation(new List<SolidOperation>() { doorExtrude, doorFrameExtrude });
        }

        private Vector3 GetClosestValidDoorPos(Line wallLine)
        {
            var fullWidth = ClearWidth + DOOR_FRAME_WIDTH * 2;
            double wallWidth = wallLine.Length();
            Vector3 p1 = wallLine.PointAt(0.5 * fullWidth);
            Vector3 p2 = wallLine.PointAt(wallWidth - 0.5 * fullWidth);
            var reducedWallLine = new Line(p1, p2);
            return OriginalPosition.ClosestPointOn(reducedWallLine);
        }

        private static double WidthWithoutFrame(double internalWidth, DoorType type)
        {
            switch (type)
            {
                case DoorType.Single:
                    return internalWidth;
                case DoorType.Double:
                    return internalWidth * 2;
            }
            return 0;
        }
    }
}