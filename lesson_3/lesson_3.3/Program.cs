// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125;

int UserNumber()
{
  Console.Write("Введите любое число: ");
  return int.Parse(Console.ReadLine());
}

void CubeNumbers()
{
  int num = UserNumber();
  for(int i = 1; i < num + 1; i++)
  {
    int resultNumber = i * i * i;
    Console.WriteLine($"{i} в кубе {resultNumber}");
  }
}

CubeNumbers();