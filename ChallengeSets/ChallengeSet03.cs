using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        { 
            if(numbers == null)
            {
                return false;
            }
            
            int oddSum = 0;
            //throw new NotImplementedException();
            foreach(var item in numbers)
            {
                if(item % 2 != 0)
                {
                    oddSum += item;
                }
            }
            return oddSum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {

            return val[0];
           
        }

        public char GetLastLetterOfString(string val)
        {

            //throw new NotImplementedException();
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            //throw new NotImplementedException();
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int first= 0;
            int last = 0;
            
            //throw new NotImplementedException();
            for(int i = 0; i < nums.Length; i++)
            {
                if(i == 0)
                {
                    first = nums[i];
                }
                if(i == nums.Length - 1)
                {
                    last = nums[i];
                }
            }
            return last - first;
        }
        public int[] GetOddsBelow100()
        {
            List<int> below100 = new List<int>();
            //throw new NotImplementedException();
            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    below100.Add(i);
                }
            }
            return below100.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
           
            //throw new NotImplementedException();
            
           
            
        }
    }
}
