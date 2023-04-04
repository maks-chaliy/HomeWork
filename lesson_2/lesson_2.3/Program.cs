// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOFtheWeek()
{
  Console.Write("Введите номер дня недели: ");
  string numberDay = Console.ReadLine();
  CheckingDay(numberDay);
}

void CheckingDay(string numberDay)
{
  switch (numberDay)
  {
    case "1":
    case "2":
    case "3":
    case "4":
    case "5": Console.WriteLine("рабочий день"); break;
    case "6":
    case "7": Console.WriteLine("выходной день"); break;
    default: Console.WriteLine("нет такого дня"); break;
  }
}

DayOFtheWeek();