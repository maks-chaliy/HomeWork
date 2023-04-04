// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int UserNumber()
{
  Console.WriteLine("Введи любое пятизначное число");
  return int.Parse(Console.ReadLine());
}

void ValidateUserNumber()
{
  int num = UserNumber();
  if (num.ToString().Length != 5)
  {
    Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз");
    ValidateUserNumber();
  }
}

//int RandomNumber()
//{
//  return new Random().Next(10000, 100000);
//}

void Palindrom()
{
  int number = UserNumber();
  //int number = RandomNumber();
  ValidateUserNumber();
  int firstSymbol = number / 10000;
  int lastSymbol = number % 10;
  int secondSymbol = (number / 1000) % 10;
  int penultimateSymbol = (number % 100) / 10;

  if (firstSymbol == lastSymbol && secondSymbol == penultimateSymbol)
  {
    Console.WriteLine($"Число {number} является палиндромом");
  }
  else
  {
    Console.WriteLine($"Число {number} не палиндром");
  }
}

Palindrom();