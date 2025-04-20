using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1551_coursework
{
    internal class ASCIIStringProcessor
    {
        public string LettersEncryptor(string Letter, int Encryptor)
        {
            string Encrypted = "";
            for (int i = 0; i < Letter.Length; i++)
            {
                char c = Letter[i];
                int AsciiValue = (int)c;
                AsciiValue += Encryptor;
                if (AsciiValue > 90)
                {
                    AsciiValue -= 26;
                }
                else if (AsciiValue < 65)
                {
                    AsciiValue += 26;
                }
                Encrypted += (char)AsciiValue;
            }
            return Encrypted;
        }

        public string SortString1(string input)
        {
            char[] charArray = input.ToCharArray();
            int n = charArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (charArray[i] > charArray[j])
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                    }
                }
            }

            return new string(charArray);
        }
        public string SortString2(string input)
        {
            char[] charArray = input.ToCharArray();
            int n = charArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (charArray[i] < charArray[j])
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                    }
                }
            }

            return new string(charArray);
        }
    }
}

