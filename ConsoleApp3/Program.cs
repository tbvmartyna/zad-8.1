Console.WriteLine("Wpisz ocene:");
string ocena = Console.ReadLine();
switch(ocena)
{
    case "6":
        Console.WriteLine("6 - Celujacy");
        break;
    case "5":
        Console.WriteLine("5 - Bardzo dobry");
        break;
    case "4":
        Console.WriteLine("4 - Dobry");
        break;
    case "3":
        Console.WriteLine("3 - Dostateczny");
        break;
    case "2":
        Console.WriteLine("2 - Dopuszczajacy");
        break;
    case "1":
        Console.WriteLine("1 - Niedostateczny");
        break;
}