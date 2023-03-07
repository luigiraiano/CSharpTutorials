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

        Polimorphism.Base base_class = new Polimorphism.Base();
        Polimorphism.Child1 child1_class = new Polimorphism.Child1();

        // Get Properties from Base Class
        base_class.getProperties();

        // Get Properties from Child1 Class (child of Base)
        child1_class.getProperties();

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

namespace Polimorphism
{

    public class Base
    {
        protected double x_;
        protected string s_;

        public Base()
        {
            Console.WriteLine("Base class instantiated.");
            s_ = "Base";
            x_ = 0;
        }

        public void setValue(in double x)
        {
            x_ = x;
        }

        public void setString(in string s)
        {
            s_ = s;
        }

        public virtual void getProperties()
        {
            Console.WriteLine("Type: " + x_.ToString());
            Console.WriteLine("String: " + s_);
        }
    }

    public class Child1 : Base
    {
        private double x1_ = 0;

        public Child1() : base()
        {
            Console.WriteLine("Child1 class instantiated.");
            s_ = "Child1";
            x_ = 1;
        }

        public void setValue2(in double x)
        {
            x1_ = x;
        }

        public override void getProperties()
        {
            Console.WriteLine("Type: " + x_.ToString());
            Console.WriteLine("String: " + s_);
            Console.WriteLine("Child ID: " + x1_.ToString());
        }
    }

}