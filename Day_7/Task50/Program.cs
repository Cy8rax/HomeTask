//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введите искомое число: ");
int userNumber = int.Parse(Console.ReadLine());

int[,] matrix=new int[row,column];
int userNumberFreq=0;

void FillArray(int[,] Array)
{
    for(int i=0;i<Array.GetLength(0);i++)
    {
        Console.WriteLine();
        for(int j=0;j<Array.GetLength(1);j++)
        {
            Array[i,j]=new Random().Next(1,10);
            Console.Write(Array[i,j]+"\t");
        }
    }
}

void numSniper(int[,] Array, int number, int numFrequency)
{
    for(int i=0;i<Array.GetLength(0);i++)
    {
        for(int j=0;j<Array.GetLength(1);j++)
        {
            if(matrix[i,j]==number)
            {
                Console.WriteLine($"Число {number} присутствует в массиве в {i} строке,{j} столбце");
            //}
            //else
            //{
                numFrequency+=1;    
            }
        }
    }
    if(numFrequency==0)
    {
        Console.WriteLine($"{number} -> Такого числа в массиве нет.");
    }
}

FillArray(matrix);
Console.WriteLine();
numSniper(matrix, userNumber,userNumberFreq);