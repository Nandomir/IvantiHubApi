﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace IvantiHubApi.Tests.Features.Models.Validators
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TriangleVerticesModelValidator")]
    public partial class TriangleVerticesModelValidatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "TriangleVerticesModelValidator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Models/Validators", "TriangleVerticesModelValidator", "    In order to validate the coordinates of a triangle\r\n    As IvantiHubApp\r\n    " +
                    "I want to ensure they are within the specified bounds", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate coordinates for different bounds")]
        [NUnit.Framework.TestCaseAttribute("0", "0", "0", "0", "0", "0", "true", null)]
        [NUnit.Framework.TestCaseAttribute("-1", "0", "0", "0", "0", "0", "false", null)]
        [NUnit.Framework.TestCaseAttribute("0", "-1", "0", "0", "0", "0", "false", null)]
        [NUnit.Framework.TestCaseAttribute("61", "0", "0", "0", "0", "0", "false", null)]
        [NUnit.Framework.TestCaseAttribute("0", "61", "0", "0", "0", "0", "false", null)]
        public void ValidateCoordinatesForDifferentBounds(string v1X, string v1Y, string v2X, string v2Y, string v3X, string v3Y, string isValid, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("V1x", v1X);
            argumentsOfScenario.Add("V1y", v1Y);
            argumentsOfScenario.Add("V2x", v2X);
            argumentsOfScenario.Add("V2y", v2Y);
            argumentsOfScenario.Add("V3x", v3X);
            argumentsOfScenario.Add("V3y", v3Y);
            argumentsOfScenario.Add("IsValid", isValid);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate coordinates for different bounds", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
    testRunner.Given(string.Format("I have the TriangleVerticesModel with coordinates V1x {0}, V1y {1}, V2x {2}, V2y " +
                            "{3}, V3x {4}, and V3y {5}", v1X, v1Y, v2X, v2Y, v3X, v3Y), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
    testRunner.When("I validate the model", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
    testRunner.Then(string.Format("the validation result should be {0}", isValid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
