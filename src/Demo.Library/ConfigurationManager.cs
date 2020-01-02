using System.Collections.Generic;

namespace Demo.Library
{
    // fake ConfigurationManager
    public class ConfigurationManager
    {
        public static Dictionary<string, string> AppSettings = new Dictionary<string, string>
            {{"IsAllUppercase", "true"}};
    }
}