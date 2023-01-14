/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] arr = GetArray(8);
Console.WriteLine($"[ {String.Join(", ", arr)} ]");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i=0; i<size; i++)
    {
        result [i] = new Random().Next(1,100);
    }
    return result;
}
*/

int[] arr = GetArray(8);
Console.WriteLine($"[ {String.Join(", ", arr)} ]");

int[] GetArray(int size)
{
    Console.Write($"Введите числа массива из {size} элементов: ");
    int[] result = new int[size];
    for (int i=0; i<size; i++)
    {
        result [i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}