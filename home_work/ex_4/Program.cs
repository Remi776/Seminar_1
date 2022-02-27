Console.Write("Enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c)
{
    Console.WriteLine("max = " + a);
}
if (b > a & b > c)
{
    Console.WriteLine("max = " + b);
}
if (c > a & c > a)
{
    Console.WriteLine("max = " + c);
}
else if (a == b & b == c)
{
    Console.WriteLine("All numbers are equal.");
}