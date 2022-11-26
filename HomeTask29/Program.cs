// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
System.Console.WriteLine("ElementsCount");
var ElementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int [ElementsCount];
var Target = NameArray(array);
int[] NameArray(int[]arr)
{
     for(int i =0; i<arr.Length; i++)
    {
        Console.WriteLine($"number {i}");
        arr[i]=int.Parse (Console.ReadLine());
    }
    return arr;
 }

PrintArray(Target);

void PrintArray(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
