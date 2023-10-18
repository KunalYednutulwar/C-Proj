using LoggerLibrary;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace TeamNameAPITestScripts
{
    internal class HandleScenarioContext
    {
        #region Methods for Scenario Context

        /// <summary>
        /// This method is used to Add or Update ScenarioContext values
        /// </summary>
        /// <param name="_scenarioContext">ScenarioContext Type - _scenarioContext</param>
        /// <param name="key">string value - key</param>
        /// <param name="value">dynamic - value</param>
        public static void AddOrUpdateScenarioContextValues(ScenarioContext _scenarioContext, string key, dynamic value)
        {
            try
            {
                if (_scenarioContext.TryGetValue(key, out dynamic val))
                {
                    //Value exists!
                    _scenarioContext[key] = value;
                }
                else
                {
                    //Add value
                    _scenarioContext.Add(key, value);
                }
            }
            catch (Exception ex)
            {
                Log.Fail($"Failed Method - {MethodBase.GetCurrentMethod()?.Name} | Exception Message - {ex.Message}");
                throw;
            }
        }

        #endregion Methods for Scenario Context
    }
}