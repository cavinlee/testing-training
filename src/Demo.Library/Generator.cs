using System;
using System.Text;

namespace Demo.Library
{
    public interface IGenerator
    {
        string Generate();
    }

    public class Generator : IGenerator
    {
        protected readonly ILogger Logger = new DatabaseLogger();

        public string Generate()
        {
            var random = $"{Guid.NewGuid():N}";

            if (GeneratorOptions.IsAllUppercase)
            {
                random = random.ToUpper();
            }
            else
            {
                random = random.ToLower();
            }

            Logger.Log(random);

            return random;
        }
    }

    public class GeneratorOptions
    {
        public static bool IsAllUppercase => bool.Parse(ConfigurationManager.AppSettings["IsAllUppercase"]);
    }
}
