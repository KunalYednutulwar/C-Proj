using System;
using System.IO;
using System.Text;

namespace APIHelperLibrary
{
    public class JSONFileHelper
    {
        #region ReadJSONAsAString

        /// <summary>
        /// This method reads JSON file and returns the content in string form
        /// </summary>
        /// <param name="jsonFilepath">Path where JSON file is kept</param>
        /// <returns>JSON read from file as string</returns>
        public string ReadJSONAsAString(string jsonFilepath)
        {
            try
            {
                string json = string.Empty;
                using (StreamReader r = new StreamReader(jsonFilepath))
                {
                    json = r.ReadToEnd();
                }

                return json;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion ReadJSONAsAString

        #region ReadJSONAsAStringWithEncoding

        /// <summary>
        ///  This method reads JSON file with enconding type and returns the content in string form
        /// </summary>
        /// <param name="jsonFilepath">Path where JSON file is kept</param>
        /// <param name="encodingType">Encoding Type of JSON text</param>
        /// <returns>JSON read from file as string</returns>
        public string ReadJSONAsAString(string jsonFilepath, string encodingType)
        {
            try
            {
                string json = string.Empty;
                using (StreamReader r = new StreamReader(jsonFilepath, Encoding.GetEncoding(encodingType)))
                {
                    json = r.ReadToEnd();
                }

                return json;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion ReadJSONAsAStringWithEncoding

        #region ConvertJSONToObject

        /// <summary>
        /// This method reads JSON file and returns it as an object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="jsonFilepath">JSON file path</param>
        /// <returns>Generic Object(POCO Class) which is passed as T</returns>
        public T ConvertJSONToObject<T>(string jsonFilepath)
        {
            try
            {
                string json = string.Empty;
                DeserializerHelper deserializerHelper = new DeserializerHelper();

                using (StreamReader r = new StreamReader(jsonFilepath))
                {
                    json = r.ReadToEnd();
                }
                T deserilisedObj = deserializerHelper.DeserializeJSONToObject<T>(json);

                return deserilisedObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion ConvertJSONToObject
    }
}