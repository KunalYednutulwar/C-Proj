using OpenQA.Selenium;
using System;
using System.Drawing;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    ///  Contains methods for performing various operations on RadioButton
    /// </summary>
    public class RadioButtonHelper
    {
        #region Get Attribute Methods

        /// <summary>
        /// Returns attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="attribute">Attribute Name</param>
        /// <returns>Attribute value</returns>
        public static string GetRadioButtonAttribute(IWebElement radioButtonElement, string attribute)
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetAttribute(radioButtonElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns inner text attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="attribute">Attribute name for Inner Text</param>
        /// <returns>Inner text attribute of RadioButton</returns>
        public static string GetRadioButtonInnerText(IWebElement radioButtonElement, string attribute = "InnerText")
        {
            try
            {
                string text = GetAttributeHelper.GetInnerTextAttribute(radioButtonElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="attribute">Attribute name for Text</param>
        /// <returns>Text attribute of RadioButton</returns>
        public static string GetRadioButtonText(IWebElement radioButtonElement, string attribute = "Text")
        {
            try
            {
                string text = GetAttributeHelper.GetTextAttribute(radioButtonElement, attribute);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns title attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="attribute">Attribute Name for title</param>
        /// <returns>title attribute value</returns>
        public static string GetRadioButtonTitle(IWebElement radioButtonElement, string attribute = "Title")
        {
            try
            {
                string attributeValue = GetAttributeHelper.GetControlTitleAttribute(radioButtonElement, attribute);
                return attributeValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns value attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="attribute">Attribute name for Value</param>
        /// <returns>Value attribute of RadioButton</returns>
        public static string GetRadioButtonValue(IWebElement radioButtonElement, string attribute = "Value")
        {
            try
            {
                string text = GetAttributeHelper.GetValueAttribute(radioButtonElement, attribute);
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
        /// Returns background color of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute name for background color</param>
        /// <returns>background color attribute value</returns>
        public static string GetRadioButtonBackgroundColor(IWebElement radioButtonElement, string cssProperty = "background-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBackgroundColor(radioButtonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns border color of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute name for border color</param>
        /// <returns>border color attribute value</returns>
        public static string GetRadioButtonBorderColor(IWebElement radioButtonElement, string cssProperty = "border-color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueBorderColor(radioButtonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns color of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute name for color</param>
        /// <returns>color attribute value</returns>
        public static string GetRadioButtonColor(IWebElement radioButtonElement, string cssProperty = "color")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueColor(radioButtonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns CSS value of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute</param>
        /// <returns>CSS attribute value</returns>
        public static string GetRadioButtonCSSValue(IWebElement radioButtonElement, string cssProperty)
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValue(radioButtonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font family details of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font family</param>
        /// <returns>font family attribute value</returns>
        public static string GetRadioButtonFontFamily(IWebElement radioButtonElement, string cssProperty = "font-family")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontFamily(radioButtonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font size details of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font size</param>
        /// <returns>font size attribute value</returns>
        public static string GetRadioButtonFontSize(IWebElement radioButtonElement, string cssProperty = "font-size")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontSize(radioButtonElement, cssProperty);
                return cssValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns font style details of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="cssProperty">CSS attribute name for font style</param>
        /// <returns>font style attribute value</returns>
        public static string GetRadioButtonFontStyle(IWebElement radioButtonElement, string cssProperty = "font-style")
        {
            try
            {
                string cssValue = GetCSSValueHelper.GetCSSValueFontStyle(radioButtonElement, cssProperty);
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
        /// Returns DOM Attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="dOMAttribute">DOM Attribute</param>
        /// <returns> DOM Attribute value</returns>
        public static string GetRadioButtonDOMAttribute(IWebElement radioButtonElement, string dOMAttribute)
        {
            try
            {
                string domAttribute = WebElementMethodHelper.GetDOMAttributeValue(radioButtonElement, dOMAttribute);
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
        /// Returns DOM Property of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="dOMProperty">DOM Property</param>
        /// <returns> DOM Property value</returns>
        public static string GetRadioButtonDomProperty(IWebElement radioButtonElement, string dOMProperty)
        {
            try
            {
                string domProperty = WebElementMethodHelper.GetDOMPropertyValue(radioButtonElement, dOMProperty);
                return domProperty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get DOM Property

        #region Get RadioButton ToolTip

        /// <summary>
        /// Returns Tooltip title for RadioButton.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <param name="hoverOverElement">Default value is false. If true method will hover over radioButton</param>
        /// <returns>Tooltip title for radioButton</returns>
        public static string GetRadioButtonTooltipTitle(IWebDriver driver, IWebElement radioButtonElement, bool hoverOverElement = false)
        {
            try
            {
                string tooltip = TooltipHelper.GetTooltipTitle(driver, radioButtonElement, hoverOverElement);
                return tooltip;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Get RadioButton ToolTip

        #region Keyboard Actions

        /// <summary>
        /// Clicks radioButton by pressing Enter key of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">Button WebElement</param>
        public static void ClickRadioButtonUsingKeyboardEnterKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                KeyboardHelper.PressEnterKeyUsingActionsClass(driver, radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks radiobutton by pressing return key present in numpad of keyboard
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ClickRadioButtonUsingKeyboardReturnKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                KeyboardHelper.PressReturnKeyUsingActionsClass(driver, radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected using keyboard Enter key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButtonUsingKeyboardEnterKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                UnselectRadioButtonUsingKeyboardEnterKey(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected using keyboard return key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButtonUsingKeyboardReturnKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                UnselectRadioButtonUsingKeyboardReturnKey(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected using keyboard enter key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButtonUsingKeyboardEnterKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    KeyboardHelper.PressEnterKeyUsingActionsClass(driver, radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected using keyboard return key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButtonUsingKeyboardReturnKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    KeyboardHelper.PressReturnKeyUsingActionsClass(driver, radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected using keyboard Enter key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnselectRadioButtonUsingKeyboardEnterKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    KeyboardHelper.PressEnterKeyUsingActionsClass(driver, radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected using keyboard return key.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnselectRadioButtonUsingKeyboardReturnKey(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    KeyboardHelper.PressReturnKeyUsingActionsClass(driver, radioButtonElement, false, false, false);
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
        /// Clicks radioButton
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ClickRadioButtonUsingMouse(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                MouseHelper.ClickOnElement(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButtonUsingMouse(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                UnselectRadioButtonUsingMouse(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButtonUsingMouse(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    MouseHelper.ClickOnElement(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnselectRadioButtonUsingMouse(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    MouseHelper.ClickOnElement(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click

        #region Hover, Move, Scroll

        /// <summary>
        /// Performs Mouse hover over RadioButton.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void MouseHoverRadioButton(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                MouseHelper.HoverOverElement(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cursor moves to radioButton
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void MoveToRadioButton(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                MouseHelper.MoveToElement(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Brings radioButton into view
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ScrollRadioButtonToView(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                MouseHelper.ScrollElementToView(driver, radioButtonElement);
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
        /// Clicks using Javascript on radioButton.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ClickRadioButtonUsingJavaScript(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                JavaScriptHelper.Click(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButtonUsingJavaScript(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                UnselectRadioButtonUsingJavaScript(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns radioButton text using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <return>returns text attribute of radioButton</return>
        public static string GetRadioButtonTextUsingJavaScript(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                string text = JavaScriptHelper.GetText(driver, radioButtonElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Background color of RadioButton using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void HighlightRadioButtonBackground(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                JavaScriptHelper.HighlightBackground(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights Border color of RadioButton using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void HighlightRadioButtonBorder(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorder(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Highlights both Border color and background color of RadioButton using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void HighlightRadioButtonBorderAndBackground(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                JavaScriptHelper.HighlightBorderAndBackground(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Scrolls to radioButton OffSet using JavaScript
        /// </summary>
        /// <param name="driver">Web Driver Instance</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollToRadioButtonOffSet(IWebDriver driver, int xOffSet, int yOffSet)
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
        /// Scrolls to radioButton using JavaScript
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ScrollToRadioButtonUsingJavaScript(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                JavaScriptHelper.ScrollToElement(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButtonUsingJavaScript(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    JavaScriptHelper.Click(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to unselected using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnselectRadioButtonUsingJavaScript(IWebDriver driver, IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    JavaScriptHelper.Click(driver, radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Actions

        #region Web Element Methods

        /// <summary>
        /// Clicks on Radio Button element.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ClickRadioButton(IWebElement radioButtonElement)
        {
            try
            {
                WebElementMethodHelper.Click(radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkey of "Enter" to radio button element.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ClickRadioButtonUsingEnterKey(IWebElement radioButtonElement)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs sendkey of "Return" to radio button element.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void ClickRadioButtonUsingReturnKey(IWebElement radioButtonElement)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to not selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButton(IWebElement radioButtonElement)
        {
            try
            {
                UnSelectRadioButton(radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to not selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButtonUsingEnterKey(IWebElement radioButtonElement)
        {
            try
            {
                UnSelectRadioButtonUsingEnterKey(radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to not selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void DeselectRadioButtonUsingReturnKey(IWebElement radioButtonElement)
        {
            try
            {
                UnSelectRadioButtonUsingReturnKey(radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButton(IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    WebElementMethodHelper.Click(radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButtonUsingEnterKey(IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    WebElementMethodHelper.PressEnterKey(radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void SelectRadioButtonUsingReturnKey(IWebElement radioButtonElement)
        {
            try
            {
                if (!IsRadioButtonSelected(radioButtonElement))
                    WebElementMethodHelper.PressReturnKey(radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to not selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnSelectRadioButton(IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    WebElementMethodHelper.Click(radioButtonElement);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to not selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnSelectRadioButtonUsingEnterKey(IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    WebElementMethodHelper.PressEnterKey(radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Changes the state of radioButton to not selected.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        public static void UnSelectRadioButtonUsingReturnKey(IWebElement radioButtonElement)
        {
            try
            {
                if (IsRadioButtonSelected(radioButtonElement))
                    WebElementMethodHelper.PressReturnKey(radioButtonElement, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Web Element Property Methods

        /// <summary>
        /// Returns the location of RadioButton on webpage.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>Location of RadioButton on webpage.</returns>
        public static Point GetRadioButtonLocation(IWebElement radioButtonElement)
        {
            try
            {
                Point location = WebElementPropertyHelper.GetLocation(radioButtonElement);
                return location;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the size attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>size of RadioButton</returns>
        public static Size GetRadioButtonSize(IWebElement radioButtonElement)
        {
            try
            {
                Size size = WebElementPropertyHelper.GetSize(radioButtonElement);
                return size;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the tagname of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>Tagname of RadioButton</returns>
        public static string GetRadioButtonTagName(IWebElement radioButtonElement)
        {
            try
            {
                string tagname = WebElementPropertyHelper.GetTagName(radioButtonElement);
                return tagname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns text attribute of RadioButton.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>Text of RadioButton</returns>
        public static string GetRadioButtonText(IWebElement radioButtonElement)
        {
            try
            {
                string text = WebElementPropertyHelper.GetText(radioButtonElement);
                return text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if RadioButton is displyed or NOT.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>True if RadioButton is displayed otherwise returns false</returns>
        public static bool IsRadioButtonDisplayed(IWebElement radioButtonElement)
        {
            try
            {
                bool isDisplayed = WebElementPropertyHelper.IsDisplayed(radioButtonElement);
                return isDisplayed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if RadioButton is enabled or NOT.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>True if RadioButton is enabled otherwise returns false</returns>
        public static bool IsRadioButtonEnabled(IWebElement radioButtonElement)
        {
            try
            {
                bool isEnabled = WebElementPropertyHelper.IsEnabled(radioButtonElement);
                return isEnabled;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if radioButton is selected or not.
        /// </summary>
        /// <param name="radioButtonElement">RadioButton WebElement</param>
        /// <returns>True if radioButton is selected otherwise returns false</returns>
        public static bool IsRadioButtonSelected(IWebElement radioButtonElement)
        {
            try
            {
                bool selected = WebElementPropertyHelper.IsSelected(radioButtonElement);
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