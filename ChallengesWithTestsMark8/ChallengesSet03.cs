using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        //Method to determine if an array contains "False"
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }     
            }

            return false;
        }

        //Method to determine if the sum of the odd numbers is odd.
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return false; 
            }

            var sum = numbers.Sum();

            return (sum % 2 != 0);

        }

        //Method to determine if a password contains an Uppercase Letter, Lowercase Letter, and Number. 
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }

            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to get the first letter of a string.
        public char GetFirstLetterOfString(string val)
        {
            return val.First();
            //alternative way - return val[0];

        }

        //Method to get the last letter of a string.
        public char GetLastLetterOfString(string val)
        {
            return val.Last();
            //alternative way - return val[val.Length - 1];
        }

        //Method to divide 2 decimals.
        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        //Method used to subtract the last number from the first number in an array. 
        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        //Method used to get all of the odd numbers that are below 100. 
        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
        }

        //Method to change all of the elements in a word to Uppercase. 
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
