Console.WriteLine("Введите день недели от 1 до 7");
int dayOfWeek = int.Parse(Console.ReadLine());

void CheckWeekend (int num) {
    if (num == 6 || num == 7) 
    {
        Console.WriteLine(num + "->да");
    }
    else 
    {
        Console.WriteLine(num + "->нет");
    }
}

CheckWeekend(dayOfWeek);