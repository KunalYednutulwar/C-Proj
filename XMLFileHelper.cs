using System.IO;

namespace APIHelperLibrary
{
    public class XMLFileHelper
    {
        #region ReadXMLAsAString

        /// <summary>
        /// This method reads XML file and returns the content in string form
        /// </summary>
        /// <param name="xmlFilepath">Path where XML file is kept</param>
        /// <returns>XML read as string from XML file</returns>
        public string ReadXMLAsAString(string xmlFilepath)
        {
            try
            {
                string xml = string.Empty;
                using (StreamReader r = new StreamReader(xmlFilepath))
                {
                    xml = r.ReadToEnd();
                }

                return xml;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion ReadXMLAsAString

        #region ConvertXMLToObject

        /// <summary>
        /// This method returns XMl file and returns it as an object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="xmlFilepath">XML file path</param>
        /// <returns>Generic Object(POCO Class) which is passed as T</returns>
        public T ConvertXMLToObject<T>(string xmlFilepath)
        {
            try
            {
                T deserilisedObj;
                DeserializerHelper deserializerHelper = new DeserializerHelper();
                using (var stream = new FileStream(xmlFilepath, FileMode.Open))
                {
                    deserilisedObj = deserializerHelper.DeserializeXMLToObject<T>(stream);
                }
                return deserilisedObj;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion ConvertXMLToObject
    }
}