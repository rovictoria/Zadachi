// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите X: ");
int X = Convert.ToInt32(Console.ReadLine());
    
Console.Write("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (X < 0 && Y > 0)
{
   Console.WriteLine("2 четверть");  
}
else if (X < 0 && Y < 0)
{
   Console.WriteLine("3 четверть");
}
else if (X > 0 && Y < 0)
{
   Console.WriteLine("4 четверть");
}
