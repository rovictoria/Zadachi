// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.Write("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);

if(number > 99)
{
    Console.WriteLine($"Третья цифра числа {number} - {str[2]}");
}
else
{
    Console.WriteLine($"В {number} нет третьей цифры");  //можно вывести {string}, но больше для схожести кодов вывода написала {number}
}