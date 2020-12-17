using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            
            
            //throw new NotImplementedException();
            if (words == null || words.Contains(null))
            {
                return false;
            }
            
           

            var newL = words.Select(x => x.ToString().ToLower());


            if (ignoreCase == false)
            {
                if (words.Contains(word) == false)
                {
                    return false;
                }
                else 
                {
                    return true;
                } 
                    
                

            }
            else 
            {
                if (!newL.Contains(word.ToLower()) )
                {
                    return false;
                }
               

                return true;
                
            }
            
            

            



           







        }

        public bool IsPrimeNumber(int num)
        {
            // throw new NotImplementedException();
            if (num <= 1)
            {
                return false;
            }
            if (num % 2 == 0 && num != 2)
            {
                return false;
            }
            if (num % 3 == 0 && num != 3)
            {
                return false;
            }

            if (num % num != 0 && num / 1 != num && num / num != 1)
            {
                return false;
            }

            return true;
        }


        public int IndexOfLastUniqueLetter(string str)
        { int index = -1;
            bool conditional;
            //throw new NotImplementedException();
            for(int i = 0; i < str.Length; i++)
            {
                conditional = true;
                
                for(int j= 0; j < str.Length; j++)
                {
                    if(str[i] == str[j] && i != j) 
                    {
                        conditional = false;
                    }
                    
                }

                if(conditional == true)
                {
                    index = i;
                }
                

            }

            return index;
        }
        public int MaxConsecutiveCount(int[] numbers)
        { 
            int maxCount = 0;
            //throw new NotImplementedException();
            for(int i = 0; i < numbers.Length; i++)
            {
                int counter = 1;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] != numbers[j])
                    {
                        break;
                    }
                    counter++;
                }
                if(counter > maxCount)
                {
                    maxCount = counter;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //throw new NotImplementedException();
            double[] check = new double[0] ;
            if(elements == null)
            {
                return check;
            }
            var newEveryNEl = new List<double>();
            for(int i = 0; i < elements.Count; i++)
            {
               
                if(elements[i] % n == 0)
                {
                    newEveryNEl.Add(elements[i]);
                }
                if(n < 0 || n > elements.Count)
                {
                    newEveryNEl.Clear();
                }
                    
                
            }
            return newEveryNEl.ToArray();
        }
    }
}
