using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pocetcisel = 0;
                double soucet = 0;
                double minimalnicislo = int.MaxValue;
                double cislamensinezpodminka = 0;
                int prvnitrojka = 3;
                int pocitadlopozice = 0;
                int zamecek = 0;
                int poziceprvnitrojky = 0;
                int poziceposlednitrojky = 0;

                for (int i = 0; i < textBox1.Lines.Length; i++)
                {
                    double value = double.Parse(textBox1.Lines[i]);
                    pocetcisel++;
                    soucet += value;
                    pocitadlopozice++;

                    if (value < minimalnicislo)
                    {
                        minimalnicislo = value; 
                    }
                    if(value < 5.30)
                    {
                        cislamensinezpodminka++;
                    }
                    if ((value == prvnitrojka) && (zamecek == 0))
                    {
                        poziceprvnitrojky = pocitadlopozice;
                        zamecek++;
                    }
                    if (value == prvnitrojka)
                    {
                        poziceposlednitrojky = pocitadlopozice;
                    }

                }
                label3.Text = "prumer cisel v Textboxu je:" + soucet / pocetcisel;
                label4.Text = "nejmensi cislo je:" + minimalnicislo;
                label5.Text = "pocet cisel mensich jak 5.30 je:" + cislamensinezpodminka;
                label6.Text = "pozice prvni trojky je:" + poziceprvnitrojky;
                label7.Text = "pozice posledni trojky je:" + poziceposlednitrojky;
                label8.Text = "soucet vsech cisel je:" + soucet;
            }
            catch(Exception)
            {
                MessageBox.Show("neco se pokazilo");
            }
        }
    }
}
