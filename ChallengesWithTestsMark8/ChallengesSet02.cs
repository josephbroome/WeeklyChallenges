using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;

            }
            else
            {
                return false;
            }
                

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if ( vals.Length%2 == 0)
            {
                return true;
            }
            else
            {
                return false ;
            }
       
        }

        public bool IsNumberEven(int number)
        {
          
            if (number%2==0)
            {
                return true;

            }
            else
            {
                return false;
            }



        }

        public bool IsNumberOdd(int num)
        {
            if (num%2!=0)
            {
                return true;

            }
            else
            {
                return false;
            }
        
                    
                    
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max() ;
           








        }
        
        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str2.Length< str1.Length)
            {
                return str2.Length;
            }
            else
            {
               return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
           if(numbers==null)
            {
                return 0;
            }


            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >0 || numbers[i]<0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
                
            
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;

            }

            int sum = 0;
          for ( int i =0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }            
            
            }
            return sum;

            
                    
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers==null)
            {
                return false;
            }
            
            if(numbers.Sum()%2 ==0)
            {
                return false ;

            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;

            if(number==1 || number <0)
            {
                return 0;
            }

            for (long i = number; i > 0; i--)
            {
                if( i %2 ==0)
                {
                    count++;
                }
            
            
            
            }

            return count;

          if(number <=0)
            {
                return 0;
            }

          else
            {
                return number / 2;
            }

        }
    }
}
