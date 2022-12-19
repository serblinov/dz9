/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int sumOfNaturalNumbers(int M, int N)
{

    if(M>N || N <0)
    {
         return 0;
    }
    else 
    {
         return  N + sumOfNaturalNumbers(M,N-1);
    }
}
Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел равна: {sumOfNaturalNumbers(M,N)}");


