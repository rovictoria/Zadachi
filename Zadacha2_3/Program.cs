// Программа, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

void AB()
{
    Console.Write("Введите X1 точки А: ");
    int X1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите Y1 точки А: ");
    int Y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите Z1 точки А: ");
    int Z1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите X2 точки В: ");
    int X2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите Y2 точки В: ");
    int Y2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите Z2 точки В: ");
    int Z2 = Convert.ToInt32(Console.ReadLine());
    
    double lengthAB = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
    Console.WriteLine($"Длина отрезка AB между точками A({X1},{Y1},{Z1}) и B({X2},{Y2},{Z2}) равна {lengthAB:f2}");   //  :f2  - сколько знаков после запятой 
}

AB();