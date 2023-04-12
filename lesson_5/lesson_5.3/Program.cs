// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] RandomArray(int lengthArray, int minValue, int maxValue)
{
  double[] randomArray = new double[lengthArray];
  for (int i = 0; i < randomArray.Length; i++)
  {
    randomArray[i] = new Random().Next(minValue, maxValue);
    Console.Write($"{randomArray[i]}, ");
  }
  return randomArray;
}

int[] arrayRandom = RandomArray(10, -10, 10);
Console.WriteLine(arrayRandom);