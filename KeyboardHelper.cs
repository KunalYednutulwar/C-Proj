using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using UISeleniumHelperLibrary.CustomExceptions;

namespace UISeleniumHelperLibrary
{
    #region Keyboard Key Enum

    /// <summary>
    /// Lists - keys available in a keyboard
    /// </summary>
    public enum Key
    {
        Null,
        NumberPad0,
        NumberPad1,
        NumberPad2,
        NumberPad3,
        NumberPad4,
        NumberPad5,
        NumberPad6,
        NumberPad7,
        NumberPad8,
        NumberPad9,
        Multiply,
        Add,
        Separator,
        Equal,
        Subtract,
        Divide,
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        Decimal,
        Meta,
        Semicolon,
        Insert,
        Cancel,
        Help,
        Backspace,
        Tab,
        Clear,
        Return,
        Enter,
        Shift,
        LeftShift,
        Control,
        LeftControl,
        Alt,
        LeftAlt,
        Delete,
        Pause,
        Space,
        PageUp,
        PageDown,
        End,
        Home,
        Left,
        ArrowLeft,
        Up,
        ArrowUp,
        Right,
        ArrowRight,
        Down,
        ArrowDown,
        Escape,
        Command
    }

    #endregion Keyboard Key Enum

    /// <summary>
    /// Contains all keyboard related helper methods - using Actions class and WebElement.Sendkeys
    /// </summary>
    public class KeyboardHelper
    {
        #region Keyboard Button Press

