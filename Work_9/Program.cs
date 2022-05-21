// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


//Metod 1;
/*
int InterSum(int num1, int num2, int sum, int mod)
{
    if (num1 == num2 + 1 * (mod))
        return sum;
    sum += num1;
    return InterSum(num1 + 1 * (mod), M, sum, mod);
}
int N = 15; int M = 1;
int mod = 1;
if (N > M) mod = -1;
Console.WriteLine(InterSum(N, M, 0, mod));
*/

//Metod 2;
/*
int Arif(int N, int M)
{
    int sum = (N + M) / 2 * (M - N + 1);
    return sum;
}
int N = 1; int M = 15;
Console.WriteLine(Arif(N, M));
*/


//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int NumSumm(int num, int sum)
{
    if (num == 0) return sum;
    sum += num % 10;
    return NumSumm((num - num % 10) / 10, sum);
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumSumm(num, 0));
*/