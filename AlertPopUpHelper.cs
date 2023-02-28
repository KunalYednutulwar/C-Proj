using OpenQA.Selenium;
using System;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on Alert
    /// </summary>
    public class AlertPopUpHelper
    {
        #region Methods

        /// <summary>
        /// Clicks 'OK' or 'YES' button on alert popup.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="maxWaitTimeForAlertToAppear">Maximum time to wait for alert to appear</param>
        public static void AcceptAlertPopup(IWebDriver driver, int maxWaitTimeForAlertToAppear = 30)
        {
            try
            {
                IAlert alert = SwitchToAlert(driver, maxWaitTimeForAlertToAppear);
                alert.Accept();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks 'Cancel' or 'NO' button on alert popup.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="maxWaitTimeForAlertToAppear">Maximum time to wait for alert to appear</param>
        public static void DismissAlertPopup(IWebDriver driver, int maxWaitTimeForAlertToAppear = 30)
        {
            try
            {
                IAlert alert = SwitchToAlert(driver, maxWaitTimeForAlertToAppear);
                alert.Dismiss();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text message from alert popup.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="maxWaitTimeForAlertToAppear">Maximum time to wait for alert to appear</param>
        /// <returns>Alert message</returns>
        public static string GetText(IWebDriver driver, int maxWaitTimeForAlertToAppear = 30)
        {
            try
            {
                IAlert alert = SwitchToAlert(driver, maxWaitTimeForAlertToAppear);
                string alertText = alert.Text;
                return alertText;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text message in alert popup.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="inputText">Text message</param>
        /// <param name="maxWaitTimeForAlertToAppear">Maximum time to wait for alert to appear</param>
        public static void InputTextInAlertTextbox(IWebDriver driver, string inputText, int maxWaitTimeForAlertToAppear = 30)
        {
            try
            {
                IAlert alert = SwitchToAlert(driver, maxWaitTimeForAlertToAppear);
                WebElementMethodHelper.EnterText(alert, inputText);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Logins through alert popup by entering credentials.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="username">Username for user</param>
        /// <param name="password">Password for user</param>
        /// <param name="maxWaitTimeForAlertToAppear">Maximum time to wait for alert to appear</param>
        public static void LoginThroughAlertPopup(IWebDriver driver, string username, string password, int maxWaitTimeForAlertToAppear = 30)
        {
            try
            {
                IAlert alert = SwitchToAlert(driver, maxWaitTimeForAlertToAppear);
                alert.SetAuthenticationCredentials(username, password);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to alert window
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="maxWaitTimeForAlertToAppear">Maximum time to wait for alert to appear</param>
        /// <returns>IAlert instance</returns>
        public static IAlert SwitchToAlert(IWebDriver driver, int maxWaitTimeForAlertToAppear = 30)
        {
            try
            {
                ExplicitWaitHelper.WaitForAlertPresent(driver, maxWaitTimeForAlertToAppear);
                IAlert alert = driver.SwitchTo().Alert();
                return alert;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}