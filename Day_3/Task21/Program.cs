//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void FillArray(int[] coordinates)
{
    for(int i=0;i<3;i++)
    {
        coordinates[i]=Convert.ToInt32(Console.ReadLine());
    }
}

int []arrayA=new int[3];
int []arrayB=new int[3];

Console.WriteLine("Введите последовательно координаты первой точки A (x,y,z): ");
FillArray(arrayA);

Console.WriteLine("Введите последовательно координаты второй точки В (x,y,z): ");
FillArray(arrayB);

double distance = Math.Sqrt(Math.Pow(arrayB[0]-arrayA[0],2)+Math.Pow(arrayB[1]-arrayA[1],2)+Math.Pow(arrayB[2]-arrayA[2],2));

Console.WriteLine("Расстояние между точкой A и B составляет: " + distance);