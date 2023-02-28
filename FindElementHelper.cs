using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using System.Reflection;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods to find an element(s) on a web page based on input identifier provided
    /// </summary>
    public class FindElementHelper
    {
        #region Methods

        /// <summary>
        /// Method to check the existence of an element in the DOM, inside the given duration
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <param name="timeOutInSeconds">Max duration till which element will be searched</param>
        /// <param name="pollingInterval">repeat search after this much duration</param>
        /// <returns>true if element exists else returns false</returns>
        public static bool IsElementExists(IWebDriver driver, Func<string, By> seleniumLocatorName, string seleniumLocatorValue, int timeOutInSeconds = 30, double pollingInterval = 0.5)
        {
            try
            {
                IWebElement element = FindElement(driver, seleniumLocatorName, seleniumLocatorValue, timeOutInSeconds, pollingInterval);
                bool elementExists = (element != null) ? true : false;
                return elementExists;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to find an element inside the given duration and return null if element not found
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <param name="timeOutInSeconds">Max duration till which element will be searched</param>
        /// <param name="pollingInterval">repeat search after this much duration</param>
        /// <returns>IWebElement instance</returns>
        public static IWebElement FindElement(IWebDriver driver, Func<string, By> seleniumLocatorName, string seleniumLocatorValue, int timeOutInSeconds = 30, double pollingInterval = 0.5)
        {
            try
            {
                string callingMethodsName = MethodBase.GetCurrentMethod().Name;
                IWebElement element = ExplicitWaitHelper.FindElementBasedOnCondition(driver, callingMethodsName, seleniumLocatorName: seleniumLocatorName, seleniumLocatorValue: seleniumLocatorValue, timeOutInSeconds: timeOutInSeconds, pollingInterval: pollingInterval);
                return element;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to find all matching elements based on identifier provided inside the given duration and return null if elements are not found
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <param name="timeOutInSeconds">Max duration till which element will be searched</param>
        /// <param name="pollingInterval">repeat search after this much duration</param>
        /// <returns>Read only collection of IWebElement</returns>
        public static ReadOnlyCollection<IWebElement> FindAllElements(IWebDriver driver, Func<string, By> seleniumLocatorName, string seleniumLocatorValue, int timeOutInSeconds = 30, double pollingInterval = 0.5)
        {
            try
            {
                string callingMethodsName = MethodBase.GetCurrentMethod().Name;
                ReadOnlyCollection<IWebElement> elements = ExplicitWaitHelper.FindElementsBasedOnCondition(driver, callingMethodsName, seleniumLocatorName: seleniumLocatorName, seleniumLocatorValue: seleniumLocatorValue, timeOutInSeconds: timeOutInSeconds, pollingInterval: pollingInterval);
                return elements;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}