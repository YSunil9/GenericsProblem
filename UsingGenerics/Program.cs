namespace UsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Problem\n");
            FindMaximum<int> findingmaxint = new FindMaximum<int>();
            findingmaxint.MaxValue(46, 98, 77);
            FindMaximum<double> findingmaxfloat = new FindMaximum<double>();
            findingmaxfloat.MaxValue(12.32, 36.33, 41.1);
            FindMaximum<string> findingmaxstring = new FindMaximum<string>();
            findingmaxstring.MaxValue("15", "19", "26");
        }
    }
}