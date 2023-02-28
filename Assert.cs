namespace LoggerLibrary
{
    public class Assert
    {
        #region Methods

        #region AreEqual

        /// <summary>
        /// Verifies the expected and actual data passed are equal or not
        /// </summary>
        /// <param name="expectedData">expected data</param>
        /// <param name="actualData">actual data</param>
        /// <param name="messageToDisplay">message to display post action</param>
        public static void AreEqual(object expectedData, object actualData, string messageToDisplay)
        {
            if (expectedData.Equals(actualData))
            {
                Log.Pass(expectedData, actualData, "[Assert] - " + messageToDisplay + " It Passed!");
            }
            else
            {
                Log.Fail(expectedData, actualData, "[Assert] - " + messageToDisplay + " It Failed!");
            }
        }

        #endregion AreEqual

        #region IsTrue

        /// <summary>
        /// Verifies condition and prints message
        /// </summary>
        /// <param name="condition">condition which returns bool</param>
        /// <param name="messageToDisplay">message to display</param>
        public static void IsTrue(bool condition, string messageToDisplay)
        {
            if (condition)
            {
                Log.Pass("[Assert] - " + messageToDisplay + " It Passed!");
            }
            else
            {
                Log.Fail("[Assert] - " + messageToDisplay + " It Failed!");
            }
        }

        #endregion IsTrue

        #region IsFalse

        /// <summary>
        /// Verifies condition and negates it and prints message
        /// </summary>
        /// <param name="condition">condition which returns bool</param>
        /// <param name="messageToDisplay">message to display</param>
        public static void IsFalse(bool condition, string messageToDisplay)
        {
            if (!condition)
            {
                Log.Pass("[Assert] - " + messageToDisplay + " It Passed!");
            }
            else
            {
                Log.Fail("[Assert] - " + messageToDisplay + " It Failed!");
            }
        }

        #endregion IsFalse

        #endregion Methods
    }
}