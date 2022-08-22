// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100,1000);
int number3 = number % 10;
int number2 = number % 100;
int number1 = number / 100;
Console.WriteLine("Было " + number );
Console.WriteLine("Cтало " + number1 + number3 );