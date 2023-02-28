using OpenQA.Selenium;
using System;
using System.IO;

namespace UISeleniumHelperLibrary
{
    /// <summary>
    /// Contains generic method for downloading file
    /// </summary>
    public class FileDownloadHelper
    {
        #region Method

        /// <summary>
        /// Downloads file from browser.
        /// </summary>
        /// <param name="downloadButton">Download button WebElement</param>
        /// <param name="downloadFolderPath">Download folder path</param>
        /// <param name="fileNameWithExtension">File name to be downloaded</param>
        public static void DownloadFile(IWebElement downloadButton, string downloadFolderPath, string fileNameWithExtension)
        {
            try
            {
                if (Directory.Exists(downloadFolderPath))
                {
                    string downloadFilePath = downloadFolderPath + @"\" + fileNameWithExtension;
                    bool isFilePresent = File.Exists(downloadFilePath);
                    if (isFilePresent)
                    {
                        File.Delete(downloadFilePath);
                    }
                }
                else
                {
                    DirectoryInfo dinfo = new DirectoryInfo(downloadFolderPath);
                    dinfo.Create();
                }
                ButtonHelper.Click(downloadButton);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Method
    }
}