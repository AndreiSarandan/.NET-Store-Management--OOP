using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaMagazin
{
    public partial class Form1 : Form
    {
        List<Mobile> ListaMobile = new List<Mobile>();
        List<Fixe> ListaFixe = new List<Fixe>();

        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

  

 /*       private void button3_Click(object sender, EventArgs e)
        {
            listBoxMobile.Items.Clear();
            foreach (Mobile mobil in ListaMobile)
                listBoxMobile.Items.Add(mobil.Marca + " " + mobil.Denumire + " " + mobil.Pret + " lei " + mobil.diagonala + " inch " + mobil.Capacitate_baterie + " baterie " + mobil.sistem_operare + " OS");
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Mobile mobil = new Mobile(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text);
            listBoxMobile.Items.Add(mobil.marca + " - " + mobil.denumire + " - " + mobil.pret + " lei - " + mobil.diagonala + " inch " + mobil.capacitate_baterie + " - baterie " + mobil.sistem_operare + " OS"); 
            ListaMobile.Add(mobil);
        }

        private void listBoxMobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x=listBoxMobile.SelectedIndex;
           // foreach(Mobile mobil in ListaMobile)
            //    if(mobil.Marca ==listBoxMobile.SelectedIndex)
            propertyGrid1.SelectedObject=ListaMobile[x];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fixe fix = new Fixe(textBox7.Text,textBox8.Text,Convert.ToInt32(textBox9.Text),textBox10.Text,textBox11.Text);
            listBoxFixe.Items.Add(fix.marca+" - "+fix.denumire+" - "+fix.pret+" lei - tip: "+fix.tip+" - functii: "+fix.functii);
            ListaFixe.Add(fix);
        }

        private void listBoxFixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = listBoxFixe.SelectedIndex;
            propertyGrid1.SelectedObject = ListaFixe[x];
        }
    }
}
