using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;

            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }


               if(numbers[i] % 2 != 0)
                {
                    sum -= numbers[i];
                }
            }
            return sum;




        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length<=str2.Length&& str1.Length<=str3.Length&& str1.Length<=str4.Length )
            {
                return str1.Length;
            }
            if(str2.Length<=str1.Length&&str2.Length<=str3.Length&&str2.Length<=str4.Length)
            {
                return str2.Length;
            }

            if(str3.Length<=str1.Length&&str3.Length<=str2.Length&&str3.Length<=str4.Length)
            {
                return str3.Length;
            }
            else
            {
                return str4.Length;
            }
        
        
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if(number1 <= number2 && number2 <= number3&& number3 <= number4)
            {
                return number1;

            }
            if(number2<=number1 && number2<=number3 && number2<=number4)
            {
                return number2;
            }
            if(number3<=number1 && number3<=number2 && number3<=number4)
                return number3;
            else
                return number4;
        
        
        
        
        
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            
            if ( sideLength1 <=0 && sideLength3 <=0 && sideLength2<=0)
            {
                return false;
            }
            if (sideLength1 <= sideLength2 && sideLength3 <= sideLength2 && sideLength1 <= sideLength3)
            {
                return true;

            }
            else
                return false;



        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }

            if (input.Length >= 0 || input.Length <= 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
