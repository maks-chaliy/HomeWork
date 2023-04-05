// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Number()
{
  int num;
  Console.Write("Input any integer number: ");
  while (!int.TryParse(Console.ReadLine(), out num))
  {
    System.Console.WriteLine("Input not a number");
  }
  return num;
}

int SumNumber()
{

  int number = Number();
  int result = 0;
  while(number > 0)
  {
    result += number % 10;
    number = number / 10;
  }
  return result;
}

Console.WriteLine(SumNumber());