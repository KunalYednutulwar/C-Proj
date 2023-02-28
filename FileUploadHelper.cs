using OpenQA.Selenium;
using System;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains method for uploading file
    /// </summary>
    public class FileUploadHelper
    {
        #region Methods

        /// <summary>
        /// Uploads file for button having Input tag.
        /// </summary>
        /// <param name="uploadButton">Browse button WebElement</param>
        /// <param name="inputFileNameTextbox">Textbox in which file path with name should be provided</param>
        /// <param name="fileNameWithExtensionAndFullPath">File name with extension and full path</param>
        /// <param name="clickTextboxBeforeEnteringValue">Click on input control</param>
        /// <param name="clearText">Default value is true. It will clear textbox before entering value when it is true Otherwise it will NOT clear text.</param>
        /// <param name="keysTab">Default value is false. If true it will tab after entering text.</param>
        public static void UploadFileWithoutBrowsing(IWebElement uploadButton, IWebElement inputFileNameTextbox, string fileNameWithExtensionAndFullPath, bool clickTextboxBeforeEnteringValue = true, bool clearText = true, bool keysTab = false)
        {
            try
            {
                KeyboardHelper.EnterText(inputFileNameTextbox, fileNameWithExtensionAndFullPath, clickTextboxBeforeEnteringValue, clearText, keysTab);
                UIControlHelper.Click(uploadButton);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}