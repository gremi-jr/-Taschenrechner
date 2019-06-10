using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        int aktive_TBx = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zahl1_i = 0, zahl2_i = 0, ergebnis_i = 0;

            try
            {
                zahl1_i = Convert.ToDouble(tBx_Zahl1.Text);
                zahl2_i = Convert.ToDouble(tBx_Zahl2.Text);

                ergebnis_i = zahl1_i + zahl2_i;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte eine Zahl eingeben!");
                return;
            }            

            tBx_Ergebnis.Text = Convert.ToString(ergebnis_i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double zahl1_i = 0, zahl2_i = 0, ergebnis_i = 0;

            try
            {
                zahl1_i = Convert.ToDouble(tBx_Zahl1.Text);
                zahl2_i = Convert.ToDouble(tBx_Zahl2.Text);

                ergebnis_i = zahl1_i * zahl2_i;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte eine Zahl eingeben!");
                return;
            }

            tBx_Ergebnis.Text = Convert.ToString(ergebnis_i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double zahl1_i = 0, zahl2_i = 0, ergebnis_i = 0;

            try
            {
                zahl1_i = Convert.ToDouble(tBx_Zahl1.Text);
                zahl2_i = Convert.ToDouble(tBx_Zahl2.Text);

                ergebnis_i = zahl1_i - zahl2_i;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte eine Zahl eingeben!");
                return;
            }

            tBx_Ergebnis.Text = Convert.ToString(ergebnis_i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double zahl1_i = 0, zahl2_i = 0, ergebnis_i = 0;

            try
            {
                zahl1_i = Convert.ToDouble(tBx_Zahl1.Text);
                zahl2_i = Convert.ToDouble(tBx_Zahl2.Text);

                ergebnis_i = zahl1_i / zahl2_i;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte eine Zahl eingeben!");
                return;
            }

            tBx_Ergebnis.Text = Convert.ToString(ergebnis_i);
        }



        private void tBx_Ergebnis_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (aktive_TBx == 1)
            {
                if (tBx_Zahl1.Text == "Zahl 1")
                    tBx_Zahl1.Text = "1";
                else
                    tBx_Zahl1.Text += "1";
            }
            else if (aktive_TBx == 2)
            {
                if (tBx_Zahl2.Text == "Zahl 2")
                    tBx_Zahl2.Text = "1";
                else
                    tBx_Zahl2.Text += "1";
            }
        }

        private void tBx_Zahl1_Leave(object sender, EventArgs e)
        {
            if (bt_1.Focused || bt_2.Focused || bt_3.Focused || bt_4.Focused || bt_5.Focused || bt_6.Focused || bt_7.Focused || bt_8.Focused || bt_9.Focused || bt_0.Focused)
                aktive_TBx = 1;
            else
                aktive_TBx = 0;

            if (tBx_Zahl1.Text == "")
                tBx_Zahl1.Text = "Zahl 1";
        }

        private void tBx_Zahl2_Leave(object sender, EventArgs e)
        {
            if (bt_1.Focused || bt_2.Focused || bt_3.Focused || bt_4.Focused || bt_5.Focused || bt_6.Focused || bt_7.Focused || bt_8.Focused || bt_9.Focused || bt_0.Focused)
                aktive_TBx = 2;
            else
                aktive_TBx = 0;

            if (tBx_Zahl2.Text == "")
                tBx_Zahl2.Text = "Zahl 2";
        }

        private void Zahl(string nummer, bool eindeutig)
        {
            if (aktive_TBx == 1)
            {
                if (eindeutig)
                    if (tBx_Zahl1.Text.Contains(','))
                        return;  

                if (tBx_Zahl1.Text == "Zahl 1")
                    tBx_Zahl1.Text = nummer;
                else
                    tBx_Zahl1.Text += nummer;
            }
            else if (aktive_TBx == 2)
            {
                if (eindeutig)
                    if (tBx_Zahl2.Text.Contains(','))
                        return;  

                if (tBx_Zahl2.Text == "Zahl 2")
                    tBx_Zahl2.Text = nummer;
                else
                    tBx_Zahl2.Text += nummer;
            }
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            Zahl("2", false);
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            Zahl("3", false);
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            Zahl("4", false);
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            Zahl("5", false);
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            Zahl("6", false);
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            Zahl("7", false);
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            Zahl("8", false);
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            Zahl("9",false);
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            Zahl("0", false);
        }

        private void bt_kommer_Click(object sender, EventArgs e)
        {
            Zahl(",", true);
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            if (aktive_TBx == 1)
            {
                string Text = tBx_Zahl1.Text;
                Text = Text.Substring(0, Text.Length - 1);
                tBx_Zahl1.Text = Text;
            }
            else if (aktive_TBx == 2)
            {
                string Text = tBx_Zahl2.Text;
                Text = Text.Substring(0, Text.Length - 1);
                tBx_Zahl2.Text = Text;
            }
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            tBx_Zahl1.Text = "";
            tBx_Zahl2.Text = "";
            tBx_Ergebnis.Text = "";
        }

        private void tBx_Zahl1_Enter(object sender, EventArgs e)
        {
            if (tBx_Zahl1.Text == "Zahl 1")
                tBx_Zahl1.Text = "";
        }

        private void tBx_Zahl2_Enter(object sender, EventArgs e)
        {
            if (tBx_Zahl2.Text == "Zahl 2")
                tBx_Zahl2.Text = "";
        }
    }
}
