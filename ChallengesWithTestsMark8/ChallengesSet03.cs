using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           if (vals!=null || vals==null)
           {
                return false;
           }
            
            if (vals.Length == 0 || vals.Length != 0)
            {
                return false;
            }

            else
            {
                return true;

            }

           
        
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if ( password.Length!='c' && password.Length=='C') 
            {
                return true;

            }
            else
            {
                return false;
            }

           
        }

        public char GetFirstLetterOfString(string val)
        {
             return char.MinValue;
           
        
        }
            

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
