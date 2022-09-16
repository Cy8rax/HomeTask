//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задайте прямоугольный двумерный массив.");

bool condition = true;
while(condition==true)
{
    Console.Write("Введите количество строк: ");
    int row=Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int column=Convert.ToInt32(Console.ReadLine());
    if(row==column)
    {
        Console.Clear();
        Console.WriteLine("Массив должен быть прямоугольным!");
        condition=true;
    }
    else
    {
        condition=false;
        int[,] matrix=new int[row,column];
        fillArray(matrix);
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow(matrix)} строка." );
    }
}

void fillArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(1,10);
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int minRow(int[,] array)
{
    int[] minSum=new int[array.GetLength(0)];

    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            minSum[i] += array[i,j];
        }
    }
    int minRowNum=0;
    for(int p=0;p<array.GetLength(0);p++)
    {
        if(minSum[0]>minSum[p])
        {
            minSum[0]=minSum[p];
            minRowNum=p+1;
        }
    }
    return minRowNum;
}
