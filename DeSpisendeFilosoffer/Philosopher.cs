using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSpisendeFilosoffer
{
    internal class Philosopher
    {
        public Philosopher(int name) {
            this.name = name;
        }

        public int name { set; get; }

        public void run() {
            while (true)
            {
                if (TakeSpoon())
                {
                    Console.WriteLine(((name.ToString() + ":").PadRight(4) + "Got a Spoon").PadRight(20) + "Spoons Left On Table: " + DinnerTable.getspoons());
                }
                else {
                
                }

                if (Eat())
                {
                    break;
                }
                Thread.Sleep(4);
            }
        }

        public int HasSpoonsInHand { get; set; } = 0;

        public bool TakeSpoon() {

            if (HasSpoonsInHand < 2) {
                if (DinnerTable.decrementSpoons())
                {
                    //take a spoon from table
                    //DinnerTable.spoonsOnTable--;
                    HasSpoonsInHand++;
                    return true;
                }
            }
            return false;
        }

        public bool Eat()
        {
            if (HasSpoonsInHand == 2)
            {
                //start eating
                Console.WriteLine(((name.ToString() + ":").PadRight(4) + "Started Eating").PadRight(20) + "Spoons Left On Table: " + DinnerTable.getspoons());

                //eat in 3 seconds
                Thread.Sleep(3000);
                HasSpoonsInHand--;
                HasSpoonsInHand--;
                DinnerTable.encrementSpoons();
                DinnerTable.encrementSpoons();

                //show done eating
                Console.WriteLine(((name.ToString() + ":").PadRight(4) + "Done Eating").PadRight(20) + "Spoons Left On Table: " + DinnerTable.getspoons());
                return true;
            }
            return false;
        }

    }
}
