using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on Button.
    /// </summary>
    public class ButtonHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value</returns>
        public static string GetButtonAttribute(IWebElement buttonElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(buttonElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute of Button</returns>
        public static string GetButtonInnerText(IWebElement buttonElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(buttonElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns placeholder attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="attribute">Attribute Name for placeholder</param>
        /// <returns>placeholder attribute value</returns>
        public static string GetButtonPlaceholder(IWebElement buttonElement, string attribute = "Placeholder")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetPlaceHolderAttribute(buttonElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute of Button</returns>
        public static string GetButtonText(IWebElement buttonElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(buttonElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value</returns>
        public static string GetButtonTitle(IWebElement buttonElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(buttonElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="attribute">Attribute name for Value</param>
        /// <returns>Value attribute of Button</returns>
        public static string GetButtonValue(IWebElement buttonElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(buttonElement, attribute);
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
        /// Returns background color of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value</returns>
        public static string GetButtonBackgroundColor(IWebElement buttonElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(buttonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetButtonBorderColor(IWebElement buttonElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(buttonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value</returns>
        public static string GetButtonColor(IWebElement buttonElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(buttonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetButtonCSSValue(IWebElement buttonElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(buttonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value</returns>
        public static string GetButtonFontFamily(IWebElement buttonElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(buttonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value</returns>
        public static string GetButtonFontSize(IWebElement buttonElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(buttonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value</returns>
        public static string GetButtonFontStyle(IWebElement buttonElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(buttonElement, cssProperty);
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
        /// Returns DOM Attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value</returns>
        public static string GetButtonDOMAttribute(IWebElement buttonElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(buttonElement, dOMAttribute);
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
        /// Returns DOM Property of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value</returns>
        public static string GetButtonDomProperty(IWebElement buttonElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(buttonElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get Button ToolTip

        /// <summary>
        /// Returns Tooltip title for Button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true mouse will hover over button</param>
        /// <returns>Tooltip title for button</returns>
        public static string GetButtonTooltipTitle(IWebDriver driver, IWebElement buttonElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, buttonElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Button ToolTip

        #region Keyboard Actions

        /// <summary>
        /// Clicks button by pressing Enter key of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickButtonUsingKeyboardEnterKey(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                KeyboardHelper.PressEnterKeyUsingActionsClass(driver, buttonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks button by pressing return key present in numpad of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickButtonUsingKeyboardReturnKey(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                KeyboardHelper.PressReturnKeyUsingActionsClass(driver, buttonElement, false, false, false);
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
        /// Clicks and Holds on button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickAndHoldButton(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.ClickAndHoldOnElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on button using Actions class implementation.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickButtonUsingMouse(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ContextClickButton(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                RightClickButton(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double clicks on button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void DoubleClickButton(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.DoubleClickOnElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void RightClickButton(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.ContextClickOnElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Drag & Drop

        /// <summary>
        /// Drags button and drops to destination element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="destinationElement">destination to drop button</param>
        public static void DragAndDropButtonToAnotherElement(IWebDriver driver, IWebElement buttonElement, IWebElement destinationElement)
        {
            try
            {
                MouseHelper.DragAndDropElement(driver, buttonElement, destinationElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags button and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="targetElement">destination to drop button</param>
        public static void DragAndDropButtonToOffSetOfTargetElement(IWebDriver driver, IWebElement buttonElement, IWebElement targetElement)
        {
            try
            {
                MouseHelper.DragAndDropElementToOffSetOfTargetElement(driver, buttonElement, targetElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags button and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        /// <param name="xOffSet">x coordinate</param>
        /// <param name="yOffSet">y coordinate</param>
        public static void DragAndDropButtonToXYCoordinateLocation(IWebDriver driver, IWebElement buttonElement, int xOffSet, int yOffSet)
        {
            try
            {
                MouseHelper.DragAndDropElementToXYCoordinates(driver, buttonElement, xOffSet, yOffSet);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Drag & Drop

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over Button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void MouseHoverButton(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to button
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void MoveToButton(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings button into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ScrollButtonToView(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, buttonElement);
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
        /// Clicks using Javascript on button.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickButtonUsingJavaScript(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns button text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        /// <return>returns text attribute of button</return>
        public static string GetButtonTextUsingJavaScript(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, buttonElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of Button using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void HighlightButtonBackground(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of Button using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void HighlightButtonBorder(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of Button using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void HighlightButtonBorderAndBackground(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to button OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToButtonOffSet(IWebDriver driver, int xOffSet, int yOffSet)
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
        /// Scrolls to button using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ScrollToButtonUsingJavaScript(IWebDriver driver, IWebElement buttonElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Actions

        #region Web Element Methods

        /// <summary>
        /// Clicks on button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        public static void Click(IWebElement buttonElement)
        {
            try
            {
                WebElementMethodHelper.Click(buttonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkey of "Enter" to button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickButtonUsingEnterKey(IWebElement buttonElement)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(buttonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkeys of "Enter key of numpad" to button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        public static void ClickButtonUsingReturnKey(IWebElement buttonElement)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(buttonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of Button on webpage.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>Location of Button on webpage.</returns>
        public static Point GetButtonLocation(IWebElement buttonElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(buttonElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>size of Button</returns>
        public static Size GetButtonSize(IWebElement buttonElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(buttonElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>Tagname of Button</returns>
        public static string GetButtonTagName(IWebElement buttonElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(buttonElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the text of Button.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>text of Button</returns>
        public static string GetButtonText(IWebElement buttonElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(buttonElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Button is displyed or NOT.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>True if Button is displayed otherwise returns false</returns>
        public static bool IsButtonDisplayed(IWebElement buttonElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(buttonElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Button is enabled or NOT.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>True if Button is enabled otherwise returns false</returns>
        public static bool IsButtonEnabled(IWebElement buttonElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(buttonElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Button is selected or NOT.
        /// </summary>
        /// <param name="buttonElement">Button WebElement</param>
        /// <returns>True if Button is selected otherwise returns false</returns>
        public static bool IsButtonSelected(IWebElement buttonElement)
        {
            try
            {
                bool isSelected = WebElementPropertyHelper.IsSelected(buttonElement);
                return isSelected;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Property Methods
    }
}