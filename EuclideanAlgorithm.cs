using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpPractice
{
    public class EuclideanAlgorithm
    {
        public static (int,int) takeUserInput(){
            Write("Enter the first number: ");
            int num1 =Int32.Parse(Console.ReadLine());
            Write("Enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            return (num1,num2);
        }


        /// <summary>
        /// Calculates the gcf using euclids algorithm
        /// </summary>
        /// <param name="num1">int</param>
        /// <param name="num2">int</param>
        /// <returns>the gcf of the two numbers</returns>
        public static int CalculateGCF(int num1,int num2){
            

            if (num2 > num1)
                (num1 , num2) = (num2 , num1);
            
            while(num2 != 0)
            {
                int rem = num1 % num2;
                num1 = num2;
                num2 = rem;
            }

            return num1;
        }
    }
}