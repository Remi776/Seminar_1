Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Wrong number");
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 1) continue;
    Console.Write(i + " ");
}