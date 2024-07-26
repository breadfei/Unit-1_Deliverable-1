int sodaStock = 100;
int chipStock = 40;
int candyStock = 60;

int sodaRestock = 40;
int chipRestock = 20;
int candyRestock = 40;

Console.Write("How many sodas have been sold today? 100 in stock. ");
string input = Console.ReadLine();
int num1 = int.Parse(input);
if (sodaStock < num1)
{
    Console.WriteLine("Too high");
}
else
{
    sodaStock = sodaStock - num1;
}

Console.Write("How many chips have been sold today? 100 in stock. ");
string input = Console.ReadLine();
int num1 = int.Parse(input);
if (chipStock < num1)
{
    Console.WriteLine("Too high");
}
else
{
    chipStock = chipStock - num1;
}

Console.Write("How many candies have been sold today? 100 in stock. ");
string input = Console.ReadLine();
int num1 = int.Parse(input);
if (candyStock < num1)
{
    Console.WriteLine("Too high");
}
else
{
    candyStock = candyStock - num1;
}

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Soda needs to be restocked.");
}
if (chipStock <= chipRestock)
{
    Console.WriteLine("Chips needs to be restocked.");
}
if (candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked.");
}