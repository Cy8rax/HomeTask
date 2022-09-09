//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int size=0;
int[] array=new int[size];
int freq = 0;
string cont="n";

int Math(string count, int[] arr,int freq)
{
    while(count != "y")
    {
        size++;
        Array.Resize(ref arr,size);
        Console.WriteLine("Введите число: ");
        arr[size-1]=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вывести результат? y/n");
        count=Console.ReadLine();
        Console.Clear();
        if(arr[size-1]>0)
        {
            freq++;
        }
    }
    return freq;
}
Console.WriteLine("Количество введенных чисел больше нуля: "+Math(cont, array,freq));
