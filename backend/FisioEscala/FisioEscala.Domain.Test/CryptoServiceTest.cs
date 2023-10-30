using FisioEscala.Domain.Services;

namespace FisioEscala.Domain.Test
{
    public class CryptoServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase("password", "drowssap")]
        [TestCase("", "")]
        public void CryptoReverseTest(string key, string expected)
        {
            string reversed = CryptoService.Reverse(key);
            Assert.AreEqual(expected, reversed);
        }
    }
}
