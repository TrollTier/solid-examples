using SOLID.BadExamples.LiskovSubstitution;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gute Beispiele für Interface segregation
            List<string> list = new List<string>();

            HashSet<string> hashset = new HashSet<string>();

            var controls = new Control[] { new Button(), new Label() };

            var button = controls[0];

            button.X = 12; // Verhält sich nicht wie erwartet durch die Basisklasse
            button.Y = 13; // Verhält sich wie erwartet durch die Basisklasse
        }
    }
}
