using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace kuytak
{
    internal class KutyaNevek
    {
        public int id;
        public string kutyanev;

        public KutyaNevek(string s)
        {
            string[] darabok = s.Split(';');
            this.id = Convert.ToInt32(darabok[0]);
            this.kutyanev = darabok[1];
        }
    }
}
