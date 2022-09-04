//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите величину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array=new int[size];

void FillArr (int[] arr)
{
    for(int i=0; i<size; i++)
    {
        arr[i]=new Random().Next(-100,101);
    }
}

int MinMax(int[] array)
{
    int min_num = array[0];
    int max_num = array[0];
    int minmax = 0;
    for(int j=0;j<size;j++)
    {
        if(min_num>array[j])
    {
        min_num=array[j];
    }
    if(max_num<array[j])
    {
        max_num=array[j];
    }
    }
    return minmax=max_num-min_num;
}
FillArr(array);
Console.WriteLine("Ваш массив: "+"[{0}]",String.Join(";",array));
Console.WriteLine("Разница между максимальным и минимальным числом массива: "+MinMax(array));