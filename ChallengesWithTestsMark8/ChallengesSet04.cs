using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        //Adding the even numbers and subtracting the odd numbers from the sum.
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        //Getting the shortest string in a list.
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };

            return stringList.Min();
        }

        //Getting the smallest number in a list. 
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberList = new List<int>() { number1, number2, number3, number4 };

            return numberList.Min();
        }

        //Changing the business name to TrueCoders.
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        //Determining if a triangle can be formed.
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                        sideLength1 + sideLength2 > sideLength3 &&
                        sideLength2 + sideLength3 > sideLength1 &&
                        sideLength1 + sideLength3 > sideLength2
                    );
        }

        //Determining if a string is a number.
        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);

            return isNumber;
        }

        //Determinig if the majority of the elements in an array are null. 
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amountInList = objs.Length;
            var majority = (amountInList / 2) + 1;
            var amountNull = 0;

            foreach (var element in objs)
            {
                if (element == null)
                {
                    amountNull++;
                }
            }

            if (amountNull >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //Determining the Average of the Even Numbers in an array.
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(num => num % 2 == 0);

            if (evens.Count() == 0)
            {
                return 0;
            }
            else
            {
                return evens.Average();
            }
            
        }

        //Determining the factorial of a number.
        public int Factorial(int number)
        {
            var factorial = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
