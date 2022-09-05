// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] CreateRandomArray(int a)
{
    double[] RandomArray = new double[a];
    for (int i = 0; i < a; i++)
    {
        RandomArray[i] = new Random().Next(1, 100);
    }
    return RandomArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите кол-во элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] MyRandomArray = CreateRandomArray(num);
ShowArray(MyRandomArray);
double min = MyRandomArray[0];
double max = MyRandomArray[0];
for (int z = 0; z < MyRandomArray.Length; z += 1)
{
    if (MyRandomArray[z] > max)
        {
            max = MyRandomArray[z];
        }
    if (MyRandomArray[z] < min)
        {
            min = MyRandomArray[z];
        }
}
Console.Write($"Min = {min}, Max = {max},разница между min и max = " + (max - min));

