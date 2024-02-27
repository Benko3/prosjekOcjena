using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsjekOcjena
{
    public partial class form1 : Form
    {
        int ocjena, brojOcjena = 0, zbroj;
        double prosjek;

        private void unosOcjene_TextChanged(object sender, EventArgs e)
        {

        }

        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(unosOcjene.Text);
            brojOcjena++;
            zbroj += ocjena;
            DialogResult odgovor = MessageBox.Show("Želiš li upisati još ocjena?", "Upit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (odgovor){
                case DialogResult.Yes:
                    textBox1.Clear();
                    textBox1.Focus();
                    break;
                case DialogResult.No:
                    prosjek = zbroj / brojOcjena;
                    textBox1.Text = prosjek.ToString();
                    textBox1.Text = ProsjekOcjena();
                    break;

            }
        }
    }
}
