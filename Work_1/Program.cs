// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();

Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("Первая четверть.");
} 
if (X<0 && Y>0)
{
    Console.WriteLine("Вторая четверть.");
} 
if (X<0 && Y<0)
{
    Console.WriteLine("Третья четверть.");
} 
if (X>0 && Y<0)
{
    Console.WriteLine("Четвертая четверть.");
} 

