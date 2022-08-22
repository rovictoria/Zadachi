// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2;  // работает если я не придаю значение, это же не обязательно? могу придать 0
int number23; // и тут тоже

if(number > 99 && number < 1000)
{
   number23 = number % 100;
   number2 = number23 / 10;
   Console.WriteLine($"Было {number}");
   Console.WriteLine($"Cтало {number2}"); 
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число, повторите ввод");
}