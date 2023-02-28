using OpenQA.Selenium;
using System;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on Frames
    /// </summary>
    public class FrameHelper
    {
        #region Methods

        /// <summary>
        /// Returns total number of iframes present on current webpage.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="frameTagName">tag name of frame - either frame or iframe</param>
        /// <returns>Total number of iframes</returns>
        public static int GetTotalFramesOnPage(IWebDriver driver, string frameTagName = "iframe")
        {
            try
            {
                int totalFrames = driver.FindElements(By.TagName(frameTagName)).Count;
                return totalFrames;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to frame by it's WebElement.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="frameElement">WebElement of frame to be switched</param>
        public static void SwitchToFrameByElement(IWebDriver driver, IWebElement frameElement)
        {
            try
            {
                driver.SwitchTo().Frame(frameElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to frame by it's id.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="frameId">Id of frame to be switched</param>
        public static void SwitchToFrameById(IWebDriver driver, string frameId)
        {
            try
            {
                driver.SwitchTo().Frame(frameId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to frame by it's index.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="indexOfframe">Index of frame to be switched</param>
        public static void SwitchToFrameByIndex(IWebDriver driver, int indexOfframe)
        {
            try
            {
                driver.SwitchTo().Frame(indexOfframe);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to frame by it's name.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="frameName">Name of frame to be switched</param>
        public static void SwitchToFrameByName(IWebDriver driver, string frameName)
        {
            try
            {
                driver.SwitchTo().Frame(frameName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to main frame from current frame.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void SwitchToMainFrame(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().DefaultContent();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Switches to parent frame from current frame.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void SwitchToParentFrame(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().ParentFrame();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}