//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if(day>5 && day<8)
{
Console.WriteLine("Этот день выходной.");
}
else
{
Console.WriteLine("Этот день не выходной.");
}

string[]array={"Monday", "Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

Console.WriteLine(array[day-1]);
