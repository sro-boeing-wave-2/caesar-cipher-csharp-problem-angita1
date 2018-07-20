using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string rotate = "";

            foreach (char item in text)
            {
                if (!char.IsLetter(item))
                {

                    rotate += item;
                }
                else
                {
                    if (item >= 'a' && item <= 'z')
                    {
                        char c = (char)(item + shiftKey);
                        if (c > 'z')
                        {
                            rotate += (char)(c - 26);
                        }
                        else
                        {
                            rotate += c;
                        }

                    }
                    if ((item >= 'A') && (item <= 'Z'))
                    {
                        char d = (char)(item + shiftKey);
                        if (d > 'Z')
                        {
                            rotate += (char)(d - 26);
                        }
                        else
                        {
                            rotate += d;
                        }
                    }
                }              
            }
            return rotate;
            throw new NotImplementedException("You need to implement this function.");
        }
           
       

    }
}
