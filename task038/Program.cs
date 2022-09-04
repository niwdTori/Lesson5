// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1,100);
    }
}

double[] array = new double[5];
FillArray(array);
Console.WriteLine(string.Join(",", array));

double max = array[0];
double min = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
}
double diff = max - min;
Console.WriteLine(diff);