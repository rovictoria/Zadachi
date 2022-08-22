//  Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)

{
    case 1: Console.Write(number + " Понедельник"); break;
    case 2: Console.Write(number + " Вторник"); break;
    case 3: Console.Write(number + " Среда"); break;
    case 4: Console.Write(number + " Четверг"); break;
    case 5: Console.Write(number + " Пятница"); break;
    case 6: Console.Write(number + " Суббота"); break;
    case 7: Console.Write(number + " Воскресенье"); break;
    default: Console.Write("Нужно ввести число от 1 до 7, попробуйте снова :)"); break;
}

if(number > 0 && number < 6)
{
   Console.WriteLine(" - нет, рабочий день");
}
else if(number == 6 || number == 7)
{
    Console.WriteLine(" - да, выходной день");
}


// Кусок с if, else if можно было не писать, просто вписать в варианты case, но так больше на программе, а не вводе))