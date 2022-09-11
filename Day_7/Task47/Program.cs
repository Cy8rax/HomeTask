//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
double[,] matrix=new double[row,column];

for(int i=0;i<matrix.GetLength(0);i++)
{
    for(int j=0;j<matrix.GetLength(1);j++)
    {
        matrix[i,j]= Convert
        .ToDouble((new Random()
        .NextDouble()*(10-(-10))-10)
        .ToString("f"+1));

        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}