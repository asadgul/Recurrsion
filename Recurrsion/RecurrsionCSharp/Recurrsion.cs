using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrsion.RecurrsionCSharp
{
    public class Recurrsion
    {
        public static void PrintNumber5To1(int no)
        {
            if (no < 1)
            {
                return;
            }
            Console.WriteLine(no);
            PrintNumber5To1(no - 1);
        }
        public static void PrintSumofNNaturalNo(int start,int end,int sum)
        {
            if (start == end)
            {
                sum += end;
                Console.WriteLine("Sum is :"+sum);
                return;
            }
            sum+=start;
            PrintSumofNNaturalNo(start + 1, end, sum);
        }
        public static int Factorial(int no)
        {
            if(no==1 || no == 0)
            {
                return 1;
            }
            return no * Factorial(no - 1);
        }
        public static void fibonacci(int a,int b,int n)
        {
            int c = a + b;
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(c);
            //After adding a will be b and b will be c
            fibonacci(b, a, n - 1);
        }
        public static int PowerFactorial(int no,int power)
        {
            if(power == 0)
            {
                return 1;
            }
            return no * PowerFactorial(no,power-1);
        }
        public static void StringReverse(string str,int index)
        {
            if (index <0)
            {
                return;
            }
            Console.WriteLine(str[index]);
            StringReverse(str, index--);
        }
        public static void firstandlastinstring(string str,int first,int last,int index)
        {
            if (index > str.Length)
            {
                Console.WriteLine(str[first]);
                Console.WriteLine(str[last]);
                return;
            }
            if (first == -1)
            {
                first = index;
            }
            else
            {
                last= index;
            }
            firstandlastinstring(str, first, last, index + 1);
        }
        public static bool CheckArraySorted(int[]arr,int index)
        {
            if (index > arr.Length-1)
            {
                return true;
            }
            return arr[index] < arr[index+1] && CheckArraySorted(arr,index+1);
        }
        public static void MoveAllxtoendofstring(string str,int index,int count,string newstring)
        {
            if (index > str.Length)
            {
                for(int i = 0; i < count; i++)
                {
                    newstring += 'x';
                }
                return;
            }
            char currentchar = str[index];
            if (currentchar == 'x')
            {
                count++;
                MoveAllxtoendofstring(str, index+1, count, newstring);
            }
            else
            {
                newstring += currentchar;
                MoveAllxtoendofstring(str, index + 1, count, newstring);
            }

        }
        public static void SubSequence(string str,int index,string newstring)
        {
            if (index == str.Length)
            {
                Console.WriteLine(newstring);
                return;
            }
            char current= str[index];
            SubSequence(str,index+1,newstring+current);
            SubSequence(str, index + 1, newstring);
        }
    }
}
