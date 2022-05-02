//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] RndArray(int len)
{
    int[] Array = new int[len];
    for (int i = 0; i < len; i++)
    {
        Array[i] = new Random().Next(100, 1000);
        Console.Write(Array[i] + " ");
    }
    return Array;
}

int Even(int[] Array)
{
    int evcon = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) evcon++;
    }
    return evcon;
}


int len = 7;
int[] MyArray =  RndArray(len);
Console.WriteLine("Even numbers is: " + Even(MyArray));

*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] RndArray(int len)
{
    int[] Array = new int[len];
    for (int i = 0; i < len; i++)
    {
        Array[i] = new Random().Next(10, 100);
        Console.Write(Array[i] + " ");
    }
    return Array;
}

int Sum(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 != 0) sum+=(Array[i]);
    }
    return sum;
}

int len = 9;
int[] MyArray =  RndArray(len);
Console.WriteLine("Summ of notEven elements is: " + Sum(MyArray));
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] RndArray(int len)
{
    double[] Array = new double[len];
    for (int i = 0; i < len; i++)
    {
        Array[i] = new Random().NextDouble()*20;
        Console.Write(Array[i] + "  ");
    }
    return Array;
}

double Maxmin(double[] Array)
{
    double max = 0; double min = 21;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) 
        {
            max = Array[i];
        }

        if (Array[i] < min) 
        {
            min = Array[i];
        }
    
    }
    Console.WriteLine();
    Console.WriteLine("Min: "+min);
    Console.WriteLine("Max: "+max);
    double end = max - min;
    return end;
}

int ln = 7;
double []MyArr= RndArray(ln);
double maxmin = Maxmin(MyArr);
Console.WriteLine();
Console.WriteLine("Max - Min : " + maxmin);

*/
