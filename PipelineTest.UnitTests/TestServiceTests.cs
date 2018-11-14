using Xunit;

namespace PipelineTest.UnitTests
{
    public class TestServiceTests
    {
        [Fact]
        public void StartServiceTest()
        {
            var sut = new TestService();
            Assert.False(sut.IsRunning);

            sut.Start();
            Assert.True(sut.IsRunning);
            Assert.False(sut.IsRunning);
        }

        [Fact]
        public void StopServiceTest()
        {
            var sut = new TestService();
            sut.Start();
            Assert.True(sut.IsRunning);

            sut.Stop();
            Assert.False(sut.IsRunning);
        }
    }
}
