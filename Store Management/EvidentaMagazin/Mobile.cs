using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EvidentaMagazin
{
    internal class Mobile:Telefoane
    {
        private int Diagonala;
        private int Capacitate_baterie;
        private string Sistem_operare;


        public Mobile(string Marca, string Denumire, int Pret, int Diagonala, int Capacitate_baterie, string Sistem_operare) : base(Marca, Denumire, Pret)
        {
            this.Diagonala = Diagonala;
            this.Capacitate_baterie = Capacitate_baterie;
            this.Sistem_operare = Sistem_operare;
        }

        [Description("Diagonala")]
        public int diagonala
        {
            get { return this.Diagonala; }
            set { this.Diagonala = value; }
        }
        [Description("Baterie")]
        public int capacitate_baterie
        {
            get { return this.Capacitate_baterie; }
            set { this.Capacitate_baterie = value; }
        }
        [Description("Sistem de operare")]
        public string sistem_operare
        {
            get { return this.Sistem_operare; }
            set { this.Sistem_operare = value; }
        }


    }
}
