using Shouldly;
using Xunit;

namespace Demo.Library.Tests
{
    public class UntestableCodeTests
    {
        [Fact]
        public void Should_Get_Morning_When_It_Is_9AM()
        {
            var time = Util.GetTimeOfDay();
            // time.ShouldBe("Morning");s
        }

        [Fact]
        public void Should_Get_Afternoon_When_It_Is_12AM()
        {
            var time = Util.GetTimeOfDay();
            // time.ShouldBe("Morning");s
        }
    }
}