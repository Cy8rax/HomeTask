//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число для определения четное/нечетное: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number % 2;
if(remainder==0)
{
    Console.WriteLine("Ваше число четное.");
}
else
{
    Console.WriteLine("Ваше число нечетное.");
}