//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double[] array=new double[4];
//заполнение данных
void input(double[] arr)
{
    Console.WriteLine("Введите последовательно точки: k1, b1, k2, b2 ");
    for(int i=0;i<4;i++)
    {
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
}

void Calc(double[] arr)
{
    if((arr[0]*arr[3]-arr[2]*arr[1])==0)
    {
        Console.WriteLine("Прямые параллельны друг другу и не имеют точек пересечения.");
    }
    else if((arr[0]*arr[3])/(arr[2]*arr[1])==1)
    {
        Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений");
    }
    else
    {
        double x = (arr[3]-arr[1])/(arr[0]-arr[2]);
        double y = (arr[2]*x)+arr[3];
        Console.WriteLine("Точка пересечения двух прямых в х="+x+"; y="+y);
    }

}

input(array);
Calc(array);

//как не получилось сделать:

// double Calc(double[] arr)
// {
//     x = (arr[3]-arr[1])/(arr[0]-arr[2]);
//     y = (arr[2]*x)+arr[3];
//     return x; //?? они же не могут одновременно return   (ツ)_/¯
//     return y; //??
// }

// input(array);
// Console.WriteLine(Calc(array));