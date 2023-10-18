using LoggerLibrary;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TemplatePOM;
using TestSettings;

[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace TemplateTestScript
{
    [Binding]
    public sealed class Hooks : TestBase
    {
        private static ThreadLocal<string> runtimeReportPath = new ThreadLocal<string>();
        private TestSetting _testSettings;
        public string screenshotFolderPath = string.Empty;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            TestSetting testSetting = new TestSetting();
            runtimeReportPath.Value = new CommonHelper().GenerateReportDirectory(testSetting.ReportPath);
            runtimeReportPath.Value = runtimeReportPath.Value + featureContext.FeatureInfo.Title.Replace(" ", "_") + "\\";

            //For consolidated report
            //Log.InitializeConsolidatedReport(runtimeReportPath.Value, testSetting.ReportTheme);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            //For consolidated report
            //Log.FinalizeConsolidatedReport(runtimeReportPath.Value);
        }

        [BeforeScenario]
        public void BeforeScenario(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _testSettings = new TestSetting();

            Log.InitializeReport(runtimeReportPath.Value, scenarioContext.ScenarioInfo.Title, _testSettings.ReportTheme);
            Log.CreateLoggerTest($"{featureContext.FeatureInfo.Title}: {scenarioContext.ScenarioInfo.Title}", false);
            Log.Info($"{scenarioContext.ScenarioInfo.Title} | Browser Used - {_testSettings.Browser}");

            ApplicationName = new TemplatePOM.PageFactory(_testSettings);

            scenarioContext.Add("app", ApplicationName);

            //For concurrent driver operations - You can create a separate BeforeScenario with tags to filter
            //Application2Name = new TemplatePOM.PageFactory(_testSettings);
            //scenarioContext.Add("app2", Application2Name);
        }

        [AfterScenario]
        public void AfterScenario(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            //Capturing screenshot before every step
            ApplicationName = scenarioContext.Get<PageFactory>("app");
            CommonHelper.TakeScreenshot(ApplicationName);

            //to check if we missed to implement any step
            string resultOfImplementation = scenarioContext.ScenarioExecutionStatus.ToString();

            //Undefined Status
            if (resultOfImplementation == "UndefinedStep")
            {
                Log.StepNotDefined();
            }

            //To flush the report and rename filename
            string finalReportPath = Log.FinalizeReport(runtimeReportPath.Value, featureContext.FeatureInfo.Title + "_" + scenarioContext.ScenarioInfo.Title);
            TestContext.AddTestAttachment(finalReportPath);

            ApplicationName.CloseAllBrowsers();

            //For Concurrent driver operations
            //Application2Name = scenarioContext.Get<PageFactory>("app2");
            //Application2Name.CloseAllBrowsers();
        }

        [BeforeStep]
        public void BeforeStep(ScenarioContext scenarioContext)
        {
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepInfo = scenarioContext.StepContext.StepInfo.Text;

            //Capturing screenshot before every step
            ApplicationName = scenarioContext.Get<PageFactory>("app");
            string base64Image = ApplicationName.TakeBase64Screenshot();

            Log.StepInfo(stepType, stepInfo, base64Image);
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepInfo = scenarioContext.StepContext.StepInfo.Text;

            //to check if we missed to implement steps inside method
            string resultOfImplementation = scenarioContext.ScenarioExecutionStatus.ToString();

            if (scenarioContext.TestError != null)
            {
                ApplicationName = scenarioContext.Get<PageFactory>("app");
                string base64Image = ApplicationName.TakeBase64Screenshot();

                Exception? innerException = scenarioContext.TestError.InnerException;
                string? testErrorMessage = scenarioContext.TestError.Message;

                Log.StepFailed(stepType, stepInfo, innerException, testErrorMessage, base64Image);
            }
            else if (resultOfImplementation == "StepDefinitionPending")
            {
                Log.StepSkipped(stepType, "Step Definition Implementation Pending for " + stepInfo);
            }
        }
    }
}