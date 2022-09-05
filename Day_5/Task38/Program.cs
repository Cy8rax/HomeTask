//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//--------МАССИВ С ЗАДАЧИ------

int[] array={3,7,22,2,78};

int MinMax(int[] array)
{
    int min_num = array[0];
    int max_num = array[0];
    int minmax = 0;
    for(int j=0;j<5;j++)
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

Console.WriteLine("Разница между максимальным и минимальным числом массива: "+MinMax(array));
