using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BterKaasEieren
{
    public partial class Form1 : Form
    {

        //
        //Vars
        //
        int BO = 0;
        Color speler1Kleur = Color.Gray;
        Color speler2Kleur = Color.Gray;

        public Form1()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //

        //Dit zijn 2 methodes om te kijken of een nummer even of oneven is
        public static bool IsOneven(int value)
        {
            return value % 2 != 0;
        }
        public static bool Iseven(int value)
        {
            return value % 2 == 0;
        }


        //Eerst maak ik een methode om de speler kleur te kiezen.
        private void KiesKleur(bool isSpeler1, Button button)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if(isSpeler1 == true)
                {
                    speler1Kleur = colorDialog1.Color;
                    if(speler1Kleur == btn1.BackColor) { MessageBox.Show("Sorry deze keuze is ongeldig.");}
                    button.BackColor = speler1Kleur;
                }
                if(isSpeler1 == false)
                {
                    speler2Kleur = colorDialog1.Color;
                    button.BackColor = speler2Kleur;
                }
            }
        }
        //Nu we de Kleur gekozen hebben maken we een methode die we elke beurt uitvoert.
        private void Beurt(Button button)
        {
            if (button.BackColor != speler1Kleur)
            {
                if (button.BackColor != speler2Kleur)
                {
                    BO = BO + 1;
                    if (IsOneven(BO))
                    {
                        button.BackColor = speler1Kleur;
                    }
                    if (Iseven(BO))
                    {
                        button.BackColor = speler2Kleur;
                    }
                    lblBO.Text = BO.ToString();
                    EindBeurt();
                    if(BO >= 9)
                    {
                        GelijkSpel();
                    }
                }
            }
            else { MessageBox.Show("Bezet!"); }

        }
        private void GelijkSpel()
        {
            MessageBox.Show("Helaas! Gelijkspel");
            btn1.BackColor = Color.Gainsboro;
            btn2.BackColor = Color.Gainsboro;
            btn3.BackColor = Color.Gainsboro;
            btn4.BackColor = Color.Gainsboro;
            btn5.BackColor = Color.Gainsboro;
            btn6.BackColor = Color.Gainsboro;
            btn7.BackColor = Color.Gainsboro;
            btn8.BackColor = Color.Gainsboro;
            btn9.BackColor = Color.Gainsboro;
            btnPlayer1.BackColor = Color.Gray;
            btnPlayer2.BackColor = Color.Gray;
            BO = 0;
        }
        private void EindBeurt()
        {
            if (btn1.BackColor != Color.Gainsboro)
            {
                    if (btn1.BackColor == btn4.BackColor)
                    {
                        if (btn4.BackColor == btn7.BackColor)
                        {
                            Win(btn1.BackColor);
                        }
                    }
                    if (btn1.BackColor == btn5.BackColor)
                    {
                        if (btn5.BackColor == btn9.BackColor)
                        {
                            Win(btn1.BackColor);
                        }
                    }
                    if (btn1.BackColor == btn2.BackColor)
                    {
                        if (btn2.BackColor == btn3.BackColor)
                        {
                            Win(btn1.BackColor);
                        }
                    }
            }
            if (btn3.BackColor != Color.Gainsboro)
            {
                    if (btn3.BackColor == btn5.BackColor)
                    {
                        if (btn5.BackColor == btn7.BackColor)
                        {
                            Win(btn3.BackColor);
                        }
                    }
                    if (btn3.BackColor == btn6.BackColor)
                    {
                        if (btn6.BackColor == btn9.BackColor)
                        {
                            Win(btn3.BackColor);
                        }
                    }  
            }
            if (btn4.BackColor != Color.Gainsboro)
            {
                    if (btn4.BackColor == btn5.BackColor)
                    {
                        if (btn5.BackColor == btn6.BackColor)
                        {
                            Win(btn4.BackColor);
                        }
                    }
                }
            if (btn2.BackColor != Color.Gainsboro)
            {
                    if (btn2.BackColor == btn5.BackColor)
                    {
                        if (btn5.BackColor == btn8.BackColor)
                        {
                            Win(btn2.BackColor);
                        }
                    }
            }
            if (btn7.BackColor != Color.Gainsboro)
            {
                if (btn7.BackColor == btn8.BackColor)
                {
                    if (btn8.BackColor == btn9.BackColor)
                    {
                        Win(btn7.BackColor);
                    }
                }
            }
        }
        private void Win(Color winKleur)
        {
            if(btnPlayer1.BackColor == winKleur)
            {
                MessageBox.Show("Hoera, Speler 1 heeft gewonnen.");
            }
            else
            {
                MessageBox.Show("Hoera, Speler 2 heeft gewonnen.");

            }
            btn1.BackColor = Color.Gainsboro;
            btn2.BackColor = Color.Gainsboro;
            btn3.BackColor = Color.Gainsboro;
            btn4.BackColor = Color.Gainsboro;
            btn5.BackColor = Color.Gainsboro;
            btn6.BackColor = Color.Gainsboro;
            btn7.BackColor = Color.Gainsboro;
            btn8.BackColor = Color.Gainsboro;
            btn9.BackColor = Color.Gainsboro;
            btnPlayer1.BackColor = Color.Gray;
            btnPlayer2.BackColor = Color.Gray;
            BO = 0;
        }
        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            KiesKleur(true, btnPlayer1);
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            KiesKleur(false, btnPlayer2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Beurt(btn7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Beurt(btn8);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Beurt(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Beurt(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Beurt(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Beurt(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Beurt(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Beurt(btn6);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Beurt(btn9);
        }
    }
}
