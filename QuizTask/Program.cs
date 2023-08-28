int point = 0;
void Print_question(string[] question)
{

    string duzgun_cavab = question[3];

    string[] main_question = new string[5];
    main_question[0] = question[0];
    main_question[4] = "Next";


    //Burada 2 dəfə Random swap edərək,Random Shuffle edilir.
    Random rand = new Random();
    int number = rand.Next(1, 4);

    string temp1 = question[number];
    question[number] = question[4 - number];
    question[4 - number] = temp1;

    temp1 = question[2];
    question[2] = question[1];
    question[1] = temp1;
    //////////////////////////////////////////////////////////

    main_question[1] = question[1];
    main_question[2] = question[2];
    main_question[3] = question[3];


    int secilen_variant = 0;
    dynamic temp;
    int row = 1;
    bool secim = false;


    while (true)
    {
        Console.Clear();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{question[0]}\t\t\tXal:{point}\n");

        for (int i = 1; i < 5; i++)
        {

            if (row == i)
                Console.ForegroundColor = ConsoleColor.Yellow;

            else
                Console.ForegroundColor = ConsoleColor.White;
            if (i == secilen_variant)
            {
                if (question[secilen_variant] == duzgun_cavab)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Red;
            }
            if (i == 1)
                Console.Write("A)");
            else if (i == 2)
                Console.Write("B)");
            else if (i == 3)
                Console.Write("C)");

            Console.WriteLine(main_question[i]);
            if (i == 3)
                Console.WriteLine();
        }

        temp = Console.ReadKey(true);

        if (temp.Key == ConsoleKey.UpArrow)
        {
            if (row == 1)
                row = 4;
            else
                row--;
        }
        else if (temp.Key == ConsoleKey.DownArrow)
        {
            if (row == 4)
                row = 1;
            else
                row++;
        }
        else if (temp.Key == ConsoleKey.Enter)
        {
            if (row == 4)
            {
                secim = false;
                return;
            }
            else
            {

                if (!secim)
                {
                    secilen_variant = row;
                    if (question[secilen_variant] == duzgun_cavab)
                        point += 10;
                    else
                    {
                        if (point >= 10)
                            point -= 10;
                    }

                }
                secim = true;
            }
        }
    }

}

string[][] questions = new string[10][];
questions[0] = new string[] { "Maye halinda olan metal hansidir?", "Galium", "Nikel", "Cive" };
questions[1] = new string[] { "Teyyarelerdeki qara qutu hansi rengdedir?", "Qara", "Sari", "Narinci" };
questions[2] = new string[] { "Efqanistanin paytaxti haradir?", "El-Beyrn", "Demesq", "Kabil" };
questions[3] = new string[] { "Dunyanin en derin okeani hansidir?", "Hind Okeani", "Sakit Okean", "Atlantik Okean" };
questions[4] = new string[] { "Afrikanin erazice en boyuk olkesi hansidir?", "CAR", "Efiopiya", "Misir" };
questions[5] = new string[] { "Ekvadorun paytaxti hansi seherdir?", "Lados", "Riqa", "Quito" };
questions[6] = new string[] { "Ilk dunya seyaheti eden seyyah? ", "Fernan Magellan", "Ameriqo Vesbucci", "Christofor Kolumb" };
questions[7] = new string[] { "Dunyanin radiusu ne qederdir?", "12032 km", "3240 km", "6371 km" };
questions[8] = new string[] { "Gunese en yaxin planet hansidir?", "Venera", "Mars", "Merkuri" };
questions[9] = new string[] { "Kagiz pul harada icad edilib?", "Misir", "Roma", "Cin" };

Console.WriteLine("-------------QUESTIONS TASK-------------");
Console.Write("\nSuallara kecid etmek ucun entere basin...");
Console.ReadKey();


for (int i = 0; i < 10; i++)
{
    Console.Clear();
    Print_question(questions[i]);
}

Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine($"\nImtahan bitmisdir.Siz {point} xal qazandiniz.");

//ByVC