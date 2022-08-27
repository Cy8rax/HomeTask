//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Вариант для ручного ввода числа!
//Console.Write("Введите пятизначное число: ");
//string num = Console.ReadLine(); 

string num = Convert.ToString(new Random().Next(10000,100000));
Console.WriteLine(num);

if(num.Length==5)
{
    if(num[0]==num[4]&&num[1]==num[3])
    {
        Console.WriteLine("Да, это число палиндрон!");
    }
    else
    {
        Console.WriteLine("Нет, это обычное число!");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число!");
}