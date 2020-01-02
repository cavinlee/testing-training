using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;

namespace Demo.Library.Tests
{
    public class RandomStringGeneratorTests
    {
        [Fact]
        public void Can_Generate_Random_String()
        {
            var randomStringGeneratorOptions = new RandomStringGeneratorOptions();
            var consoleLogger = new ConsoleLogger();
            var randomStringGenerator = new RandomStringGenerator(randomStringGeneratorOptions, consoleLogger);

            var randomString = randomStringGenerator.GenerateRandomString();
            randomString.ShouldNotBeNullOrWhiteSpace();
        }

        [Fact]
        public void Can_Configure_To_Generate_Uppercased_Random_String()
        {
            var randomStringGeneratorOptions = new RandomStringGeneratorOptions
            {
                IsAllUppercase = true
            };
            var consoleLogger = new ConsoleLogger();
            var randomStringGenerator = new RandomStringGenerator(randomStringGeneratorOptions, consoleLogger);

            var randomString = randomStringGenerator.GenerateRandomString();
            randomString.ShouldNotBeNullOrWhiteSpace();

            randomString.ToUpper().ShouldBe(randomString);
            randomString.ToLower().ShouldNotBe(randomString);
        }
    }
}
