// найти Max из двух введённых чисел

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Фигурные скобки можно было опустить, учитывая что внутри только по одному действию, тренировала
// логическую насмотренность в большом количестве условий

if(numberA > numberB)
{
    Console.WriteLine("max = " + numberA + " (является большим из двух чисел)");
}
else
{
    if(numberA < numberB)
    {
        Console.WriteLine("max = " + numberB + " (является большим из двух чисел)");
    }
     else
     {
        Console.WriteLine("max = " + numberA + " (числа равны между собой)");
     }
}
