//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row,column];

void FillArray (int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        Console.WriteLine();
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(1,10);
            Console.Write(array[i,j]+"\t");
        }
    }
}

void meanNumber(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        double mean=0;
        for(int j=0;j<array.GetLength(1);j++)
        {
            mean = array[j,i]+mean;
        }
        Console.Write((mean/(array.GetLength(0)))+"\t");
    }
}

FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
meanNumber(matrix);