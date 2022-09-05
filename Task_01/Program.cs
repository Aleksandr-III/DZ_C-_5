// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] CreateRandomArray(int a)
{
    int[] RandomArray = new int[a];
    for (int i = 0; i < a; i++)
    {
        RandomArray[i] = new Random().Next(100, 1000);
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
Console.WriteLine("-------------");
int count = 0;
for (int z = 0; z < MyRandomArray.Length; z++)
   {
    if (MyRandomArray[z] % 2 == 0)
    count++;
   }

Console.WriteLine($"Всего {MyRandomArray.Length} чисел, {count} из них чётные");






