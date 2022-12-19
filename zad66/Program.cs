/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int resultNumber(int M, int N)
{
    int sum=0;
    if(M>0 && N>0)
    {
         sum = (M+N)*(N-M+1)/2;
    }
    else if(N<M)
    {
         sum=0;
    }
    return sum;
}
Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел равна: {resultNumber(M,N)}");
