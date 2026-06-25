using Challenge;

namespace Run
{
    internal class Program
    {
        static void Print(bool[,] table)
        {
            int x = table.GetLength(0);
            int y = table.GetLength(1);
            for (int j = 0; j < x; j++, Console.WriteLine())
                for (int k = 0; k < y; k++, Console.Write(" "))
                    Console.Write($"{Convert.ToByte(table[j, k])}");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            bool[,] case1 = {
                { true, false, false},
                { false, true, false},
                { false, false, true},
            };
            bool[,] case2 = {
                { true,  true,  false},
                { false, true,  false},
                { false, false, true},
            };
            bool[,] case3 = {
                {true , true , false, false, false },
                {false, true , false, false, false },
                {false, false, true , false, false },
                {false, false, true , true, false },
                {false, false, false, false, false },
            };
            ConwayGame game = new ConwayGame(case3);
            Console.WriteLine($"Environment: [{game.table.Rank}: {game.table.GetLength(0)} x {game.table.GetLength(1)}]");
            Console.WriteLine();


            bool[,] prev;
            do
            {
                prev = (bool[,])game.table.Clone();
                Print(game.table);
                game.Next();

            } while (!game.table.Cast<bool>().SequenceEqual(prev.Cast<bool>()));

        }
    }
}
