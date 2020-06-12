using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s = new Storm("Wind", false, "XanThanos");
            Console.WriteLine(s.Announce());

            Pupil p = new Pupil("Raegar");
            Storm windStorm = p.CastWindStorm();
            Console.WriteLine(windStorm.Announce());

            Mage m = new Mage("Guldan");
            Storm rainStorm = m.CastRainStorm();
            Console.WriteLine(rainStorm.Announce());

            Archmage a = new Archmage("Gandalf");
            Storm archRainStorm = a.CastRainStorm();
            Storm archLightningStorm = a.CastLightningStorm();
            Console.WriteLine(archRainStorm.Announce);
            Console.WriteLine(archLightningStorm.Announce);
        }
    }
}