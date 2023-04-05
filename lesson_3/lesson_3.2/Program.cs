// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinats(string argument)
{
  Console.Write($"Enter coordinats dotts {argument}:");
  int number = int.Parse(Console.ReadLine());
  
  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Not a number");
  }
  return number;
}

double Distance()
{
  int x1 = Coordinats("x1");
  int y1 = Coordinats("y1");
  int z1 = Coordinats("z1");
  int x2 = Coordinats("x2");
  int y2 = Coordinats("y2");
  int z2 = Coordinats("z2");
  double resultDistance = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
  return resultDistance;
}

Console.WriteLine($"Distance between dotts: {Distance()}");