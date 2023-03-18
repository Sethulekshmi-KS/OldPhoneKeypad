using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldPhoneKeypad
{
    public class Helper
    {
        readonly string[] Buttons = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ", " " };
        int Counter = 0;
        char PreviousChar = ' ';
        string FinalString = "";

        /// <summary>
        /// This method loops through each character in the input string
        /// and returns respective alphabets
        /// '*' button will remove last letter from the input string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public string OldPhonePad(string inputString)
        {
            FinalString = "";
            foreach (char c in inputString)
            {
                switch (c)
                {
                    case '2':
                        GetAlphabet(c, 0);
                        break;
                    case '3':
                        GetAlphabet(c, 1);
                        break;
                    case '4':
                        GetAlphabet(c, 2);
                        break;
                    case '5':
                        GetAlphabet(c, 3);
                        break;
                    case '6':
                        GetAlphabet(c, 4);
                        break;
                    case '7':
                        GetAlphabet(c, 5);
                        break;
                    case '8':
                        GetAlphabet(c, 6);
                        break;
                    case '9':
                        GetAlphabet(c, 7);
                        break;
                    case '*':
                        if (!string.IsNullOrEmpty(FinalString))
                            FinalString = FinalString.Remove(FinalString.Length - 1, 1);
                        ResetPreviousChar();
                        break;
                    case '0':
                        GetAlphabet(c, 8);
                        break;
                    case ' ':
                        ResetPreviousChar();
                        break;
                    default:
                        break;

                }
            }
            return FinalString;
        }


        /// <summary>
        /// Here alphabets are calculated according to a string array declared
        /// at the beginning of code which contains sets of alphabets
        /// as seen on old phone keypad
        /// </summary>
        /// <param name="c"></param>
        /// <param name="index"></param>
        public void GetAlphabet(char c, int index)
        {
            char[] Button;
            Button = Buttons[index].ToCharArray();
            if (PreviousChar == c)
            {
                Counter++;
                if (Counter >= Button.Length) Counter = 0;
                if (!string.IsNullOrEmpty(FinalString))
                    FinalString = FinalString.Remove(FinalString.Length - 1, 1) + Button[Counter].ToString();
            }
            else
            {
                Counter = 0;
                FinalString += Button[Counter].ToString();
            }
            PreviousChar = c;
        }

        public void ResetPreviousChar()
        {
            PreviousChar = ' ';
        }
    }
}
