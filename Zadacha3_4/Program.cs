// Программа, которая задаёт массив
// из 8 элементов и выводит их на экран

void FillArray(int[] numbers)
{
    int length = numbers.Length;

    for (int index = 0; index < length; index++)
    {
        numbers[index] = new Random().Next(-10000, 10000);
    }
}

// void PrintArray(int[] num)
// {
//     int length1 = num.Length;

//     for (int position = 0; position < (length1 - 1); position++)
//     {
//         Console.Write($"{num[position]}   ");
//     }
    
// }


// А если нужно через запятую и с {}

void PrintArray(int[] num)
{
    int length1 = num.Length;
    int position = 0;
    Console.Write("{ ");

    while (position < (length1 - 1))
    {
        Console.Write($"{num[position]}, ");
        position++;
    }
    Console.Write(num[position] + " }");
}

int[] array = new int[8];

FillArray(array);

PrintArray(array);