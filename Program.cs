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
            // Jag annvänder ett do while komando för att köra hela programet i en loop tills vincondition = 1, som betyder att spelet är vunnet.
            do{
                //Sen kommer den att kalla på ett annat program som heter Brädan, det är själva spelplanen, den är uppbygd av arrays för att man ska kunna byta ut siffrorna
                Brädan();
                positionval = int.Parse(Console.ReadLine());
                //Här annvänder jag mig av ett Readline för att få input från annvändaren
                if(array[positionval] != 'X' && array[positionval] !='O'){
                    //Här kollar den så att det inte står X eller O på brädan redan, om det gör det så skickas den till en WriteLine, där den varnar att man gör fel.
                    if(spelare % 2 == 0){
                        //Här delar jag spelare inten med två, för att se om den är ett ojämnt tal eller inte. Om den inte är ojämnt, som t.ex 1 är, så kör den det andra kommandot  
                        array[positionval] = 'O';
                        spelare++;
                    }
                    else{
                        //Här byter den ut arrayen som spelaren valt med ett X, sen ökar den spelare inten med 1, då blir den ett jämt tal när den kär om loopen och spelare två får köra
                        array[positionval] = 'X';
                        spelare++;
                    }
                }
                else{
                    Console.WriteLine("Det finns redan något här på {0}:an, den är redan markerad med {1}", positionval, array[positionval]);
                    // Det här händer om spelaren väljer en redan upptagen ruta, då kommer den säga vilken ruta och vad som finns där, (X eller O) och sedan köra om loopen.
                }
            }
            while(vincondition != 1);
        }




        private static void Brädan()
        {
            //Här har jag ett program som helt enkelt skriver ut hela brädan, den har också arrayerna i sig, så att man ska kunna ändra dem senare, när spelaren väljer positioner. 
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);
        }
    }
}
