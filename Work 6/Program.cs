//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

int[] IsArray()
{
    int[] array = new int[1];
    int input = 1;
    Console.WriteLine("Input any count of numbers; 0 is exit");
    for (int n = 0; input != 0; n++)
    {
        Console.WriteLine("Next number: is " + (n+1));
        input = Convert.ToInt32(Console.ReadLine());
        
        if (input!=0) 
        {
            array[n] = input;
            Array.Resize(ref array, array.Length + 1);
        }
    }   
    Array.Resize(ref array, array.Length - 1);
    return array;
}

int Count(int[] array)
{   
    int cnt=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) cnt++;
    }
    return cnt;
}

void Shov(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Element " + (i+1) + " is : " + array[i]);
    }
}

//Console.WriteLine(IsArray().Length);
int []MyArray = IsArray();
Shov(MyArray);
Console.WriteLine("Number of  elements much 0 is: " + Count(MyArray));

*/





//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Итерационный вариант.

/*
string Sys2Metod(int dex)
{
    string binary = "";
    while (dex>1)
    {
        int cel = dex / 2;
        int ost = dex - 2 * cel;
        string c = Convert.ToString(ost);
        binary = c + binary;
        dex=cel;
    }
    string d = Convert.ToString(dex);
    binary=d+binary;
    return binary;
}    

Console.WriteLine("Input DEX number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number in  binary system:  "+Sys2Metod(input));

*/

// Рекурсивный вариант)

/*
string Sys2Metod(int dex, string binary)
{
    if (dex <= 1)
    {
        string d = Convert.ToString(dex);
        binary = d + binary;
        return binary;
    }
    return Sys2Metod(dex / 2, Convert.ToString(dex - 2 * (dex / 2)) + binary);
}

Console.WriteLine("Input DEX number: ");
int input = Convert.ToInt32(Console.ReadLine());
string bin = "";
Console.WriteLine("Number in  binary system:  " + Sys2Metod(input, bin));

*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


// Вариант номер 1))) Буквальный, как если бы не умел преобразовывать уравнения))). Проверенный. Заморочился люто на нём) чинил пока не понял почему не работает. 

// Но починил.

/*
double Y1(double x, int k1, int b1)
{
    double y = k1 * x + b1;
    return y;
}

double Y2(double x, int k2, int b2)
{
    double y = k2 * x + b2;
    return y;
}

double[] calc(int k1, int k2, int b1, int b2)
{
    double[] anyArr = new double[2];
    for (double x = -10; x < 11; x += 0.0005)
    {
        int z1 = (int) Y1(x, k1, b1);
        int z2 = (int) Y2(x, k2, b2);
        //Console.WriteLine("Y1: " + z1);
        //Console.WriteLine("Y2: " + z2);
        if (z1 == z2)
        {
            anyArr[0] = x;
            anyArr[1] = Y1(x, k1, b1);
            return anyArr;
        }

    }
    return anyArr;
}

int input(string X)
{
    Console.WriteLine("input " + X + ": ");
    int Z = Convert.ToInt32(Console.ReadLine());
    return Z;
}

int K1 = input("K1");
int K2 = input("K2");
int B1 = input("B1");
int B2 = input("B2");

double[] resArr = calc(K1, K2, B1, B2);

if ((resArr[0] != 0) && (resArr[1] != 0)) 
    Console.WriteLine("Coords of across is: X ~   " + Math.Round(resArr[0], 3) + "   Y ~  " + Math.Round(resArr[1], 3));
else Console.WriteLine("Have No Coords of across in current values  (X-10 to 10)");

*/


// Вариант номер 2- упрощенная универсальная версия.

// т.к. Y будет одинаково и в 1 и во 2 уравнении, то его упрощаем и получаем:
// K1*X + B1 = K2*X + B2  =>  K1X -K2X = B2 - B1  =>  X(K1-K2) = B2-B1  =>  X = (B2-B1)/(K1-K2)
// Теперь у нас есть формула для определения X.

 /*
double input(string X)
{
    Console.WriteLine("input " + X + ": ");
    double Z = Convert.ToInt32(Console.ReadLine());
    return Z;
}

double K1 = input ("K1");
double K2 = input ("K2");
double B1 = input ("B1");
double B2 = input ("B2");

double X = (B2-B1)/(K1-K2);
double Y = K1*X+B1;

Console.WriteLine();
Console.WriteLine("point of across!  X: " + X + "   Y: "+ Y);

 */