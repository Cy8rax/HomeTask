//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите последовательно параметры 3х мерного массива: ");
int row=int.Parse(Console.ReadLine());
int column=int.Parse(Console.ReadLine());
int dimension=int.Parse(Console.ReadLine());

int slots=(row*column*dimension);
int[,,] matrix=new int[row,column,dimension];
int[] numbers=new int[slots];

for(int p=0;p<slots;p++)
{
    bool noneR=false;
    while(noneR==false)
    {
        numbers[p]=new Random().Next(10,100);
        noneR=true;
        for(int u=0;u<slots;u++)
        {
            if(p!=u&&numbers[p]==numbers[u])
            {
                noneR=false;
            }
        }
    }
}

int l=0;
for(int i=0;i<row;i++)
{
    for(int j=0;j<column;j++)
    {
        for(int k=0;k<dimension;k++)
        {
            matrix[i,j,k]=numbers[l];
            l++;
            Console.Write($"{matrix[i,j,k]}({i},{j},{k})");
        }
        Console.WriteLine();
    }
}