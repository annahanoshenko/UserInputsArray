
int[] numbers = new int[5];
Console.WriteLine("Enter 5 integers");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter number {0}: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}
    Console.WriteLine("User input finished. Processing...");

foreach(int num in numbers)
{
    Console.Write((num * 10) + " ");
}
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadLine();
