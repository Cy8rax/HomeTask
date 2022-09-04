//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = new Random().Next(5,10);
int[] array=new int[size];

void FillArr(int[] arr)
{
    for(int i=0;i<size;i++)
    arr[i]=new Random().Next(1,100);
}

FillArr(array);

int length = array.Length;

int Sum_odd(int[] arr)
{
    int summary_odd = 0;
    for(int j=0;j<length;j++)
    if(j%2!=0)
    {
        summary_odd+=arr[j];
    }
    return summary_odd;
}
Console.WriteLine("В массиве: "+"[{0}]",String.Join(";",array));
Console.WriteLine("Сумма стоящих элементов на нечетных позициях: "+Sum_odd(array));