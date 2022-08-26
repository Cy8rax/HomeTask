//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
int count = number;

while(count>1) // этот счетчик нужен чтобы узнать скольки-значное число введено
{
    count=count/10;
    index++;
}

if (number < 99) //отсеить лишнее
{
    Console.WriteLine("Номер слишком мал, третьей цифры нет.");
}
else
{
    int thrd_number = (number/(Convert.ToInt32(Math. Pow(10,index-3))))%10;
    //в формуле выше я 10ть возвожу в степень без 3х нулей от исходного, чтобы получилось только трехзначное, а затем уже просто остаток определяю
    Console.WriteLine(thrd_number);
}