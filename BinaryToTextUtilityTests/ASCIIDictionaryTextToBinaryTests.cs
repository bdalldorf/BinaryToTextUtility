using BinaryToTextUtility;
using NUnit.Framework;

namespace Tests
{
    public class ASCIIDictionaryTextToBinaryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UpperCaseLetterConversionTest()
        {
            string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Assert.AreEqual(@"01000001 01000010 01000011 01000100 01000101 01000110 01000111 01001000 01001001 01001010 01001011 01001100 01001101 01001110 01001111 01010000 01010001 01010010 01010011 01010100 01010101 01010110 01010111 01011000 01011001 01011010",
                ASCIIMethods.GetASCIIBinaryFromStringWithSpaces(UpperCaseLetters));
        }

        [Test]
        public void LowerCaseLetterConversionTest()
        {
            string LowerCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();

            Assert.AreEqual(@"01100001 01100010 01100011 01100100 01100101 01100110 01100111 01101000 01101001 01101010 01101011 01101100 01101101 01101110 01101111 01110000 01110001 01110010 01110011 01110100 01110101 01110110 01110111 01111000 01111001 01111010",
                ASCIIMethods.GetASCIIBinaryFromStringWithSpaces(LowerCaseLetters));
        }

        [Test]
        public void SpecialCharacterConversionTest()
        {
            string SpecialCharacters = @" !""#$%&'()*+,-./:;<=>?@[\]^_`{|}~";

            Assert.AreEqual(@"00100000 00100001 00100010 00100011 00100100 00100101 00100110 00100111 00101000 00101001 00101010 00101011 00101100 00101101 00101110 00101111 00111010 00111011 00111100 00111101 00111110 00111111 01000000 01011011 01011100 01011101 01011110 01011111 01100000 01111011 01111100 01111101 01111110",
                ASCIIMethods.GetASCIIBinaryFromStringWithSpaces(SpecialCharacters));
        }

        [Test]
        public void NumberConversionTest()
        {
            string Numbers = "0123456789";

            Assert.AreEqual(@"00110000 00110001 00110010 00110011 00110100 00110101 00110110 00110111 00111000 00111001",
                ASCIIMethods.GetASCIIBinaryFromStringWithSpaces(Numbers));
        }

        [Test]
        public void HelloWorldConversionTest()
        {
            string HelloWorld = "Hello World";

            Assert.AreEqual(@"01001000 01100101 01101100 01101100 01101111 00100000 01010111 01101111 01110010 01101100 01100100",
                ASCIIMethods.GetASCIIBinaryFromStringWithSpaces(HelloWorld));
        }
    }
}