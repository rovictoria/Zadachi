
// На вход пятизначное. Проверка на полиндром.
// 12821 - да
void Polindrom()
{
  Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000) {
  string num = Convert.ToString(number);
  if (num[0] == num[4] && num[1] == num[3]) {
    Console.WriteLine($"{num} число-полиндром");
  } else {
    Console.WriteLine($"{num} НЕ число-полиндром");
  }
} else {
    Console.WriteLine("Это не пятизначное число, попробуйте снова");
}
}

Polindrom();
