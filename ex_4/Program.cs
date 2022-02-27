Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);
for (int i = -1 * a; i <= a; i++)
{
    Console.Write($"{i} ");
}