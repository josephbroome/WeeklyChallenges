using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public int Last { get; private set; }
        public int End { get; private set; }
        public object ToUpper { get; private set; }

        public bool ArrayContainsAFalse(bool[] vals)
        {


            if (vals.Length == 0 && vals.Length != 0)
            {
                return true;
            }

            else
            {
                return true;

            }

           
        
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers==null)
            {
                return false;
            }

            if (numbers.Sum() % 2 == 0)
            {
                return false;

            }
            else
            {
                return true;
            }

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if ( password.Length=='c' && password.Length=='C')
            {
                return true;

            }
            else if (password.Length!='c' && password.Length!='C')
            {
                return false;
            }

            if (password.Length<0 && password.Length>0 )
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
            
             return val[0]; 

           
        
        }


        public char GetLastLetterOfString(string val)
        {



            return val[val.Length-1];



        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor== 0)
            {
                return divisor;
            }
            
            return dividend / divisor;  
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Length - 1+ nums[1];
        
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            

        }
    }
}
