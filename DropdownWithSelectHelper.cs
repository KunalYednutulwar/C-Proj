using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on dropdown having html select tag <select>
    /// </summary>
    public class DropdownWithSelectHelper
    {
        #region Select Operations

        /// <summary>
        /// Selects dropdown item by its Index.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <param name="indexToBeSelected">Index of item to be selected</param>
        public static void SelectByIndex(IWebElement dropDownElement, int indexToBeSelected)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.SelectByIndex(indexToBeSelected);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Selects dropdown item by its value.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <param name="valueToBeSelected">Value of item to be selected</param>
        public static void SelectByValue(IWebElement dropDownElement, string valueToBeSelected)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.SelectByValue(valueToBeSelected);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Selects dropdown item by its visible text.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <param name="textToBeSelected">Text value of item to be selected</param>
        /// <param name="partialMatch">Default value is false. If true it will select item with partial text</param>
        public static void SelectByVisibleText(IWebElement dropDownElement, string textToBeSelected, bool partialMatch = false)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.SelectByText(textToBeSelected, partialMatch);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Select Operations

        #region Deselect Operations

        /// <summary>
        /// Deselects all selected dropdown options.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        public static void DeselectAllOptions(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.DeselectAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deselects dropdown item by its Index.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <param name="indexToBeDeselected">Index of item to be deselected</param>
        public static void DeselectByIndex(IWebElement dropDownElement, int indexToBeDeselected)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.DeselectByIndex(indexToBeDeselected);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deselects dropdown item by its value.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <param name="valueToBeDeselected">Value of item to be deselected</param>
        public static void DeselectByValue(IWebElement dropDownElement, string valueToBeDeselected)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.DeselectByValue(valueToBeDeselected);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deselects dropdown item by its visible text.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <param name="textToBeDeselected">Text value of item to be deselected</param>
        public static void DeselectByVisibleText(IWebElement dropDownElement, string textToBeDeselected)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                dropdown.DeselectByText(textToBeDeselected);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Deselect Operations

        #region Methods

        /// <summary>
        /// Returns all available options in dropdown.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>List of all available options in dropdown</returns>
        public static IList<string> GetAllOptions(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                IList<IWebElement> optionList = dropdown.Options;
                IList<string> optionValueList = new List<string>();
                foreach (IWebElement dropdownItem in optionList)
                {
                    optionValueList.Add(WebElementPropertyHelper.GetText(dropdownItem));
                }

                return optionValueList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns all selected options in dropdown.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>List of all selected options in dropdown</returns>
        public static IList<string> GetAllSelectedOptions(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                IList<IWebElement> selectedItemList = dropdown.AllSelectedOptions;
                IList<string> selectedItemValueList = new List<string>();
                foreach (IWebElement selectedItem in selectedItemList)
                {
                    selectedItemValueList.Add(WebElementPropertyHelper.GetText(selectedItem));
                }
                return selectedItemValueList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns total count of all available options in dropdown.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>Total count of all available options in dropdown</returns>
        public static int GetCountOfAllOptions(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                IList<IWebElement> optionList = dropdown.Options;
                int totalOptions = optionList.Count;
                return totalOptions;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns total count of all selected options in dropdown.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>Total count of all selected options in dropdown</returns>
        public static int GetCountOfAllSelectedOptions(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                IList<IWebElement> selectedItemList = dropdown.AllSelectedOptions;
                int totalSelectedOptions = selectedItemList.Count;
                return totalSelectedOptions;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns selected option in dropdown.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>Selected option in dropdown</returns>
        public static string GetSelectedOption(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                IWebElement selectedOption = dropdown.SelectedOption;
                string selectedOptionValue = WebElementPropertyHelper.GetText(selectedOption);
                return selectedOptionValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the IWebElement wrapped by this object.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>Wrapped object of WebElement</returns>
        public static IWebElement GetWrappedElement(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                IWebElement wrappedElement = dropdown.WrappedElement;
                return wrappedElement;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if multiple selection available for dropdown.
        /// </summary>
        /// <param name="dropDownElement">Dropdown WebElement</param>
        /// <returns>True if multiple selection is available otherwise returns false</returns>
        public static bool IsMultipleSelectionAvailable(IWebElement dropDownElement)
        {
            try
            {
                SelectElement dropdown = new SelectElement(dropDownElement);
                bool isMultiple = dropdown.IsMultiple;
                return isMultiple;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}