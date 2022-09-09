using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaMagazin
{
    internal class Telefoane
    {
        private string Marca;
        private string Denumire;
        private int Pret;

        public Telefoane(string Marca, string Denumire, int Pret)
         {
             this.Marca = Marca;
             this.Denumire = Denumire;   
             this.Pret = Pret;   
         }


        [Description("Producator")]
        public string marca
        {
            get { return Marca; }   
            set { Marca = value; }  
        }


        [Description("Model")]
        public string denumire
        {
            get { return Denumire; }    
            set { Denumire = value; }  
            

        }
        [Description("Pret")]
        public int pret
        {
            get { return Pret; }    
            set { Pret = value; }   
        }
    }
}
