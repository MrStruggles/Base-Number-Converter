using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBaseConverter
{
    public class Calculator
    {
        public static string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "z", ",", " ", "." };
        public static string ConvertNumber(int numberBase, int answerBase, int number)
        {
            string answer = "";
            int quotient = 0;
            List<string> answerComponents = new List<string>();
            int remainder;

            
            

            void FromNonBinary(int? binAnswer = null)
            {
                if (binAnswer != null)
                {
                    number = (int)binAnswer;
                    numberBase = 10;
                }

                if (numberBase == answerBase)
                {
                    answer = number.ToString();
                }
                else
                {
                    answerComponents.Clear();
                    do
                    {
                        quotient = Math.DivRem(number, answerBase, out remainder);
                        number = quotient;
                        answerComponents.Add(remainder.ToString());

                    } while (quotient != 0);

                    foreach (string component in answerComponents)
                    {
                        string comp = component;
                        if (Convert.ToInt32(comp) > 9)
                        {
                            comp = (alphabet[Convert.ToInt32(comp) - 10]).ToUpper();
                        }
                        answer += comp;
                    }
                }
                
            }

            int FromBinary()
            {
                //int numberLength = (int)Math.Floor(Math.Log10(number)) + 1;
                string sNumber = number.ToString();
                int binAnswer = 0;
                int powerCounter = 0;
                
                for (int i = sNumber.Length - 1; i >= 0; i--)
                {
                    if (sNumber.Substring(i, 1) == "1")
                    {
                        binAnswer += (int)Math.Pow(2, powerCounter);
                    }

                    powerCounter++;
                }

                return binAnswer;
            }

            if (numberBase == 2)
            {
                FromNonBinary(FromBinary());    
            }
            else
            {
                FromNonBinary();

            }

            if (answerBase != 10)
            {
                char[] stringComponents = answer.ToCharArray();
                Array.Reverse(stringComponents);
                answer = new string(stringComponents);
            }
            
            return answer;
        }
    }
}
