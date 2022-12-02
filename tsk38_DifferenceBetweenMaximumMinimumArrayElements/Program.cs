// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int arraySize = ReadInt("Enter the dimension of the array: ");
int lowerLimit = ReadInt("Enter a lower limit for array elements: ");
int upperLimit = ReadInt("Enter an upper limit for array elements: ");
int [] numbers = new int[arraySize];

ArrayFillingRandomNumbers(numbers);
PrintArray(numbers);

int minArrayElement = numbers[0];
int maxArrayElement = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minArrayElement)
    {
        minArrayElement = numbers[i];
    }
    if (numbers[i] > maxArrayElement)
    {
        maxArrayElement = numbers[i];
    }
}
Console.WriteLine($"The difference between the maximum and minimum array elements = {maxArrayElement - minArrayElement}");

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
        array[i] = new Random().Next(lowerLimit, upperLimit);
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