using System;
using TestSettings.Configurations;

namespace TestSettings
{
    public class TestSetting : AppConfigReader
    {
        #region Constructor

        public TestSetting()
        {
            Launch();
        }

        #endregion Constructor

        #region Fields

        private string url;
        private string userName;
        private string noRightUserName;
        private string password;
        private string clientAPIBaseUrl;
        private string scClientAPIBaseUrl;
        private string serverAPIBaseUrl;
        private string reportPath;
        private string reportTheme;
        private string tokenAuthenticationEndPoint;
        private string requestTestDataPath;
        private string responseTestDataPath;
        private long maxAcceptableResponseTime;
        private string prefixForDataCreation;
        private string logTypeIfResponseTimeExceed;
        private string serverName;
        private string protocolVersion;
        private string contentEncoding;

        #endregion Fields

        #region Properties

        public string ClientAPIBaseUrl { get => clientAPIBaseUrl; }
        public string Url { get => url; }

        public string UserName { get => userName; }
        public string NoRightUserName { get => noRightUserName; }

        public string Password { get => password; }
        public string TokenAuthenticationEndPoint { get => tokenAuthenticationEndPoint; }

        public string SCClientAPIBaseUrl { get => scClientAPIBaseUrl; }
        public string ServerAPIBaseUrl { get => serverAPIBaseUrl; }

        public string ReportPath { get => reportPath; }

        public string ReportTheme { get => reportTheme; }

        public string ResponseTestDataPath { get => responseTestDataPath; }

        public string RequestTestDataPath { get => requestTestDataPath; }

        public long MaxAcceptableResponseTime { get => maxAcceptableResponseTime; }

        public string PrefixForDataCreation { get => prefixForDataCreation; }

        public string LogTypeIfResponseTimeExceed { get => logTypeIfResponseTimeExceed; }

        public string ServerName { get => serverName; }

        public string ProtocolVersion { get => protocolVersion; }

        public string ContentEncoding { get => contentEncoding; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Method to Initialise the Property Fields Values. These Property Fields are used to fetch values from Config File.
        /// </summary>
        public void Launch()
        {
            try
            {
                clientAPIBaseUrl = GetClientAPIBaseUrl();
                url = GetUrl();
                userName = GetUserName();
                noRightUserName = GetNoRightUserName();
                password = GetPassword();
                tokenAuthenticationEndPoint = GetTokenAuthenticationEndPoint();
                scClientAPIBaseUrl = GetSCClientAPIBaseUrl();
                serverAPIBaseUrl = GetSCClientAPIBaseUrl();
                reportPath = GetReportPath();
                reportTheme = GetReportTheme();
                responseTestDataPath = GetResponseTestDataPath();
                requestTestDataPath = GetRequestTestDataPath();
                maxAcceptableResponseTime = GetExpectedResponseTime();
                prefixForDataCreation = GetPrefixForDataCreation();
                logTypeIfResponseTimeExceed = GetLogTypeIfResponseTimeExceed();
                serverName = GetServerName();
                protocolVersion = GetProtocolVersion();
                contentEncoding = GetContentEncoding();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Methods
    }
}