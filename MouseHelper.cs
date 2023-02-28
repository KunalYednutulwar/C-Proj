using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains all mouse related helper methods - actions are performed using actions class implementation
    /// </summary>
    public class MouseHelper
    {
        #region Click Helpers

        /// <summary>
        /// Clicks where mouse is pointing to.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void Click(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.Click().Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks and holds where mouse is pointing to.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void ClickAndHold(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.ClickAndHold().Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks and holds on the WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void ClickAndHoldOnElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.ClickAndHold(element).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Clicks on the WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void ClickOnElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.Click(element).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right Clicks where mouse is pointing to.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void ContextClick(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.ContextClick().Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right Clicks on the WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void ContextClickOnElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.ContextClick(element).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Right Clicks on the WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void RightClickOnElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                ContextClickOnElement(driver, element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double Clicks where mouse is pointing to.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void DoubleClick(IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.DoubleClick().Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Double Clicks on the WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void DoubleClickOnElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.DoubleClick(element).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Click Helpers

        #region Drag & Drop Helpers

        /// <summary>
        /// This drags an element and drops it to a destination
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement to be dragged</param>
        /// <param name="targetElement">Location to drop the element</param>
        public static void DragAndDropElement(IWebDriver driver, IWebElement element, IWebElement targetElement)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.DragAndDrop(element, targetElement).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This drags an element and drops it to a destination elements x and y co-ordinates
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement to be dragged</param>
        /// <param name="targetElement">Location to drop the element</param>
        public static void DragAndDropElementToOffSetOfTargetElement(IWebDriver driver, IWebElement element, IWebElement targetElement)
        {
            try
            {
                Actions actions = new Actions(driver);
                int xOffSet = targetElement.Location.X;
                int yOffSet = targetElement.Location.Y;
                actions.DragAndDropToOffset(element, xOffSet, yOffSet).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This drags an element and drops it to given offset
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="element">WebElement to be dragged</param>
        /// <param name="xOffSet">x coordinate</param>
        /// <param name="yOffSet">y coordinate</param>
        public static void DragAndDropElementToXYCoordinates(IWebDriver driver, IWebElement element, int xOffSet, int yOffSet)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.DragAndDropToOffset(element, xOffSet, yOffSet).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Drag & Drop Helpers

        #region Hover, Move, Scroll Helpers

        /// <summary>
        /// Hovers over the WebElement.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void HoverOverElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                MoveToElement(driver, element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method moves the mouse to the center of the element
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void MoveToElement(IWebDriver driver, IWebElement element)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method moves the mouse to the x,y coordinate of the element
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void MoveToElementOffSet(IWebDriver driver, IWebElement element, int xOffSet, int yOffSet)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(element, xOffSet, yOffSet).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method moves the mouse from its current position (or 0,0) by the given offset.
        /// If the coordinates are outside the view window, then the mouse will end up outside the view window.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="xOffSet">x coordinate value</param>
        /// <param name="yOffSet">y coordinate value</param>
        public static void ScrollByOffSet(IWebDriver driver, int xOffSet, int yOffSet)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveByOffset(xOffSet, yOffSet).Build().Perform();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method brings element into view.
        /// </summary>
        /// <param name="element">Instance of IWebElement - Depicting an UI control</param>
        /// <param name="driver">Instance of IWebDriver</param>
        public static void ScrollElementToView(IWebDriver driver, IWebElement element)
        {
            try
            {
                MoveToElement(driver, element);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Hover, Move, Scroll Helpers
    }
}