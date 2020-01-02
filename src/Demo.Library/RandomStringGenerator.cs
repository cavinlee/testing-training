using System;

namespace Demo.Library
{
    public interface IRandomStringGenerator
    {
        string GenerateRandomString();
    }

    // Class name is exactly what it is instead of just calling it Generator that too generic.
    public class RandomStringGenerator : IRandomStringGenerator
    {
        // use protected instead of private unless proven need to be private.
        protected readonly RandomStringGeneratorOptions Options;
        protected readonly ILogger Logger;

        // Requirement to instantiate the generator are specified in the constructor parameter. 
        public RandomStringGenerator(RandomStringGeneratorOptions options, ILogger logger)
        {
            Options = options;
            Logger = logger;
        }

        // function name describe what it does
        public string GenerateRandomString()
        {
            var random = $"{Guid.NewGuid():N}";

            // refer to the options passed in when instantiate instead of static value. 
            if (Options.IsAllUppercase)
            {
                random = random.ToUpper();
            }
            else
            {
                random = random.ToLower();
            }

            return random;
        }
    }

    public class RandomStringGeneratorOptions
    {
        public virtual bool IsAllUppercase { get; set; }
    }
}
