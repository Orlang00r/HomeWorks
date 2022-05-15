//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
Console.Write("input Matrix of 2 size");
Console.WriteLine();
Console.Write("input 1 size of matrix: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input 2 size of matrix: ");
int size2 = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[size1, size2];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Math.Round(new Random().NextDouble()*20-10, 1);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
double[,] Array(int size1, int size2)
{
    double[,] matrix = new double[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
    return matrix;
}

double CheckOfIndex(double[,] Array, int index1, int index2)
{
    if (index1 <= Array.GetLength(0) - 1 && index2 <= Array.GetLength(1) - 1
        && index1 >= 0 && index2 >= 0) { return Array[index1, index2]; }
    return 99;
}

int size1 = new Random().Next(1, 25);
int size2 = new Random().Next(1, 25);
Console.Write("Matrix size is: " + size1 + "x" + size2);
Console.WriteLine();
double[,] MyArray = Array(size1, size2);

Console.Write("input index1 is 0 to " + (size1 - 1) + ": ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input index2 is 0 to " + (size2 - 1) + ": ");
int index2 = Convert.ToInt32(Console.ReadLine());
double checkResult = CheckOfIndex(MyArray, index1, index2);
if (checkResult == 99) { Console.WriteLine("index not found"); }
else { Console.WriteLine("index value is: " + MyArray[index1, index2]); }
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
double[] Array(int size1, int size2)
{
    double[] rezult = new double[size1];
    int[,] matrix = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + "\t");
            rezult[j] =rezult[j] + Convert.ToDouble(matrix[i, j])/size2;
        }
        Console.WriteLine();
    }
    return rezult;
}

Console.Write("input Matrix of 2 size");
Console.WriteLine();
Console.Write("input 1 size of matrix: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input 2 size of matrix: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] arithmeticMean = Array(size1, size2);
Console.WriteLine("arithmetic mean: ");
for (int i = 0; i < size1; i++)
{
    Console.Write(Math.Round(arithmeticMean[i],1)+"\t");
}
*/