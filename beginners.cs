// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int age = -23;
        System.Console.WriteLine(age);
        System.Console.WriteLine(int.MaxValue);
        System.Console.WriteLine(int.MinValue);

        long bigNumber = -900000000000000L;
        System.Console.WriteLine(bigNumber);
        System.Console.WriteLine(long.MaxValue);
        System.Console.WriteLine(long.MinValue);

        double negative = -55.20D;
        System.Console.WriteLine(negative);
        System.Console.WriteLine(double.MaxValue);
        System.Console.WriteLine(double.MinValue);

        float precision = 5.000001F;
        System.Console.WriteLine(precision);
        System.Console.WriteLine(float.MaxValue);
        System.Console.WriteLine(float.MinValue);

        decimal money = 14.9M;
        System.Console.WriteLine(money);
        System.Console.WriteLine(decimal.MaxValue);
        System.Console.WriteLine(decimal.MinValue);

        



        System.Console.ReadLine();
    }
}
