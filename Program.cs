using System;
using System.Threading;

namespace Luffarschack
{
    class Program
    {
        //Först har jag en array som ska innehålla alla positioner på spelbrädan
        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        //sen har jag en int som kollar vem som spelar, det ska alltid börja med spelare 1
        static int spelare = 1;
        //sen har jag en int som ska kolla vart spelaren vill lägga sin ruta på
        static int positionval;
        //Jag har en int som ska kolla vart spelet ligger, en nolla ska indikera att ingen har vunnit, en etta om någon har vunnit och en -1 om det blir lika
        static int vincondition = 0;
        static void Main(string[] args){
            //Här är skällva huvud programmet, den kommer först att skriva ut lite om spelarna
            Console.WriteLine("Spelare 1 är kryss(x) och spelar 2 är cirkel(O)");
            Console.WriteLine("");
            Console.WriteLine("");
            //Sen kommer den att kalla på ett annat program som heter Brädan
            Brädan();

        }

        private static void Brädan(){
            //Här har jag ett program som helt enkelt skriver ut hela brädan, den har också arrayerna i sig, så att man ska kunna ändra dem senare, när spelaren väljer positioner. 
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}
