using System;

namespace BuildAMeasure2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            notebuilder whole = new notebuilder();
            whole.noteval = 4;
            whole.notename = "whole note";

            notebuilder dothalf = new notebuilder();
            dothalf.noteval = 3;
            dothalf.notename = "dotted half note";

            notebuilder half = new notebuilder();
            half.noteval = 2;
            half.notename = "half note";

            notebuilder dotquart = new notebuilder();
            dotquart.noteval = 1.5;
            dotquart.notename = "dotted quarter note";

            notebuilder quarter = new notebuilder();
            quarter.noteval = 1;
            quarter.notename = "quarter note";

            notebuilder doteight = new notebuilder();
            doteight.noteval = .75;
            doteight.notename = "dotted eighth note";

            notebuilder eighth = new notebuilder();
            eighth.noteval = .5;
            eighth.notename = "eighth note";

            notebuilder sixt = new notebuilder();
            sixt.noteval = .25;
            sixt.notename = "sixteenth note";

            notebuilder placeholder = new notebuilder();
            placeholder.noteval = 0;
            placeholder.notename = "place-holder";

            notebuilder[] notesarray = { whole, dothalf, half, dotquart, quarter, doteight, eighth, sixt, placeholder };

            double meascount = 0;

            while (meascount < 4)
            {
                int l;
                l = rando.genrand();

                var x = notesarray[l];
                    if (meascount + x.noteval <= 4)
                    {
                    meascount = meascount + x.noteval;
                    Console.WriteLine(meascount);
                    } else if (meascount < 4 && meascount >= 3.875)
                    {
                    x = notesarray[7]; //placeholder = 0
                    meascount += x.noteval;
                    Console.WriteLine(meascount);
                    };
            }
            
        }
    }
}
