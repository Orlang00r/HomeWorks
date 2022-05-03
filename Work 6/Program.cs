//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


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