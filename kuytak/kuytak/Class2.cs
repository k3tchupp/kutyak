using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuytak
{
    internal class Kutyak
    {
        public int id;
        public int fajta_id;
        public int nev_id;
        public int eletkor;
        public DateTime utolso_orvosi_egesz;

        public Kutyak(string s)
        {
            string[] darabok = s.Split(';');
            this.id = Convert.ToInt32(darabok[0]);
            this.fajta_id = Convert.ToInt32(darabok[1]);
            this.nev_id = Convert.ToInt32(darabok[2]);
            this.eletkor = Convert.ToInt32(darabok[3]);
            this.utolso_orvosi_egesz = DateTime.Parse(darabok[4]);
            
        }
    }
}