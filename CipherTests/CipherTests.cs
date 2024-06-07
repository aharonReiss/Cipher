using Cipher;
using System;
using System.Threading.Channels;
using Xunit;

namespace CipherTests
{
    public class CipherTests
    {
        private const string Key = "BCDEFGHIJKLMNOPQRSTUVWXYZA";

        [Theory]
        [InlineData("AaA", "BbB")]
        [InlineData("ZzZ", "AaA")]
        [InlineData("CiPhEr", "DjQiFs")]
        public static void EncryptionTest(string message, string expected)
        {
            ICodeValueCipher cipher = new CodeValueCipher();
            var result = cipher.Encrypt(message, Key);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("BbB", "AaA")]
        [InlineData("AaA", "ZzZ")]
        [InlineData("DjQiFs", "CiPhEr")]
        public static void DecryptionTest(string message, string expected)
        {
            ICodeValueCipher cipher = new CodeValueCipher();
            var result = cipher.Decrypt(message, Key);
            Assert.Equal(expected, result);
        }
    }
}
