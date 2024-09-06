using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char x)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            if (lowercaseAlphabet.Contains(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null || numbers.Count() != 0)
            
            {
                return numbers.Min() + numbers.Max();
            }
            
            return 0;
            //didn't use:
            // if (numbers == null || numbers.Count() == 0)
            // {
            //     return 0;
            // }
            // return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null)
            {
                return numbers.Sum();
            }
            else
            {
                return 0;
            }
        }

        public static int SumEvens(int[] numbers)
        {
            if (numbers != null)
            {
                foreach (int x in numbers)
                {
                    return numbers.Where(x => x % 2 == 0).Sum();
                }
            }
            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
            {
                foreach (int x in numbers)
                {
                    var isItOdd =  numbers.Where(x => x % 2 != 0).Sum();
                    if (isItOdd % 2 != 0)
                    {
                        return true;
                    }
                   
                }
            }

            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            while (number > 0)
            {
                if(number > 0 && number % 2 == 0)
                {
                    return number / 2;
                }
                else
                {
                    return (number - 1) / 2;
                }
            }
            return 0;
        }
    }
}
