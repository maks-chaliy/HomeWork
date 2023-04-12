// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ArrayRandom(int lengthArray, int minValue, int maxValue)
{
  int[] arrayRandom = new int[lengthArray];
  Console.Write("[");
  for (int i = 0; i < arrayRandom.Length; i++)
  {
    arrayRandom[i] = new Random().Next(minValue, maxValue);
    Console.Write($"{arrayRandom[i]}, ");
  }
  Console.WriteLine("]");
  return arrayRandom;
}

int ArrayNumbers(string arguments)
{
  Console.Write($"Enter {arguments}: ");
  return int.Parse(Console.ReadLine());
}

int lengthArray = ArrayNumbers("length array");
int minValue = ArrayNumbers("minimum three-digit number array");
int maxValue = ArrayNumbers("maximum three-digit number array");

//void PrintArray(int[] array)
//{
//  Console.Write("[");
//  for (int i = 0; i < array.Length; i++)
//  {
//    Console.Write($"{array[i]}, ");
//  }
//  Console.WriteLine("]");
//}

//PrintArray(ArrayRandom(lengthArray, minValue, maxValue));
int[] arrayRandom = ArrayRandom(lengthArray, minValue, maxValue);

int showEvenNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
  return count;
}

int countEvenNumbers = showEvenNumbers(arrayRandom);
Console.WriteLine($"Qauntity enen numbers in array: {countEvenNumbers}");