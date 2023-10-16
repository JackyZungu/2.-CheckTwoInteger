using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CheckTwoInteger
{
    internal class Program
    {
        public static bool Check(int num1, int num2)
        {
            return num1 == 30 || num2 == 30 || num1 + num2 == 30;
        }
        public static void Main(string[] args)
        {
            int[] input1 = { 30, 25, 20, 20 };
            int[] input2 = { 0, 5, 30, 25 };

            for (int i = 0; i < input1.Length; i++)
            {
                bool result = Check(input1[i], input2[i]);
                Console.WriteLine($"The result for {input1[i]} , {input2[i]} -> {result}");
            }
            Console.ReadLine(); 
        }
     
        
    }
}
