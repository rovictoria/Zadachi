// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100,1000);
int number3 = number % 10;
int number2 = number % 100;
int number1 = number / 100;

Console.WriteLine("Было " + number );
Console.WriteLine("Cтало " + number1 + number3 );

// Или другой вариант: сумма двухзначного + однозначного 
// int number11 = new Random().Next(100,1000);
// int result = ((number11 / 100) * 10) + (number11 % 10);

// Console.WriteLine($"Number = {number11}; result = {result} ");