//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n=int.Parse(Console.ReadLine());

int sumNum(int a, int b)
{
    if(a>b) return 0;
    return a+sumNum(a+1,b);
}

Console.WriteLine(sumNum(m,n));