using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        //Determines the next number that is divisible by the value entered for n. 
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        //A method that will change the name of a business to CLOSED if they have not received any revenue.
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                };
            }  
        }

        //Determines if an array of numbers is in ascending order.
        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null|| numbers.Length == 0)
            {
                return false;
            }
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        //Calculates the sum of the elements in an array that follow an even number if an even number is in the array.
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                   sum += numbers[i];
                }
            }
            return sum;
        }

        //Turns an array of words into a sentence.
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            var sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";

            return sentence;
        }

        //Determines every fourth element of a list. 
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            var everyFourth = new List<double>();

            for (var i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();
        }

        //Determines if the sum of 2 different elements in an array is the same as an inputted target number. 
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
