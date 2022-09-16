//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Random random = new Random();
int row = random.Next(1,10);
int column = random.Next(1,10);


int[,] matrix=new int[row,column];

void fillarray(int[,] array)
{
    for(int i=0;i<row;i++)
    {
        for(int j=0;j<column;j++)
        {
            array[i,j]=random.Next(1,10);
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}


void sorter(int[,] array)
{
    int[,] temp=new int[row,column];
    for(int i=0;i<row;i++)
    {
        Console.WriteLine();
        for(int j=0;j<column;j++)
        {
            for(int k=j+1;k<column;k++)
            {
                if(array[i,k]>array[i,j])
                {
                    int num=array[i,j];
                    temp[i,j]=array[i,k];
                    array[i,j]=array[i,k];
                    array[i,k]=num;

                }
            }
        } 
    }
}

void printer(int[,] array)
{
    for(int i=0;i<row;i++)
    {
        for(int j=0;j<column;j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}


fillarray(matrix);
Console.Write("----------------------");
sorter(matrix);
printer(matrix);