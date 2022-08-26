//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
if(numA>numB)
{
    max = numA;
}
if(numB>max)
{
    max = numB;
}
if(numC>max)
{
    max = numC;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);