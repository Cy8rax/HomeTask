//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int size =new Random().Next(4,10);
int[] array=new int[size];

void FillArr (int[] arr)
{
    for(int i=0;i<size;i++)
    {
    arr[i]=new Random().Next(100,1000);
    }
}

int EvenCalc(int[] array)
{
    int number=0;
    for(int j=0;j<size;j++)
    if(array[j]%2==0)
    {
        number++;
    }
    return number;
}
FillArr(array);

Console.Write("В массиве: ");
Console.WriteLine(String.Join(";",array));
Console.WriteLine("Четных числа: "+EvenCalc(array));