// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
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

int Parity (int [] array)
{   int count = 0;
    for (int i =0; i<array.Length; i++)
        if(array[i]%2==0)
        count++;
        
    return count;
    
}

int [] mass1 = CreateRandomArray(10, 99, 1000);
ShowArray(mass1);
Console.WriteLine($"В Заданном массиве  {Parity(mass1)} четных чисел");