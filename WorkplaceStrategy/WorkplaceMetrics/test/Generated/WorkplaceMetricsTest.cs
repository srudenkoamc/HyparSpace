
// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar test generate'.
// DO NOT EDIT THIS FILE.

using Elements;
using Xunit;
using System;
using System.IO;
using System.Collections.Generic;
using Elements.Serialization.glTF;

namespace WorkplaceMetrics
{
    public class WorkplaceMetricsTest
    {
        [Fact]
        public void TestExecute()
        {
            var input = GetInput();

            var modelDependencies = new Dictionary<string, Model> { 
                {"Floors", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Floors/8dafb9fa-e392-4ab8-be78-457e464b63aa.json")) }, 
                {"Space Planning Zones", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Space Planning Zones/5849601d-73e1-4b0a-b1eb-5ccf225b7b8a.json")) }, 
                {"Open Office Layout", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Open Office Layout/3b4b071e-1e6d-4227-ba01-cf21b92ea831.json")) }, 
                {"Meeting Room Layout", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Meeting Room Layout/2d718baf-3a06-4794-ad83-13c1d2e8ba84.json")) }, 
                {"Classroom Layout", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Classroom Layout/c87222fc-6f83-452f-a7ae-f266db972828.json")) }, 
                {"Phone Booth Layout", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Phone Booth Layout/ce1975ff-34d6-4c8f-8e6a-10875a291c76.json")) }, 
                {"Open Collaboration Layout", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Open Collaboration Layout/7dae7c6c-ae86-4700-b282-c48e758e0a59.json")) }, 
                {"Private Office Layout", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Private Office Layout/370c3c2e-07ba-4179-b0db-769c9764b891.json")) }, 
                {"Program Requirements", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Program Requirements/7615c611-4824-4e80-bdd7-d5b180a22c78.json")) }, 
                {"Circulation", Model.FromJson(File.ReadAllText(@"/Users/andrewheumann/Dev/HyparSpace/WorkplaceStrategy/WorkplaceMetrics/test/Generated/WorkplaceMetricsTest/model_dependencies/Circulation/aba61113-5851-4000-8ddc-7ca10e78bd4d.json")) }, 
            };

            var result = WorkplaceMetrics.Execute(modelDependencies, input);
            result.Model.ToGlTF("../../../Generated/WorkplaceMetricsTest/results/WorkplaceMetricsTest.gltf", false);
            result.Model.ToGlTF("../../../Generated/WorkplaceMetricsTest/results/WorkplaceMetricsTest.glb");
            File.WriteAllText("../../../Generated/WorkplaceMetricsTest/results/WorkplaceMetricsTest.json", result.Model.ToJson());

        }

        public WorkplaceMetricsInputs GetInput()
        {
            var json = File.ReadAllText("../../../Generated/WorkplaceMetricsTest/inputs.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<WorkplaceMetricsInputs>(json);
        }
    }
}