using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {
            HashSet<string> Showroom = new HashSet<string> ();
            Showroom.Add ("4 Runner");
            Showroom.Add ("Jeep");
            Showroom.Add ("Range Rover");
            Showroom.Add ("Mazda 3");

            HashSet<string> UsedLot = new HashSet<string> ();
            UsedLot.Add ("Porsche");
            UsedLot.Add ("Ferrari");

            Showroom.UnionWith (UsedLot);

            Showroom.Remove ("Mazda 3");

            HashSet<string> Junkyard = new HashSet<string> ();
            Junkyard.Add ("4 Runner");
            Junkyard.Add ("Jeep");
            Junkyard.Add ("Honda");
            Junkyard.Add ("Chevy");
            Junkyard.Add ("Ford");
            Junkyard.Add ("Lambo");

            HashSet<string> clone = new HashSet<string>(Showroom);

            clone.IntersectWith(Junkyard);

            Showroom.UnionWith(Junkyard);

            foreach (string vehicle in Showroom) {
                Console.WriteLine ($"{vehicle}");
            }
        }
    }
}
