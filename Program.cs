using System;


namespace Calisma23_NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = new Nullable<int>();
            n = 5;
           Console.WriteLine(n.GetValueOrDefault());
           Nullable<double> d = null;
           Nullable<double> d1 = 10.10;
           Console.WriteLine(d);
           Console.WriteLine(d.GetValueOrDefault());
           Console.WriteLine(d1);
           Console.WriteLine(d1.GetValueOrDefault());

        }
    }
}
