// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"SC for show character, CR for calculate retail, TT for temperature table, and PN for prime numbers: ");
string input = Console.ReadLine();

switch(input.Trim().ToUpper())
{
    case "SC":
        Console.Write("Enter a word: ");
        string str = Console.ReadLine();
        Console.Write("Enter a letter's position you want: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine(ShowCharacter(str, index));
        break;
    case "CR":
        CalculateRetail();
        break;
    case "TT":
        for (int i = 80; i <= 100; i++)
        {
            Celsius(i);
        }
        break;
    case "PN":
        Console.WriteLine("What is the number? :");
        string numberAsString = Console.ReadLine();
        int number = Convert.ToInt32(numberAsString);
        Console.WriteLine(IsPrime(number));
        break;
}

static char ShowCharacter(string str, int index)
{
    return str[index];
}

static void CalculateRetail()
{
    Console.WriteLine("What is the wholesale cost? :");
    string wholesaleCostAsString = Console.ReadLine();
    double wholesaleCost = Convert.ToInt32(wholesaleCostAsString);
    Console.WriteLine("What is the markup percentage?");
    string markupPercentageAsString = Console.ReadLine();
    double markupAmount = Convert.ToInt32(markupPercentageAsString);
    double markupPercentage = markupAmount / 100;
    double markupPrice = wholesaleCost * markupPercentage;
    double retailPrice = markupPrice + wholesaleCost;
    Console.WriteLine($"The item's retail price is ${retailPrice}");
}

static void Celsius(double temperatureInF)
{
    double temperatureInC = (temperatureInF - 32) * 5 / 9;
    Console.WriteLine($"Your temperature, {temperatureInF} degrees Fahrenheit, is {temperatureInC} degrees in Celesuis.");

}

static bool IsPrime(int number)
{
    bool flag = false;

    for(int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
        else
            flag = true;
    }
    return flag;
}