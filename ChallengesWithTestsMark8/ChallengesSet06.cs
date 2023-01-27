using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        //Determines if a collection contains a word. 
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var containsWord = false;

            if (words == null || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase)
            {
                word = word.ToLower();

                var lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }

            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        //Determines if an integer is a prime number.
        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;

            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }

            if (num == 2 || num == 3)
            {
                isPrime = true;
            }

            if (num == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }

        //Determines the index of the last letter in a string that is unique from the rest of the letters.
        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    index = i;
                }
            }

            return index;

        }

        //Determines the maximum number of consecutive letters.
        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        //Determines every nth element based on what is inputted as the value of n and if it is contained in the list.
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null || n <= 0 || n> elements.Count)
            {
                return nthElement.ToArray();
            }

            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
        }
    }
}
