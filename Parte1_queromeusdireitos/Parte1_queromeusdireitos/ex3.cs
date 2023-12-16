using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte1_queromeusdireitos
{
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";
            label25.Text = "0";
            label26.Text = "0";
            label27.Text = "0";
            label28.Text = "0";
            label29.Text = "0";

            //char[] vetor = new char[255];
            string hold = textBox1.Text.ToUpper();

                for (int i = 0; i < textBox1.TextLength; i++)
                {
                    switch (hold[i])
                    {

                        case 'A':
                            int varA = int.Parse(label1.Text);
                            varA++;
                            label1.Text = varA.ToString();

                            break;
                        case 'B':
                            int varB = int.Parse(label5.Text);
                            varB++;
                            label5.Text = varB.ToString();

                            break;
                        case 'C':
                            int varC = int.Parse(label6.Text);
                            varC++;
                            label6.Text = varC.ToString();

                            break;
                        case 'D':
                            int varD = int.Parse(label7.Text);
                            varD++;
                            label7.Text = varD.ToString();
                            break;
                        case 'E':
                            int varE = int.Parse(label8.Text);
                            varE++;
                            label8.Text = varE.ToString();
                            break;
                        case 'F':
                            int varF = int.Parse(label9.Text);
                            varF++;
                            label9.Text = varF.ToString();
                            break;
                        case 'G':
                            int varG = int.Parse(label10.Text);
                            varG++;
                            label10.Text = varG.ToString();
                            break;
                        case 'H':
                            int varH = int.Parse(label11.Text);
                            varH++;
                            label11.Text = varH.ToString();
                            break;
                        case 'I':
                            int varI = int.Parse(label12.Text);
                            varI++;
                            label12.Text = varI.ToString();
                            break;
                        case 'J':
                            int varJ = int.Parse(label13.Text);
                            varJ++;
                            label13.Text = varJ.ToString();
                            break;
                        case 'K':
                            int varK = int.Parse(label14.Text);
                            varK++;
                            label14.Text = varK.ToString();
                            break;
                        case 'L':
                            int varL = int.Parse(label15.Text);
                            varL++;
                            label15.Text = varL.ToString();
                            break;
                        case 'M':
                            int varM = int.Parse(label16.Text);
                            varM++;
                            label16.Text = varM.ToString();
                            break;
                        case 'N':
                            int varN = int.Parse(label17.Text);
                            varN++;
                            label17.Text = varN.ToString();
                            break;
                        case 'O':
                            int varO = int.Parse(label18.Text);
                            varO++;
                            label18.Text = varO.ToString();
                            break;
                        case 'P':
                            int varP = int.Parse(label19.Text);
                            varP++;
                            label19.Text = varP.ToString();
                            break;
                        case 'Q':
                            int varQ = int.Parse(label20.Text);
                            varQ++;
                            label20.Text = varQ.ToString();
                            break;
                        case 'R':
                            int varR = int.Parse(label21.Text);
                            varR++;
                            label21.Text = varR.ToString();
                            break;
                        case 'S':
                            int varS = int.Parse(label22.Text);
                            varS++;
                            label22.Text = varS.ToString();
                            break;
                        case 'T':
                            int varT = int.Parse(label23.Text);
                            varT++;
                            label23.Text = varT.ToString();
                            break;
                        case 'U':
                            int varU = int.Parse(label24.Text);
                            varU++;
                            label24.Text = varU.ToString();
                            break;
                        case 'V':
                            int varV = int.Parse(label25.Text);
                            varV++;
                            label25.Text = varV.ToString();
                            break;
                        case 'W':
                            int varW = int.Parse(label26.Text);
                            varW++;
                            label26.Text = varW.ToString();
                            break;
                        case 'X':
                            int varX = int.Parse(label27.Text);
                            varX++;
                            label27.Text = varX.ToString();
                            break;
                        case 'Y':
                            int varY = int.Parse(label28.Text);
                            varY++;
                            label28.Text = varY.ToString();
                            break;
                        case 'Z':
                            int varZ = int.Parse(label29.Text);
                            varZ++;
                            label29.Text = varZ.ToString();
                            break;
                        default: break;
                    }
                }
            }


                }
            }

   
    

