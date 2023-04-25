Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

void GetThirdDigit(int num)
{
    string digit = Convert.ToString(num);
    if (num < 100 && num >= 0)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
        Console.WriteLine($"Третья цифра числа {digit[2]}");

}

GetThirdDigit(a);