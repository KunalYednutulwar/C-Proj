using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using TestSettings.Settings;

namespace TestSettings.Configurations
{
    public class AppConfigReader
    {
        #region Fields

        private IConfiguration config;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method to fetch the environment section
        /// </summary>
        /// <returns>The environment section</returns>
        public string FetchEnvironmentSection()
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @$"\ConfigFiles\{AppConfigKeys.AppConfigFileName}";
                config = new ConfigurationBuilder().AddJsonFile(path).Build();
                string environmentSection = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.Environment);
                return environmentSection;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Fetch the Password of the Specified Environment
        /// </summary>
        /// <returns>password</returns>
        public string GetPassword()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string password = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.Password);

                return password;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Fetch the Token Authentication End Point of the Specified Environment
        /// </summary>
        /// <returns>password</returns>
        public string GetTokenAuthenticationEndPoint()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string tokenAuthenticationEndPoint = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.TokenAuthenticationEndPoint);

                return tokenAuthenticationEndPoint;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the Report Path from appSettings.json
        /// </summary>
        /// <returns>reportPath</returns>
        public string GetReportPath()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string reportPath = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.ReportPath);

                return reportPath;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the Report Theme from appSettings.json
        /// </summary>
        /// <returns>reportTheme</returns>
        public string GetReportTheme()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string reportTheme = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.ReportTheme);

                return reportTheme;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the URl of a ClientAPI BaseUrl
        /// </summary>
        /// <returns>url</returns>
        public string GetClientAPIBaseUrl()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string url = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.ClientAPIBaseUrl);

                return url;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the URl of a Specified Environment
        /// </summary>
        /// <returns>url</returns>
        public string GetUrl()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string url = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.Url);

                return url;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the UserName of a Specified Environment
        /// </summary>
        /// <returns>username</returns>
        public string GetUserName()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string username = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.UserName);

                return username;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the No Rigth UserName of a Specified Environment
        /// </summary>
        /// <returns>username</returns>
        public string GetNoRightUserName()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string username = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.NoRightUserName);

                return username;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the URl of a SCClientAPI BaseUrl
        /// </summary>
        /// <returns>url</returns>
        public string GetSCClientAPIBaseUrl()
        {
            try
            {
                string environmentSection = FetchEnvironmentSection();
                string url = config.GetRequiredSection(environmentSection).GetValue<string>(AppConfigKeys.SCClientAPIBaseUrl);

                return url;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the Response Test Data Path
        /// </summary>
        /// <returns>responseTestDataPath</returns>
        ///
        public string GetResponseTestDataPath()
        {
            try
            {
                string responseTestDataPath = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.ResponseTestDataPath);

                return responseTestDataPath;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the Request Test Data Path
        /// </summary>
        /// <returns>requestTestDataPath</returns>
        ///
        public string GetRequestTestDataPath()
        {
            try
            {
                string requestTestDataPath = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.RequestTestDataPath);

                return requestTestDataPath;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the expected Response Time
        /// </summary>
        /// <returns>requestTestDataPath</returns>
        ///
        public long GetExpectedResponseTime()
        {
            try
            {
                long responseTime = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<long>(AppConfigKeys.MaxAcceptableResponseTime);

                return responseTime;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get prefix for Data Creation
        /// </summary>
        /// <returns>PrefexforDataCreation</returns>
        public string GetPrefixForDataCreation()
        {
            try
            {
                string prefixForDataCreation = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.PrefixForDataCreation);

                return prefixForDataCreation;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get log type to write Response time log
        /// </summary>
        /// <returns>LogType</returns>
        public string GetLogTypeIfResponseTimeExceed()
        {
            try
            {
                string logTypeIfResponseTimeExceed = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.LogTypeIfResponseTimeExceed);

                return logTypeIfResponseTimeExceed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the server name
        /// </summary>
        /// <returns>serverName</returns>
        public string GetServerName()
        {
            try
            {
                string serverName = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.ServerName);

                return serverName;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
		/// Method to get the server name
		/// </summary>
		/// <returns>serverName</returns>
		public string GetProtocolVersion()
        {
            try
            {
                string protocolVersion = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.ProtocolVersion);

                return protocolVersion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get the content encoding
        /// </summary>
        /// <returns>serverName</returns>
        public string GetContentEncoding()
        {
            try
            {
                string ContentEncoding = config.GetSection(AppConfigKeys.Generic_Settings).GetValue<string>(AppConfigKeys.ContentEncoding);

                return ContentEncoding;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}