        /// <summary>
        /// Performs - Keydown operation for a key
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="key">Key to be clicked - from custom enum of keys</param>
        public static void KeyDown(IWebDriver driver, Key key)
        {
            try
            {
                Actions actions = new Actions(driver);

                #region Key Action

                switch (key)
                {
                    case Key.Null:
                        actions.KeyDown(Keys.Null);
                        break;

                    case Key.NumberPad0:
                        actions.KeyDown(Keys.NumberPad0);
                        break;

                    case Key.NumberPad1:
                        actions.KeyDown(Keys.NumberPad1);
                        break;

                    case Key.NumberPad2:
                        actions.KeyDown(Keys.NumberPad2);
                        break;

                    case Key.NumberPad3:
                        actions.KeyDown(Keys.NumberPad3);
                        break;

                    case Key.NumberPad4:
                        actions.KeyDown(Keys.NumberPad4);
                        break;

                    case Key.NumberPad5:
                        actions.KeyDown(Keys.NumberPad5);
                        break;

                    case Key.NumberPad6:
                        actions.KeyDown(Keys.NumberPad6);
                        break;

                    case Key.NumberPad7:
                        actions.KeyDown(Keys.NumberPad7);
                        break;

                    case Key.NumberPad8:
                        actions.KeyDown(Keys.NumberPad8);
                        break;

                    case Key.NumberPad9:
                        actions.KeyDown(Keys.NumberPad9);
                        break;

                    case Key.Multiply:
                        actions.KeyDown(Keys.Multiply);
                        break;

                    case Key.Add:
                        actions.KeyDown(Keys.Add);
                        break;

                    case Key.Separator:
                        actions.KeyDown(Keys.Separator);
                        break;

                    case Key.Equal:
                        actions.KeyDown(Keys.Equal);
                        break;

                    case Key.Subtract:
                        actions.KeyDown(Keys.Subtract);
                        break;

                    case Key.Divide:
                        actions.KeyDown(Keys.Divide);
                        break;

                    case Key.F1:
                        actions.KeyDown(Keys.F1);
                        break;

                    case Key.F2:
                        actions.KeyDown(Keys.F2);
                        break;

                    case Key.F3:
                        actions.KeyDown(Keys.F3);
                        break;

                    case Key.F4:
                        actions.KeyDown(Keys.F4);
                        break;

                    case Key.F5:
                        actions.KeyDown(Keys.F5);
                        break;

                    case Key.F6:
                        actions.KeyDown(Keys.F6);
                        break;

                    case Key.F7:
                        actions.KeyDown(Keys.F7);
                        break;

                    case Key.F8:
                        actions.KeyDown(Keys.F8);
                        break;

                    case Key.F9:
                        actions.KeyDown(Keys.F9);
                        break;

                    case Key.F10:
                        actions.KeyDown(Keys.F10);
                        break;

                    case Key.F11:
                        actions.KeyDown(Keys.F11);
                        break;

                    case Key.F12:
                        actions.KeyDown(Keys.F12);
                        break;

                    case Key.Decimal:
                        actions.KeyDown(Keys.Decimal);
                        break;

                    case Key.Meta:
                        actions.KeyDown(Keys.Meta);
                        break;

                    case Key.Semicolon:
                        actions.KeyDown(Keys.Semicolon);
                        break;

                    case Key.Insert:
                        actions.KeyDown(Keys.Insert);
                        break;

                    case Key.Cancel:
                        actions.KeyDown(Keys.Cancel);
                        break;

                    case Key.Help:
                        actions.KeyDown(Keys.Help);
                        break;

                    case Key.Backspace:
                        actions.KeyDown(Keys.Backspace);
                        break;

                    case Key.Tab:
                        actions.KeyDown(Keys.Tab);
                        break;

                    case Key.Clear:
                        actions.KeyDown(Keys.Clear);
                        break;

                    case Key.Return:
                        actions.KeyDown(Keys.Return);
                        break;

                    case Key.Enter:
                        actions.KeyDown(Keys.Enter);
                        break;

                    case Key.Shift:
                        actions.KeyDown(Keys.Shift);
                        break;

                    case Key.LeftShift:
                        actions.KeyDown(Keys.LeftShift);
                        break;

                    case Key.Control:
                        actions.KeyDown(Keys.Control);
                        break;

                    case Key.LeftControl:
                        actions.KeyDown(Keys.LeftControl);
                        break;

                    case Key.Alt:
                        actions.KeyDown(Keys.Alt);
                        break;

                    case Key.LeftAlt:
                        actions.KeyDown(Keys.LeftAlt);
                        break;

                    case Key.Delete:
                        actions.KeyDown(Keys.Delete);
                        break;

                    case Key.Pause:
                        actions.KeyDown(Keys.Pause);
                        break;

                    case Key.Space:
                        actions.KeyDown(Keys.Space);
                        break;

                    case Key.PageUp:
                        actions.KeyDown(Keys.PageUp);
                        break;

                    case Key.PageDown:
                        actions.KeyDown(Keys.PageDown);
                        break;

                    case Key.End:
                        actions.KeyDown(Keys.End);
                        break;

                    case Key.Home:
                        actions.KeyDown(Keys.Home);
                        break;

                    case Key.Left:
                        actions.KeyDown(Keys.Left);
                        break;

                    case Key.ArrowLeft:
                        actions.KeyDown(Keys.ArrowLeft);
                        break;

                    case Key.Up:
                        actions.KeyDown(Keys.Up);
                        break;

                    case Key.ArrowUp:
                        actions.KeyDown(Keys.ArrowUp);
                        break;

                    case Key.Right:
                        actions.KeyDown(Keys.Right);
                        break;

                    case Key.ArrowRight:
                        actions.KeyDown(Keys.ArrowRight);
                        break;

                    case Key.Down:
                        actions.KeyDown(Keys.Down);
                        break;

                    case Key.ArrowDown:
                        actions.KeyDown(Keys.ArrowDown);
                        break;

                    case Key.Escape:
                        actions.KeyDown(Keys.Escape);
                        break;

                    case Key.Command:
                        actions.KeyDown(Keys.Command);
                        break;

                    default:
                        throw new NoSuitableKeyFoundException($"{key}'s  is not found! Please check method {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }

                #endregion Key Action

                actions.Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Keydown operation for a key on an element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="key">Key to be clicked - from custom enum of keys</param>
        public static void KeyDownOnElement(IWebDriver driver, IWebElement element, Key key)
        {
            try
            {
                Actions actions = new Actions(driver);

                #region Key Action

                switch (key)
                {
                    case Key.Null:
                        actions.KeyDown(element, Keys.Null);
                        break;

                    case Key.NumberPad0:
                        actions.KeyDown(element, Keys.NumberPad0);
                        break;

                    case Key.NumberPad1:
                        actions.KeyDown(element, Keys.NumberPad1);
                        break;

                    case Key.NumberPad2:
                        actions.KeyDown(element, Keys.NumberPad2);
                        break;

                    case Key.NumberPad3:
                        actions.KeyDown(element, Keys.NumberPad3);
                        break;

                    case Key.NumberPad4:
                        actions.KeyDown(element, Keys.NumberPad4);
                        break;

                    case Key.NumberPad5:
                        actions.KeyDown(element, Keys.NumberPad5);
                        break;

                    case Key.NumberPad6:
                        actions.KeyDown(element, Keys.NumberPad6);
                        break;

                    case Key.NumberPad7:
                        actions.KeyDown(element, Keys.NumberPad7);
                        break;

                    case Key.NumberPad8:
                        actions.KeyDown(element, Keys.NumberPad8);
                        break;

                    case Key.NumberPad9:
                        actions.KeyDown(element, Keys.NumberPad9);
                        break;

                    case Key.Multiply:
                        actions.KeyDown(element, Keys.Multiply);
                        break;

                    case Key.Add:
                        actions.KeyDown(element, Keys.Add);
                        break;

                    case Key.Separator:
                        actions.KeyDown(element, Keys.Separator);
                        break;

                    case Key.Equal:
                        actions.KeyDown(element, Keys.Equal);
                        break;

                    case Key.Subtract:
                        actions.KeyDown(element, Keys.Subtract);
                        break;

                    case Key.Divide:
                        actions.KeyDown(element, Keys.Divide);
                        break;

                    case Key.F1:
                        actions.KeyDown(element, Keys.F1);
                        break;

                    case Key.F2:
                        actions.KeyDown(element, Keys.F2);
                        break;

                    case Key.F3:
                        actions.KeyDown(element, Keys.F3);
                        break;

                    case Key.F4:
                        actions.KeyDown(element, Keys.F4);
                        break;

                    case Key.F5:
                        actions.KeyDown(element, Keys.F5);
                        break;

                    case Key.F6:
                        actions.KeyDown(element, Keys.F6);
                        break;

                    case Key.F7:
                        actions.KeyDown(element, Keys.F7);
                        break;

                    case Key.F8:
                        actions.KeyDown(element, Keys.F8);
                        break;

                    case Key.F9:
                        actions.KeyDown(element, Keys.F9);
                        break;

                    case Key.F10:
                        actions.KeyDown(element, Keys.F10);
                        break;

                    case Key.F11:
                        actions.KeyDown(element, Keys.F11);
                        break;

                    case Key.F12:
                        actions.KeyDown(element, Keys.F12);
                        break;

                    case Key.Decimal:
                        actions.KeyDown(element, Keys.Decimal);
                        break;

                    case Key.Meta:
                        actions.KeyDown(element, Keys.Meta);
                        break;

                    case Key.Semicolon:
                        actions.KeyDown(element, Keys.Semicolon);
                        break;

                    case Key.Insert:
                        actions.KeyDown(element, Keys.Insert);
                        break;

                    case Key.Cancel:
                        actions.KeyDown(element, Keys.Cancel);
                        break;

                    case Key.Help:
                        actions.KeyDown(element, Keys.Help);
                        break;

                    case Key.Backspace:
                        actions.KeyDown(element, Keys.Backspace);
                        break;

                    case Key.Tab:
                        actions.KeyDown(element, Keys.Tab);
                        break;

                    case Key.Clear:
                        actions.KeyDown(element, Keys.Clear);
                        break;

                    case Key.Return:
                        actions.KeyDown(element, Keys.Return);
                        break;

                    case Key.Enter:
                        actions.KeyDown(element, Keys.Enter);
                        break;

                    case Key.Shift:
                        actions.KeyDown(element, Keys.Shift);
                        break;

                    case Key.LeftShift:
                        actions.KeyDown(element, Keys.LeftShift);
                        break;

                    case Key.Control:
                        actions.KeyDown(element, Keys.Control);
                        break;

                    case Key.LeftControl:
                        actions.KeyDown(element, Keys.LeftControl);
                        break;

                    case Key.Alt:
                        actions.KeyDown(element, Keys.Alt);
                        break;

                    case Key.LeftAlt:
                        actions.KeyDown(element, Keys.LeftAlt);
                        break;

                    case Key.Delete:
                        actions.KeyDown(element, Keys.Delete);
                        break;

                    case Key.Pause:
                        actions.KeyDown(element, Keys.Pause);
                        break;

                    case Key.Space:
                        actions.KeyDown(element, Keys.Space);
                        break;

                    case Key.PageUp:
                        actions.KeyDown(element, Keys.PageUp);
                        break;

                    case Key.PageDown:
                        actions.KeyDown(element, Keys.PageDown);
                        break;

                    case Key.End:
                        actions.KeyDown(element, Keys.End);
                        break;

                    case Key.Home:
                        actions.KeyDown(element, Keys.Home);
                        break;

                    case Key.Left:
                        actions.KeyDown(element, Keys.Left);
                        break;

                    case Key.ArrowLeft:
                        actions.KeyDown(element, Keys.ArrowLeft);
                        break;

                    case Key.Up:
                        actions.KeyDown(element, Keys.Up);
                        break;

                    case Key.ArrowUp:
                        actions.KeyDown(element, Keys.ArrowUp);
                        break;

                    case Key.Right:
                        actions.KeyDown(element, Keys.Right);
                        break;

                    case Key.ArrowRight:
                        actions.KeyDown(element, Keys.ArrowRight);
                        break;

                    case Key.Down:
                        actions.KeyDown(element, Keys.Down);
                        break;

                    case Key.ArrowDown:
                        actions.KeyDown(element, Keys.ArrowDown);
                        break;

                    case Key.Escape:
                        actions.KeyDown(element, Keys.Escape);
                        break;

                    case Key.Command:
                        actions.KeyDown(element, Keys.Command);
                        break;

                    default:
                        throw new NoSuitableKeyFoundException($"{key}'s  is not found! Please check method {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }

                #endregion Key Action

                actions.Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - KeyUp operation for a key
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="key">Key to be clicked - from custom enum of keys</param>
        public static void KeyUp(IWebDriver driver, Key key)
        {
            try
            {
                Actions actions = new Actions(driver);

                #region Key Action

                switch (key)
                {
                    case Key.Null:
                        actions.KeyUp(Keys.Null);
                        break;

                    case Key.NumberPad0:
                        actions.KeyUp(Keys.NumberPad0);
                        break;

                    case Key.NumberPad1:
                        actions.KeyUp(Keys.NumberPad1);
                        break;

                    case Key.NumberPad2:
                        actions.KeyUp(Keys.NumberPad2);
                        break;

                    case Key.NumberPad3:
                        actions.KeyUp(Keys.NumberPad3);
                        break;

                    case Key.NumberPad4:
                        actions.KeyUp(Keys.NumberPad4);
                        break;

                    case Key.NumberPad5:
                        actions.KeyUp(Keys.NumberPad5);
                        break;

                    case Key.NumberPad6:
                        actions.KeyUp(Keys.NumberPad6);
                        break;

                    case Key.NumberPad7:
                        actions.KeyUp(Keys.NumberPad7);
                        break;

                    case Key.NumberPad8:
                        actions.KeyUp(Keys.NumberPad8);
                        break;

                    case Key.NumberPad9:
                        actions.KeyUp(Keys.NumberPad9);
                        break;

                    case Key.Multiply:
                        actions.KeyUp(Keys.Multiply);
                        break;

                    case Key.Add:
                        actions.KeyUp(Keys.Add);
                        break;

                    case Key.Separator:
                        actions.KeyUp(Keys.Separator);
                        break;

                    case Key.Equal:
                        actions.KeyUp(Keys.Equal);
                        break;

                    case Key.Subtract:
                        actions.KeyUp(Keys.Subtract);
                        break;

                    case Key.Divide:
                        actions.KeyUp(Keys.Divide);
                        break;

                    case Key.F1:
                        actions.KeyUp(Keys.F1);
                        break;

                    case Key.F2:
                        actions.KeyUp(Keys.F2);
                        break;

                    case Key.F3:
                        actions.KeyUp(Keys.F3);
                        break;

                    case Key.F4:
                        actions.KeyUp(Keys.F4);
                        break;

                    case Key.F5:
                        actions.KeyUp(Keys.F5);
                        break;

                    case Key.F6:
                        actions.KeyUp(Keys.F6);
                        break;

                    case Key.F7:
                        actions.KeyUp(Keys.F7);
                        break;

                    case Key.F8:
                        actions.KeyUp(Keys.F8);
                        break;

                    case Key.F9:
                        actions.KeyUp(Keys.F9);
                        break;

                    case Key.F10:
                        actions.KeyUp(Keys.F10);
                        break;

                    case Key.F11:
                        actions.KeyUp(Keys.F11);
                        break;

                    case Key.F12:
                        actions.KeyUp(Keys.F12);
                        break;

                    case Key.Decimal:
                        actions.KeyUp(Keys.Decimal);
                        break;

                    case Key.Meta:
                        actions.KeyUp(Keys.Meta);
                        break;

                    case Key.Semicolon:
                        actions.KeyUp(Keys.Semicolon);
                        break;

                    case Key.Insert:
                        actions.KeyUp(Keys.Insert);
                        break;

                    case Key.Cancel:
                        actions.KeyUp(Keys.Cancel);
                        break;

                    case Key.Help:
                        actions.KeyUp(Keys.Help);
                        break;

                    case Key.Backspace:
                        actions.KeyUp(Keys.Backspace);
                        break;

                    case Key.Tab:
                        actions.KeyUp(Keys.Tab);
                        break;

                    case Key.Clear:
                        actions.KeyUp(Keys.Clear);
                        break;

                    case Key.Return:
                        actions.KeyUp(Keys.Return);
                        break;

                    case Key.Enter:
                        actions.KeyUp(Keys.Enter);
                        break;

                    case Key.Shift:
                        actions.KeyUp(Keys.Shift);
                        break;

                    case Key.LeftShift:
                        actions.KeyUp(Keys.LeftShift);
                        break;

                    case Key.Control:
                        actions.KeyUp(Keys.Control);
                        break;

                    case Key.LeftControl:
                        actions.KeyUp(Keys.LeftControl);
                        break;

                    case Key.Alt:
                        actions.KeyUp(Keys.Alt);
                        break;

                    case Key.LeftAlt:
                        actions.KeyUp(Keys.LeftAlt);
                        break;

                    case Key.Delete:
                        actions.KeyUp(Keys.Delete);
                        break;

                    case Key.Pause:
                        actions.KeyUp(Keys.Pause);
                        break;

                    case Key.Space:
                        actions.KeyUp(Keys.Space);
                        break;

                    case Key.PageUp:
                        actions.KeyUp(Keys.PageUp);
                        break;

                    case Key.PageDown:
                        actions.KeyUp(Keys.PageDown);
                        break;

                    case Key.End:
                        actions.KeyUp(Keys.End);
                        break;

                    case Key.Home:
                        actions.KeyUp(Keys.Home);
                        break;

                    case Key.Left:
                        actions.KeyUp(Keys.Left);
                        break;

                    case Key.ArrowLeft:
                        actions.KeyUp(Keys.ArrowLeft);
                        break;

                    case Key.Up:
                        actions.KeyUp(Keys.Up);
                        break;

                    case Key.ArrowUp:
                        actions.KeyUp(Keys.ArrowUp);
                        break;

                    case Key.Right:
                        actions.KeyUp(Keys.Right);
                        break;

                    case Key.ArrowRight:
                        actions.KeyUp(Keys.ArrowRight);
                        break;

                    case Key.Down:
                        actions.KeyUp(Keys.Down);
                        break;

                    case Key.ArrowDown:
                        actions.KeyUp(Keys.ArrowDown);
                        break;

                    case Key.Escape:
                        actions.KeyUp(Keys.Escape);
                        break;

                    case Key.Command:
                        actions.KeyUp(Keys.Command);
                        break;

                    default:
                        throw new NoSuitableKeyFoundException($"{key}'s  is not found! Please check method {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }

                #endregion Key Action

                actions.Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - KeyUp operation for a key on an element
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="key">Key to be clicked - from custom enum of keys</param>
        public static void KeyUpOnElement(IWebDriver driver, IWebElement element, Key key)
        {
            try
            {
                Actions actions = new Actions(driver);

                #region Key Action

                switch (key)
                {
                    case Key.Null:
                        actions.KeyUp(element, Keys.Null);
                        break;

                    case Key.NumberPad0:
                        actions.KeyUp(element, Keys.NumberPad0);
                        break;

                    case Key.NumberPad1:
                        actions.KeyUp(element, Keys.NumberPad1);
                        break;

                    case Key.NumberPad2:
                        actions.KeyUp(element, Keys.NumberPad2);
                        break;

                    case Key.NumberPad3:
                        actions.KeyUp(element, Keys.NumberPad3);
                        break;

                    case Key.NumberPad4:
                        actions.KeyUp(element, Keys.NumberPad4);
                        break;

                    case Key.NumberPad5:
                        actions.KeyUp(element, Keys.NumberPad5);
                        break;

                    case Key.NumberPad6:
                        actions.KeyUp(element, Keys.NumberPad6);
                        break;

                    case Key.NumberPad7:
                        actions.KeyUp(element, Keys.NumberPad7);
                        break;

                    case Key.NumberPad8:
                        actions.KeyUp(element, Keys.NumberPad8);
                        break;

                    case Key.NumberPad9:
                        actions.KeyUp(element, Keys.NumberPad9);
                        break;

                    case Key.Multiply:
                        actions.KeyUp(element, Keys.Multiply);
                        break;

                    case Key.Add:
                        actions.KeyUp(element, Keys.Add);
                        break;

                    case Key.Separator:
                        actions.KeyUp(element, Keys.Separator);
                        break;

                    case Key.Equal:
                        actions.KeyUp(element, Keys.Equal);
                        break;

                    case Key.Subtract:
                        actions.KeyUp(element, Keys.Subtract);
                        break;

                    case Key.Divide:
                        actions.KeyUp(element, Keys.Divide);
                        break;

                    case Key.F1:
                        actions.KeyUp(element, Keys.F1);
                        break;

                    case Key.F2:
                        actions.KeyUp(element, Keys.F2);
                        break;

                    case Key.F3:
                        actions.KeyUp(element, Keys.F3);
                        break;

                    case Key.F4:
                        actions.KeyUp(element, Keys.F4);
                        break;

                    case Key.F5:
                        actions.KeyUp(element, Keys.F5);
                        break;

                    case Key.F6:
                        actions.KeyUp(element, Keys.F6);
                        break;

                    case Key.F7:
                        actions.KeyUp(element, Keys.F7);
                        break;

                    case Key.F8:
                        actions.KeyUp(element, Keys.F8);
                        break;

                    case Key.F9:
                        actions.KeyUp(element, Keys.F9);
                        break;

                    case Key.F10:
                        actions.KeyUp(element, Keys.F10);
                        break;

                    case Key.F11:
                        actions.KeyUp(element, Keys.F11);
                        break;

                    case Key.F12:
                        actions.KeyUp(element, Keys.F12);
                        break;

                    case Key.Decimal:
                        actions.KeyUp(element, Keys.Decimal);
                        break;

                    case Key.Meta:
                        actions.KeyUp(element, Keys.Meta);
                        break;

                    case Key.Semicolon:
                        actions.KeyUp(element, Keys.Semicolon);
                        break;

                    case Key.Insert:
                        actions.KeyUp(element, Keys.Insert);
                        break;

                    case Key.Cancel:
                        actions.KeyUp(element, Keys.Cancel);
                        break;

                    case Key.Help:
                        actions.KeyUp(element, Keys.Help);
                        break;

                    case Key.Backspace:
                        actions.KeyUp(element, Keys.Backspace);
                        break;

                    case Key.Tab:
                        actions.KeyUp(element, Keys.Tab);
                        break;

                    case Key.Clear:
                        actions.KeyUp(element, Keys.Clear);
                        break;

                    case Key.Return:
                        actions.KeyUp(element, Keys.Return);
                        break;

                    case Key.Enter:
                        actions.KeyUp(element, Keys.Enter);
                        break;

                    case Key.Shift:
                        actions.KeyUp(element, Keys.Shift);
                        break;

                    case Key.LeftShift:
                        actions.KeyUp(element, Keys.LeftShift);
                        break;

                    case Key.Control:
                        actions.KeyUp(element, Keys.Control);
                        break;

                    case Key.LeftControl:
                        actions.KeyUp(element, Keys.LeftControl);
                        break;

                    case Key.Alt:
                        actions.KeyUp(element, Keys.Alt);
                        break;

                    case Key.LeftAlt:
                        actions.KeyUp(element, Keys.LeftAlt);
                        break;

                    case Key.Delete:
                        actions.KeyUp(element, Keys.Delete);
                        break;

                    case Key.Pause:
                        actions.KeyUp(element, Keys.Pause);
                        break;

                    case Key.Space:
                        actions.KeyUp(element, Keys.Space);
                        break;

                    case Key.PageUp:
                        actions.KeyUp(element, Keys.PageUp);
                        break;

                    case Key.PageDown:
                        actions.KeyUp(element, Keys.PageDown);
                        break;

                    case Key.End:
                        actions.KeyUp(element, Keys.End);
                        break;

                    case Key.Home:
                        actions.KeyUp(element, Keys.Home);
                        break;

                    case Key.Left:
                        actions.KeyUp(element, Keys.Left);
                        break;

                    case Key.ArrowLeft:
                        actions.KeyUp(element, Keys.ArrowLeft);
                        break;

                    case Key.Up:
                        actions.KeyUp(element, Keys.Up);
                        break;

                    case Key.ArrowUp:
                        actions.KeyUp(element, Keys.ArrowUp);
                        break;

                    case Key.Right:
                        actions.KeyUp(element, Keys.Right);
                        break;

                    case Key.ArrowRight:
                        actions.KeyUp(element, Keys.ArrowRight);
                        break;

                    case Key.Down:
                        actions.KeyUp(element, Keys.Down);
                        break;

                    case Key.ArrowDown:
                        actions.KeyUp(element, Keys.ArrowDown);
                        break;

                    case Key.Escape:
                        actions.KeyUp(element, Keys.Escape);
                        break;

                    case Key.Command:
                        actions.KeyUp(element, Keys.Command);
                        break;

                    default:
                        throw new NoSuitableKeyFoundException($"{key}'s  is not found! Please check method {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }

                #endregion Key Action

                actions.Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press backspace button on keyboard.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on textbox control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressBackspaceKey(IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.PressBackspaceKey(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press backspace button on keyboard uisng Actions Class.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressBackspaceKeyUsingActionsClass(IWebDriver driver, IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                PressKeyUsingActionsClassOnElement(driver, element, Key.Backspace, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Perform - press enter button on keyboard.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressEnterKey(IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.PressEnterKey(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Perform - press enter button on keyboard using actions class.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressEnterKeyUsingActionsClass(IWebDriver driver, IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                PressKeyUsingActionsClassOnElement(driver, element, Key.Enter, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press escape on keyboard.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressEscapeKey(IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.PressEscapeKey(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press escape on keyboard.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressEscapeKeyUsingActionsClass(IWebDriver driver, IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                PressKeyUsingActionsClassOnElement(driver, element, Key.Escape, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - pressing of a key on IWebElement passed.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="key">Key to be pressed - custom enum of keys</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressKey(IWebElement element, string key, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(element, key, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - pressing of a key using Actions class.
        /// </summary>
        /// <param name="driver">web driver instance</param>
        /// <param name="key">Key to be pressed - custom enum of keys</param>
        public static void PressKeyUsingActionsClass(IWebDriver driver, Key key)
        {
            try
            {
                //not implementing - click as this method will only perform key action where ever the cursor is. There is another overload for element specific action

                Actions actions = new Actions(driver);

                #region Key Actions

                switch (key)
                {
                    case Key.Null:
                        actions.SendKeys(Keys.Null);
                        break;

                    case Key.NumberPad0:
                        actions.SendKeys(Keys.NumberPad0);
                        break;

                    case Key.NumberPad1:
                        actions.SendKeys(Keys.NumberPad1);
                        break;

                    case Key.NumberPad2:
                        actions.SendKeys(Keys.NumberPad2);
                        break;

                    case Key.NumberPad3:
                        actions.SendKeys(Keys.NumberPad3);
                        break;

                    case Key.NumberPad4:
                        actions.SendKeys(Keys.NumberPad4);
                        break;

                    case Key.NumberPad5:
                        actions.SendKeys(Keys.NumberPad5);
                        break;

                    case Key.NumberPad6:
                        actions.SendKeys(Keys.NumberPad6);
                        break;

                    case Key.NumberPad7:
                        actions.SendKeys(Keys.NumberPad7);
                        break;

                    case Key.NumberPad8:
                        actions.SendKeys(Keys.NumberPad8);
                        break;

                    case Key.NumberPad9:
                        actions.SendKeys(Keys.NumberPad9);
                        break;

                    case Key.Multiply:
                        actions.SendKeys(Keys.Multiply);
                        break;

                    case Key.Add:
                        actions.SendKeys(Keys.Add);
                        break;

                    case Key.Separator:
                        actions.SendKeys(Keys.Separator);
                        break;

                    case Key.Equal:
                        actions.SendKeys(Keys.Equal);
                        break;

                    case Key.Subtract:
                        actions.SendKeys(Keys.Subtract);
                        break;

                    case Key.Divide:
                        actions.SendKeys(Keys.Divide);
                        break;

                    case Key.F1:
                        actions.SendKeys(Keys.F1);
                        break;

                    case Key.F2:
                        actions.SendKeys(Keys.F2);
                        break;

                    case Key.F3:
                        actions.SendKeys(Keys.F3);
                        break;

                    case Key.F4:
                        actions.SendKeys(Keys.F4);
                        break;

                    case Key.F5:
                        actions.SendKeys(Keys.F5);
                        break;

                    case Key.F6:
                        actions.SendKeys(Keys.F6);
                        break;

                    case Key.F7:
                        actions.SendKeys(Keys.F7);
                        break;

                    case Key.F8:
                        actions.SendKeys(Keys.F8);
                        break;

                    case Key.F9:
                        actions.SendKeys(Keys.F9);
                        break;

                    case Key.F10:
                        actions.SendKeys(Keys.F10);
                        break;

                    case Key.F11:
                        actions.SendKeys(Keys.F11);
                        break;

                    case Key.F12:
                        actions.SendKeys(Keys.F12);
                        break;

                    case Key.Decimal:
                        actions.SendKeys(Keys.Decimal);
                        break;

                    case Key.Meta:
                        actions.SendKeys(Keys.Meta);
                        break;

                    case Key.Semicolon:
                        actions.SendKeys(Keys.Semicolon);
                        break;

                    case Key.Insert:
                        actions.SendKeys(Keys.Insert);
                        break;

                    case Key.Cancel:
                        actions.SendKeys(Keys.Cancel);
                        break;

                    case Key.Help:
                        actions.SendKeys(Keys.Help);
                        break;

                    case Key.Backspace:
                        actions.SendKeys(Keys.Backspace);
                        break;

                    case Key.Tab:
                        actions.SendKeys(Keys.Tab);
                        break;

                    case Key.Clear:
                        actions.SendKeys(Keys.Clear);
                        break;

                    case Key.Return:
                        actions.SendKeys(Keys.Return);
                        break;

                    case Key.Enter:
                        actions.SendKeys(Keys.Enter);
                        break;

                    case Key.Shift:
                        actions.SendKeys(Keys.Shift);
                        break;

                    case Key.LeftShift:
                        actions.SendKeys(Keys.LeftShift);
                        break;

                    case Key.Control:
                        actions.SendKeys(Keys.Control);
                        break;

                    case Key.LeftControl:
                        actions.SendKeys(Keys.LeftControl);
                        break;

                    case Key.Alt:
                        actions.SendKeys(Keys.Alt);
                        break;

                    case Key.LeftAlt:
                        actions.SendKeys(Keys.LeftAlt);
                        break;

                    case Key.Delete:
                        actions.SendKeys(Keys.Delete);
                        break;

                    case Key.Pause:
                        actions.SendKeys(Keys.Pause);
                        break;

                    case Key.Space:
                        actions.SendKeys(Keys.Space);
                        break;

                    case Key.PageUp:
                        actions.SendKeys(Keys.PageUp);
                        break;

                    case Key.PageDown:
                        actions.SendKeys(Keys.PageDown);
                        break;

                    case Key.End:
                        actions.SendKeys(Keys.End);
                        break;

                    case Key.Home:
                        actions.SendKeys(Keys.Home);
                        break;

                    case Key.Left:
                        actions.SendKeys(Keys.Left);
                        break;

                    case Key.ArrowLeft:
                        actions.SendKeys(Keys.ArrowLeft);
                        break;

                    case Key.Up:
                        actions.SendKeys(Keys.Up);
                        break;

                    case Key.ArrowUp:
                        actions.SendKeys(Keys.ArrowUp);
                        break;

                    case Key.Right:
                        actions.SendKeys(Keys.Right);
                        break;

                    case Key.ArrowRight:
                        actions.SendKeys(Keys.ArrowRight);
                        break;

                    case Key.Down:
                        actions.SendKeys(Keys.Down);
                        break;

                    case Key.ArrowDown:
                        actions.SendKeys(Keys.ArrowDown);
                        break;

                    case Key.Escape:
                        actions.SendKeys(Keys.Escape);
                        break;

                    case Key.Command:
                        actions.SendKeys(Keys.Command);
                        break;

                    default:
                        throw new NoSuitableKeyFoundException($"{key}'s  is not found! Please check method {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }

                #endregion Key Actions

                actions.Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - pressing of a key using Actions class on IWebElement passed.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="driver">web driver instance</param>
        /// <param name="key">Key to be pressed - custom enum of keys</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressKeyUsingActionsClassOnElement(IWebDriver driver, IWebElement element, Key key, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                if (clickTextboxBeforeEnteringValue)
                {
                    MouseHelper.ClickOnElement(driver, element);
                }

                if (clearText)
                {
                    //not using actions class here - as there is no method to clear - passing repeated backspace is not an option or select & delete
                    WebElementMethodHelper.Clear(element);
                }

                Actions actions = new Actions(driver);

                #region Key Action

                switch (key)
                {
                    case Key.Null:
                        actions.SendKeys(element, Keys.Null);
                        break;

                    case Key.NumberPad0:
                        actions.SendKeys(element, Keys.NumberPad0);
                        break;

                    case Key.NumberPad1:
                        actions.SendKeys(element, Keys.NumberPad1);
                        break;

                    case Key.NumberPad2:
                        actions.SendKeys(element, Keys.NumberPad2);
                        break;

                    case Key.NumberPad3:
                        actions.SendKeys(element, Keys.NumberPad3);
                        break;

                    case Key.NumberPad4:
                        actions.SendKeys(element, Keys.NumberPad4);
                        break;

                    case Key.NumberPad5:
                        actions.SendKeys(element, Keys.NumberPad5);
                        break;

                    case Key.NumberPad6:
                        actions.SendKeys(element, Keys.NumberPad6);
                        break;

                    case Key.NumberPad7:
                        actions.SendKeys(element, Keys.NumberPad7);
                        break;

                    case Key.NumberPad8:
                        actions.SendKeys(element, Keys.NumberPad8);
                        break;

                    case Key.NumberPad9:
                        actions.SendKeys(element, Keys.NumberPad9);
                        break;

                    case Key.Multiply:
                        actions.SendKeys(element, Keys.Multiply);
                        break;

                    case Key.Add:
                        actions.SendKeys(element, Keys.Add);
                        break;

                    case Key.Separator:
                        actions.SendKeys(element, Keys.Separator);
                        break;

                    case Key.Equal:
                        actions.SendKeys(element, Keys.Equal);
                        break;

                    case Key.Subtract:
                        actions.SendKeys(element, Keys.Subtract);
                        break;

                    case Key.Divide:
                        actions.SendKeys(element, Keys.Divide);
                        break;

                    case Key.F1:
                        actions.SendKeys(element, Keys.F1);
                        break;

                    case Key.F2:
                        actions.SendKeys(element, Keys.F2);
                        break;

                    case Key.F3:
                        actions.SendKeys(element, Keys.F3);
                        break;

                    case Key.F4:
                        actions.SendKeys(element, Keys.F4);
                        break;

                    case Key.F5:
                        actions.SendKeys(element, Keys.F5);
                        break;

                    case Key.F6:
                        actions.SendKeys(element, Keys.F6);
                        break;

                    case Key.F7:
                        actions.SendKeys(element, Keys.F7);
                        break;

                    case Key.F8:
                        actions.SendKeys(element, Keys.F8);
                        break;

                    case Key.F9:
                        actions.SendKeys(element, Keys.F9);
                        break;

                    case Key.F10:
                        actions.SendKeys(element, Keys.F10);
                        break;

                    case Key.F11:
                        actions.SendKeys(element, Keys.F11);
                        break;

                    case Key.F12:
                        actions.SendKeys(element, Keys.F12);
                        break;

                    case Key.Decimal:
                        actions.SendKeys(element, Keys.Decimal);
                        break;

                    case Key.Meta:
                        actions.SendKeys(element, Keys.Meta);
                        break;

                    case Key.Semicolon:
                        actions.SendKeys(element, Keys.Semicolon);
                        break;

                    case Key.Insert:
                        actions.SendKeys(element, Keys.Insert);
                        break;

                    case Key.Cancel:
                        actions.SendKeys(element, Keys.Cancel);
                        break;

                    case Key.Help:
                        actions.SendKeys(element, Keys.Help);
                        break;

                    case Key.Backspace:
                        actions.SendKeys(element, Keys.Backspace);
                        break;

                    case Key.Tab:
                        actions.SendKeys(element, Keys.Tab);
                        break;

                    case Key.Clear:
                        actions.SendKeys(element, Keys.Clear);
                        break;

                    case Key.Return:
                        actions.SendKeys(element, Keys.Return);
                        break;

                    case Key.Enter:
                        actions.SendKeys(element, Keys.Enter);
                        break;

                    case Key.Shift:
                        actions.SendKeys(element, Keys.Shift);
                        break;

                    case Key.LeftShift:
                        actions.SendKeys(element, Keys.LeftShift);
                        break;

                    case Key.Control:
                        actions.SendKeys(element, Keys.Control);
                        break;

                    case Key.LeftControl:
                        actions.SendKeys(element, Keys.LeftControl);
                        break;

                    case Key.Alt:
                        actions.SendKeys(element, Keys.Alt);
                        break;

                    case Key.LeftAlt:
                        actions.SendKeys(element, Keys.LeftAlt);
                        break;

                    case Key.Delete:
                        actions.SendKeys(element, Keys.Delete);
                        break;

                    case Key.Pause:
                        actions.SendKeys(element, Keys.Pause);
                        break;

                    case Key.Space:
                        actions.SendKeys(element, Keys.Space);
                        break;

                    case Key.PageUp:
                        actions.SendKeys(element, Keys.PageUp);
                        break;

                    case Key.PageDown:
                        actions.SendKeys(element, Keys.PageDown);
                        break;

                    case Key.End:
                        actions.SendKeys(element, Keys.End);
                        break;

                    case Key.Home:
                        actions.SendKeys(element, Keys.Home);
                        break;

                    case Key.Left:
                        actions.SendKeys(element, Keys.Left);
                        break;

                    case Key.ArrowLeft:
                        actions.SendKeys(element, Keys.ArrowLeft);
                        break;

                    case Key.Up:
                        actions.SendKeys(element, Keys.Up);
                        break;

                    case Key.ArrowUp:
                        actions.SendKeys(element, Keys.ArrowUp);
                        break;

                    case Key.Right:
                        actions.SendKeys(element, Keys.Right);
                        break;

                    case Key.ArrowRight:
                        actions.SendKeys(element, Keys.ArrowRight);
                        break;

                    case Key.Down:
                        actions.SendKeys(element, Keys.Down);
                        break;

                    case Key.ArrowDown:
                        actions.SendKeys(element, Keys.ArrowDown);
                        break;

                    case Key.Escape:
                        actions.SendKeys(element, Keys.Escape);
                        break;

                    case Key.Command:
                        actions.SendKeys(element, Keys.Command);
                        break;

                    default:
                        throw new NoSuitableKeyFoundException($"{key}'s  is not found! Please check method {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }

                #endregion Key Action

                actions.Build().Perform();

                if (keysTab)
                {
                    PressKeyUsingActionsClass(driver, Key.Tab);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press enter button on numpad.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressReturnKey(IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.PressReturnKey(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press enter button on numpad using Actions Class.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressReturnKeyUsingActionsClass(IWebDriver driver, IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false, bool keysTab = false)
        {
            try
            {
                PressKeyUsingActionsClassOnElement(driver, element, Key.Return, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press space on keyboard.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressSpaceKey(IWebElement element, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.PressSpaceKey(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press space on keyboard.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PressSpaceKeyUsingActionsClass(IWebDriver driver, IWebElement element, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                PressKeyUsingActionsClassOnElement(driver, element, Key.Space, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press tab button on keyboard.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        public static void PressTab(IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false)
        {
            try
            {
                WebElementMethodHelper.PressTabKey(element, clickTextboxBeforeEnteringValue, clearText);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - press tab on keyboard using actions class.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        public static void PressTabKeyUsingActionsClass(IWebDriver driver, IWebElement element, bool clickTextboxBeforeEnteringValue = false, bool clearText = false)
        {
            try
            {
                PressKeyUsingActionsClassOnElement(driver, element, Key.Tab, clickTextboxBeforeEnteringValue, clearText, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Keyboard Button Press

        #region Keyboard Actions

        /// <summary>
        /// Performs - Copy text from WebElement.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        public static void CopyTextToClipboard(IWebElement element, bool clickTextboxBeforeEnteringValue = false)
        {
            try
            {
                WebElementMethodHelper.CopyTextToClipboard(element, clickTextboxBeforeEnteringValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Copy text from WebElement using actions class implementation of sendkeys.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void CopyTextToClipboardUsingActionsClass(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);

                actions.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Ctrl+x from keyboard to Cut text from WebElement. Pre-selection of text is required.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        public static void CutText(IWebElement element)
        {
            try
            {
                WebElementMethodHelper.CutText(element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Cut text from WebElement using actions class implementation of sendkeys.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void CutTextUsingActionsClass(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);

                actions.KeyDown(Keys.Control).SendKeys("x").KeyUp(Keys.Control).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text in the given WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="text">Text to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterText(IWebElement element, string text, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(element, text, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters whole number in the given WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="number">Whole number to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterText(IWebElement element, long number, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(element, number, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters fractional number in the given WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="number">Fractional number to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterText(IWebElement element, double number, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.EnterText(element, number, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters text in the given WebElement.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="text">Text to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterTextUsingActionsClass(IWebDriver driver, IWebElement element, string text, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                if (clickTextboxBeforeEnteringValue)
                {
                    MouseHelper.ClickOnElement(driver, element);
                }

                if (clearText)
                {
                    //not using actions class here - as there is no method to clear - passing repeated backspace is not an option or select & delete
                    WebElementMethodHelper.Clear(element);
                }

                Actions actions = new Actions(driver);

                actions.SendKeys(text);

                actions.Build().Perform();

                if (keysTab)
                {
                    PressKeyUsingActionsClass(driver, Key.Tab);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters given whole number in the given WebElement.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="number">Number to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterTextUsingActionsClass(IWebDriver driver, IWebElement element, long number, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                EnterTextUsingActionsClass(driver, element, number.ToString(), clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enters given fractional number in the given WebElement.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="number">Number to be entered</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void EnterTextUsingActionsClass(IWebDriver driver, IWebElement element, double number, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                EnterTextUsingActionsClass(driver, element, number.ToString(), clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Performs keyboard control+v to Paste text to WebElement. Pre-requisite copied text is required.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void PasteText(IWebElement element, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.PasteText(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Paste text to WebElement using actions class implementation of sendkeys.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void PasteTextUsingActionsClass(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);

                actions.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - performs Ctrl+ y to Redo text in WebElement.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        public static void RedoText(IWebElement element, bool clickTextboxBeforeEnteringValue = true)
        {
            try
            {
                WebElementMethodHelper.RedoText(element, clickTextboxBeforeEnteringValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Redo text in WebElement using actions class implementation of sendkeys.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void RedoTextUsingActionsClass(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);

                actions.KeyDown(Keys.Control).SendKeys("y").KeyUp(Keys.Control).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - select all text from WebElement
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is false. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void SelectAllText(IWebElement element, bool clickTextboxBeforeEnteringValue = true, bool clearText = false, bool keysTab = false)
        {
            try
            {
                WebElementMethodHelper.SelectAllText(element, clickTextboxBeforeEnteringValue, clearText, keysTab);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - select all text from WebElement using actions class implementation of sendkeys.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void SelectAllTextUsingActionsClass(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);

                actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Undo text in WebElement.
        /// </summary>
        /// <param name="element">WebElement on which actions to be performed</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        public static void UndoText(IWebElement element, bool clickTextboxBeforeEnteringValue = true)
        {
            try
            {
                WebElementMethodHelper.UndoText(element, clickTextboxBeforeEnteringValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Performs - Undo text in WebElement using actions class implementation of sendkeys.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void UndoTextUsingActionsClass(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);

                actions.KeyDown(Keys.Control).SendKeys("z").KeyUp(Keys.Control).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Keyboard Actions
    }
}