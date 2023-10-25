using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Bolygo
    {
        public string name { get; set; }
        public int holdakszama { get; set; }
        public double terf { get; set; }

        public Bolygo(string x)
        {
            string[] y = x.Split(';');
            name = y[0];
            holdakszama = Convert.ToInt32(y[1]);
            terf = double.Parse(y[2]);
        }
    }
}
