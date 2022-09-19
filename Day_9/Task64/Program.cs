//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

string natNum(int a, int b)
{
    if(a==b) return Convert.ToString(a);
    return a+", "+ natNum(a+1,b);
}
Console.WriteLine(natNum(m,n));