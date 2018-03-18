﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WiproTestProject
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("WeatherForecastFeature1", Description="\tIn order to check that the forecast application works\r\n\tAs a user\r\n\tI want to be" +
        " told the forcast details for specified cities", SourceFile="SpecFlowFeature1.feature", SourceLine=0)]
    public partial class WeatherForecastFeature1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WeatherForecastFeature1", "\tIn order to check that the forecast application works\r\n\tAs a user\r\n\tI want to be" +
                    " told the forcast details for specified cities", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void Get5DayForecastForVariousCities(string city, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get 5 day forecast for Various Cities", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am on the forecast page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I have entered \'{0}\' into the city field and pressed Enter", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("forecast details for all five days should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get 5 day forecast for Various Cities, Aberdeen", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void Get5DayForecastForVariousCities_Aberdeen()
        {
#line 7
this.Get5DayForecastForVariousCities("Aberdeen", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get 5 day forecast for Various Cities, Dundee", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void Get5DayForecastForVariousCities_Dundee()
        {
#line 7
this.Get5DayForecastForVariousCities("Dundee", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get 5 day forecast for Various Cities, Edinburgh", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void Get5DayForecastForVariousCities_Edinburgh()
        {
#line 7
this.Get5DayForecastForVariousCities("Edinburgh", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get 5 day forecast for Various Cities, Glasgow", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void Get5DayForecastForVariousCities_Glasgow()
        {
#line 7
this.Get5DayForecastForVariousCities("Glasgow", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get 5 day forecast for Various Cities, Perth", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void Get5DayForecastForVariousCities_Perth()
        {
#line 7
this.Get5DayForecastForVariousCities("Perth", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get 5 day forecast for Various Cities, sTirling", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void Get5DayForecastForVariousCities_STirling()
        {
#line 7
this.Get5DayForecastForVariousCities("sTirling", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Display and hide 3 hourly forecast", SourceLine=21)]
        public virtual void DisplayAndHide3HourlyForecast()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display and hide 3 hourly forecast", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
testRunner.Given("I am on the forecast page with a five day forecast displayed for \'Dundee\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.When("I click on a day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.Then("the three hourly forecast details for that date should be displayed on the screen" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
testRunner.And("the three hourly forecast details are hidden when I click on the day again", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Current condition is shown in summary", SourceLine=29)]
        public virtual void CurrentConditionIsShownInSummary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Current condition is shown in summary", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.Given("I am on the forecast page with a five day forecast displayed for \'Dundee\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
testRunner.When("I click on a day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
testRunner.Then("the three hourly forecast details for that date should be displayed on the screen" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
testRunner.And("the summarised condition matches the current condition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Max temp and min temp shown in the summary", SourceLine=35)]
        public virtual void MaxTempAndMinTempShownInTheSummary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Max temp and min temp shown in the summary", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
testRunner.Given("I am on the forecast page with a five day forecast displayed for \'Dundee\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
testRunner.When("I click on a day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
testRunner.Then("the three hourly forecast details for that date should be displayed on the screen" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
testRunner.And("the summarised max and min temps match the values in the three hourly forecast", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("WindSpeed and Direction shown in the summary", SourceLine=41)]
        public virtual void WindSpeedAndDirectionShownInTheSummary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WindSpeed and Direction shown in the summary", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
testRunner.Given("I am on the forecast page with a five day forecast displayed for \'Dundee\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.When("I click on a day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.Then("the three hourly forecast details for that date should be displayed on the screen" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
testRunner.And("the summarised windspeed and direction match the current values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Aggregate Rainfall shown in the summary", SourceLine=47)]
        public virtual void AggregateRainfallShownInTheSummary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aggregate Rainfall shown in the summary", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
testRunner.Given("I am on the forecast page with a five day forecast displayed for \'Dundee\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
testRunner.When("I click on a day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("the three hourly forecast details for that date should be displayed on the screen" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
testRunner.And("the aggregate rainfall is shown in the summary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Display error message if city name not recognised", SourceLine=54)]
        public virtual void DisplayErrorMessageIfCityNameNotRecognised()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display error message if city name not recognised", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("I am on the forecast page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
testRunner.When("I have entered \'London\' into the city field and pressed Enter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
testRunner.Then("An error message should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
