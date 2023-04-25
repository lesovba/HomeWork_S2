//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetThreeDigitNumber()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine(rand);
    return rand;
}

int ShowSecondDigit(int num)
{
    int second_digit = num%100;
    Console.WriteLine("Вторая цифра числа равна" + second_digit);
    return second_digit;
}

ShowSecondDigit(GetThreeDigitNumber()); 
