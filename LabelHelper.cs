using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    ///  Contains methods for performing various operations on Label
    /// </summary>
    public class LabelHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value</returns>
        public static string GetLabelAttribute(IWebElement labelElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(labelElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute of Label</returns>
        public static string GetLabelInnerText(IWebElement labelElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(labelElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns placeholder attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="attribute">Attribute Name for placeholder</param>
        /// <returns>placeholder attribute value</returns>
        public static string GetLabelPlaceholder(IWebElement labelElement, string attribute = "Placeholder")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetPlaceHolderAttribute(labelElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute of Label</returns>
        public static string GetLabelText(IWebElement labelElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(labelElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value</returns>
        public static string GetLabelTitle(IWebElement labelElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(labelElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="attribute">Attribute name for Value</param>
        /// <returns>Value attribute of Label</returns>
        public static string GetLabelValue(IWebElement labelElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(labelElement, attribute);
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
        /// Returns background color of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value</returns>
        public static string GetLabelBackgroundColor(IWebElement labelElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(labelElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetLabelBorderColor(IWebElement labelElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(labelElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value</returns>
        public static string GetLabelColor(IWebElement labelElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(labelElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetLabelCSSValue(IWebElement labelElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(labelElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value</returns>
        public static string GetLabelFontFamily(IWebElement labelElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(labelElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value</returns>
        public static string GetLabelFontSize(IWebElement labelElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(labelElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value</returns>
        public static string GetLabelFontStyle(IWebElement labelElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(labelElement, cssProperty);
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
        /// Returns DOM Attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value</returns>
        public static string GetLabelDOMAttribute(IWebElement labelElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(labelElement, dOMAttribute);
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
        /// Returns DOM Property of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value</returns>
        public static string GetLabelDomProperty(IWebElement labelElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(labelElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get Label ToolTip

        /// <summary>
        /// Returns Tooltip title for Label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true method will hover over label</param>
        /// <returns>Tooltip title for label</returns>
        public static string GetLabelTooltipTitle(IWebDriver driver, IWebElement labelElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, labelElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get Label ToolTip

        #region Keyboard Actions

        /// <summary>
        /// Clicks label by pressing Enter key of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickLabelUsingKeyboardEnterKey(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                KeyboardHelper.PressEnterKeyUsingActionsClass(driver, labelElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks label by pressing return key present in numpad of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickLabelUsingKeyboardReturnKey(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                KeyboardHelper.PressReturnKeyUsingActionsClass(driver, labelElement, false, false, false);
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
        /// Clicks and Holds on label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickAndHoldLabel(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.ClickAndHoldOnElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on label using Actions class implementation.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickLabelUsingMouse(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ContextClickLabel(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                RightClickLabel(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double clicks on label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void DoubleClickLabel(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.DoubleClickOnElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right clicks on label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void RightClickLabel(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.ContextClickOnElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Drag & Drop

        /// <summary>
        /// Drags label and drops to destination element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="destinationElement">destination to drop label</param>
        public static void DragAndDropLabelToAnotherElement(IWebDriver driver, IWebElement labelElement, IWebElement destinationElement)
        {
            try
            {
                MouseHelper.DragAndDropElement(driver, labelElement, destinationElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags label and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="targetElement">destination to drop label</param>
        public static void DragAndDropLabelToOffSetOfTargetElement(IWebDriver driver, IWebElement labelElement, IWebElement targetElement)
        {
            try
            {
                MouseHelper.DragAndDropElementToOffSetOfTargetElement(driver, labelElement, targetElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Drags label and drops to destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        /// <param name="xOffSet">x coordinate</param>
        /// <param name="yOffSet">y coordinate</param>
        public static void DragAndDropLabelToXYCoordinateLocation(IWebDriver driver, IWebElement labelElement, int xOffSet, int yOffSet)
        {
            try
            {
                MouseHelper.DragAndDropElementToXYCoordinates(driver, labelElement, xOffSet, yOffSet);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Drag & Drop

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over Label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void MouseHoverLabel(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to label
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void MoveToLabel(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings label into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ScrollLabelToView(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, labelElement);
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
        /// Clicks using Javascript on label.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickLabelUsingJavaScript(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns label text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        /// <return>returns text attribute of label</return>
        public static string GetLabelTextUsingJavaScript(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, labelElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of Label using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void HighlightLabelBackground(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of Label using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void HighlightLabelBorder(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of Label using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void HighlightLabelBorderAndBackground(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to label OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToLabelOffSet(IWebDriver driver, int xOffSet, int yOffSet)
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
        /// Scrolls to label using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="labelElement">Label WebElement</param>
        public static void ScrollToLabelUsingJavaScript(IWebDriver driver, IWebElement labelElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Actions

        #region Web Element Methods

        /// <summary>
        /// Clicks on label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        public static void Click(IWebElement labelElement)
        {
            try
            {
                WebElementMethodHelper.Click(labelElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkey of "Enter" to label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickLabelUsingEnterKey(IWebElement labelElement)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(labelElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkeys of "Enter key of numpad" to label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        public static void ClickLabelUsingReturnKey(IWebElement labelElement)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(labelElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of Label on webpage.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>Location of Label on webpage.</returns>
        public static Point GetLabelLocation(IWebElement labelElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(labelElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>size of Label</returns>
        public static Size GetLabelSize(IWebElement labelElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(labelElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>Tagname of Label</returns>
        public static string GetLabelTagName(IWebElement labelElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(labelElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the text of Label.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>text of Label</returns>
        public static string GetLabelText(IWebElement labelElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(labelElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Label is displyed or NOT.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>True if Label is displayed otherwise returns false</returns>
        public static bool IsLabelDisplayed(IWebElement labelElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(labelElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Label is enabled or NOT.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>True if Label is enabled otherwise returns false</returns>
        public static bool IsLabelEnabled(IWebElement labelElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(labelElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if Label is selected or NOT.
        /// </summary>
        /// <param name="labelElement">Label WebElement</param>
        /// <returns>True if Label is selected otherwise returns false</returns>
        public static bool IsLabelSelected(IWebElement labelElement)
        {
            try
            {
                bool isSelected = WebElementPropertyHelper.IsSelected(labelElement);
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