
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace SpacePlanningZones
{
    public class SpacePlanningZonesTest
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> {
                {"Levels", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/SpacePlanningZones/test/Generated/SpacePlanningZonesTest/model_dependencies/Levels/model.json")) },
                {"Columns", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/SpacePlanningZones/test/Generated/SpacePlanningZonesTest/model_dependencies/Columns/model.json")) },
                {"Program Requirements", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/SpacePlanningZones/test/Generated/SpacePlanningZonesTest/model_dependencies/Program Requirements/model.json")) },
                {"Floors", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/SpacePlanningZones/test/Generated/SpacePlanningZonesTest/model_dependencies/Floors/model.json")) },
                {"Walls", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/SpacePlanningZones/test/Generated/SpacePlanningZonesTest/model_dependencies/Walls/model.json")) },
                {"Core", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/ZonePlanningFunctions/SpacePlanningZones/test/Generated/SpacePlanningZonesTest/model_dependencies/Core/model.json")) },
            };

            var result = SpacePlanningZones.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/SpacePlanningZonesTest/results/SpacePlanningZonesTest.glb");
            File.WriteAllText("../../../Generated/SpacePlanningZonesTest/results/SpacePlanningZonesTest.json", result.Model.ToJson());
        }

        public SpacePlanningZonesInputs GetInput()
        {
            var inputText = @"
            {
  ""Default Program Assignment"": ""unspecified"",
  ""Circulation Mode"": ""Automatic"",
  ""Add Corridors"": {
    ""SplitLocations"": []
  },
  ""Depth at Ends"": 8,
  ""Split Zones"": {
    ""SplitLocations"": []
  },
  ""Corridors"": [],
  ""Corridor Width"": 1.5,
  ""Outer Band Depth"": 6,
  ""Manual Split Locations"": [],
  ""model_input_keys"": {
    ""Levels"": ""59291271-38db-4496-b235-055686d77be2_61dbb9f8-aaae-4295-9112-c8ae81655361_elements.zip"",
    ""Columns"": ""f59a3fe0-c173-4d10-bb11-de0a8dc9a030_6a8c567d-6a2e-4402-a713-7474170bd302_elements.zip"",
    ""Program Requirements"": ""0e43d337-ceef-4e07-93f5-848c64a47867_ac2d042f-ede8-4f11-9d6e-ae3ffe849e81_elements.zip"",
    ""Floors"": ""f59a3fe0-c173-4d10-bb11-de0a8dc9a030_6a8c567d-6a2e-4402-a713-7474170bd302_elements.zip"",
    ""Walls"": ""f59a3fe0-c173-4d10-bb11-de0a8dc9a030_6a8c567d-6a2e-4402-a713-7474170bd302_elements.zip"",
    ""Core"": ""18e8e727-e8d1-4401-baeb-49004d98ff36_a9cac5a1-f68d-4d2e-bfdd-0d204359bbe4_elements.zip""
  },
  ""Additional Corridor Locations"": []
}
            ";
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SpacePlanningZonesInputs>(inputText);
        }
    }
}