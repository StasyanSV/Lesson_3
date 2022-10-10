// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.WriteLine ("Введите координаты первой точки: ");
int Xa = int.Parse(Console.ReadLine());
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите координаты второй точки: ");
int Xb = int.Parse(Console.ReadLine());
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine ($"Координаты первой точки: ({Xa},{Xb}) ");
Console.WriteLine ($"Координаты второй точки: ({Ya},{Yb}) ");

double distance = Math.Sqrt(Math.Pow(Xb-Xa,2) + Math.Pow(Yb-Ya,2));

Console.WriteLine ($"Расстояние между двумя точками: {distance}");