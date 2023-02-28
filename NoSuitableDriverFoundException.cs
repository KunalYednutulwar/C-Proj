using System;

namespace UISeleniumHelperLibrary.CustomExceptions
{
    /// <summary>
    /// Custom exception to represent no suitable driver found
    /// </summary>
    internal class NoSuitableDriverFoundException : Exception
    {
        internal NoSuitableDriverFoundException(string message) : base(message)
        {
        }
    }
}