using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = int.MaxValue;
           //throw new NotImplementedException();
           for (int i = startNumber + 1; i <= nextNumber; i++)
            {
                if(i % n == 0)
                {
                    nextNumber = i;

                    
                }
               
               
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            // throw new NotImplementedException();
            Business business = new Business();
            for(int i = 0; i < businesses.Length; i++)
            {
                businesses[i] = new Business();
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                    
                    //business.SetParentCompany(businesses[i]);
                    
                    
                }
            }

         
        }

        public bool IsAscendingOrder(int[] numbers)
        { 
            int currenNumber = int.MinValue;
            bool conditional = false;
            
            
            //throw new NotImplementedException();
            if(numbers == null ||numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                

                if (numbers[i] >= currenNumber)
                {
                    currenNumber = numbers[i];
                    conditional = true;
                }
                else
                {
                    conditional = false;
                    return false;
                }
                

            }

                return conditional;
               

            
            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();
            
            
            int sumAfterNums = 0;
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for(int i = 1; i < numbers.Length; i++)
            {
                
                if(numbers[i-1] % 2 == 0)
                {
                    sumAfterNums += numbers[i];

                }
               
                
                
                
                
                

            }
            return sumAfterNums;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //throw new NotImplementedException();
            

            string sentence = "";
            if(words == null)
            {
                return sentence;
            }
           
            foreach(var item in words)
            {
                if(item.Trim().Length > 0)
                {
                    sentence += item.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {   
            //throw new NotImplementedException();
            var newList = new List<double>();
            if(elements == null || elements.Count == 0)
            {
                return newList.ToArray();
            }
            for(int i = 3; i < elements.Count; i+= 4)
            {
                newList.Add(elements[i]);
            }
            return newList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
           
            //throw new NotImplementedException();
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j =i +1; j < nums.Length; j++)
                {
                    if((nums[i] + nums[j])== targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
