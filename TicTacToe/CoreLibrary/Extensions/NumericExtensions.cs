//Ethan Smith

using System;

namespace CoreLibrary
{
    public static class NumericExtensions
    {
        public static int ToInt(this object content, int defaultValue = 0)
        {
            try
            {
                int intResult;
                if (int.TryParse(content.ToString(), out intResult)) return intResult;

                double dblResult;
                return (double.TryParse(content.ToString(), out dblResult))
                    ? Convert.ToInt32(dblResult)
                    : defaultValue;
            }
            catch (Exception e)
            {
                return defaultValue;
            }
        }
    }
}