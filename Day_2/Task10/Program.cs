//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = Convert.ToInt32(Console.ReadLine());
// или можно int number = new Random().Next(100,1000);

Console.WriteLine(number);
int qnumber = (number%100)/10;

Console.WriteLine(qnumber);