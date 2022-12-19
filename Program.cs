//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая 
// покажет количество чётных чисел в массиве.

/*
Console.WriteLine("input array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"result: {numbers.Length} , even numbers {count} ");
*/

// zadacha 2 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.WriteLine("Input array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"result {numbers.Length} , sum = {sum}");
*/


// zadacha 3
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.WriteLine("Input array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"result {numbers.Length} . max = {max}, min = {min}");
Console.WriteLine($"difference = {max - min}");
*/


