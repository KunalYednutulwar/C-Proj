using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.Xml;
using System;
using System.IO;
using System.Xml.Serialization;

namespace APIHelperLibrary
{
    public class DeserializerHelper
    {
        #region JSON_Deserializer

        /// <summary>
        ///  This method will deserialize JSON string to Generic Object
        /// </summary>
        /// <typeparam name="T">Generic object - Accepts POCO class</typeparam>
        /// <param name="jsonString">JSON as string, to be deserialized into object</param>
        /// <returns>Generic Object(POCO Class) which is passed as T</returns>
        public T DeserializeJSONToObject<T>(string jsonString)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion JSON_Deserializer

        #region XML_Deserializer

        /// <summary>
        /// This method will deserialize XML RestResponse to Generic Object
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <param name="restResponse">RestResponse</param>
        /// <returns>Generic Object(POCO Class) which is passed as T</returns>
        public T DeserializeXMLToObject<T>(RestResponse restResponse)
        {
            try
            {
                DotNetXmlDeserializer serializer = new DotNetXmlDeserializer();
                var value = serializer.Deserialize<T>(restResponse);

                return value;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  This method will deserialize XML string  to Generic Object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="xmlFileStream">xmlFileStream</param>
        /// <returns>Generic Object(POCO Class) which is passed as T</returns>
        public T DeserializeXMLToObject<T>(FileStream xmlFileStream)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(xmlFileStream);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion XML_Deserializer
    }
}