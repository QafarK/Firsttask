short select = 1;
string archive = new string("");
do
{
    switch (select)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Start new calculator");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Archive");
            Console.WriteLine("Exit");
            break;
        case 2:
            Console.WriteLine("Start new calculator");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Archive");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exit");
            break;
        case 3:
            Console.WriteLine("Start new calculator");
            Console.WriteLine("Archive");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--> Exit");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        default:
            break;
    }

    ConsoleKeyInfo info = Console.ReadKey(true);
    Console.Clear();

    if (info.Key == ConsoleKey.UpArrow)
    {
        if (select != 1) { select--; }
        else { select = 3; }
    }
    else if (info.Key == ConsoleKey.DownArrow)
    {
        if (select != 3) { select++; }
        else { select = 1; }
    }
    else if (info.Key == ConsoleKey.Enter && select == 1)
    {
        Calculator();
    }
    else if (info.Key == ConsoleKey.Enter && select == 2)
    {
        Archive();
    }
    else if (info.Key == ConsoleKey.Enter && select == 3)
    {
        break;
    }

} while (true);

void Calculator()
{
    string _num1;
    string _num2;
    int num1;
    int num2;

    Console.Write("Enter first number:");
    _num1 = Console.ReadLine();
    Console.Write("Enter second number:");
    _num2 = Console.ReadLine();
    Console.Clear();

    num1 = Int32.Parse(_num1);
    num2 = Int32.Parse(_num2);

    short select = 1;
    do
    {

        switch (select)
        {
            case 1:
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}"); 
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = ERROR");
                }
                break;
            default:
                break;
        }
        Console.WriteLine();
        switch (select)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--> +");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                break;

            case 2:
                Console.WriteLine("+");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("--> -");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*");
                Console.WriteLine("/");
                break;

            case 3:
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--> *");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("/");
                break;

            case 4:
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("--> /");
                Console.ForegroundColor = ConsoleColor.White;
                break;

            default:
                break;
        }

        ConsoleKeyInfo info = Console.ReadKey(true);
        Console.Clear();

        if (info.Key == ConsoleKey.UpArrow)
        {
            if (select != 1) { select--; }
            else { select = 4; }
        }
        else if (info.Key == ConsoleKey.DownArrow)
        {
            if (select != 4) { select++; }
            else { select = 1; }
        }
        else if (info.Key == ConsoleKey.Enter && select == 1)
        {
            archive += $"{num1} + {num2} = {num1 + num2}\n\n";
            break;
        }
        else if (info.Key == ConsoleKey.Enter && select == 2)
        {
            archive += $"{num1} - {num2} = {num1 - num2}\n\n";
            break;
        }
        else if (info.Key == ConsoleKey.Enter && select == 3)
        {
            archive += $"{num1} * {num2} = {num1 * num2}\n\n";
            break;
        }
        else if (info.Key == ConsoleKey.Enter && select == 4)
        {
            if (num2 != 0)
            {
                archive += $"{num1} / {num2} = {num1 / num2}\n\n";
            }
            break;
        }
    }
    while (true);

}
void Archive()
{
    if (archive != "")
    {
        Console.Write(archive);
        Console.WriteLine("Press any key to continue:");
        ConsoleKeyInfo info = Console.ReadKey(true);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Archive is NULL");
        Thread.Sleep(2000);
        Console.Clear();
    }

}




