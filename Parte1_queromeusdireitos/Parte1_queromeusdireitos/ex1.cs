using System;
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
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private double Dividir(double totale)
        {
            return totale / 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {



                double total = 0, calculo = 0, var1, var2, var3;

                total += double.Parse(CieN.Text);
                total += double.Parse(PortN.Text);
                total += double.Parse(MateN.Text);

                label10.Text = Dividir(total).ToString("0.00");

                var1 = double.Parse(PortP.Text) * double.Parse(PortN.Text);
                var2 = double.Parse(MateP.Text) * double.Parse(MateN.Text);
                var3 = double.Parse(CieP.Text) * double.Parse(CieN.Text);

                calculo += double.Parse(PortP.Text);
                calculo += double.Parse(MateP.Text);
                calculo += double.Parse(CieP.Text);

                total = (var1 + var2 + var3) / calculo;



                label11.Text = total.ToString("0.00");

            }
            catch
            {
                MessageBox.Show("Informe um valor valido");
            }
        }
    }
}
