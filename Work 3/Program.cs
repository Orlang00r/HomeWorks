//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void poli(int n)
{
    int n1 = n / 10000;
    int n2 = n % 10;
    int n3 = n / 1000 - n1 * 10;
    int n4 = (n % 100 - n2) / 10;
    if (n1 == n2 && n3 == n4)
    {    
        Console.WriteLine("number is polyndrome");
    }
    else
    {
        Console.WriteLine("number is not polyndrome");
    }
}

void CorrNum(int n0)
{
    while (n0 < 10000 || n0 >99999)
    {
        Console.WriteLine("Input number between 10000 & 99999");
        n0 = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Input number between 10000 & 99999");
int num = Convert.ToInt32(Console.ReadLine());

CorrNum(num);
poli(num);

*/


//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Range(int x1,  int x2, int y1, int y2, int z1, int z2)
{
    double x = Math.Pow((x2-x1), 2);
    double y = Math.Pow((y2-y1), 2);
    double z = Math.Pow((z2-z1), 2);
    double rng = Math.Sqrt(x+y+z);
    return rng;
}

int Generate()
{
  int nmb = new Random().Next(-10, 10);
    return nmb;
}


int nxt = 0;
int[] array = new int[6];
while (nxt < 6)
{
    array[nxt] = Generate();
    if (nxt == 0)
        Console.WriteLine("X1 = " + array[nxt]);
    else if (nxt == 1)
        Console.WriteLine("X2 = " + array[nxt]);
    else if (nxt == 2)
        Console.WriteLine("Y1 = " + array[nxt]);
    else if (nxt == 3)
        Console.WriteLine("Y2 = " + array[nxt]);
    else if (nxt == 4)
        Console.WriteLine("Z1 = " + array[nxt]);
    else
        Console.WriteLine("Z2 = " + array[nxt]);
    nxt++;
}

double result = Range(array[0], array[1], array[2], array[3], array[4], array[5]);
Console.WriteLine("Range is: " + result);

*/


