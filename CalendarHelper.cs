using OpenQA.Selenium;
using System;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on Calendar
    /// </summary>
    public class CalendarHelper
    {
        #region Web Element Methods

        /// <summary>
        /// Enters date and time.
        /// </summary>
        /// <param name="dateTimeElement">DateTime webElement</param>
        /// <param name="date">Date to be entered</param>
        /// <param name="time">Time to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true.If it's true it will  Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void SelectDateAndTimeWithoutDateTimePicker(IWebElement dateTimeElement, string date, string time, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                date = date + " ";
                TextBoxHelper.EnterText(dateTimeElement, date, clickTextboxBeforeEnteringValue, clearText, keysTab);
                TextBoxHelper.EnterText(dateTimeElement, time, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters date.
        /// </summary>
        /// <param name="dateElement">Date webElement</param>
        /// <param name="date">Date to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it's true it will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void SelectDateWithoutDatePicker(IWebElement dateElement, string date, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(dateElement, date, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Web Element Methods

        #region Keyboard Methods

        /// <summary>
        /// Enters date and time.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dateTimeElement">DateTime webElement</param>
        /// <param name="date">Date to be entered</param>
        /// <param name="time">Time to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it's true it will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void SelectDateAndTimeWithoutDateTimePickerUsingKeyboard(IWebDriver driver, IWebElement dateTimeElement, string date, string time, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                date = date + " ";
                KeyboardHelper.EnterTextUsingActionsClass(driver, dateTimeElement, date, clickTextboxBeforeEnteringValue, clearText, keysTab);
                KeyboardHelper.EnterTextUsingActionsClass(driver, dateTimeElement, time, false, false, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters date.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dateElement">Date webElement</param>
        /// <param name="date">Date to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it's true it will Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void SelectDateWithoutDatePickerUsingKeyboard(IWebDriver driver, IWebElement dateElement, string date, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                KeyboardHelper.EnterTextUsingActionsClass(driver, dateElement, date, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Keyboard Methods

        #region JavaScript Methods

        /// <summary>
        /// Enters date using JavaScript.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dateElement">Date webElement</param>
        /// <param name="date">Date to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Default value is true. If it's true it will Click on input control</param>
        public static void SelectDateWithoutDatePickerUsingJavaScript(IWebDriver driver, IWebElement dateElement, string date, bool clickTextboxBeforeEnteringValue = true)
        {
            try
            {
                JavaScriptHelper.EnterText(driver, dateElement, date, clickTextboxBeforeEnteringValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JavaScript Methods
    }
}