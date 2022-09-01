//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

for(int i=0; i<8;i++)
{
    array[i]=new Random().Next(1,1000);
}

void ArrayPrinter(int[] arr)
{
    for(int j=0;j<8;j++)
    Console.Write(arr[j]+", ");
}

ArrayPrinter(array);
Console.WriteLine();