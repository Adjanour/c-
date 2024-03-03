// See https://aka.ms/new-console-template for more information
using static CSharpPractice.EuclideanAlgorithm;
using static System.Console;

(int num1, int num2) =  takeUserInput();

WriteLine($"The gcf of {num1} and {num2} is {CalculateGCF(num1,num2)}");




