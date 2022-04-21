//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Temp(int num)
{
    int tmp = ((num - (num / 100) * 100) - num % 10) / 10;
    return tmp;
}

Console.WriteLine("Input three-digit integer number (-999 to 999)");
int num = Convert.ToInt32(Console.ReadLine());

if (num > -1000 & num < -99)
{
    Console.WriteLine(Temp(num));
}
if (num < 1000 & num > 99)
{
    Console.WriteLine(Temp(num));
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

int Length(int num)
{
    int tmp = num;
    while (tmp / 1000 > 0)
    {
        tmp = (tmp - (tmp % 10)) / 10;
    }
    tmp = tmp % 10;
    return tmp;
}

Console.WriteLine("Input integer number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Length(num));

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



Console.WriteLine("Input number of weekday");
int day = Convert.ToInt32(Console.ReadLine());

void CorrectDay ()
{
    while (day<1 || day>7)
        {
        Console.WriteLine("Input correct number of weekday");
        int day = Convert.ToInt32(Console.ReadLine());
        }
}  

void DayOfWeek ()
{
        if(day>5)
        {
            Console.WriteLine("weekend");
        }
        else 
            Console.WriteLine("weekday");
}

CorrectDay ();
DayOfWeek();



