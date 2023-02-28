using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace LoggerLibrary
{
    /// <summary>
    /// Logger class
    /// </summary>
    public class Log
    {
        #region Fields

        private static readonly string base64ImageType = "base64";

        [ThreadStatic]
        private static ExtentReports extentReport;

        [ThreadStatic]
        private static ExtentReports extentReport_Consolidated;

        [ThreadStatic]
        private static ExtentTest extentTest;

        [ThreadStatic]
        private static ExtentTest extentTest_Consolidated;

        #endregion Fields

        #region Methods

        #region Report Creation/Ending

        /// <summary>
        /// This method creates test(Feature) under Extent report
        /// </summary>
        /// <param name="currentFeatureName">Name of feature</param>
        /// <param name="createConsolidatedReport">Pass TRUE if you require a consolidated report. Not applicable with parallel execution</param>
        public static void CreateLoggerTest(string currentFeatureName, bool createConsolidatedReport = false)
        {
            try
            {
                extentTest = extentReport.CreateTest(currentFeatureName.Split('-')[0]);
                if (createConsolidatedReport)
                    extentTest_Consolidated = extentReport_Consolidated.CreateTest(currentFeatureName.Split('-')[0]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method creates report
        /// </summary>
        /// <param name="extentReportPath">Path to save consolidated report</param>
        public static void FinalizeConsolidatedReport(string extentReportPath)
        {
            try
            {
                extentReport_Consolidated.Flush();

                //This is additional code to rename report file need to remove after extent report issue fix https://github.com/extent-framework/extentreports-csharp/issues/134
                string newFilename = extentReportPath + "Consolidated_Report.html";
                System.IO.File.Move(extentReportPath + "index.html", newFilename);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method creates the report
        /// </summary>
        /// <param name="extentReportPath">The path of extent report generated at time of execution</param>
        /// <param name="extentReportFilename">The name of extent report file to be given</param>
        /// <returns>Path of report file</returns>
        public static string FinalizeReport(string extentReportPath, string extentReportFilename)
        {
            try
            {
                extentReport.Flush();

                //This is additional code to rename report file need to remove after extent report issue fix https://github.com/extent-framework/extentreports-csharp/issues/134
                string newFilePathWithName = extentReportPath + string.Join("_", extentReportFilename.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)) + ".html";
                if (File.Exists(newFilePathWithName))
                {
                    Random random = new Random();
                    newFilePathWithName = extentReportPath + string.Join("_", extentReportFilename.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)) + "_" + DateTime.Now.ToString("ff") + random.Next(999999) + ".html";
                    System.IO.File.Move(extentReportPath + "index.html", newFilePathWithName);
                }
                else
                {
                    newFilePathWithName = extentReportPath + string.Join("_", extentReportFilename.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)) + ".html";
                    System.IO.File.Move(extentReportPath + "index.html", newFilePathWithName);
                }

                return newFilePathWithName;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Create report
        /// </summary>
        /// <param name="reportPath">path to store report</param>
        /// <param name="reportTheme">report theme</param>
        public static void InitializeConsolidatedReport(string reportPath, string reportTheme = "Standard")
        {
            try
            {
                //Initialize Extent report before test starts
                ExtentHtmlReporter htmlReporterConsolidated = new ExtentHtmlReporter(reportPath + "Consolidated_Report.html");

                switch (reportTheme.ToLower())
                {
                    case "dark":
                        htmlReporterConsolidated.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                        break;

                    case "standard":
                    default:
                        htmlReporterConsolidated.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
                        break;
                }

                //Attach report to reporter
                extentReport_Consolidated = new ExtentReports();

                extentReport_Consolidated.AttachReporter(htmlReporterConsolidated);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method creates html report and attach it to ExtentReport variable
        /// </summary>
        /// <param name="reportPath">Where the report should be saved</param>
        ///  <param name="reportFileName">This is the title of report file</param>
        /// <param name="reportTheme">Dark or standard theme option</param>
        public static void InitializeReport(string reportPath, string reportFileName, string reportTheme = "Standard")
        {
            try
            {
                //Initialize Extent report before test starts
                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath + string.Join("_", reportFileName.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)) + ".html");

                switch (reportTheme.ToLower())
                {
                    case "dark":
                        htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                        break;

                    case "standard":
                    default:
                        htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
                        break;
                }

                //Attach report to reporter
                extentReport = new ExtentReports();

                extentReport.AttachReporter(htmlReporter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Report Creation/Ending

        #region Passed Log

        /// <summary>
        /// This method is used to handle Passed step with message
        /// </summary>
        /// <param name="SuccessfulMessage">Success message to print</param>
        public static void Pass(string SuccessfulMessage)
        {
            try
            {
                extentTest.Pass($"<p style='color:green'>{SuccessfulMessage}</p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Pass($"<p style='color:green'>{SuccessfulMessage}</p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints pass message into log with expected and actual data
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Pass message to be displayed</param>
        public static void Pass(object expectedData, object actualData, string messageToDisplay)
        {
            try
            {
                extentTest.Pass($"<p style='color:green'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Pass($"<p style='color:green'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle Passed step with message. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="SuccessfulMessage">Success message to print</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Pass(string SuccessfulMessage, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Pass(SuccessfulMessage);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Pass($"<p style='color:green'>{SuccessfulMessage}</p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Pass($"<p style='color:green'>{SuccessfulMessage}</p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints pass message into log with expected and actual data. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Pass message to be displayed</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Pass(object expectedData, object actualData, string messageToDisplay, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Pass(expectedData, actualData, messageToDisplay);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Pass($"<p style='color:green'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Pass($"<p style='color:green'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for passed scenario
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step information/step</param>
        public static void StepPassed(string stepType, string stepInfo)
        {
            try
            {
                extentTest.Pass($"<p style='color:green'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Pass($"<p style='color:green'><b>{stepType} : </b> <i>{stepInfo}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for passed scenario. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step information/step</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void StepPassed(string stepType, string stepInfo, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    StepPassed(stepType, stepInfo);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Pass($"<p style='color:green'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Pass($"<p style='color:green'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Passed Log

        #region Failed Log

        /// <summary>
        /// This method is used to handle failed step with custom message printing
        /// </summary>
        /// <param name="failureMessage">Message to print on failure</param>
        public static void Fail(string failureMessage)
        {
            try
            {
                extentTest.Fail($"<p style='color:red'>{failureMessage}</p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<p style='color:red'>{failureMessage}</p>");

                throw new Exception(failureMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Fail message into log with expected and actual data
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Fail message to be displayed</param>
        public static void Fail(object expectedData, object actualData, string messageToDisplay)
        {
            try
            {
                extentTest.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");

                throw new Exception($"Expected Value - {expectedData} | Actual Value - {actualData} | Message - {messageToDisplay}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle failed step with custom message printing. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="failureMessage">Message to print on failure</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Fail(string failureMessage, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Fail(failureMessage);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Fail($"<p style='color:red'>{failureMessage}</p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'>{failureMessage}</p>", mediaEntityModelProvider);

                    throw new Exception(failureMessage);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Fail message into log with expected and actual data. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Fail message to be displayed</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Fail(object expectedData, object actualData, string messageToDisplay, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Fail(expectedData, actualData, messageToDisplay);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);

                    throw new Exception($"Expected Value - {expectedData} | Actual Value - {actualData} | Message - {messageToDisplay}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle failed step with custom message printing, without throwing exception on failure.
        /// </summary>
        /// <param name="failureMessage">Message to print on failure</param>
        public static void FailWithoutThrowingException(string failureMessage)
        {
            try
            {
                extentTest.Fail($"<p style='color:red'>{failureMessage}</p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<p style='color:red'>{failureMessage}</p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Fail message into log with expected and actual data. Without throwing exception.
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Fail message to be displayed</param>
        public static void FailWithoutThrowingException(object expectedData, object actualData, string messageToDisplay)
        {
            try
            {
                extentTest.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle failed step with custom message printing, without throwing exception on failure. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="failureMessage">Message to print on failure</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void FailWithoutThrowingException(string failureMessage, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    FailWithoutThrowingException(failureMessage);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Fail($"<p style='color:red'>{failureMessage}</p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'>{failureMessage}</p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Fail message into log with expected and actual data. Without throwing exception. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Fail message to be displayed</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void FailWithoutThrowingException(object expectedData, object actualData, string messageToDisplay, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    FailWithoutThrowingException(expectedData, actualData, messageToDisplay);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for Failed scenario
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        /// <param name="innerException">Inner exception occurred</param>
        /// <param name="testError">Error message</param>
        public static void StepFailed(string stepType, string stepInfo, Exception innerException, string testError)
        {
            try
            {
                extentTest.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (innerException != null)
                {
                    extentTest.Fail($"\n<p style=\"color: red\">Inner Exception - {innerException}</p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"\n<p style=\"color: red\">Inner Exception - {innerException}</p>");
                }
                if (testError != null || testError != "")
                {
                    extentTest.Fail($"\n<p style=\"color: red\">Test Error - {testError}</p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"\n<p style=\"color: red\">Test Error - {testError}</p>");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for Failed scenario. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        /// <param name="innerException">Inner exception occurred</param>
        /// <param name="testError">Error message</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void StepFailed(string stepType, string stepInfo, Exception innerException, string testError, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    StepFailed(stepType, stepInfo, innerException, testError);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);

                    extentTest.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (innerException != null)
                    {
                        extentTest.Fail($"\n<p style=\"color: red\">Inner Exception - {innerException}</p>", mediaEntityModelProvider);

                        if (extentTest_Consolidated != null)
                            extentTest_Consolidated.Fail($"\n<p style=\"color: red\">Inner Exception - {innerException}</p>", mediaEntityModelProvider);
                    }
                    if (testError != null || testError != "")
                    {
                        extentTest.Fail($"\n<p style=\"color: red\">Test Error - {testError}</p>", mediaEntityModelProvider);

                        if (extentTest_Consolidated != null)
                            extentTest_Consolidated.Fail($"\n<p style=\"color: red\">Test Error - {testError}</p>", mediaEntityModelProvider);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Failed Log

        #region Warning Log

        /// <summary>
        /// This method prints Gherkin format step for Warning scenario
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        /// <param name="innerException">Inner exception occurred</param>
        /// <param name="testWarning">Error message</param>
        public static void StepWarning(string stepType, string stepInfo, Exception innerException, string testWarning)
        {
            try
            {
                extentTest.Warning($"<p style='color:#eba834'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Warning($"<p style='color:#eba834'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (innerException != null)
                {
                    extentTest.Warning($"\n<p style=\"color:#eba834\">Inner Exception - {innerException}</p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Warning($"\n<p style=\"color:#eba834\">Inner Exception - {innerException}</p>");
                }
                if (testWarning != null || testWarning != "")
                {
                    extentTest.Warning($"\n<p style=\"color:#eba834\">Test Warning - {testWarning}</p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Warning($"\n<p style=\"color:#eba834\">Test Warning - {testWarning}</p>");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for Warning scenario. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        /// <param name="innerException">Inner exception occurred</param>
        /// <param name="testWarning">Error message</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void StepWarning(string stepType, string stepInfo, Exception innerException, string testWarning, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    StepWarning(stepType, stepInfo, innerException, testWarning);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Warning($"<p style='color:#eba834'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Warning($"<p style='color:#eba834'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (innerException != null)
                    {
                        extentTest.Warning($"\n<p style=\"color:#eba834\">Inner Exception - {innerException}</p>", mediaEntityModelProvider);

                        if (extentTest_Consolidated != null)
                            extentTest_Consolidated.Warning($"\n<p style=\"color:#eba834\">Inner Exception - {innerException}</p>", mediaEntityModelProvider);
                    }
                    if (testWarning != null || testWarning != "")
                    {
                        extentTest.Warning($"\n<p style=\"color:#eba834\">Test Warning - {testWarning}</p>", mediaEntityModelProvider);

                        if (extentTest_Consolidated != null)
                            extentTest_Consolidated.Warning($"\n<p style=\"color:#eba834\">Test Warning - {testWarning}</p>", mediaEntityModelProvider);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle warning step with message
        /// </summary>
        /// <param name="warningMessage">Message to print on warning</param>
        public static void Warning(string warningMessage)
        {
            try
            {
                extentTest.Warning($"<p style='color:#eba834'>{warningMessage}</p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Warning($"<p style='color:#eba834'>{warningMessage}</p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Warning message into log with expected and actual data
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Warning message to be displayed</param>
        public static void Warning(object expectedData, object actualData, string messageToDisplay)
        {
            try
            {
                extentTest.Warning($"<p style='color:#eba834'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Warning($"<p style='color:#eba834'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle warning step with message. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="warningMessage">Message to print on warning</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Warning(string warningMessage, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Warning(warningMessage);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Warning($"<p style='color:#eba834'>{warningMessage}</p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Warning($"<p style='color:#eba834'>{warningMessage}</p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Warning message into log with expected and actual data. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Warning message to be displayed</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Warning(object expectedData, object actualData, string messageToDisplay, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Warning(expectedData, actualData, messageToDisplay);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Warning($"<p style='color:#eba834'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Warning($"<p style='color:#eba834'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Warning Log

        #region Info Log

        /// <summary>
        /// This method prints Gherkin format step for Info scenario
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        public static void BeforeStepInfo(string stepType, string stepInfo)
        {
            try
            {
                extentTest.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for Info scenario. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void BeforeStepInfo(string stepType, string stepInfo, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    BeforeStepInfo(stepType, stepInfo);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle Info step with message
        /// </summary>
        /// <param name="infoMessage">Information message to be printed</param>
        public static void Info(string infoMessage)
        {
            try
            {
                extentTest.Info($"<p style='color:blue'>{infoMessage}</p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Info($"<p style='color:blue'>{infoMessage}</p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle Info step with message and title of message with bold formating
        /// </summary>
        /// <param name="infoTitle">This is title with bold text format </param>
        /// <param name="infoMessage">Message to printed on log</param>
        public static void Info(string infoTitle, string infoMessage)
        {
            try
            {
                extentTest.Info($"<p style='color:blue'><b>{infoTitle} : </b> <i>{infoMessage}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Info($"<p style='color:blue'><b>{infoTitle} : </b> <i>{infoMessage}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Info message into log with expected and actual data
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Info message to be displayed</param>
        public static void Info(object expectedData, object actualData, string messageToDisplay)
        {
            try
            {
                extentTest.Info($"<p style='color:blue'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Info($"<p style='color:blue'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle Info step with message. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="infoMessage">Information message to be printed</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Info(string infoMessage, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Info(infoMessage);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Info($"<p style='color:blue'>{infoMessage}</p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'>{infoMessage}</p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method is used to handle Info step with message and title of message with bold formating. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="infoTitle">This is title with bold text format </param>
        /// <param name="infoMessage">Message to printed on log</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Info(string infoTitle, string infoMessage, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Info(infoTitle, infoMessage);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Info($"<p style='color:blue'><b>{infoTitle} : </b> <i>{infoMessage}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'><b>{infoTitle} : </b> <i>{infoMessage}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Prints Info message into log with expected and actual data. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="expectedData">Expected data</param>
        /// <param name="actualData">Actual data</param>
        /// <param name="messageToDisplay">Info message to be displayed</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void Info(object expectedData, object actualData, string messageToDisplay, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    Info(expectedData, actualData, messageToDisplay);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Info($"<p style='color:blue'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'><b>Expected Data :</b> <i>{expectedData} </i><br/> <b>Actual Data :</b> <i>{actualData} </i><br/> <i>{messageToDisplay}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for Info scenario
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        public static void StepInfo(string stepType, string stepInfo)
        {
            try
            {
                extentTest.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for Info scenario. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step details</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void StepInfo(string stepType, string stepInfo, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    StepInfo(stepType, stepInfo);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);

                    extentTest.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'><b>{stepType} : </b> <i>{stepInfo}</i></p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Info Log

        #region Skipped Log

        /// <summary>
        /// This method prints Gherkin format step for skipped scenario
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step info</param>
        public static void StepSkipped(string stepType, string stepInfo)
        {
            try
            {
                string errorMessage = "Step Definition is not implemented!";
                extentTest.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>" +
                    $"\n<p style=\"color: red\">{errorMessage}</p>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>" +
                    $"\n<p style=\"color: red\">{errorMessage}</p>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method prints Gherkin format step for skipped scenario. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="stepType">Gherkin step type</param>
        /// <param name="stepInfo">Gherkin step info</param>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void StepSkipped(string stepType, string stepInfo, string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    StepSkipped(stepType, stepInfo);
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    string errorMessage = "Step Definition is not implemented!";
                    extentTest.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>" +
                        $"\n<p style=\"color: red\">{errorMessage}</p>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'><b>{stepType} : </b> <i>{stepInfo}</i></p>" +
                        $"\n<p style=\"color: red\">{errorMessage}</p>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Skipped Log

        #region Not Defined Log

        /// <summary>
        /// This method fails the scenario if step is not defined
        /// </summary>
        public static void StepNotDefined()
        {
            try
            {
                extentTest.Fail($"<strong style=\"color: red\">Undefined Test Found!</strong>");

                if (extentTest_Consolidated != null)
                    extentTest_Consolidated.Fail($"<strong style=\"color: red\">Undefined Test Found!</strong>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method fails the scenario if step is not defined. It also adds a screenshot to the step.
        /// </summary>
        /// <param name="base64String">base64 string of screenshot</param>
        /// <param name="title">Title of screenshot</param>
        public static void StepNotDefined(string base64String, string title = null)
        {
            try
            {
                if (string.IsNullOrEmpty(base64String))
                {
                    StepNotDefined();
                }
                else
                {
                    MediaEntityModelProvider mediaEntityModelProvider = ConvertBase64StringToMediaEntityModelProvider(base64String, title);
                    extentTest.Fail($"<strong style=\"color: red\">Undefined Test Found!</strong>", mediaEntityModelProvider);

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<strong style=\"color: red\">Undefined Test Found!</strong>", mediaEntityModelProvider);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Not Defined Log

        #region Print JSON

        /// <summary>
        /// This method prints JSON format as Info in report.
        /// </summary>
        /// <param name="descriptionOfJSON">Description of JSON (What that JSON depicts)</param>
        /// <param name="jsonString">json in string format</param>
        public static void PrintJSON(string descriptionOfJSON, string jsonString)
        {
            try
            {
                if (String.IsNullOrEmpty(jsonString))
                {
                    extentTest.Fail($"<p style='color:red'><b> No Response body found! </b></br>Response : <i> {jsonString}</i> </p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'><b> No Response body found! </b></br>Response : <i> {jsonString}</i> </p>");

                    throw new Exception();
                }
                else if (!jsonString.Contains("{"))
                {
                    extentTest.Info($"<p style='color:blue'><b> Plain Response Body </b></br> Response : <i> {jsonString}</i> </p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'><b> Plain Response Body </b></br>Response : <i> {jsonString}</i> </p>");
                }
                else
                {
                    extentTest.Info($"<p style='color:blue'><b>{descriptionOfJSON} : </b> <i></i></p>");
                    extentTest.Info(MarkupHelper.CreateCodeBlock(jsonString, CodeLanguage.Json));

                    if (extentTest_Consolidated != null)
                    {
                        extentTest_Consolidated.Info($"<p style='color:blue'><b>{descriptionOfJSON} : </b> <i></i></p>");
                        extentTest_Consolidated.Info(MarkupHelper.CreateCodeBlock(jsonString, CodeLanguage.Json));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Print JSON

        #region Print XML

        /// <summary>
        /// This method prints XML format as Info in report.
        /// </summary>
        /// <param name="descriptionOfXML">Description of XML (What that XML depicts)</param>
        /// <param name="xmlString">XML in string format</param>
        public static void PrintXML(string descriptionOfXML, string xmlString)
        {
            try
            {
                if (String.IsNullOrEmpty(xmlString))
                {
                    extentTest.Fail($"<p style='color:red'><b> No Response body found! </b></br>Response : <i> {xmlString}</i> </p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Fail($"<p style='color:red'><b> No Response body found! </b></br>Response : <i> {xmlString}</i> </p>");

                    throw new Exception();
                }
                else if (!xmlString.Contains("<"))
                {
                    extentTest.Info($"<p style='color:blue'><b> Plain Response Body </b></br> Response : <i> {xmlString}</i> </p>");

                    if (extentTest_Consolidated != null)
                        extentTest_Consolidated.Info($"<p style='color:blue'><b> Plain Response Body </b></br>Response : <i> {xmlString}</i> </p>");
                }
                else
                {
                    extentTest.Info($"<p style='color:blue'><b>{descriptionOfXML} : </b> <i></i></p>");
                    extentTest.Info(MarkupHelper.CreateCodeBlock(xmlString, CodeLanguage.Xml));

                    if (extentTest_Consolidated != null)
                    {
                        extentTest_Consolidated.Info($"<p style='color:blue'><b>{descriptionOfXML} : </b> <i></i></p>");
                        extentTest_Consolidated.Info(MarkupHelper.CreateCodeBlock(xmlString, CodeLanguage.Xml));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Print XML

        #region Screenshot

        public static void AddBase64ScreenshotToReport(string base64String, string title = null)
        {
            try
            {
                extentTest.AddScreenCaptureFromBase64String(base64String, title);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MediaEntityModelProvider ConvertBase64StringToMediaEntityModelProvider(string base64String, string title = null)
        {
            MediaEntityModelProvider mediaEntityModelProvider = MediaEntityBuilder.CreateScreenCaptureFromBase64String(base64String, title).Build();
            return mediaEntityModelProvider;
        }

        #endregion Screenshot

        #endregion Methods
    }
}