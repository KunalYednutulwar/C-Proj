using System;

namespace UISeleniumHelperLibrary.CustomExceptions
{
    /// <summary>
    /// Custom exception to represent no suitable keyboard key found
    /// </summary>
    internal class NoSuitableKeyFoundException : Exception
    {
        internal NoSuitableKeyFoundException(string message) : base(message)
        {
        }
    }
}