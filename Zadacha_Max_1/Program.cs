Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine(numberA + " является большим (максимальным) из двух чисел");
}
else
{
    Console.WriteLine(numberB + " является большим (максимальным) из двух чисел");
}