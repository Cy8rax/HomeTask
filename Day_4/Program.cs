Console.WriteLine("Введите два числа для возведения первого в натуральную степень второго: ");

int[] array = new int[2];
void DataInput(int[] data)
{
    for(int i=0;i<2;i++)
    {
        data[i]=Convert.ToInt32(Console.ReadLine());
    }
}
DataInput(array);

