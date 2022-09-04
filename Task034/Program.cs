// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100,1000);
    }
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine(string.Join(",", array));

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0) count++;
}
Console.WriteLine(count);