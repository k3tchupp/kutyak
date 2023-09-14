using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuytak
{
    internal class Kutyafajtak
    {
        public int id;
        public string név;
        public string eredeti;

        public Kutyafajtak(string s)
        {
            string[] darabok = s.Split(';');
            this.id = Convert.ToInt32(darabok[0]);
            this.név = darabok[1];
            this.eredeti = darabok[2];
        }
    }
}
