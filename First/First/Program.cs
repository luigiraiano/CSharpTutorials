using System.Diagnostics.CodeAnalysis;

internal class Program
{ 
    private static void Main(string[] args)
    {
        Luigi.Tutorial test = new Luigi.Tutorial();

        Console.WriteLine("Sum with ext class");

        Console.WriteLine(Luigi.Tutorial.sum(1, 2).ToString());

        test.set(1, 2);

        Console.WriteLine("Un enum avanzato: " + Luigi.EnumAvanzato.Angela);

        double a = 1;
        double b = 3;
        double sum = 0;
        Console.WriteLine("Compute Sum v2");
        Luigi.Tutorial.computeSum(in a, in b, ref sum);
        Console.WriteLine(sum.ToString());
    }
}

namespace Luigi
{
    public class Tutorial
    {
        // Private Vars
        double a_, b_;

        // Class Constructor
        public Tutorial()
        {
            Console.WriteLine("'Turorial' class instantiated.");
        }

        /*
        public ~Tutorial()
        {

        }
        */

        public void set(double a, double b)
        {
            a_ = a;
            b_ = b;

            Console.WriteLine("Set New Values: " + a_.ToString() + ", " + b_.ToString());
        }

        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static void computeSum(in double a, in double b, ref double sum)
        {
            sum = a + b;
        }

    }

    public enum EnumAvanzato : byte
    {
        Luigi, Angela, Michele
    }
}