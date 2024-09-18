namespace Chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej vänligen mata hur stort schackbräde du vill ha.");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0) ;
            {

            }

        }
    }
}
