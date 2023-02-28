using OpenQA.Selenium;
using System;
using System.Linq;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains JavaScript helper methods
    /// </summary>
    public class JavaScriptHelper
    {
        #region Click

        /// <summary>
        /// Clicks a web element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        public static void Click(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("arguments[0].click();", element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Enter Text

        /// <summary>
        /// Enters text
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="inputValue">Text to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        public static void EnterText(IWebDriver driver, IWebElement element, string inputValue, bool clickTextboxBeforeEnteringValue = true)
        {
            try
            {
                //Didn't implement clear. as we don't have method to clear using javascript. Don't use clear of other helpers, as chances of failure are there.

                if (clickTextboxBeforeEnteringValue)
                    Click(driver, element);

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript($"arguments[0].value='{inputValue}';", element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Enter Text

        #region Get Text

        /// <summary>
        /// Returns text attribute of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns text attribute of the element</returns>
        public static string GetText(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                string text = jsExecutor.ExecuteScript("return arguments[0].text;", element).ToString();
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Text

        #region Get Value Attribute

        /// <summary>
        /// Returns Value attribute of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns value attribute of the element</returns>
        public static string GetValueAttribute(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string valueText = jsExecutor.ExecuteScript("return arguments[0].value;", element).ToString();

                return valueText;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Value Attribute

        #region Get Title Attribute Value

        /// <summary>
        /// Returns Title attribute value of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns title attribute value of the element</returns>
        public static string GetTitleAttributeValue(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string title = jsExecutor.ExecuteScript("return arguments[0].title;", element).ToString();

                return title;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Title Attribute Value

        #region Get Inner Text Attribute value

        /// <summary>
        /// Returns Inner Text attribute value of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns inner text attribute value of the element</returns>
        public static string GetInnerTextAttributeValue(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string innerText = jsExecutor.ExecuteScript("return arguments[0].innerText;", element).ToString();

                return innerText;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Inner Text Attribute value

        #region Get PlaceHolder Attribute Value

        /// <summary>
        /// Returns Placeholder attribute value of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns placeholder attribute value of the element</returns>
        public static string GetPlaceHolderAttributeValue(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string placeholderValue = jsExecutor.ExecuteScript("return arguments[0].placeholder;", element).ToString();

                return placeholderValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get PlaceHolder Attribute Value

        #region Get Type Attribute Value

        /// <summary>
        /// Returns type attribute value of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns type attribute value of the element</returns>
        public static string GetTypeAttributeValue(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string type = jsExecutor.ExecuteScript("return arguments[0].type;", element).ToString();

                return type;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Type Attribute Value

        #region Get ClassName Attribute Value

        /// <summary>
        /// Returns class name attribute value of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns className attribute value of the element</returns>
        public static string GetClassNameAttributeValue(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string className = jsExecutor.ExecuteScript("return arguments[0].className;", element).ToString();

                return className;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get ClassName Attribute Value

        #region Get Name Attribute Value

        /// <summary>
        /// Returns name attribute value of the element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>Returns name attribute value of the element</returns>
        public static string GetNameAttributeValue(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

                string name = jsExecutor.ExecuteScript("return arguments[0].name;", element).ToString();

                return name;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Name Attribute Value

        #region Get Document Ready State

        /// <summary>
        /// Returns document ready state
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <returns>Returns document ready state</returns>
        public static string GetDocumentReadyState(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                string state = jsExecutor.ExecuteScript("return document.readyState;").ToString();
                return state;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Document Ready State

        #region Get Document Domain

        /// <summary>
        /// Returns domain of document
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <returns>Returns document domain</returns>
        public static string GetDocumentDomain(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                string state = jsExecutor.ExecuteScript("return document.domain;").ToString();
                return state;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Document Domain

        #region Open New Tab

        /// <summary>
        /// Opens new tab
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        public static void OpenNewTab(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Open New Tab

        #region Scroll

        /// <summary>
        /// Scrolls by Off Set
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollByOffSet(IWebDriver driver, int xOffSet, int yOffSet)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript($"window.scrollBy({xOffSet},{yOffSet});");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to bottom of the page
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        public static void ScrollToBottomOfThePage(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to an element
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("arguments[0].scrollIntoView();", element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to top of the page
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        public static void ScrollToTopOfThePage(IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("window.scrollTo(0, 0);");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Scroll

        #region Highlight Control

        /// <summary>
        /// Highlights Background color of WebElement.
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="backgroundColor">color to use to highlight background</param>
        public static void HighlightBackground(IWebDriver driver, IWebElement element, string backgroundColor = "yellow")
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                string javaScript = "arguments[0].style.background='" + backgroundColor + "';";
                jsExecutor.ExecuteScript(javaScript, element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of WebElement.
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="borderColor">color to use to highlight border</param>
        public static void HighlightBorder(IWebDriver driver, IWebElement element, string borderColor = "red")
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                string javaScript = "arguments[0].style.border='2px solid " + borderColor + "';";
                jsExecutor.ExecuteScript(javaScript, element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of WebElement.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="borderColor">color to use to highlight border</param>
        /// <param name="backgroundColor">color to use to highlight background</param>
        public static void HighlightBorderAndBackground(IWebDriver driver, IWebElement element, string borderColor = "red", string backgroundColor = "yellow")
        {
            try
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                string javaScript = "arguments[0].setAttribute('style', 'border:2px solid " + borderColor + "; background:" + backgroundColor + "')";
                jsExecutor.ExecuteScript(javaScript, element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Highlight Control
    }
}