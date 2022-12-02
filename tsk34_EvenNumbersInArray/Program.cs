// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int arSize = ReadArSize("Enter the dimension of the array ... ");
int [] numbers = new int[arSize];

ArrayFillingRandomNumbers(numbers);
PrintArray(numbers);
int evenElements = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenElements++;
    }
}
if (evenElements == 1)
{
    Console.WriteLine($"There is {evenElements} even number in the array");
}
else
    Console.WriteLine($"There are {evenElements} even numbers in the array");

// Методы

int ReadArSize(string message)  // Функция ввода размерности массива
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ArrayFillingRandomNumbers(int [] array) // Функция заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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