namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int value = Maximum.MaximumInteger(20, 30, 40);
            //Console.WriteLine(value);
            //float value1 = Maximum.Maximumfloat(28.3f, 12.6f, 56.7f);
            //Console.WriteLine(value1);
         //  string value5= Maximum.Maximumstring("abc", "abcd", "ab");
           var value=GenMax.GenericsMax("abc", "abcd", "ab");
            Console.WriteLine(value);
        }
    }
}