// Cakc10=>2 recurs

/*
string Sys2Metod(int dex, string binary)
{
    if (dex >= 1) return Sys2Metod(dex / 2, Convert.ToString(dex%2) + binary);
    return binary;
}

Console.WriteLine("Input DEX number: ");
int input = Convert.ToInt32(Console.ReadLine());
string bin = "";
Console.WriteLine("Number in  binary system:  " + Sys2Metod(input, bin));
*/



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Метод для выведение символа по коду

/*
char Str(int asc)
{
    char str = Convert.ToChar(asc);
    return str;
}
*/



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Конвертер значений между системами от 2х до 16х

/*
int Ord(string smb)
{
    //Console.WriteLine(smb + "  "+smb);
    int rez = 0;
    rez = Char.ConvertToUtf32(smb, 0);
    return rez;
}

char Str(int asc)
{
    char str = Convert.ToChar(asc);
    return str;
}

string[] Arr(string str)
{
    string[] arr = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = str[i].ToString();
    }
    return arr;
}

int MetodTo10x(string[] num, int i, int dex, int ind1)
{
    while (i < num.Length)
    {
        string curCh = num[i];
        if (Ord(curCh) >= Ord("A"))
        {
            int zn = Ord(curCh) - Ord("A") + 10;
            dex = dex + zn * Convert.ToInt32(Math.Pow(ind1, (num.Length - i) - 1));
            return MetodTo10x(num, i + 1, dex, ind1);
        }

        else
        {
            int zn = Convert.ToInt32(curCh);
            dex = dex + zn * Convert.ToInt32(Math.Pow(ind1, (num.Length - i) - 1));
            return MetodTo10x(num, i + 1, dex, ind1);
        }
    }
    return dex;
}

string EndVal(string endV, int dex1, int ind2)
{
    while (dex1 >=1)
    {
        int ost = dex1 % (ind2);
        if (ost > 9)
        {
            endV = Str(Ord("A") - 10 + ost) + endV;
        }
        else
        {
            endV = ost.ToString() + endV;
        }
        return EndVal(endV, dex1 / ind2, ind2);
    }
    return endV;
}

Console.WriteLine("Введите индекс изначильный системы: 2 - 16: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс конечной системы: 2 - 16:");
int index2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для преобразования: ");
string numIn = 0 + Convert.ToString(Console.ReadLine());

string endVal = "";
string[] numStr = Arr(numIn);
int Ln = numStr.Length;
int dex = MetodTo10x(numStr, 0, 0, index1);

string result = EndVal(endVal, dex, index2);
Console.WriteLine();
Console.WriteLine(" Переведено в десятичную систему: " + dex);
Console.WriteLine();
Console.WriteLine(" Переведено в конечную систему: " + result);

*/

void FillMatrix(int[,] a, int N)
{
    for (int ik = 0; ik < N; ik++)
        for (int jk = 0; jk < N; jk++)
        {
            int i = ik + 1; // Превод в уддобную для подсчёта форму
            int j = jk + 1;
            int switcher = (j - i + N) / N; // Задаём матрицу переключателя направления движения (направо => вниз / налево => вверх)
            int iCentr = Math.Abs(i - N / 2 - 1) + (i - 1) / (N / 2) * ((N - 1) % 2);   // Определяем близость к центру по i с учетом четности стороны
            int jCentr = Math.Abs(j - N / 2 - 1) + (j - 1) / (N / 2) * ((N - 1) % 2);   // Определяем близость к центру по j с учетом четности стороны
            int centr = N / 2 - (Math.Abs(iCentr - jCentr) + iCentr + jCentr) / 2; // Задаём матрицу близости к центру кольца от центра.
            int doubleLine = i - centr + j - centr - 1; // Вычисляем промежуточное значение согласно матрице
            int ringCoef = 4 * centr * (N - centr); // Вычисляем коэффициент прироста текущего кольца
            a[ik, jk] = ringCoef + switcher * doubleLine + Math.Abs(switcher - 1) * (4 * (N - 2 * centr) - 2 - doubleLine); // Вычисляем текущее значение
            //  с учётом тдаленности текущего кольца и переключателя направления заполнения.
        }
}

Console.WriteLine("Input count elements direction of matrix: ");
int count = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[count, count];
FillMatrix(array, count);
for (int ik = 0; ik < count; ik++)
{
    for (int jk = 0; jk < count; jk++)
        Console.Write(" \t " + array[ik, jk]);
    Console.WriteLine();
}
