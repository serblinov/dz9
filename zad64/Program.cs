/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 N = 5 -> "5, 4, 3, 2, 1"
 N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

string integers (int m, int n)
{
    if(m<=n) 
    {
        return integers(m+1,n) + $"{m}"+ ",";
    }
    else 
    {
        return string.Empty;
    }
}
int m = 1;
Console.WriteLine($"Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{integers(m,n)}");

