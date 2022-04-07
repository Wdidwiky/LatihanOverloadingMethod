using LatihanOverloadingMethod;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Minimum #1: {0}", Numbers.FindMinimum(3, 1));
        Console.WriteLine("Minimum #2: {0}", Numbers.FindMinimum(3, 2, 4));
        Console.WriteLine();
        Console.WriteLine("Maximum #1: {0}", Numbers.FindMaximum(3, 1));
        Console.WriteLine("Maximum $2: {0}", Numbers.FindMaximum(3, 2, 4));

        Console.ReadKey();
    }
}