using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on UIControls like ListBox, Modal, any custom div, span controls, etc.
    /// </summary>
    public class UIControlHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value</returns>
        public static string GetUIControlAttribute(IWebElement uIControlElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(uIControlElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute of UIControl</returns>
        public static string GetUIControlInnerText(IWebElement uIControlElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(uIControlElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns placeholder attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="attribute">Attribute Name for placeholder</param>
        /// <returns>placeholder attribute value</returns>
        public static string GetUIControlPlaceholder(IWebElement uIControlElement, string attribute = "Placeholder")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetPlaceHolderAttribute(uIControlElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute of UIControl</returns>
        public static string GetUIControlText(IWebElement uIControlElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(uIControlElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value</returns>
        public static string GetUIControlTitle(IWebElement uIControlElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(uIControlElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="attribute">Attribute name for Value</param>
        /// <returns>Value attribute of UIControl</returns>
        public static string GetUIControlValue(IWebElement uIControlElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(uIControlElement, attribute);
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
        /// Returns background color of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value</returns>
        public static string GetUIControlBackgroundColor(IWebElement uIControlElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(uIControlElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetUIControlBorderColor(IWebElement uIControlElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(uIControlElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value</returns>
        public static string GetUIControlColor(IWebElement uIControlElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(uIControlElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetUIControlCSSValue(IWebElement uIControlElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(uIControlElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value</returns>
        public static string GetUIControlFontFamily(IWebElement uIControlElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(uIControlElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value</returns>
        public static string GetUIControlFontSize(IWebElement uIControlElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(uIControlElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value</returns>
        public static string GetUIControlFontStyle(IWebElement uIControlElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(uIControlElement, cssProperty);
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
        /// Returns DOM Attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value</returns>
        public static string GetUIControlDOMAttribute(IWebElement uIControlElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(uIControlElement, dOMAttribute);
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
        /// Returns DOM Property of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value</returns>
        public static string GetUIControlDomProperty(IWebElement uIControlElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(uIControlElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get UIControl ToolTip

        /// <summary>
        /// Returns Tooltip title for UIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true method will hover over uIControl</param>
        /// <returns>Tooltip title for uIControl</returns>
        public static string GetUIControlTooltipTitle(IWebDriver driver, IWebElement uIControlElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, uIControlElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get UIControl ToolTip

        #region Keyboard Actions

        /// <summary>
        /// Clicks uIControl by pressing Enter key of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickUIControlUsingKeyboardEnterKey(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                KeyboardHelper.PressEnterKeyUsingActionsClass(driver, uIControlElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks uIControl by pressing return key present in numpad of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickUIControlUsingKeyboardReturnKey(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                KeyboardHelper.PressReturnKeyUsingActionsClass(driver, uIControlElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

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

        #endregion Keyboard Actions

        #region Mouse Actions

        #region Click

        /// <summary>
        /// Clicks and Holds on uIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickAndHoldUIControl(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.ClickAndHoldOnElement(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on uIControl using Actions class implementation.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickUIControlUsingMouse(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on uIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ContextClickUIControl(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                RightClickUIControl(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double clicks on uIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void DoubleClickUIControl(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.DoubleClickOnElement(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on uIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void RightClickUIControl(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.ContextClickOnElement(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Drag & Drop

        /// <summary>
        /// Drags uIControl and drops to destination element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="destinationElement">destination to drop uIControl</param>
        public static void DragAndDropUIControlToAnotherElement(IWebDriver driver, IWebElement uIControlElement, IWebElement destinationElement)
        {
            try
            {
                MouseHelper.DragAndDropElement(driver, uIControlElement, destinationElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags uIControl and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="targetElement">destination to drop uIControl</param>
        public static void DragAndDropUIControlToOffSetOfTargetElement(IWebDriver driver, IWebElement uIControlElement, IWebElement targetElement)
        {
            try
            {
                MouseHelper.DragAndDropElementToOffSetOfTargetElement(driver, uIControlElement, targetElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags uIControl and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <param name="xOffSet">x coordinate</param>
        /// <param name="yOffSet">y coordinate</param>
        public static void DragAndDropUIControlToXYCoordinateLocation(IWebDriver driver, IWebElement uIControlElement, int xOffSet, int yOffSet)
        {
            try
            {
                MouseHelper.DragAndDropElementToXYCoordinates(driver, uIControlElement, xOffSet, yOffSet);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Drag & Drop

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over UIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void MouseHoverUIControl(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to uIControl
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void MoveToUIControl(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings uIControl into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ScrollUIControlToView(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, uIControlElement);
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
        /// Clicks using Javascript on uIControl.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickUIControlUsingJavaScript(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns uIControl text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <return>returns text attribute of uIControl</return>
        public static string GetUIControlTextUsingJavaScript(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, uIControlElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of UIControl using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void HighlightUIControlBackground(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of UIControl using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void HighlightUIControlBorder(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of UIControl using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void HighlightUIControlBorderAndBackground(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to uIControl OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToUIControlOffSet(IWebDriver driver, int xOffSet, int yOffSet)
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
        /// Scrolls to uIControl using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ScrollToUIControlUsingJavaScript(IWebDriver driver, IWebElement uIControlElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, uIControlElement);
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
        /// Clicks on uIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void Click(IWebElement uIControlElement)
        {
            try
            {
                WebElementMethodHelper.Click(uIControlElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkey of "Enter" to uIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickUIControlUsingEnterKey(IWebElement uIControlElement)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(uIControlElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkeys of "Enter key of numpad" to uIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        public static void ClickUIControlUsingReturnKey(IWebElement uIControlElement)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(uIControlElement, false, false, false);
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

        /// <summary>
        /// Submits page.
        /// </summary>
        /// <param name="element">Textbox WebElement</param>
        public static void SubmitForm(IWebElement element)
        {
            try
            {
                WebElementMethodHelper.Submit(element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns Shadow root
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <returns>ISearchContext</returns>
        public static ISearchContext GetShadowRoot(IWebElement element)
        {
            try
            {
                ISearchContext searchContext = WebElementMethodHelper.GetShadowRoot(element);
                return searchContext;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of UIControl on webpage.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>Location of UIControl on webpage.</returns>
        public static Point GetUIControlLocation(IWebElement uIControlElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(uIControlElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>size of UIControl</returns>
        public static Size GetUIControlSize(IWebElement uIControlElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(uIControlElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>Tagname of UIControl</returns>
        public static string GetUIControlTagName(IWebElement uIControlElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(uIControlElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the text of UIControl.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>text of UIControl</returns>
        public static string GetUIControlText(IWebElement uIControlElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(uIControlElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if UIControl is displyed or NOT.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>True if UIControl is displayed otherwise returns false</returns>
        public static bool IsUIControlDisplayed(IWebElement uIControlElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(uIControlElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if UIControl is enabled or NOT.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>True if UIControl is enabled otherwise returns false</returns>
        public static bool IsUIControlEnabled(IWebElement uIControlElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(uIControlElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if UIControl is selected or NOT.
        /// </summary>
        /// <param name="uIControlElement">UIControl WebElement</param>
        /// <returns>True if UIControl is selected otherwise returns false</returns>
        public static bool IsUIControlSelected(IWebElement uIControlElement)
        {
            try
            {
                bool isSelected = WebElementPropertyHelper.IsSelected(uIControlElement);
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