//Ethan Smith

using System;
using System.Diagnostics;

namespace CoreLibrary
{
    public static class BooleanExtensions
    {
        public static bool ToBool(this object content, bool defaultValue)
        {
            try
            {
                bool boolResult;

                var conversionSuccessful = (bool.TryParse(content.ToString(), out boolResult));

                return conversionSuccessful ? boolResult : defaultValue;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return defaultValue;
            }
        }
    }
}