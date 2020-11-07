using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            int num = vals.Length;
            return num % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        { 
            //throw new NotImplementedException();
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            
            
            
            
            double max = numbers.Max();
            double min = numbers.Min();
            
            double sum = max + min;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
            if(str1.Length < str2.Length)
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
            if(numbers == null)
            {
                return 0;
            }
            int sum = 0;
            //throw new NotImplementedException();
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            //throw new NotImplementedException();
            int evenSum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];
                if(n % 2 == 0)
                {
                    evenSum += n;
                    
                }
            }
            return evenSum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            //throw new NotImplementedException();
            foreach(var item in numbers)
            {
                sum += item;
            }
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            long counter = 0;
            
            for (long i = 0; i < number; i++ ){

                if(i % 2 != 0 )
                {
                    counter++;
                }

            }

            
            return counter;
        }
            
    }
}
