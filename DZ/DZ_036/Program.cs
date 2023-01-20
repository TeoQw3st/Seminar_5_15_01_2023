// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int N, int start, int end)
{
int[] RandomArray = new int[N];
for (int i = 0; i < N; i++)
{
RandomArray[i] = new Random().Next(start, end + 1);
}
return RandomArray;
}


void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int Summn (int []array)
{   int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (i%2!=0)
            sum=sum+array[i];
    }
return sum;
}

int [] mass2 = CreateRandomArray(10, 99, 1000);
ShowArray(mass2);
Console.Write(Summn(mass2));