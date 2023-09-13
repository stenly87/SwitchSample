// тема 3. Задание 1
/*
Console.WriteLine("Номер дня?");
int.TryParse(Console.ReadLine(), out int day);
int numLesson = 0;
switch (day)
{
    case 1:
        numLesson = 3; break;
    case 2:
    case 3:
    case 4:
        numLesson = 4; break;
    case 5:
        numLesson = 2; break;
    case 6:
        numLesson = 1; break;
    case 7:
        numLesson = 0; break;
    default:
        Console.WriteLine("Такого дня не существует");
        return;
}
Console.WriteLine($"Кол-во уроков в этот день: {numLesson}");
*/

// тема 3. Задание 3
Console.WriteLine("Год?");
int.TryParse(Console.ReadLine(), out int year);
Console.WriteLine("Месяц? (1-12)");
int.TryParse(Console.ReadLine(), out int month);
int countDays = 0;
switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        countDays = 31; break;
    case 2:
        countDays = (year % 4 == 0) ? 29 : 28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        countDays = 30; break;
}
Console.WriteLine($"Кол-во дней в указанном месяце: {countDays}");