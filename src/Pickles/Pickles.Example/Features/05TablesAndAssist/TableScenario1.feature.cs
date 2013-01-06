﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PicklesDoc.Pickles.Example.Features._05TablesAndAssist
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Showing table usage")]
    public partial class ShowingTableUsageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TableScenario.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Showing table usage", "In order to show how to use tables\r\nAs a SpecFlow evanglist\r\nI want to write some" +
                    " simple scenarios that uses tables tables", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using tables")]
        public virtual void UsingTables()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using tables", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred"});
            table1.AddRow(new string[] {
                        "Marcus",
                        "Cool",
                        "1972-10-09",
                        "50"});
            table1.AddRow(new string[] {
                        "Anders",
                        "Butch",
                        "1977-01-01",
                        "500"});
            table1.AddRow(new string[] {
                        "Jocke",
                        "Soft",
                        "1974-04-04",
                        "1000"});
#line 7
 testRunner.Given("I have the following persons", ((string)(null)), table1, "Given ");
#line 12
 testRunner.When("I search for Jocke", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred"});
            table2.AddRow(new string[] {
                        "Jocke",
                        "Soft",
                        "1974-04-04",
                        "1000"});
#line 13
 testRunner.Then("the following person should be returned", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using tables with SpecFlow Assist")]
        public virtual void UsingTablesWithSpecFlowAssist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using tables with SpecFlow Assist", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred"});
            table3.AddRow(new string[] {
                        "Marcus",
                        "Very cool",
                        "1972-10-09",
                        "50"});
            table3.AddRow(new string[] {
                        "Anders",
                        "Butch",
                        "1977-01-01",
                        "500"});
            table3.AddRow(new string[] {
                        "Jocke",
                        "Soft",
                        "1974-04-04",
                        "1000"});
#line 18
 testRunner.Given("I have the following persons using assist", ((string)(null)), table3, "Given ");
#line 23
 testRunner.When("I search for Jocke", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred"});
            table4.AddRow(new string[] {
                        "Jocke",
                        "Soft",
                        "1974-04-04",
                        "1000"});
#line 24
 testRunner.Then("the following person should be returned using assist", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating a entity from field value")]
        public virtual void CreatingAEntityFromFieldValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a entity from field value", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table5.AddRow(new string[] {
                        "Style",
                        "very cool"});
            table5.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table5.AddRow(new string[] {
                        "Cred",
                        "100"});
#line 29
 testRunner.When("I fill out the form like this", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred"});
            table6.AddRow(new string[] {
                        "Marcus",
                        "Very cool",
                        "1972-10-09",
                        "1000"});
#line 35
 testRunner.Then("the following person should be returned using assist", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Example of a wide table")]
        public virtual void ExampleOfAWideTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Example of a wide table", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred",
                        "Name",
                        "Style",
                        "Birth date",
                        "Cred"});
            table7.AddRow(new string[] {
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000",
                        "Marcus",
                        "Very cool",
                        "10/9/1972",
                        "1000"});
#line 40
 testRunner.Given("this wide table", ((string)(null)), table7, "Given ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
