Console.Write("Enter number 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("number 1 = max" + "\n" + "number 2 = min");
}
else
{
    Console.WriteLine("number 1 = min" + "\n" + "number 2 = max");
}