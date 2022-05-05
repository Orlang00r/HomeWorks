// Cakc10=>2 recurs

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

// Подсчет вводимых элементов массива >0. 

/*

int[] IsArray(int[] array, int n, int input)
{
    if (n == 0)
        Console.WriteLine("Input any count of numbers; 0 is exit");
    if (input != 0)
    {   
        Console.WriteLine("Next number: is " + (n + 1));
        Array.Resize(ref array, array.Length + 1);
        input = Convert.ToInt32(Console.ReadLine());
        array[n] = input;
        return IsArray(array, n + 1, input);
    }
    Array.Resize(ref array, array.Length - 2);
    return array;
}

int Count(int[] array, int cnt, int i)
{
    if (i < array.Length)
    {
        if (array[i] > 0) return Count(array, cnt+1, i+1);
        return Count(array, cnt, i+1);
    }
    return cnt;
}

void Shov(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine("Element " + (i + 1) + " is : " + array[i]);
}

int[] arr = new int[1];
int N = 0;
int[] MyArray = IsArray(arr, N, 1);
Shov(MyArray);
Console.WriteLine("Number of  elements much 0 is: " + Count(MyArray, 0, 0));

*/


// Программа проверяет, являтся ли первое число степенью второго.

/*
double Degree(int a, int b, int res)
{
    if ((a / b) * b == a) return Degree((a / b), b, res + 1);
    return res + 1;
}
double result = -1;
int res = -1;
Console.WriteLine();
Console.WriteLine("Программа настроена на положительные числа");
Console.WriteLine();
Console.WriteLine("Введите проверяемое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите проверочное число: ");
int deg = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
deg = Math.Abs(deg);
if (num == 1 && deg != 1) Console.WriteLine(num + " является " + 0 + " Степенью числа " + deg);
if (num == 1 && deg == 1) Console.WriteLine(num + " является " + 1 + " Степенью числа " + deg);
if (num != 1 && deg != 1) result = Degree(num, deg, res);
if (result > 0) Console.WriteLine(num + " является " + result + " Степенью числа " + deg);
else
    if (num != 1) Console.WriteLine(num + " не является степенью числа " + deg);
*/

// Расчет длины массива необходимого под перевод десятичного в довичное число.

/*
int Len (int number10, int length)
{
    number10=number10/2;
    if (number10 > 0) return Len(number10, length+1);
    return length;
}
Console.WriteLine("Input number");
int len = Len(Convert.ToInt32(Console.ReadLine()),1);
Console.WriteLine(len);
*/



// Программа позволяет получить код вводимого символа, если символ пустой, то выводит код пробела.
// Метод реализован для символа, программа реализована, как защита от ввода пустого символа,что приводит к ошибкам.

/*
int Asc(string smb)
{
    int rez = 0;
    if (smb.Length==1) rez = Char.ConvertToUtf32(smb, 0);
    return rez;
}

string str = " " + Convert.ToString(Console.ReadLine());
if (str.Length>1) str = str.Substring(1);
    Console.WriteLine(Asc(str));
*/



// Метод для выведение символа по коду

/*
char Str(int asc)
{
    char str = Convert.ToChar(asc);
    return str;
}
*/

