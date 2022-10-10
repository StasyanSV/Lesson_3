// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверти ( 1, 2, 3 или 4): ");
int number_1 = int.Parse(Console.ReadLine());

switch (number_1)
{
    case 1:
        Console.WriteLine("Первой четверти соответсвует следующий диапазон координат: ");
        Console.Write("X >= 0 и Y >=0 ");
        break;
    case 2:
        Console.WriteLine("Второй четверти соответсвует следующий диапазон координат: ");
        Console.Write("X <= 0 и Y >=0 ");
        break;
    case 3:
        Console.WriteLine("Третьей четверти соответсвует следующий диапазон координат: ");
        Console.Write("X <= 0 и Y <=0 ");
        break;
    case 4:
        Console.WriteLine("Четвертой четверти соответсвует следующий диапазон координат: ");
        Console.Write("X >= 0 и Y <=0 ");
        break;
    default:
        Console.Write("Введенное число не соответсвует условию задачи!");
        break;
}
