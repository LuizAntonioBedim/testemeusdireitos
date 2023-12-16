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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex1 exer1 = new ex1();
            exer1.ShowDialog();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex2 exer2 = new ex2();
            exer2.ShowDialog();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex3 exer3 = new ex3();
            exer3.ShowDialog();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex4 exer4 = new ex4();
            exer4.ShowDialog();
        }
    }
}
