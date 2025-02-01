using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit
{
    internal class Dado
    {
        public int lanciaDado()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
