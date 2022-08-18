Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA % 2 == 0)
{
    Console.WriteLine(numberA + " - да, это чётное число");
}
else
{
    Console.WriteLine(numberA + " - нет, это нечётное число");
}