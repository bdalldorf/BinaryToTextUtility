using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryToTextUtility
{
    public static class ASCIIMethods
    {
        #region Text To Binary Methods

        public static string GetASCIIBinaryStringFromChar(char character)
        {
            return Convert.ToString(character, 2).PadLeft(8, '0');
        }

        public static string GetASCIIBinaryFromStringWithSpaces(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char ASCIILetter in value)
            {
                stringBuilder.Append(stringBuilder.Length != 0 ? $" {GetASCIIBinaryStringFromChar(ASCIILetter)}" : GetASCIIBinaryStringFromChar(ASCIILetter));
            }

            return stringBuilder.ToString();
        }

        public static string GetASCIIBinaryFromString(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char ASCIILetter in value)
            {
                stringBuilder.Append(GetASCIIBinaryStringFromChar(ASCIILetter));
            }

            return stringBuilder.ToString();
        }

        #endregion


        #region Binary to Text Methods

        public static char GetASCIICharFromBinaryString(string binary)
        {
            return (char)Convert.ToByte(binary, 2);
        }

        /// <summary>
        /// The Binary string needs to be split into a byte with a space. I.E. 01001001 00101110 01000101 00101110
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>
        public static string GetASCIIStringFromBinary(string binary)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string BinaryString in binary.Split(' '))
            {
                stringBuilder.Append(GetASCIICharFromBinaryString(BinaryString));
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
