// На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число, большее 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int evennumber = 2;


// Это усложнённый вариант, чтобы числа выводились через запятую и после крайнего чётного запятой не было
if(N > 1)

{
    while(evennumber < (N-1))     // [1,N], т.е. включительно
    {
        Console.Write(evennumber + ", ");
        evennumber = evennumber + 2;
    }
    if (evennumber % 2 == 0 && evennumber == (N-1)) Console.Write(evennumber);
    if (N % 2 == 0) Console.Write(evennumber);
}
else
{
    Console.WriteLine("Ваше число не подходит условию задачи, невозможно определить чётные числа [1,N]");
}