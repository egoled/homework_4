// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
//  Оформите заполнение массива и вывод в виде функции 

void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
       Console.Write(A[i] + " ");
    }
}

int [] RandomArray(int Length)
{
    int[] array;
    array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}
int[] RandomArrayEight = RandomArray(8);
PrintArray(RandomArrayEight);

