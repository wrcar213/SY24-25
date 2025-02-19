using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Quartet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCard C4 = new CarCard("Corvette Coupe", 281, 5.2, 344 , 5665, 8 , 5400, "C" );
            CarCard C3 = new CarCard("Porsche 9/11 Targa", 285, 5.2, 320, 3596, 6 , 6800, "C");
            CarCard F1 = new CarCard("Opel Astra Coupe 2.0", 245, 7.5, 192, 1988, 4, 5400, "F");
            CarCard D3 = new CarCard("Nissan 350 Z", 250, 5.9, 280, 3498, 6, 6200, "D");
            CarCard D2 = new CarCard("Audi RS 6 plus", 280, 4.6, 480, 4172, 8, 6400, "D");
            CarCard A3 = new CarCard("Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500, "A");
            CarCard G4 = new CarCard("Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250, "G");
            CarCard G1 = new CarCard("Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750, "G");
            CarCard C2 = new CarCard("Audi RS 6 Plus", 280, 5.2, 480, 4172, 8, 6400, "C");
            CarCard C1 = new CarCard("Nissan 350 Z", 250, 5.9, 280, 3498, 6, 6200, "C");
            CarCard C0 = new CarCard("Opel Astra Coupe 2.0", 245, 7.5, 192, 1998, 4, 5400, "C");
            CarCard E1 = new CarCard("Aston Martin V8 Vantage", 280, 5.0, 4282, 8, 385, 7000, "D");
            CarCard E4 = new CarCard("Bentley Azure", 241, 6.7, 6750, 8, 388, 4000, "E");
            CarCard B2 = new CarCard("TVR Sagaris", 300, 3.9, 3966, 8, 400, 7000, "B");
            CarCard C5 = new CarCard("porsche 911", 285, 5.2, 3596, 6, 320, 6300, "C");
            CarCard C6 = new CarCard("BMW", 250, 4.7, 507, 4999, 10, 7750, "C");
            CarCard C7 = new CarCard("viper", 285, 4.6, 411, 7990, 10, 5100, "C");
            CarCard C8 = new CarCard("bmw 2", 250, 4.7, 400, 4941, 8, 6600,"C");
            CarCard G3 = new CarCard("Alfa Romeo Brera", 248, 6.3, 3195, 6, 260, 6200, "G");
            CarCard F3 = new CarCard("Chrysler Crossfire", 250, 6.9, 3199, 6, 218, 5700, "F");
            CarCard H1 = new CarCard("BMW Z4", 250, 5.9, 2979, 6, 231, 5900, "H");
            CarCard h4 = new CarCard("bmw m5", 250, 4.7, 507, 4999, 10, 7750, "H");
            CarCard H3 = new CarCard("Pontiac GTO", 280, 5.7, 5970, 8, 400, 5200, "H");
            CarCard F4 = new CarCard("Fisker Tramonto", 325, 3.6, 5439, 8, 610, 6100, "F");
            CarCard E3 = new CarCard("BMW 645 Ci", 250, 5.6, 4398, 8, 333, 6100, "E");
            CarCard D1 = new CarCard("Audi RS4", 250, 4.8, 4163, 8, 420, 7800, "D");
            CarCard B3 = new CarCard("Range Rover Sport", 225, 7.6, 4197, 8, 390, 5750, "B");
            CarCard E2 = new CarCard("Ferrari F50", 325, 3.9, 521, 4700, 12, 8500, "e2");
            CarCard F2 = new CarCard("VW Golf R32", 248, 6.2, 250, 3189, 6, 6300, "f2");
            CarCard A4 = new CarCard("viper gts", 285, 4.6, 411, 7990, 10, 5100, "A");
            CarCard H4 = new CarCard("bmw m5", 250, 4.7, 507, 4999, 10, 7750, "H");
            CarCard A1 = new CarCard("bmw z8", 250, 4.7, 400, 4941, 8, 6600, "A");












            //WriteLine(C4.Compare(D3,CarCard.category.RPM));
            List<CarCard> List = new List<CarCard>();
            List.Add(C4);
            List.Add(C3);
            List.Add(F1);
            List.Add(D3);
            List.Add(D2);
            Deck d = new Deck(List);    
            ReadLine();
        }
    }
}
