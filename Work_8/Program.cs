// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

/*
int[,] FillArray(int size1, int size2)
{
    int[] arrayLine = new int[size2];
    int[,] matrix = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            arrayLine[j] = matrix[i, j];
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
        Sort(arrayLine, 0, 3);
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = arrayLine[j];
        }
    }
    return matrix;
}

int Partition(int[] array, int start, int end)
{
    int marker = start;
    for (int i = start; i < end; i++)
    {
        if (array[i] < array[end])
        {
            (array[marker], array[i]) = (array[i], array[marker]);
            marker += 1;
        }
    }

    (array[marker], array[end]) = (array[end], array[marker]);
    return marker;
}

void Sort(int[] array, int start, int end)
{
    if (start >= end)
        return;

    int pivot = Partition(array, start, end);
    Sort(array, start, pivot - 1);
    Sort(array, pivot + 1, end);
}

void ArrayView(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


int[,] MyArray = FillArray(4, 4);
Console.WriteLine();
ArrayView(MyArray);

*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[] FillArray(int size1, int size2)
{
    int[] arrayLine = new int[size1];
    int[,] matrix = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        int sum = 0;
        for (int j = 0; j < size2; j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
            sum += matrix[i, j];
            Console.Write(matrix[i, j] + "\t");
        }
        arrayLine[i] = sum;
        Console.WriteLine(sum);
    }
    return arrayLine;
}

void MaxArrayLine(int[] array)
{
    int min = array[0];
    int str = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { str = i; min = array[i]; }
    }
    Console.WriteLine("Min line is: " + (str+1));
}
MaxArrayLine (FillArray(9, 5));

*/





// Задача 62. Заполните спирально массив 4 на 4.



// Метод 1; С использованием рекурсии.

// Z is 0 , iAdd is 1, jAdd is 2, i is 3, j is 4, num is 5, cont is 6, cycle is 7, ring is 8, totalNum is 9,

/*
void PrintArray(int[]Data, int [,]matrix)
{
    for (int i = 0; i < Data[0]; i++)
    {
        for (int j = 0; j < Data[0]; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
        
}

int[] WriteLine(int[] Data, int[,] matrix) // Заполняет линию в одну сторону
{
    Data[6]++; // cont+1
    matrix[Data[3], Data[4]] = Data[5]; // matrix (i,j)=num;
    Data[5]++; // num++
    Data[3] += Data[1]; //движение по i
    Data[4] += Data[2]; //движение по j
    if (Data[6] < ((Data[0] - 1) - Data[8])) return WriteLine(Data, matrix); // recurs
    Data[7]++; // прирост значения цикла
    return Data;  // return Data
}

int FillCycle(int[,] matrix, int[] Data, int N)
{

    if (Data[5] == Data[9] + 1) return 0;
    if ((Data[7] + 4) % 4 == 0) { Data[1] = 0; Data[2] = 1; } // Определение направления заполнения
    if ((Data[7] + 4) % 4 == 1) { Data[1] = 1; Data[2] = 0; }
    if ((Data[7] + 4) % 4 == 2) { Data[1] = 0; Data[2] = -1; }
    if ((Data[7] + 4) % 4 == 3) { Data[1] = -1; Data[2] = 0; }
    Data = WriteLine(Data, matrix);
    if ((Data[7] + 4) % 4 == 0)  // проверка окончания кольца
    {
        Data[8] += 2; // поправочный коэффициент очередного кольца
        Data[1] = 0; Data[2] = 0; // обнуление прироста
        Data[3] = Data[8] / 2; Data[4] = Data[8] / 2; // установка координат очередного круга
    }
    Data[6] = 0; // Обнуление счетчика смещения по линии
                 // Установка старотовой позиции след.кольца
    return FillCycle(matrix, Data, N); // возвращение функции себе

}

int Z = 7;
int[] Data = new int[11];
int[,] MyArray = new int[Z, Z];
Data[0] = Z; Data[1] = 0; Data[2] = 0; Data[3] = 0; Data[4] = 0; Data[5] = 1; Data[6] = 0; Data[7] = 0; Data[8] = 0;
Data[9] = Convert.ToInt32(Math.Pow(Z, 2));

FillCycle(MyArray, Data, Data[0]);
PrintArray(Data,MyArray);

*/


// Метод 2 - вычислительный. Алгоритм не сам придумал, но перелопатил под С# с пояснениями

/*
void FillMatrix(int[,] a, int N)
{
    for (int ik = 0; ik < N; ik++)
        for (int jk = 0; jk < N; jk++)
        {
            int i = ik + 1; // Превод в удобную для подсчёта форму
            int j = jk + 1;
            int switcher = (j - i + N) / N; // Задаём матрицу переключателя направления движения (направо => вниз / налево => вверх)
            int iCentr = Math.Abs(i - N / 2 - 1) + (i - 1) / (N / 2) * ((N - 1) % 2);   // Определяем близость к центру по i с учетом четности стороны
            int jCentr = Math.Abs(j - N / 2 - 1) + (j - 1) / (N / 2) * ((N - 1) % 2);   // Определяем близость к центру по j с учетом четности стороны
            int centr = N / 2 - (Math.Abs(iCentr - jCentr) + iCentr + jCentr) / 2; // Задаём матрицу близости к центру кольца от центра.
            int doubleLine = i - centr + j - centr - 1; // Вычисляем промежуточное значение согласно матрице
            int ringCoef = 4 * centr * (N - centr); // Вычисляем коэффициент прироста текущего кольца
            a[ik, jk] = ringCoef + switcher * doubleLine + Math.Abs(switcher - 1) * (4 * (N - 2 * centr) - 2 - doubleLine); // Вычисляем текущее значение
            //  с учётом отдаленности текущего кольца и переключателя направления заполнения.
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

*/

