using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feefteen2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = typeof(Program).Assembly.FullName;
            string g = typeof(game).Assembly.FullName;
            Console.WriteLine("program   " + s);
            Console.WriteLine("game   " + g);
            game Game = new game(4);
            Game.Start();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"{game.mas[i, j]} --- {Game.GetNumber(game.mas[i, j])}");
                }
            }
            int Test = Game.GetNumber(5);
            Console.WriteLine(Test);
            Console.ReadLine();
        }
    }
}
