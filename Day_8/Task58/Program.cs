//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введите кол-во строк A матрицы: ");
int rowA=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов A матрицы: ");
int columnA=int.Parse(Console.ReadLine());
int[,] matrix1 = new int[rowA,columnA];

Console.WriteLine();
Console.WriteLine("Введите данные второй матрицы.");
Console.WriteLine();
Console.Write("Введите кол-во строк B матрицы: ");
int rowB=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов B матрицы: ");
int columnB=int.Parse(Console.ReadLine());
int[,] matrix2 = new int[rowB,columnB];

Console.Clear();

void materixGen(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]= new Random().Next(1,3);
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

materixGen(matrix1);
Console.WriteLine();
Console.WriteLine("        X");
Console.WriteLine();
materixGen(matrix2);
Console.WriteLine("________________________");

if(columnA!=rowB)
{
    Console.WriteLine("Матрицы не могут быть перемножены!");

}
else
{
    int temp=0;
    int[,] result=new int[rowA,columnB];
    for(int i=0;i<rowA;i++)
    {
        for(int j=0;j<columnB;j++)
        {
            temp=0;
            for(int k=0; k<columnA;k++)
            {
                temp +=matrix1[i,k]*matrix2[k,j];
            }
            result[i,j]=temp;
            Console.Write(result[i,j]+"\t");
        }
        Console.WriteLine();
    }
}