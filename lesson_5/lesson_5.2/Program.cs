// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] arrayRandom = ArrayRandom(lengthArray, minValue, maxValue);

int SumElements(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 1) sum += array[i];;
  }
  return sum;
}

int result = SumElements(arrayRandom);
Console.WriteLine(result);