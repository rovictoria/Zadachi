Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB) Console.WriteLine("max = " + numberA + " (является большим из двух чисел)");
if(numberA < numberB) Console.WriteLine("max = " + numberB + " (является большим из двух чисел)");
if(numberA == numberB) Console.WriteLine("max = " + numberA + " (числа равны между собой)");