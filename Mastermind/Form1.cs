using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Mastermind : Form
    {
        double runde = 1, zug = 1, code1, code2, code3, code4, check1, check2, check3, check4, schwarz = 0, grau=0;


        
        /*for (zug <= 4; zug++)
            {
            if (weisbt_Click == true)
                    bt11.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
            }*/



    private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public Mastermind()
        {
            InitializeComponent();
        }

    private void btstart_Click(object sender, EventArgs e)
        {
            Random zufall = new Random();   //zufallszahlen für code generieren
            code1 = zufall.Next(1, 7);
            code2 = zufall.Next(1, 7);
            code3 = zufall.Next(1, 7);
            code4 = zufall.Next(1, 7); // 1 = weiß, 2 = pink, 3 = gelb, 4 = grün, 5 = rot, 6 = blau
            testlabel.Text = Convert.ToString(code1) + Convert.ToString(code2) + Convert.ToString(code3) + Convert.ToString(code4);
            btstart.Visible = false;
        }

        enum Zugwert
        {
            Zug1,
            Zug2,
            Zug3,
            Zug4,
        }




    //                                                                  WEIß!!!!!!

    private void weisbt_Click(object sender, EventArgs e)
        {
            if (runde == 1)
            {
                if (zug == 1)
                {
                    bt11.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt12.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt13.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt14.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 2)
            {
                if (zug == 1)
                {
                    bt21.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt22.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt23.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt24.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 3)
            {
                if (zug == 1)
                {
                    bt31.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt32.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt33.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt34.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 4)
            {
                if (zug == 1)
                {
                    bt41.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt42.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt43.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt44.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 5)
            {
                if (zug == 1)
                {
                    bt51.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt52.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt53.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt54.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 6)
            {
                if (zug == 1)
                {
                    bt61.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt62.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt63.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt64.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 7)
            {
                if (zug == 1)
                {
                    bt71.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt72.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt73.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt74.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
            if (runde == 8)
            {
                if (zug == 1)
                {
                    bt81.BackColor = weisbt.BackColor;
                    check1 = 1;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt82.BackColor = weisbt.BackColor;
                    check2 = 1;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt83.BackColor = weisbt.BackColor;
                    check3 = 1;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt84.BackColor = weisbt.BackColor;
                    check4 = 1;
                    btok.Visible = true;
                }
            }
        }

        //                                                              PINK!!!

        private void pinkbt_Click(object sender, EventArgs e)
        {
            if (runde == 1)
            {
                if (zug == 1)
                {
                    bt11.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt12.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt13.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt14.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 2)
            {
                if (zug == 1)
                {
                    bt21.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt22.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt23.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt24.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 3)
            {
                if (zug == 1)
                {
                    bt31.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt32.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt33.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt34.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 4)
            {
                if (zug == 1)
                {
                    bt41.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt42.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt43.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt44.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 5)
            {
                if (zug == 1)
                {
                    bt51.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt52.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt53.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt54.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 6)
            {
                if (zug == 1)
                {
                    bt61.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt62.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt63.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt64.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 7)
            {
                if (zug == 1)
                {
                    bt71.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt72.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt73.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt74.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
            if (runde == 8)
            {
                if (zug == 1)
                {
                    bt81.BackColor = pinkbt.BackColor;
                    check1 = 2;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt82.BackColor = pinkbt.BackColor;
                    check2 = 2;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt83.BackColor = pinkbt.BackColor;
                    check3 = 2;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt84.BackColor = pinkbt.BackColor;
                    check4 = 2;
                    btok.Visible = true;
                }
            }
        }

        //                                                              GELB!!!!!

        private void gelbbt_Click(object sender, EventArgs e)
        {
            if (runde == 1)
            {
                if (zug == 1)
                {
                    bt11.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt12.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt13.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt14.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 2)
            {
                if (zug == 1)
                {
                    bt21.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt22.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt23.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt24.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 3)
            {
                if (zug == 1)
                {
                    bt31.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt32.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt33.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt34.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 4)
            {
                if (zug == 1)
                {
                    bt41.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt42.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt43.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt44.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 5)
            {
                if (zug == 1)
                {
                    bt51.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt52.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt53.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt54.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 6)
            {
                if (zug == 1)
                {
                    bt61.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt62.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt63.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt64.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 7)
            {
                if (zug == 1)
                {
                    bt71.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt72.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt73.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt74.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
            if (runde == 8)
            {
                if (zug == 1)
                {
                    bt81.BackColor = gelbbt.BackColor;
                    check1 = 3;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt82.BackColor = gelbbt.BackColor;
                    check2 = 3;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt83.BackColor = gelbbt.BackColor;
                    check3 = 3;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt84.BackColor = gelbbt.BackColor;
                    check4 = 3;
                    btok.Visible = true;
                }
            }
        }

        //                                                          GRÜN!!!!!!

        private void grunbt_Click(object sender, EventArgs e)
        {
            if (runde == 1)
            {
                if (zug == 1)
                {
                    bt11.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt12.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt13.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt14.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 2)
            {
                if (zug == 1)
                {
                    bt21.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt22.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt23.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt24.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 3)
            {
                if (zug == 1)
                {
                    bt31.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt32.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt33.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt34.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 4)
            {
                if (zug == 1)
                {
                    bt41.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt42.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt43.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt44.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 5)
            {
                if (zug == 1)
                {
                    bt51.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt52.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt53.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt54.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 6)
            {
                if (zug == 1)
                {
                    bt61.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt62.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt63.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt64.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 7)
            {
                if (zug == 1)
                {
                    bt71.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt72.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt73.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt74.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
            if (runde == 8)
            {
                if (zug == 1)
                {
                    bt81.BackColor = grunbt.BackColor;
                    check1 = 4;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt82.BackColor = grunbt.BackColor;
                    check2 = 4;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt83.BackColor = grunbt.BackColor;
                    check3 = 4;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt84.BackColor = grunbt.BackColor;
                    check4 = 4;
                    btok.Visible = true;
                }
            }
        }

        //                                                      ROT!!!!!!

        private void rotbt_Click(object sender, EventArgs e)
        {
            if (runde == 1)
            {
                if (zug == 1)
                {
                    bt11.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt12.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt13.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt14.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 2)
            {
                if (zug == 1)
                {
                    bt21.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt22.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt23.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt24.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 3)
            {
                if (zug == 1)
                {
                    bt31.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt32.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt33.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt34.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 4)
            {
                if (zug == 1)
                {
                    bt41.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt42.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt43.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt44.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 5)
            {
                if (zug == 1)
                {
                    bt51.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt52.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt53.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt54.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 6)
            {
                if (zug == 1)
                {
                    bt61.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt62.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt63.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt64.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 7)
            {
                if (zug == 1)
                {
                    bt71.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt72.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt73.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt74.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
            if (runde == 8)
            {
                if (zug == 1)
                {
                    bt81.BackColor = rotbt.BackColor;
                    check1 = 5;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt82.BackColor = rotbt.BackColor;
                    check2 = 5;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt83.BackColor = rotbt.BackColor;
                    check3 = 5;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt84.BackColor = rotbt.BackColor;
                    check4 = 5;
                    btok.Visible = true;
                }
            }
        }

        //                                                           BLAU!!!!!

        private void blaubt_Click(object sender, EventArgs e)
        {
            if (runde == 1)
            {
                if (zug == 1)
                {
                    bt11.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt12.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt13.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt14.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 2)
            {
                if (zug == 1)
                {
                    bt21.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt22.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt23.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt24.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 3)
            {
                if (zug == 1)
                {
                    bt31.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt32.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt33.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt34.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 4)
            {
                if (zug == 1)
                {
                    bt41.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt42.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt43.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt44.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 5)
            {
                if (zug == 1)
                {
                    bt51.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt52.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt53.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt54.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 6)
            {
                if (zug == 1)
                {
                    bt61.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt62.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt63.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt64.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 7)
            {
                if (zug == 1)
                {
                    bt71.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt72.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt73.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt74.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
            if (runde == 8)
            {
                if (zug == 1)
                {
                    bt81.BackColor = blaubt.BackColor;
                    check1 = 6;
                    zug = 2;
                }
                else if (zug == 2)
                {
                    bt82.BackColor = blaubt.BackColor;
                    check2 = 6;
                    zug = 3;
                }
                else if (zug == 3)
                {
                    bt83.BackColor = blaubt.BackColor;
                    check3 = 6;
                    zug = 4;
                }
                else if (zug == 4)
                {
                    bt84.BackColor = blaubt.BackColor;
                    check4 = 6;
                    btok.Visible = true;
                }
            }
        }

        //                                                      CHECKER!!!!!!

        private void btok_Click(object sender, EventArgs e)
        {
            //1. check
            if (check1 == code1)
            {
                schwarz++;
            }

            //2. check
            if (check2 == code2)
            {
                schwarz++;
            }

            //3. check
            if (check3 == code3)
            {
                schwarz++;
            }

            //4. check
            if (check4 == code4)
            {
                schwarz++;
            }



            //schwarz
            if (schwarz >= 1)
            {
                if (runde == 1)
                {
                    cb11.Checked = true;
                    cb11.BackColor = Color.Black;
                }
                else if (runde == 2)
                {
                    cb21.Checked = true;
                    cb21.BackColor = Color.Black;
                }
                else if (runde == 3)
                {
                    cb31.Checked = true;
                    cb31.BackColor = Color.Black;
                }
                else if (runde == 4)
                {
                    cb41.Checked = true;
                    cb41.BackColor = Color.Black;
                }
                else if (runde == 5)
                {
                    cb51.Checked = true;
                    cb51.BackColor = Color.Black;
                }
                else if (runde == 6)
                {
                    cb61.Checked = true;
                    cb61.BackColor = Color.Black;
                }
                else if (runde == 7)
                {
                    cb71.Checked = true;
                    cb71.BackColor = Color.Black;
                }
                else if (runde == 8)
                {
                    cb81.Checked = true;
                    cb81.BackColor = Color.Black;
                }
            }
            if (schwarz >= 2)
            {
                if (runde == 1)
                {
                    cb12.Checked = true;
                    cb12.BackColor = Color.Black;
                }
                else if (runde == 2)
                {
                    cb22.Checked = true;
                    cb22.BackColor = Color.Black;
                }
                else if (runde == 3)
                {
                    cb32.Checked = true;
                    cb32.BackColor = Color.Black;
                }
                else if (runde == 4)
                {
                    cb42.Checked = true;
                    cb42.BackColor = Color.Black;
                }
                else if (runde == 5)
                {
                    cb52.Checked = true;
                    cb52.BackColor = Color.Black;
                }
                else if (runde == 6)
                {
                    cb62.Checked = true;
                    cb62.BackColor = Color.Black;
                }
                else if (runde == 7)
                {
                    cb72.Checked = true;
                    cb72.BackColor = Color.Black;
                }
                else if (runde == 8)
                {
                    cb82.Checked = true;
                    cb82.BackColor = Color.Black;
                }
            }
            if (schwarz >= 3)
            {
                if (runde == 1)
                {
                    cb13.Checked = true;
                    cb13.BackColor = Color.Black;
                }
                else if (runde == 2)
                {
                    cb23.Checked = true;
                    cb23.BackColor = Color.Black;
                }
                else if (runde == 3)
                {
                    cb33.Checked = true;
                    cb33.BackColor = Color.Black;
                }
                else if (runde == 4)
                {
                    cb43.Checked = true;
                    cb43.BackColor = Color.Black;
                }
                else if (runde == 5)
                {
                    cb53.Checked = true;
                    cb53.BackColor = Color.Black;
                }
                else if (runde == 6)
                {
                    cb63.Checked = true;
                    cb63.BackColor = Color.Black;
                }
                else if (runde == 7)
                {
                    cb73.Checked = true;
                    cb73.BackColor = Color.Black;
                }
                else if (runde == 8)
                {
                    cb83.Checked = true;
                    cb83.BackColor = Color.Black;
                }
            }
            if (schwarz == 4)
            {
                if (runde == 1)
                {
                    cb14.Checked = true;
                    cb14.BackColor = Color.Black;
                }
                else if (runde == 2)
                {
                    cb24.Checked = true;
                    cb24.BackColor = Color.Black;
                }
                else if (runde == 3)
                {
                    cb34.Checked = true;
                    cb34.BackColor = Color.Black;
                }
                else if (runde == 4)
                {
                    cb44.Checked = true;
                    cb44.BackColor = Color.Black;
                }
                else if (runde == 5)
                {
                    cb54.Checked = true;
                    cb54.BackColor = Color.Black;
                }
                else if (runde == 6)
                {
                    cb64.Checked = true;
                    cb64.BackColor = Color.Black;
                }
                else if (runde == 7)
                {
                    cb74.Checked = true;
                    cb74.BackColor = Color.Black;
                }
                else if (runde == 8)
                {
                    cb84.Checked = true;
                    cb84.BackColor = Color.Black;
                }
                btwin.Visible = true;
                //testlabel.Text = Convert.ToString(schwarz);
            }

            //grau


            if (check1 == code2 | check1 == code3 | check1 == code4)
            {
                grau++;
            }
            if (check2 == code1 | check2 == code3 | check2 == code4)
            {
                grau++;
            }
            if (check3 == code1 | check3 == code2 | check3 == code4)
            {
                grau++;
            }
            if (check4 == code1 | check4 == code2 | check4 == code3)
            {
                grau++;
            }
            if (check2 == code1 && check3 == code1 && check4 == code1)
            {
                grau =- 2;
            }
                else if (check2 == code1 && check3 == code1)
                {
                    grau--;
                }
                else if (check3 == code1 && check4 == code1)
                {
                    grau--;
                }
                else if (check2 == code1 && check4 == code1)
                {
                    grau--;
                }
            if (check1 == code2 && check3 == code2 && check4 == code2)
            {
                grau = -2;
            }
                else if (check1 == code2 && check3 == code2)
                {
                    grau--;
                }
                else if (check3 == code2 && check4 == code2)
                {
                    grau--;
                }
                else if (check1 == code2 && check4 == code2)
                {
                    grau--;
                }
            if (check1 == code3 && check2 == code3 && check4 == code3)
            {
                grau = -2;
            }
                else if (check1 == code3 && check2 == code3)
                {
                    grau--;
                }
                else if (check2 == code3 && check4 == code3)
                {
                    grau--;
                }
                else if (check1 == code3 && check4 == code3)
                {
                    grau--;
                }
            if (check1 == code4 && check2 == code4 && check3 == code4)
            {
                grau = -2;
            }
                else if (check1 == code4 && check2 == code4)
                {
                    grau--;
                }
                else if (check2 == code4 && check3 == code4)
                {
                    grau--;
                }
                else if (check1 == code4 && check3 == code4)
                {
                    grau--;
                }








            if (grau >= 1)
            {
                if (runde == 1)
                {
                    if (schwarz == 0)
                    {
                        cb11.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb12.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb13.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb14.Checked = true;
                    }
                }
                else if (runde == 2)
                {
                    if (schwarz == 0)
                    {
                        cb21.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb22.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb23.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb24.Checked = true;
                    }
                }
                else if (runde == 3)
                {
                    if (schwarz == 0)
                    {
                        cb31.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb32.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb33.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb34.Checked = true;
                    }
                }
                else if (runde == 4)
                {
                    if (schwarz == 0)
                    {
                        cb41.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb42.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb43.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb44.Checked = true;
                    }
                }
                else if (runde == 5)
                {
                    if (schwarz == 0)
                    {
                        cb51.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb52.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb53.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb54.Checked = true;
                    }
                }
                else if (runde == 6)
                {
                    if (schwarz == 0)
                    {
                        cb61.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb62.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb63.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb64.Checked = true;
                    }
                }
                else if (runde == 7)
                {
                    if (schwarz == 0)
                    {
                        cb71.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb72.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb73.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb74.Checked = true;
                    }
                }
                else if (runde == 8)
                {
                    if (schwarz == 0)
                    {
                        cb81.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb82.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb83.Checked = true;
                    }
                    else if (schwarz == 3)
                    {
                        cb84.Checked = true;
                    }
                }
            }
            if (grau >= 2)
            {
                if (runde == 1)
                {
                    if (schwarz == 0)
                    {
                        cb12.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb13.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb14.Checked = true;
                    }
                }
                else if (runde == 2)
                {
                    if (schwarz == 0)
                    {
                        cb22.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb23.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb24.Checked = true;
                    }
                }
                else if (runde == 3)
                {
                    if (schwarz == 0)
                    {
                        cb32.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb33.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb34.Checked = true;
                    }
                }
                else if (runde == 4)
                {
                    if (schwarz == 0)
                    {
                        cb42.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb43.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb44.Checked = true;
                    }
                }
                else if (runde == 5)
                {
                    if (schwarz == 0)
                    {
                        cb52.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb53.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb54.Checked = true;
                    }
                }
                else if (runde == 6)
                {
                    if (schwarz == 0)
                    {
                        cb62.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb63.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb64.Checked = true;
                    }
                }
                else if (runde == 7)
                {
                    if (schwarz == 0)
                    {
                        cb72.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb73.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb74.Checked = true;
                    }
                }
                else if (runde == 8)
                {
                    if (schwarz == 0)
                    {
                        cb82.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb83.Checked = true;
                    }
                    else if (schwarz == 2)
                    {
                        cb84.Checked = true;
                    }
                }
            }
            if (grau >= 3)
            {
                if (runde == 1)
                {
                    if (schwarz == 0)
                    {
                        cb13.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb14.Checked = true;
                    }
                }
                else if (runde == 2)
                {
                    if (schwarz == 0)
                    {
                        cb23.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb24.Checked = true;
                    }
                }
                else if (runde == 3)
                {
                    if (schwarz == 0)
                    {
                        cb33.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb34.Checked = true;
                    }
                }
                else if (runde == 4)
                {
                    if (schwarz == 0)
                    {
                        cb43.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb44.Checked = true;
                    }
                }
                else if (runde == 5)
                {
                    if (schwarz == 0)
                    {
                        cb53.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb54.Checked = true;
                    }
                }
                else if (runde == 6)
                {
                    if (schwarz == 0)
                    {
                        cb63.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb64.Checked = true;
                    }
                }
                else if (runde == 7)
                {
                    if (schwarz == 0)
                    {
                        cb73.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb74.Checked = true;
                    }
                }
                else if (runde == 8)
                {
                    if (schwarz == 0)
                    {
                        cb83.Checked = true;
                    }
                    else if (schwarz == 1)
                    {
                        cb84.Checked = true;
                    }
                }
            }
            if (grau == 4)
            {
                if (runde == 1)
                {
                    cb14.Checked = true;
                }
                else if (runde == 2)
                {
                    cb24.Checked = true;
                }
                else if (runde == 3)
                {
                    cb34.Checked = true;
                }
                else if (runde == 4)
                {
                    cb44.Checked = true;
                }
                else if (runde == 5)
                {
                    cb54.Checked = true;
                }
                else if (runde == 6)
                {
                    cb64.Checked = true;
                }
                else if (runde == 7)
                {
                    cb74.Checked = true;
                }
                else if (runde == 8)
                {
                    cb84.Checked = true;
                }
            }

            btok.Visible = false;

            zug = 1;
            grau = 0;
            schwarz = 0;
            
            if (runde == 1)
            {
                runde = 2;
            }
            else if (runde == 2)
            {
                runde = 3;
            }
            else if (runde == 3)
            {
                runde = 4;
            }
            else if (runde == 4)
            {
                runde = 5;
            }
            else if (runde == 5)
            {
                runde = 6;
            }
            else if (runde == 6)
            {
                runde = 7;
            }
            else if (runde == 7)
            {
                runde = 8;
            }
            else if (runde == 8)
            {
                if (btwin.Visible == false)
                {
                    btlose.Visible = true;
                }
            }



            /*float check(float wert1, float wert2){
                float ergebnis
                if (wert1 == wert2)
                {
                    ergebnis = 1;
                    return ergebnis;
                }
                else
                {
                    ergebnis = 0;
                    return ergebnis;
                }*/

        }

        private void Mastermind_Load(object sender, EventArgs e)
        {
        }
    }
}
