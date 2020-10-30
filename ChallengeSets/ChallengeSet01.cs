using System;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //throw new NotImplementedException();
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();
            double diff = minuend - subtrahend;
            return diff;
        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            return Math.Min(number1, number2);
        }

        public long Multiply(long factor1, long factor2)
        {
            //throw new NotImplementedException();
            long product = factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if(nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return  $"Hello, {nameOfPerson}!";
            }
             
           
           
            
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
