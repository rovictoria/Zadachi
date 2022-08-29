// Программа, которая принимает на вход число и выдаёт количество цифр в числе.
void SumCount()
{
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = (int) Math.Log10(number) + 1;
Console.WriteLine(count);
}
SumCount();