// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//==================================================
//при запуске NumberInDegree() почему то 2 раза идет запрос UserNumber() и UserDegree()
//и не пойму почему так происходит
//при втором запросе происходит считывание данных

int UserNumber()
{
  int userNumber;
  Console.Write("Input integer number: ");
  if (!int.TryParse(Console.ReadLine(), out userNumber))
  {
    Console.WriteLine("it's not an integer");
  }
  return userNumber;
}

int UserDegree()
{
  int userDegree;
  Console.Write("Input degree of the number: ");
  if (!int.TryParse(Console.ReadLine(), out userDegree))
  {
    Console.WriteLine("it's not an integer");
  }
  return userDegree;
}

void NumberInDegree()
{
  int number = UserNumber();
  int degree = UserDegree();
  int resultNumberInDegree = 1;
  for(int i = 1; i <= degree; i++)
  {
    resultNumberInDegree *= number;
  }
  Console.WriteLine($"number {UserNumber()} in degree {UserDegree()} = {resultNumberInDegree}");
}

NumberInDegree();

//==================================================
//если весь код поместить в одну функцию то двойного запроса нет

/*
void NumberInDegree()
{
  int userNumber;
  Console.Write("Input integer number: ");
  if (!int.TryParse(Console.ReadLine(), out userNumber))
  {
    Console.WriteLine("it's not an integer");
  }

  int userDegree;
  Console.Write("Input degree of the number: ");
  if (!int.TryParse(Console.ReadLine(), out userDegree))
  {
    Console.WriteLine("it's not an integer");
  }

  int resultNumberInDegree = 1;
  for(int i = 1; i <= userDegree; i++)
  {
    resultNumberInDegree *= userNumber;
  }
  Console.WriteLine($"number {userNumber} in degree {userDegree} = {resultNumberInDegree}");
}
*/