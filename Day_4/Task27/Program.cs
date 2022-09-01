//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число для получения суммы его цифр: ");
int number = Convert.ToInt32(Console.ReadLine());


int Summarizer(int num)
{
    int sum=0;
    int length = num.ToString().Length;
    for(int i=0;i<length;i++)
    {
        sum+=num%10;
        num=num/10;
    }
    return sum;
}

Console.Clear();
Console.WriteLine($"Сумма цифр числа: "+number+" = "+Summarizer(number));