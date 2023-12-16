using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte1_queromeusdireitos
{
    public partial class ex2 : Form
    {

        int var = 0;
        int[] numeros = new int[10];
        public ex2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var++;
                numeros[var - 1] = int.Parse(textBox1.Text);


                label5.Text = var.ToString();

                if (var == 10)
                {
                    Array.Sort(numeros);
                    foreach (int p in numeros) textBox2.Text += p.ToString() + "  ";
                    var = 0;
                    
                }
                if (var == 1)
                {
                    textBox2.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Informe um número valido");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
