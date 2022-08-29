// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)


// Основной вариант решения задачи 
void Pow1()
{
    Console.Write("Введите А: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите B: ");
    int B = Convert.ToInt32(Console.ReadLine());

    int result  = 1 ;
    if(B != 0)
    {
        for(int i = 1; i <= B; i++)
        {
        result = result * A;
        }
    }
    Console.WriteLine($"{A} в степени {B} = {result}");
    
}

Pow1();

// Второй вариант решения задачи без цикла
double Pow2(int A, int B)
{
   double result = Math.Pow(A,B);
   Console.Write($"{A} в степени {B} = ");
   return result;
}

double res = Pow2(2,5);
Console.WriteLine($"{res}");


// Третий вариант решения задачи без цикла через void
void Pow()
{
    Console.Write("Введите А: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите B: ");
    int B = Convert.ToInt32(Console.ReadLine());

    double result = Math.Pow(A, B);
    Console.WriteLine($"{A} в степени {B} = {result}");
}

Pow();


// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
