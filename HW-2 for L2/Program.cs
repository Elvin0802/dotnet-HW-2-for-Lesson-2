sbyte option = 0;

string[] menu1 = { "SmartPhones", "PCs", "Cars", "Exit" };
int len1 = menu1.Length;

while (true)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\n\t\t|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n\n");

    for (sbyte s = 0; s < len1; s++)
    {
        if (s == option)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\t\t\t\t{menu1[s]}\n");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\t\t\t{menu1[s]}\n");
        }
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\n\t\t|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n\n");
    Console.ForegroundColor = ConsoleColor.White;

    var keyInfo = Console.ReadKey(true);

    if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
    {
        option--;
        if (option < 0) option = ((sbyte)(len1-1));
    }
    else if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
    {
        option++;
        if (option > (len1-1)) option = 0;
    }
    else if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D)
    {
        option--;
        if (option < 0) option = ((sbyte)(len1-1));
    }
    else if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A)
    {
        option++;
        if (option > (len1-1)) option = 0;
    }
    else if (keyInfo.Key == ConsoleKey.Enter)
    {
        if (option == 3)
        {
            Console.WriteLine("\n\nExited.");
            break;
        }

        string[] menu2 = { "", "", "", "Exit" };
        int len2 = menu2.Length;
        sbyte option2 = 0;

        if (option == 0)
        {
            menu2[0]="Apple"; menu2[1]="Samsung"; menu2[2]="Xiaomi";
        }
        else if (option == 1)
        {
            menu2[0]="Dell"; menu2[1]="Asus"; menu2[2]="Lenovo";
        }
        else if (option == 2)
        {
            menu2[0]="Lamborghini"; menu2[1]="Ferrari"; menu2[2]="McLaren";
        }

        while (true)
        {
            Console.Clear();
            Console.Write("\n\n\n");

            for (sbyte k = 0; k < len2; k++)
            {
                if (k == option2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\t\t\t\t{menu2[k]}\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\t\t\t\t{menu2[k]}\n");
                }
            }

            var keyInfo2 = Console.ReadKey(true);

            if (keyInfo2.Key == ConsoleKey.UpArrow || keyInfo2.Key == ConsoleKey.W)
            {
                option2--;
                if (option2 < 0) option2 = ((sbyte)(len1-1));
            }
            else if (keyInfo2.Key == ConsoleKey.DownArrow || keyInfo2.Key == ConsoleKey.S)
            {
                option2++;
                if (option2 > (len1-1)) option2 = 0;
            }
            else if (keyInfo2.Key == ConsoleKey.RightArrow || keyInfo2.Key == ConsoleKey.D)
            {
                option2--;
                if (option2 < 0) option2 = ((sbyte)(len1-1));
            }
            else if (keyInfo2.Key == ConsoleKey.LeftArrow || keyInfo2.Key == ConsoleKey.A)
            {
                option2++;
                if (option2 > (len1-1)) option2 = 0;
            }
            else if (keyInfo2.Key == ConsoleKey.Enter)
            {
                if (option2 == 3) { break; }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\tYou are Selected {menu2[option2]}.\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press Any Key...");
                Console.ReadKey();
                break;
            }
        }
    }
}
