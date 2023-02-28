using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on checkbox
    /// </summary>
    public class CheckboxHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value of Checkbox</returns>
        public static string GetCheckboxAttribute(IWebElement checkboxElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(checkboxElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute value of Checkbox</returns>
        public static string GetCheckboxInnerText(IWebElement checkboxElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(checkboxElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns placeholder attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="attribute">Attribute Name for placeholder</param>
        /// <returns>placeholder attribute value of Checkbox</returns>
        public static string GetCheckboxPlaceholder(IWebElement checkboxElement, string attribute = "Placeholder")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetPlaceHolderAttribute(checkboxElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute value of Checkbox</returns>
        public static string GetCheckboxText(IWebElement checkboxElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(checkboxElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value of Checkbox</returns>
        public static string GetCheckboxTitle(IWebElement checkboxElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(checkboxElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="attribute">Attribute name for Value of Checkbox</param>
        /// <returns>Value attribute of Checkbox</returns>
        public static string GetCheckboxValue(IWebElement checkboxElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(checkboxElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Attribute Methods

        #region Get CSS Methods

        /// <summary>
        /// Returns background color of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value of Checkbox</returns>
        public static string GetCheckboxBackgroundColor(IWebElement checkboxElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetCheckboxBorderColor(IWebElement checkboxElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value of Checkbox</returns>
        public static string GetCheckboxColor(IWebElement checkboxElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetCheckboxCSSValue(IWebElement checkboxElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value of Checkbox</returns>
        public static string GetCheckboxFontFamily(IWebElement checkboxElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value of Checkbox</returns>
        public static string GetCheckboxFontSize(IWebElement checkboxElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value of Checkbox</returns>
        public static string GetCheckboxFontStyle(IWebElement checkboxElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(checkboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get CSS Methods

        #region Get DOM Attribute

        /// <summary>
        /// Returns DOM Attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value of Checkbox</returns>
        public static string GetCheckboxDOMAttribute(IWebElement checkboxElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(checkboxElement, dOMAttribute);
                return domAttribute;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Attribute

        #region Get DOM Property

        /// <summary>
        /// Returns DOM Property of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value of Checkbox</returns>
        public static string GetCheckboxDomProperty(IWebElement checkboxElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(checkboxElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get Checkbox ToolTip

        /// <summary>
        /// Returns Tooltip title for Checkbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true method will hover over checkbox</param>
        /// <returns>Tooltip title for checkbox</returns>
        public static string GetCheckboxTooltipTitle(IWebDriver driver, IWebElement checkboxElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, checkboxElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Checkbox ToolTip

        #region Keyboard Actions

        /// <summary>
        /// Changes the state to check of checkbox using keyboard Enter key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Button WebElement</param>
        public static void CheckMarkCheckboxUsingKeyboardEnterKey(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    KeyboardHelper.PressEnterKeyUsingActionsClass(driver, checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state to check of checkbox using keyboard Return key..
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Button WebElement</param>
        public static void CheckMarkCheckboxUsingKeyboardReturnKey(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    KeyboardHelper.PressReturnKeyUsingActionsClass(driver, checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Hits Enter key of keyboard on checkbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Button WebElement</param>
        public static void ClickCheckboxUsingKeyboardEnterKey(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                KeyboardHelper.PressEnterKeyUsingActionsClass(driver, checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Hits Enter key of numpad keyboard on checkbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Button WebElement</param>
        public static void ClickCheckboxUsingKeyboardReturnKey(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                KeyboardHelper.PressReturnKeyUsingActionsClass(driver, checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck using keyboard Enter key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Button WebElement</param>
        public static void UncheckCheckboxUsingKeyboardEnterKey(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    KeyboardHelper.PressEnterKeyUsingActionsClass(driver, checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck using keyboard return key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Button WebElement</param>
        public static void UncheckCheckboxUsingKeyboardReturnKey(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    KeyboardHelper.PressReturnKeyUsingActionsClass(driver, checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Keyboard Actions

        #region Mouse Actions

        #region Click

        /// <summary>
        /// Changes the state of checkbox to check.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void CheckMarkCheckboxUsingMouse(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    MouseHelper.ClickOnElement(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks checkbox irrespective of checkbox state
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ClickCheckboxUsingMouse(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void UncheckCheckboxUsingMouse(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    MouseHelper.ClickOnElement(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over Checkbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void MouseHoverCheckbox(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to checkbox
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void MoveToCheckbox(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings checkbox into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ScrollCheckboxToView(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Hover, Move, Scroll

        #endregion Mouse Actions

        #region JavaScript Actions

        /// <summary>
        /// Changes the state of checkbox to check using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void CheckMarkCheckboxUsingJavaScript(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    JavaScriptHelper.Click(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks using Javascript on checkbox irrespective of state of checkbox
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ClickCheckboxUsingJavaScript(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns checkbox text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <return>returns text attribute of checkbox</return>
        public static string GetCheckboxTextUsingJavaScript(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, checkboxElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of Checkbox using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void HighlightCheckboxBackground(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of Checkbox using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void HighlightCheckboxBorder(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of Checkbox using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void HighlightCheckboxBorderAndBackground(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to checkbox OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToCheckboxOffSet(IWebDriver driver, int xOffSet, int yOffSet)
        {
            try
            {
                JavaScriptHelper.ScrollByOffSet(driver, xOffSet, yOffSet);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to checkbox using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ScrollToCheckboxUsingJavaScript(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void UncheckCheckboxUsingJavaScript(IWebDriver driver, IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    JavaScriptHelper.Click(driver, checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Actions

        #region Web Element Methods

        /// <summary>
        /// Changes the state of checkbox to checked.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void CheckMarkCheckbox(IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    WebElementMethodHelper.Click(checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to checked using keyboard enter key.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void CheckMarkCheckboxUsingEnterKey(IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    WebElementMethodHelper.PressEnterKey(checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to check using keyboard return key.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void CheckMarkCheckboxUsingReturnKey(IWebElement checkboxElement)
        {
            try
            {
                if (!IsCheckboxSelected(checkboxElement))
                    WebElementMethodHelper.PressReturnKey(checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on check box element irrespective of checkbox state.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ClickCheckbox(IWebElement checkboxElement)
        {
            try
            {
                WebElementMethodHelper.Click(checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Hits Enter key on keyboard for checkbox irrespective of checkbox state.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ClickCheckboxUsingEnterKey(IWebElement checkboxElement)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Hits enter/return key on numpad keyboard for checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void ClickCheckboxUsingReturnKey(IWebElement checkboxElement)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void UncheckCheckbox(IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    WebElementMethodHelper.Click(checkboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck using keyboard Enter key.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void UncheckCheckboxUsingEnterKey(IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    WebElementMethodHelper.PressEnterKey(checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of checkbox to uncheck using keyboard return key.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        public static void UncheckCheckboxUsingReturnKey(IWebElement checkboxElement)
        {
            try
            {
                if (IsCheckboxSelected(checkboxElement))
                    WebElementMethodHelper.PressReturnKey(checkboxElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of Checkbox on webpage.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>Location of Checkbox on webpage.</returns>
        public static Point GetCheckboxLocation(IWebElement checkboxElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(checkboxElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>size of Checkbox</returns>
        public static Size GetCheckboxSize(IWebElement checkboxElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(checkboxElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>Tagname of Checkbox</returns>
        public static string GetCheckboxTagName(IWebElement checkboxElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(checkboxElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of Checkbox.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>Text of Checkbox</returns>
        public static string GetCheckboxText(IWebElement checkboxElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(checkboxElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Checkbox is displyed or NOT.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>True if Checkbox is displayed otherwise returns false</returns>
        public static bool IsCheckboxDisplayed(IWebElement checkboxElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(checkboxElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Checkbox is enabled or NOT.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>True if Checkbox is enabled otherwise returns false</returns>
        public static bool IsCheckboxEnabled(IWebElement checkboxElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(checkboxElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if checkbox is checked or not.
        /// </summary>
        /// <param name="checkboxElement">Checkbox WebElement</param>
        /// <returns>True if checkbox is selected otherwise returns false</returns>
        public static bool IsCheckboxSelected(IWebElement checkboxElement)
        {
            try
            {
                bool selected = WebElementPropertyHelper.IsSelected(checkboxElement);
                return selected;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Property Methods
    }
}