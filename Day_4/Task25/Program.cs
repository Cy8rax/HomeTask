//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите последовательно число и затем степень в которую желаете его возвести: ");

int[] array=new int[3];

void InPut(int[] array)
{    
    for(int j=0;j<2;j++)
    {
        array[j]=Convert.ToInt32(Console.ReadLine());
    }
}

int Degree(int[] array)
{
    array[2]=1;
    for(int i=1;i<=array[1];i++)
    {
        array[2]=array[0]*array[2];
    }
    return array[2];
}

InPut(array);
Console.Clear();
Console.WriteLine($"Число "+array[0]+" в степени "+array[1]+" равно "+Degree(array));