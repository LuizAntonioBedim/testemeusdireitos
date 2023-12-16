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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int var = int.Parse(textBox1.Text), total = 0;
                R100.Text = "0";
                R50.Text = "0";
                R20.Text = "0";
                R10.Text = "0";
                R5.Text = "0";
                R2.Text = "0";
                R1.Text = "0";

                if (var > 0)
                {
                    

                        if ((var / 100) >= 1)
                        {

                            total = var / 100;
                            var -= total * 100;
                            int text100 = int.Parse(R100.Text);
                            text100 += total;
                            R100.Text = text100.ToString();

                        }
                        if ((var / 50) >= 1)
                        {
                            total = var / 50;
                        var -= total * 50;
                        int text50 = int.Parse(R50.Text);
                            text50 += total;
                            R50.Text = text50.ToString();

                        }
                        if ((var / 20) >= 1)
                        {
                        total = var / 20;
                        var -= total * 20;
                        int text20 = int.Parse(R20.Text);
                            text20 += total;
                            R20.Text = text20.ToString();
                        }
                        if ((var / 10) >= 1)
                        {
                        total = var / 10;
                        var -= total * 10;
                        int text10 = int.Parse(R10.Text);
                            text10 += total;
                            R10.Text = text10.ToString();
                        }
                        if ((var / 5) >= 1)
                        {
                        total = var / 5;
                        var -= total * 5;
                        int text5 = int.Parse(R5.Text);
                            text5 += total;
                            R5.Text = text5.ToString();
                        }
                        if ((var / 2) >= 1)
                        {
                        total = var / 2;
                        var -= total * 2;
                        int text2 = int.Parse(R2.Text);
                            text2 += total;
                            R2.Text = text2.ToString();
                        }
                        if ((var / 1) >= 1)
                        {
                        total = var / 1;
                        var -= total * 1;
                        int text1 = int.Parse(R1.Text);
                            text1 += total;
                            R1.Text = text1.ToString();

                        }
                    }
                
                else
                {
                    MessageBox.Show("Insira um número acima de 0!");
                }
            }
            catch
            {
                MessageBox.Show("Insira um número!");
            }
        }
    }
}
