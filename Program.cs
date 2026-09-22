
Console.WriteLine("Здравствуйте! Вас приветствует Ульянов Владислав ");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Введите число 1-4");
int agr = int.Parse(Console.ReadLine());

switch (agr)
{
    case 1:
        Console.WriteLine("Ульянов Владислав");
        break;
    case 2:
        Console.WriteLine("ИСП-243");
        break;
    case 3:
        Console.WriteLine("22.09.2026");
        break;
    case 4:
        Console.WriteLine("Выход");
        Console.ReadKey();
        break;


}

