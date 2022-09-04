// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-100,100);
    }
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine(string.Join(",", array));

int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i%2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine(sum);