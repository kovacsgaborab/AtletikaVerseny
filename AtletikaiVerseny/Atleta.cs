using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }


        public Atleta(string sor)
        {
            string Nev;

            

            string[] a = sor.Split(';');
            Rajtszam = a[0];

            
            Nev = a[1];

            string[] b = Nev.Split(' ');
            VezNev = b[0];
            KerNev = b[1];

            Egyesulet = a[2];
            Ugras =Convert.ToInt32(a[3]);
        }


        //public string Nev
        //{
        //    string nev = "";

        //    string[] a = a.Split(' ');
        //    KerNev = a[3];
        //    VezNev = a[4];

        //    nev = KerNev + VezNev;

        //    return nev;
        //}

    }
}
