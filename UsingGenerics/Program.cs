namespace UsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Problem\n");
            FindMaximum findMaximum = new FindMaximum(); 
            //findMaximum.MaxValue(30, 80, 60);
            //findMaximum.MaxValue(90.22f, 20.111f, 10.2f);
            findMaximum.MaxValue("Apple", "Peach", "Banana");
        }
    }
}