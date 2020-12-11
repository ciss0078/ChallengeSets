using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int add = 0;
            int substract = 0;
            //throw new NotImplementedException();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    add += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    substract += numbers[i];
                }
            }
            return add - substract;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = 0;

            if (str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            {
                shortest = str1.Length;
            } else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            {
                shortest = str2.Length;
            } else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length <= str4.Length)
            {
                shortest = str3.Length;
            }
            else
            {
                shortest = str4.Length;
            }
            return shortest;
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallNum;
            //throw new NotImplementedException();
            if (number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                smallNum = number1;
            } else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                smallNum = number2;
            } else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                smallNum = number3;
            }
            else
            {
                smallNum = number4;
            }
            return smallNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();

            biz.Name = "TrueCoders";


        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool conditional;
            int sum1 = sideLength1 + sideLength2;
            int sum2 = sideLength1 + sideLength3;
            int sum3 = sideLength2 + sideLength3;
            if (sum1 > sideLength3 && sum2 > sideLength2 && sum3 > sideLength1)
            {
                conditional = true;
            }
            else
            {
                conditional = false;
            }
            return conditional;

            //throw new NotImplementedException();

        }

        public bool IsStringANumber(string input)
        {
            // throw new NotImplementedException();
            int number;
            double num;
            bool conditional;
            if (Int32.TryParse(input, out number))
            {
                conditional = true;
            } else if (Double.TryParse(input, out num))
            {
                conditional = true;
            }
            else
            {
                conditional = false;
            }

            return conditional;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            bool conditional;
            int nullCount = 0;
            int nonNullCount = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }
            if (nullCount > nonNullCount)
            {
                conditional = true;
            }
            else
            {
                conditional = false;
            }
            //throw new NotImplementedException();
            return conditional;
        }

        public double AverageEvens(int[] numbers)
        {
            
            double average = 0;
            double sumOfAverage =0;
            double counter = 0;

            if (numbers == null)
            {
                average = 0;
            }
            else 
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    
                    if (numbers[i] % 2 == 0)
                    {
                        sumOfAverage += numbers[i];
                        counter++;

                    }

                   
                }
                if(sumOfAverage == 0)
                {
                    average = 0;
                }
                else
                {
                    average = sumOfAverage / counter;
                }
               
            }


            
               

            
            return average;

        }















        public int Factorial(int number)
        {
            var result = 0;
            //throw new NotImplementedException();
            
            
                if (number == 0 || number == 1)
                {
                    result = 1;
                }
                else if(number < 0)
                {
                throw new ArgumentOutOfRangeException();
                }
                else 
                {
                result = number * Factorial(number - 1);
                }
            
            
            return result;
        }
           
        }
    } 

