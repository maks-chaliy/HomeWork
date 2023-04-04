// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void StartGame()
{
  Console.Write("Для продолжения игры нажмите - y, для выхода нажмите - n: ");
  string enterData = Console.ReadLine();
  bool work = true;
  while (work)
  {
    switch (enterData)
    {
      case "y": EnterNumber(); break;
      case "n": work = false; break;
      default: StartGame(); break;
    }
  }

}

void EnterNumber()
{
  Console.Write("Ведите число не менее 3-х символов: ");
  string number = Console.ReadLine();
  ValidateNumber(number);
  Console.WriteLine($"Третья цифра заданного числа: {number[2]}");
}

void ValidateNumber(string number)
{
  if (number.Length < 3)
  {
    Console.WriteLine("Вы ввели менее 3-х цифр");
    EnterNumber();
  }
}

StartGame();
