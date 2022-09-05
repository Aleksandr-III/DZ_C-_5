// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] CreateRandomArray(int a)
{
    int[] RandomArray = new int[a];
    for (int i = 0; i < a; i++)
    {
        RandomArray[i] = new Random().Next(-99, 100);
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


Console.Write("Введите кол-во элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] MyRandomArray = CreateRandomArray(num);
ShowArray(MyRandomArray);
int count = 1;
int sum = 0;
for (int z = 0; z < MyRandomArray.Length; z+=2)
   {
    sum = sum + MyRandomArray[z];
    count++;
    }
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {sum}");


