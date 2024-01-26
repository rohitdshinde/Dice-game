using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int rvalue;
            int evalue;

            int rv = 0;
            int ev = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++) {

                Console.WriteLine("press any key to roll the dice");
                Console.ReadLine();

                rvalue = random.Next(1,7);
                Console.WriteLine("Player entered a value :"+rvalue);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                evalue =random.Next(1,7);
                Console.WriteLine("Enmy value :"+evalue);
                Console.WriteLine();

                if (rvalue > evalue)
                {
                    rv++;
                    Console.WriteLine("player win this round");
                }
                else if (rvalue < evalue)
                {
                    ev++;
                    Console.WriteLine("Enemy win this round");
                }
                else 
                {
                    Console.WriteLine("draw");

                }
                

                Console.WriteLine("scoreboard player value :" + rv +"  Enemy value :" + ev);

                if (rv > ev)
                {
                    Console.WriteLine("player win");
                }
                else if (rv<ev) 
                {
                    Console.WriteLine("You lose");
                }
                else
                {
                    Console.WriteLine("DRAW");

                }

                Console.WriteLine("-------------------------------------------------------------------------------");






            }
           // Console.ReadLine();

        }
    }
}
