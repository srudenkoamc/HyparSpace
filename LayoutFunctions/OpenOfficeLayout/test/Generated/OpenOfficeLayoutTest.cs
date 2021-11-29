
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace OpenOfficeLayout
{
    public class OpenOfficeLayoutTest
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> { 
                {"Space Planning Zones", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/LayoutFunctions/OpenOfficeLayout/test/Generated/OpenOfficeLayoutTest/model_dependencies/Space Planning Zones/f4683c51-56e3-4bbf-9c8b-2ad2aa71471e.json")) }, 
            };

            var result = OpenOfficeLayout.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/OpenOfficeLayoutTest/results/OpenOfficeLayoutTest.gltf", false);
            result.Model.ToGlTF("../../../Generated/OpenOfficeLayoutTest/results/OpenOfficeLayoutTest.glb");
            File.WriteAllText("../../../Generated/OpenOfficeLayoutTest/results/OpenOfficeLayoutTest.json", result.Model.ToJson());
        }

        public OpenOfficeLayoutInputs GetInput()
        {
            var inputText = @"
            {
  ""Grid Rotation"": 0,
  ""Integrated Collaboration Space Density"": 0.2,
  ""Custom Workstation Properties"": {
    ""Length"": 2,
    ""Width"": 2
  },
  ""model_input_keys"": {
    ""Space Planning Zones"": ""f4683c51-56e3-4bbf-9c8b-2ad2aa71471e_09b8407f-6c93-4741-ad6c-31288213f4f7_elements.zip""
  },
  ""Desk Type"": ""Simple Desk - 24x48""
}
            ";
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenOfficeLayoutInputs>(inputText);
        }
    }
}