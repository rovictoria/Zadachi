// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

void SumNumbers()

{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    if (number < 0) 
    {
        number = number * (-1);
    }
    
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }

    Console.WriteLine(sum);
}

SumNumbers();