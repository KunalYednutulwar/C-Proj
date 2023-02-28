using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains methods for performing various operations on dropdown without having select tag
    /// </summary>
    public class DropDownWithoutSelectHelper
    {
        #region Methods

        /// <summary>
        /// Returns list of all available options in dropdown.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dropDownElement">Dropdown WebElement expand button</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <returns>list of all available options</returns>
        public static IList<string> GetAllOptions(IWebDriver driver, IWebElement dropDownElement, Func<string, By> seleniumLocatorName, string seleniumLocatorValue)
        {
            try
            {
                // Expand dropdown options
                ButtonHelper.Click(dropDownElement);

                // Get webElement list of all dropdown options.
                IList<WebElement> allOptionsElement = (IList<WebElement>)FindElementHelper.FindAllElements(driver, seleniumLocatorName, seleniumLocatorValue);
                IList<string> allOptionsList = new List<string>();

                // Iterate through dropdown option list and add all available options from dropdown one at a time.
                foreach (WebElement dropdownOption in allOptionsElement)
                {
                    allOptionsList.Add(WebElementPropertyHelper.GetText(dropdownOption));
                }
                return allOptionsList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns list of all selected options in dropdown.
        /// If dropdown has only one item selected then it will return list of one item.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dropDownElement">Dropdown WebElement expand button</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <returns>list of all selected options</returns>
        public static IList<string> GetAllSelectedOptions(IWebDriver driver, IWebElement dropDownElement, Func<string, By> seleniumLocatorName, string seleniumLocatorValue)
        {
            try
            {
                // Expand dropdown options
                ButtonHelper.Click(dropDownElement);

                // Get webElement list of all dropdown options.
                IList<WebElement> allOptionsElement = (IList<WebElement>)FindElementHelper.FindAllElements(driver, seleniumLocatorName, seleniumLocatorValue);
                IList<string> allSelectedOptionsList = new List<string>();

                // Iterate through dropdown option list and add all selected options from dropdown one at a time.
                foreach (WebElement dropdownOption in allOptionsElement)
                {
                    if (WebElementPropertyHelper.IsSelected(dropdownOption))
                    {
                        allSelectedOptionsList.Add(WebElementPropertyHelper.GetText(dropdownOption));
                    }
                }
                return allSelectedOptionsList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns total count of all available options in dropdown.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dropDownElement">Dropdown WebElement expand button</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <returns>Total count of all available options in dropdown</returns>
        public static int GetCountOfAllOptions(IWebDriver driver, IWebElement dropDownElement, Func<string, By> seleniumLocatorName, string seleniumLocatorValue)
        {
            try
            {
                // Expand dropdown options
                ButtonHelper.Click(dropDownElement);

                // Get webElement list of all dropdown options.
                IList<WebElement> allOptionsElement = (IList<WebElement>)FindElementHelper.FindAllElements(driver, seleniumLocatorName, seleniumLocatorValue);

                int totalOptions = allOptionsElement.Count;
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
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dropDownElement">Dropdown WebElement expand button</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <returns>Total count of all selected options in dropdown</returns>
        public static int GetCountOfAllSelectedOptions(IWebDriver driver, IWebElement dropDownElement, Func<string, By> seleniumLocatorName, string seleniumLocatorValue)
        {
            try
            {
                // Expand dropdown options
                ButtonHelper.Click(dropDownElement);

                // Get webElement list of all dropdown options.
                IList<WebElement> allOptionsElement = (IList<WebElement>)FindElementHelper.FindAllElements(driver, seleniumLocatorName, seleniumLocatorValue);

                int totalSelectedOptions = 0;

                // Iterate through dropdown option list and add all selected options from dropdown one at a time.
                foreach (WebElement dropdownOption in allOptionsElement)
                {
                    if (WebElementPropertyHelper.IsSelected(dropdownOption))
                    {
                        totalSelectedOptions++;
                    }
                }
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
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dropDownElement">Dropdown WebElement expand button</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <returns>Selected option</returns>
        public static string GetSelectedOption(IWebDriver driver, IWebElement dropDownElement, Func<string, By> seleniumLocatorName, string seleniumLocatorValue)
        {
            try
            {
                // Expand dropdown options
                ButtonHelper.Click(dropDownElement);

                // Get webElement list of all dropdown options.
                IList<WebElement> allOptionsElement = (IList<WebElement>)FindElementHelper.FindAllElements(driver, seleniumLocatorName, seleniumLocatorValue);

                string selectedOption = "";

                // Iterate through dropdown option list and add all selected options from dropdown one at a time.
                foreach (WebElement dropdownOption in allOptionsElement)
                {
                    if (WebElementPropertyHelper.IsSelected(dropdownOption))
                    {
                        selectedOption = WebElementPropertyHelper.GetText(dropdownOption);
                        break;
                    }
                }
                return selectedOption;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Selects dropdown item from dropdown by expanding dropdown.
        /// </summary>
        /// <param name="driver">Instance of IWebDriver</param>
        /// <param name="dropDownElement">Dropdown WebElement expand button</param>
        /// <param name="seleniumLocatorName">Selenium By type i.e. xpath, id, etc</param>
        /// <param name="seleniumLocatorValue">identifier value against which user needs to find element</param>
        /// <param name="optionToBeSelected">dropdown item to be selected</param>
        /// <param name="partialMatch">Default value is false. If true it will select item with partial text</param>
        public static void SelectDropdownItem(IWebDriver driver, IWebElement dropDownElement, Func<string, By> seleniumLocatorName, string seleniumLocatorValue, string optionToBeSelected, bool partialMatch = true)
        {
            try
            {
                // Expand dropdown options
                ButtonHelper.Click(dropDownElement);

                // Get webElement list of all dropdown options.
                IList<WebElement> allOptionsElement = (IList<WebElement>)FindElementHelper.FindAllElements(driver, seleniumLocatorName, seleniumLocatorValue);

                // Iterate through dropdown option list and select desired option from dropdown.
                foreach (IWebElement dropdownItem in allOptionsElement)
                {
                    if (partialMatch)
                    {
                        if (optionToBeSelected.Equals(WebElementPropertyHelper.GetText(dropdownItem)))
                        {
                            dropdownItem.Click();
                            break;
                        }
                    }
                    else
                    {
                        if (optionToBeSelected.Contains(WebElementPropertyHelper.GetText(dropdownItem)))
                        {
                            dropdownItem.Click();
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}