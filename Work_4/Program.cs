// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Clear();

Console.Write("Введите целое число N: ");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i <= N)
{
    Console.Write(Math.Pow(i,2) + " ");
    i++;
}