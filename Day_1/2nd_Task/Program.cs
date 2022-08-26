//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if(numberA>numberB)
{
    Console.Write("Меньшее число: ");
    Console.WriteLine(numberB);
    Console.Write("Большее число: ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("Меньшее число: ");
    Console.WriteLine(numberA);
    Console.Write("Большее число: ");
    Console.WriteLine(numberB);
}