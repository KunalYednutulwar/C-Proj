using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    ///  Contains methods for performing various operations on Textbox
    /// </summary>
    public class TextBoxHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value</returns>
        public static string GetTextboxAttribute(IWebElement textboxElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(textboxElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute of Textbox</returns>
        public static string GetTextboxInnerText(IWebElement textboxElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(textboxElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns placeholder attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="attribute">Attribute Name for placeholder</param>
        /// <returns>placeholder attribute value</returns>
        public static string GetTextboxPlaceholder(IWebElement textboxElement, string attribute = "Placeholder")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetPlaceHolderAttribute(textboxElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute of Textbox</returns>
        public static string GetTextboxText(IWebElement textboxElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(textboxElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value</returns>
        public static string GetTextboxTitle(IWebElement textboxElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(textboxElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="attribute">Attribute name for Value</param>
        /// <returns>Value attribute of Textbox</returns>
        public static string GetTextboxValue(IWebElement textboxElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(textboxElement, attribute);
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
        /// Returns background color of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value</returns>
        public static string GetTextboxBackgroundColor(IWebElement textboxElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(textboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetTextboxBorderColor(IWebElement textboxElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(textboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value</returns>
        public static string GetTextboxColor(IWebElement textboxElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(textboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetTextboxCSSValue(IWebElement textboxElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(textboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value</returns>
        public static string GetTextboxFontFamily(IWebElement textboxElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(textboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value</returns>
        public static string GetTextboxFontSize(IWebElement textboxElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(textboxElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value</returns>
        public static string GetTextboxFontStyle(IWebElement textboxElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(textboxElement, cssProperty);
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
        /// Returns DOM Attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value</returns>
        public static string GetTextboxDOMAttribute(IWebElement textboxElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(textboxElement, dOMAttribute);
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
        /// Returns DOM Property of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value</returns>
        public static string GetTextboxDomProperty(IWebElement textboxElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(textboxElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get Textbox ToolTip

        /// <summary>
        /// Returns Tooltip title for Textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true method will hover over textbox</param>
        /// <returns>Tooltip title for textbox</returns>
        public static string GetTextboxTooltipTitle(IWebDriver driver, IWebElement textboxElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, textboxElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Textbox ToolTip

        #region Keyboard Helper

        /// <summary>
        /// Enters text where cursor is pointing using implementation from actions class.
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="textboxElement">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="text">Text to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it is true will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterTextUsingKeyboard(IWebDriver driver, IWebElement textboxElement, string text, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                KeyboardHelper.EnterTextUsingActionsClass(driver, textboxElement, text, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Keyboard Helper

        #region Mouse Actions

        #region Click

        /// <summary>
        /// Clicks and Holds on textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ClickAndHoldTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.ClickAndHoldOnElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ClickTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ContextClickTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                RightClickTextbox(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double clicks on textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void DoubleClickTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.DoubleClickOnElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void RightClickTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.ContextClickOnElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Drag & Drop

        /// <summary>
        /// Drags textbox and drops to destination element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="destinationElement">destination to drop textbox</param>
        public static void DragAndDropTextboxToAnotherElement(IWebDriver driver, IWebElement textboxElement, IWebElement destinationElement)
        {
            try
            {
                MouseHelper.DragAndDropElement(driver, textboxElement, destinationElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags textbox and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="targetElement">destination to drop textbox</param>
        public static void DragAndDropTextboxToOffSetOfTargetElement(IWebDriver driver, IWebElement textboxElement, IWebElement targetElement)
        {
            try
            {
                MouseHelper.DragAndDropElementToOffSetOfTargetElement(driver, textboxElement, targetElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags textbox and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="xOffSet">x coordinate</param>
        /// <param name="yOffSet">y coordinate</param>
        public static void DragAndDropTextboxToXYCoordinateLocation(IWebDriver driver, IWebElement textboxElement, int xOffSet, int yOffSet)
        {
            try
            {
                MouseHelper.DragAndDropElementToXYCoordinates(driver, textboxElement, xOffSet, yOffSet);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Drag & Drop

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over Textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void MouseHoverTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to textbox
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void MoveToTextbox(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings textbox into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ScrollTextboxToView(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, textboxElement);
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
        /// Clicks using Javascript on textbox.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ClickTextboxUsingJavaScript(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text using Javascript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="inputValue">value to input</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it is true will Click on input control</param>
        public static void EnterTextUsingJavaScript(IWebDriver driver, IWebElement textboxElement, string inputValue, bool clickTextboxBeforeEnteringValue = true)
        {
            try
            {
                JavaScriptHelper.EnterText(driver, textboxElement, inputValue, clickTextboxBeforeEnteringValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns textbox text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <return>returns text attribute of textbox</return>
        public static string GetTextboxTextUsingJavaScript(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, textboxElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of Textbox using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void HighlightTextboxBackground(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of Textbox using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void HighlightTextboxBorder(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of Textbox using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void HighlightTextboxBorderAndBackground(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to textbox OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToTextboxOffSet(IWebDriver driver, int xOffSet, int yOffSet)
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
        /// Scrolls to textbox using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ScrollToTextboxUsingJavaScript(IWebDriver driver, IWebElement textboxElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Actions

        #region Web Element Methods

        /// <summary>
        /// Clears text box.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        public static void ClearTextbox(IWebElement textboxElement)
        {
            try
            {
                WebElementMethodHelper.Clear(textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on textbox.
        /// </summary>
        /// <param name="textboxElement">textbox WebElement</param>
        public static void ClickTextbox(IWebElement textboxElement)
        {
            try
            {
                WebElementMethodHelper.Click(textboxElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text to text box.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="inputValue">Input value to enter in textbox</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it is true will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterText(IWebElement textboxElement, string inputValue, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(textboxElement, inputValue, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text to text box.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="number">Whole number to enter in textbox</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it is true will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterText(IWebElement textboxElement, long number, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(textboxElement, number, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text to text box.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <param name="number">Decimal number to enter in textbox</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it is true will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterText(IWebElement textboxElement, double number, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(textboxElement, number, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of Textbox on webpage.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <returns>Location of Textbox on webpage.</returns>
        public static Point GetTextboxLocation(IWebElement textboxElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(textboxElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <returns>size of Textbox</returns>
        public static Size GetTextboxSize(IWebElement textboxElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(textboxElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <returns>Tagname of Textbox</returns>
        public static string GetTextboxTagName(IWebElement textboxElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(textboxElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the text of Textbox.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <returns>text of Textbox</returns>
        public static string GetTextboxText(IWebElement textboxElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(textboxElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Textbox is displyed or NOT.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <returns>True if Textbox is displayed otherwise returns false</returns>
        public static bool IsTextboxDisplayed(IWebElement textboxElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(textboxElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Textbox is enabled or NOT.
        /// </summary>
        /// <param name="textboxElement">Textbox WebElement</param>
        /// <returns>True if Textbox is enabled otherwise returns false</returns>
        public static bool IsTextboxEnabled(IWebElement textboxElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(textboxElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Property Methods
    }
}