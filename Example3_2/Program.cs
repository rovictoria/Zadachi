// принимает на вход два числа и выводит,
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB % numberA == 0)
{
    Console.WriteLine($"Число {numberB} кратно числу {numberA}");
}
else
{
    int result = numberB % numberA;
    Console.WriteLine($"Остаток от деления {numberB} на {numberA} равен {result}");
}
