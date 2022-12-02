//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0

int arraySize = ReadInt("Enter the dimension of the array ... ");
int minElement = ReadInt("Enter a lower limit for array elements: ");
int maxElement = ReadInt("Enter an upper limit for array elements: ");
int [] numbers = new int[arraySize];

ArrayFillingRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"The sum of the array elements in odd positions = {result}");

// Методы

int ReadInt(string message)  // Функция ввода с консоли
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ArrayFillingRandomNumbers(int [] array) // Функция заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minElement, maxElement);
    }
}

void PrintArray(int[] array) // Функция вывода массива на экран
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}