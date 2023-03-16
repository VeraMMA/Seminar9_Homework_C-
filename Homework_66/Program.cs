static void Print(string word)
{
    Console.WriteLine(word);
}

Print("Найти сумму чисел от M до N.");

Print("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Print("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
Summa(numberM,numberN);

void Summa(int numberM, int numberN)
{
    Console.Write(SumOfSegment(numberM - 1, numberN));
}

int SumOfSegment (int numberM, int numberN)
{
    int result = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        result = numberM + SumOfSegment(numberM, numberN);
        return result;
    }
}



