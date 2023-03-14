static void Print(string word)
{
    Console.WriteLine(word);
}
Print("Вывести все натуральные числа в промежутке от N до 1.");

Random rand = new Random();
int numberN = rand.Next(2, 100);
Decrease(numberN);


static void Decrease(int numberN)
{
    if (1 <= numberN)
    {
        System.Console.WriteLine(numberN);
        numberN--;
        Decrease(numberN);
    }
}