using System;
namespace BuildAMeasure2
{
    public class rando
    {
        public static int genrand()
        {
            Random m = new Random();
            int n = m.Next(0, 8);
            return n;
        }
    }
}
