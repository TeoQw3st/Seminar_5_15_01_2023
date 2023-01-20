// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

int FindMax (int []array)
{
    int maxim = array[0];
    for (int i = 0; i < array.Length; i++) 
    if (array[i]>maxim)
    maxim = array[i];
return maxim;    
}
int FindMin (int []array)
{
    int minim = array[0];
    for (int i = 0; i < array.Length; i++) 
    if (array[i]<minim)
    minim = array[i];
return minim;    
}

int [] mass3 =CreateRandomArray(10, 0, 20);
ShowArray(mass3);
int max = FindMax(mass3);
int min = FindMin(mass3);
Console.WriteLine($" {max} - {min} = {max - min}");