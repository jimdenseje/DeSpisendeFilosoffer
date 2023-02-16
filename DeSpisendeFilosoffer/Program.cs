using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSpisendeFilosoffer
{
    internal class Program
    {
        public static void Main()
        {
            /*
            Thread SpoonsOnTable = new Thread(() => {
                while (true)
                {
                    Console.WriteLine("Spoons On Table" + DinnerTable.spoonsOnTable);
                    Thread.Sleep(1000);
                }
            });
            SpoonsOnTable.Start();
            */

            for (int x = 1; x <= 50; x++) {

                var Phil = new Philosopher(x);
                Thread thr = new Thread(new ThreadStart(Phil.run));
                thr.Start();

                Thread.Sleep(1);

            }
        }
    }
}