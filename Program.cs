using System;
using System.Threading;

namespace Luffarschack
{
    class Program
    {
        //Först har jag en array som ska innehålla alla positioner på spelbrädan
        //annledningen till att jag har å är för att annvändaren inte ska skriva in det, om jag hade noll fanns en chans att annvändaren kanske skulle skriva det, vilket sabbar koden
        //Jag måste också ha något före '1' eftersom det annars skulle man skriva in 1 och byta ut 2:an på brädan, å var då bättre än 0 bara för att det är osanolikt att annvändaren skulle 
        //skriva den och sabba koden.
        static char[] array = {'å', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        //sen har jag en int som kollar vem som spelar, det ska alltid börja med spelare 1
        static int spelare = 1;
        //sen har jag en int som ska kolla vart spelaren vill lägga sin ruta på
        static int positionval;
        //Jag har en int som ska kolla vart spelet ligger, en nolla ska indikera att ingen har vunnit, en etta om någon har vunnit och en -1 om det blir lika
        static int vincondition = 0;
        static void Main(string[] args){
            

            
            //Här är skällva huvud programmet, den kommer först att skriva ut lite om spelarna
            Console.WriteLine("Spelare 1 är kryss(x) och spelar 2 är cirkel(O)");
            // Jag annvänder ett do while komando för att köra hela programet i en loop tills vincondition = 1, som betyder att spelet är vunnet.
            do{
                //Sen kommer den att kalla på ett annat program som heter Brädan, det är själva spelplanen, den är uppbygd av arrays för att man ska kunna byta ut siffrorna
                Brädan();
                positionval = int.Parse(Console.ReadLine());
                //Här annvänder jag mig av ett Readline för att få input från annvändaren
                if(array[positionval] != 'X' && array[positionval] !='O'){
                    //Här kollar den så att det inte står X eller O på brädan redan, om det gör det så skickas den till en WriteLine, där den varnar att man gör fel.
                    if(spelare % 2 == 0){
                        //Här delar jag spelare int:en med två, för att se om den är ett ojämnt tal eller inte. Om den är ojämn som t.ex 1 är, så kör den det andra kommandot  
                        //Här byter den ut arrayen som spelaren valt med ett O, sedan ökar den spelare int:en med 1, så att den blir jämn.
                        array[positionval] = 'O';
                        spelare++;
                    }
                    else{
                        //Här byter den ut arrayen som spelaren valt med ett X, sen ökar den spelare int:en med 1, då blir den ett jämt tal när den kör om loopen och spelare två får köra
                        array[positionval] = 'X';
                        spelare++;
                    }
                }
                else{
                    Console.WriteLine("Det finns redan något här på {0}:an, den är redan markerad med {1}", positionval, array[positionval]);
                    // Det här händer om spelaren väljer en redan upptagen ruta, då kommer den säga vilken ruta och vad som finns där, (X eller O) och sedan köra om loopen.
                }

            vincondition = Vinnkoll();
            //Här kollar jag om någon spelare har vunnit, med hjälp av Vinnkoll, som är ett programm längre ner.
            }
            while(vincondition != 1 && vincondition !=-1);
            //Här är slutet på do while koden, det är den som loopar när spelet är igång, 
            //om den når 1 så har någon av spelarna vunnit och om den blir minus 1 är det oavgjort, detta får den från Vinnkoll.

            if(vincondition == 1){
                //Här kollar den om en spelare har vunnit och skriver då vilken spelare.
                Console.WriteLine("Spelare {0} har segrat", (spelare % 2) + 1);
            }
            else{
                //Om den är minus 1 så kommer den helt enkelt skriva att ingen vann
                Console.WriteLine("Ingen vann!");
            }
        //ReadLinen är till för att visa att programmet är slut. Den vill helt enkelt vänta på att annvändaren trycker på någon bokstav så att de själva kan välja när de avslutar proggrammet.
            Console.ReadLine();
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
        //Här är själva vinn kollen, som ska se till att man kan vinna eller förlora spelet. Den kallas alltid i slutet av do-while loopen i main proggrammet. 
         private static int Vinnkoll()
        {
            return 0;
        }
    }   
}
    
     