using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaMagazin
{
    internal class Fixe:Telefoane
    {
        public string Tip;
        public string Functii;

       public Fixe(string Marca, string Denumire, int Pret,string Tip,string Functii) : base(Marca, Denumire, Pret)
        {
            this.Tip = Tip;
            this.Functii = Functii;
        }
        public string tip
        {
            get { return this.Tip; }
            set { this.Tip = value; }
        }
        public string functii
        {
            get { return this.Functii; }
            set { this.Functii = value;}
        }
    
     }
}
