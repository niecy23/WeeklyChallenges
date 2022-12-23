using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        //Determines if a character is a letter.
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        //Determines if the count of the amount of elements is even. 
        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
           
            return false;
            
        }

        //Determines if a number is even.
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }

        //Determines if a number is odd.
        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }

            return false;
        }

        //Calculates the sum of the minimum number and the maximum number in the list.
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        //Provides the length of the shortest string inputted. 
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

        //Calculates the sum of multiple arrays. 
        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            return numbers.Sum();
        }

        //Calculates the sum of all the even numbers in an array. 
        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }

            return evenSum;
        }

        //Determines if the sum of the inputted list of numbers is odd. 
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;
        }

        //Determines how many positive odd numbers are below any given number. 
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
