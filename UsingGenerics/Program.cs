namespace UsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Problem\n");
            FindMaximum findMaximum = new FindMaximum(); 
            findMaximum.MaxValue(30, 80, 60);
        }
    }
}