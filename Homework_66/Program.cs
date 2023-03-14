// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static void Print(string word)
{
    Console.WriteLine(word);
}

Print("Найти сумму чисел от M до N.");
Print("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
//rint("Введите число N");
// int numberN = Convert.ToInt32(Console.ReadLine());
 Summa(numberM);


static int Summa(int numberM)
{
    if (numberM <= 8)
        return 0;
    int t = 0;
    return t + Summa(numberM);
    Console.WriteLine($"Для числа {numberM}\t" + "суммой чисел будет являться\t");
}