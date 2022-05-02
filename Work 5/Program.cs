//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Проверку на корректный ввод не делал, торопился.  

/*
int Degree(int num, int deg)
{
    int res = num;
    for (int i = 1; i < deg; i++) 
    {
        res = res * num;
    }
    return res;
}

Console.WriteLine("Input start number: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree: ");
int Y = Convert.ToInt32(Console.ReadLine());

int result = Degree(X, Y);
Console.WriteLine("Result number is:" + result);
*/


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int Summ(int num)
{
    int temp=num;
    int sum=0;
    while (temp > 0)
    {
        sum+=temp%10;
        temp/=10;
    }
    return sum;
}

Console.WriteLine("Input number: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Summ of elements: " + Summ(X));

*/


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] GetArray(int len, int min, int max)
{
    int[] anyArray = new int[len];
    int nxt = len;
    Console.WriteLine("Input number between: " + min + " & " + max);
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine("Need input " + nxt + " elements");
        Console.WriteLine();
        
        int temp = Convert.ToInt32(Console.ReadLine());
        while (temp > max || temp < min)
        {
            Console.WriteLine("Incorrect number!!!");
            Console.WriteLine();
            Console.WriteLine("Input number between: " + min + " & " + max);
            temp = Convert.ToInt32(Console.ReadLine());
        }
        anyArray[i] = temp; nxt-=1;

    }
    return anyArray;
}

void WriteMass(int[] anyArray)
{
    for (int i = 0; i < anyArray.Length; i++)
    {
        Console.Write(" " + anyArray[i]);
    }
    Console.WriteLine();
}

int min = 0, max = 10, len = 8;

int[] Current = GetArray(len, min, max);
WriteMass(Current);
