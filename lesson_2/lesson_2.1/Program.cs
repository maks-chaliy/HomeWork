// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int RandomNumber()
{
  return new Random().Next(100, 1000);
}

void DigitInNumber()
{
  string number = RandomNumber().ToString();
  Console.WriteLine($"Трехзначное число - {number}");
  Console.WriteLine($"Вторая цифра этого числа - {number[1]}");
}

DigitInNumber();