//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for(int i=1;i<number+1;i++)
{
    Console.WriteLine(Math.Pow(i,3)+", ");
}