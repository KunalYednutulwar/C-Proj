using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    ///  Contains methods for performing various operations on hyperlink.
    /// </summary>
    public class HyperLinkHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute value of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value</returns>
        public static string GetHyperlinkAttribute(IWebElement hyperlinkElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(hyperlinkElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute of Hyperlink</returns>
        public static string GetHyperlinkInnerText(IWebElement hyperlinkElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(hyperlinkElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns placeholder attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="attribute">Attribute Name for placeholder</param>
        /// <returns>placeholder attribute value</returns>
        public static string GetHyperlinkPlaceholder(IWebElement hyperlinkElement, string attribute = "Placeholder")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetPlaceHolderAttribute(hyperlinkElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute of Hyperlink</returns>
        public static string GetHyperlinkText(IWebElement hyperlinkElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(hyperlinkElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value</returns>
        public static string GetHyperlinkTitle(IWebElement hyperlinkElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(hyperlinkElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="attribute">Attribute name for Value</param>
        /// <returns>Value attribute of Hyperlink</returns>
        public static string GetHyperlinkValue(IWebElement hyperlinkElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(hyperlinkElement, attribute);
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
        /// Returns background color of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value</returns>
        public static string GetHyperlinkBackgroundColor(IWebElement hyperlinkElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(hyperlinkElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetHyperlinkBorderColor(IWebElement hyperlinkElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(hyperlinkElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value</returns>
        public static string GetHyperlinkColor(IWebElement hyperlinkElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(hyperlinkElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetHyperlinkCSSValue(IWebElement hyperlinkElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(hyperlinkElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value</returns>
        public static string GetHyperlinkFontFamily(IWebElement hyperlinkElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(hyperlinkElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value</returns>
        public static string GetHyperlinkFontSize(IWebElement hyperlinkElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(hyperlinkElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value</returns>
        public static string GetHyperlinkFontStyle(IWebElement hyperlinkElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(hyperlinkElement, cssProperty);
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
        /// Returns DOM Attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value</returns>
        public static string GetHyperlinkDOMAttribute(IWebElement hyperlinkElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(hyperlinkElement, dOMAttribute);
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
        /// Returns DOM Property of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value</returns>
        public static string GetHyperlinkDomProperty(IWebElement hyperlinkElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(hyperlinkElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get Hyperlink ToolTip

        /// <summary>
        /// Returns Tooltip title for Hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true method will hover over hyperlink</param>
        /// <returns>Tooltip title for hyperlink</returns>
        public static string GetHyperlinkTooltipTitle(IWebDriver driver, IWebElement hyperlinkElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, hyperlinkElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Hyperlink ToolTip

        #region Keyboard Actions

        /// <summary>
        /// Clicks hyperlink by pressing Enter key of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickHyperlinkUsingKeyboardEnterKey(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                KeyboardHelper.PressEnterKeyUsingActionsClass(driver, hyperlinkElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks hyperlink by pressing return key present in numpad of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickHyperlinkUsingKeyboardReturnKey(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                KeyboardHelper.PressReturnKeyUsingActionsClass(driver, hyperlinkElement, false, false, false);
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
        /// Clicks and Holds on hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickAndHoldHyperlink(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.ClickAndHoldOnElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on hyperlink using Actions class implementation.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickHyperlinkUsingMouse(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ContextClickHyperlink(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                RightClickHyperlink(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double clicks on hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void DoubleClickHyperlink(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.DoubleClickOnElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void RightClickHyperlink(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.ContextClickOnElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Drag & Drop

        /// <summary>
        /// Drags hyperlink and drops to destination element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="destinationElement">destination to drop hyperlink</param>
        public static void DragAndDropHyperlinkToAnotherElement(IWebDriver driver, IWebElement hyperlinkElement, IWebElement destinationElement)
        {
            try
            {
                MouseHelper.DragAndDropElement(driver, hyperlinkElement, destinationElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags hyperlink and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="targetElement">destination to drop hyperlink</param>
        public static void DragAndDropHyperlinkToOffSetOfTargetElement(IWebDriver driver, IWebElement hyperlinkElement, IWebElement targetElement)
        {
            try
            {
                MouseHelper.DragAndDropElementToOffSetOfTargetElement(driver, hyperlinkElement, targetElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags hyperlink and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <param name="xOffSet">x coordinate</param>
        /// <param name="yOffSet">y coordinate</param>
        public static void DragAndDropHyperlinkToXYCoordinateLocation(IWebDriver driver, IWebElement hyperlinkElement, int xOffSet, int yOffSet)
        {
            try
            {
                MouseHelper.DragAndDropElementToXYCoordinates(driver, hyperlinkElement, xOffSet, yOffSet);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Drag & Drop

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over Hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void MouseHoverHyperlink(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to hyperlink
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void MoveToHyperlink(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings hyperlink into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ScrollHyperlinkToView(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, hyperlinkElement);
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
        /// Clicks using Javascript on hyperlink.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickHyperlinkUsingJavaScript(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns hyperlink text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <return>returns text attribute of hyperlink</return>
        public static string GetHyperlinkTextUsingJavaScript(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, hyperlinkElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of Hyperlink using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void HighlightHyperlinkBackground(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of Hyperlink using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void HighlightHyperlinkBorder(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of Hyperlink using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void HighlightHyperlinkBorderAndBackground(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to hyperlink OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToHyperlinkOffSet(IWebDriver driver, int xOffSet, int yOffSet)
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
        /// Scrolls to hyperlink using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ScrollToHyperlinkUsingJavaScript(IWebDriver driver, IWebElement hyperlinkElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Actions

        #region Web Element Methods

        /// <summary>
        /// Clicks on hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void Click(IWebElement hyperlinkElement)
        {
            try
            {
                WebElementMethodHelper.Click(hyperlinkElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkey of "Enter" to hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickHyperlinkUsingEnterKey(IWebElement hyperlinkElement)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(hyperlinkElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkeys of "Enter key of numpad" to hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        public static void ClickHyperlinkUsingReturnKey(IWebElement hyperlinkElement)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(hyperlinkElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of Hyperlink on webpage.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>Location of Hyperlink on webpage.</returns>
        public static Point GetHyperlinkLocation(IWebElement hyperlinkElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(hyperlinkElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>size of Hyperlink</returns>
        public static Size GetHyperlinkSize(IWebElement hyperlinkElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(hyperlinkElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>Tagname of Hyperlink</returns>
        public static string GetHyperlinkTagName(IWebElement hyperlinkElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(hyperlinkElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the text of Hyperlink.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>text of Hyperlink</returns>
        public static string GetHyperlinkText(IWebElement hyperlinkElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(hyperlinkElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Hyperlink is displyed or NOT.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>True if Hyperlink is displayed otherwise returns false</returns>
        public static bool IsHyperlinkDisplayed(IWebElement hyperlinkElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(hyperlinkElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Hyperlink is enabled or NOT.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>True if Hyperlink is enabled otherwise returns false</returns>
        public static bool IsHyperlinkEnabled(IWebElement hyperlinkElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(hyperlinkElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Hyperlink is selected or NOT.
        /// </summary>
        /// <param name="hyperlinkElement">Hyperlink WebElement</param>
        /// <returns>True if Hyperlink is selected otherwise returns false</returns>
        public static bool IsHyperlinkSelected(IWebElement hyperlinkElement)
        {
            try
            {
                bool isSelected = WebElementPropertyHelper.IsSelected(hyperlinkElement);
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