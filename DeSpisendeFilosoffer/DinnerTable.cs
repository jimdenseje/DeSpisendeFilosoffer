using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSpisendeFilosoffer
{
    internal static class DinnerTable
    {
        private static Object LOCK = new();

        private static int spoonsOnTable = 30;

        public static int getspoons() {
            lock (LOCK)
            {
                return spoonsOnTable;
            }
        }

        public static void encrementSpoons() {
            lock (LOCK) {
                spoonsOnTable++;
            }
        }
        public static bool decrementSpoons()
        {
            lock (LOCK)
            {
                if (spoonsOnTable > 0) {
                    spoonsOnTable--;
                    return true;
                }
            }
            return false;
        }
    }
}
