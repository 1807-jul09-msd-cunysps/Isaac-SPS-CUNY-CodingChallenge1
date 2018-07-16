using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLibrary
{
    public class PalindromeChecker
    {
        public bool Check(int value)
        {
            string text = value.ToString();
            return this.Check(text);
        }

        public bool Check(string text)
        {
            stripString(ref text);
            string original = text;
            string reversed = "";

            for(int i = text.Length; i > 0; i--)
            {
                reversed += original.ElementAt(i-1);
            }

            if(original == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void stripString(ref string text)
        {
            string tempString = "";

            foreach (var character in text.ToCharArray())
            {
                if (char.IsLetterOrDigit(character))
                {
                    tempString += char.ToUpper(character);
                }
            }

            text = tempString;
        }
    }
}
