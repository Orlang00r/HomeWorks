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


