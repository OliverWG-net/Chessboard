namespace Chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Får symbolen för vit och svart ruta att fungera
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //ber användaren om storlek på brädet
            Console.WriteLine("Hej vänligen mata hur stort schackbräde du vill ha.");
            //sätter input från användaren i variablen size och gör den till en int
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)// lägger in inmatade värdet i size som en int eller ger ogitligt resultat
            {
                Console.WriteLine("Ogilltig inamtning vänligen försök igen");//ber användaren att försöka igen
            }
            
            for (int row = 0; row < size; row++)// sätter row som int med värdet 0 och ligger till +1 tills row inte längre är mindre en size och så får jag ut mina rader
            {
                for (int col = 0; col < size; col++)//samma som row ovan men gör det på col istället så jag får ut columner
                    if ((row + col) % 2 == 0 )//här ber vi koden skriva ut vit ruta om det blir jämnt 
                    {
                        Console.Write("◻︎");
                    }
                    else
                    {
                        Console.Write("◼︎");// här ber vi koden skriva ut svart om det är ojämnt
                    }
                Console.WriteLine();// för att stoppa programmet för att stängas
            }

            //Git test
        }
    }
}
