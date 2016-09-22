using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voledig_reken_machinen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPLUS_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Length == 0 && label1.Text.Length == 0)
            {
                textBox1.Text = textBox2.Text;
                label1.Text = "+";
                textBox2.Clear();
            }
            else
            {
                if (label1.Text == "+")
                {
                    MessageBox.Show("you didn't out a number in ",
                        "error",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);

                }



                else
                {
                    if (label1.Text == "+")
                    {
                        double resultaat;
                        resultaat = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                        textBox2.Clear();
                        textBox1.Text = resultaat.ToString();


                    }
                    else
                    {
                        if (textBox2.Text == "")
                        {
                            MessageBox.Show("you didn't out a number in ",
                                "error",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error);

                        }
                        else
                        {
                            if (textBox1.Text.Length > 0 && label1.Text.Length > 0)
                            {

                                label1.Text = "+";
                                double resultaat;
                                resultaat = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                                textBox2.Clear();
                                textBox1.Text = resultaat.ToString();

                            }



                        }
                    }
                }
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            int getal1;
            getal1 = 1;
            textBox2.Text = textBox2.Text + getal1.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 2;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 3;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 4;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 5;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 6;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 7;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 8;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 9;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int getal2;
            getal2 = 0;
            textBox2.Text = textBox2.Text + getal2.ToString();
        }

        private void btnMIN_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 && label1.Text.Length == 0)
            {
                textBox1.Text = textBox2.Text;
                label1.Text = "-";
                textBox2.Clear();
            }
            else
            {
                if (label1.Text == "-")
                {
                    double resultaat;
                    resultaat = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                    textBox2.Clear();
                    textBox1.Text = resultaat.ToString();


                }
                else
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("you didn't out a number in ",
                            "error",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Error);

                    }

                    else
                    {
                        if (label1.Text == "-")
                        {
                            int resultaat;
                            resultaat = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                            textBox2.Clear();
                            textBox1.Text = resultaat.ToString();

                        }
                        else
                        {
                            if (textBox1.Text.Length > 0 && label1.Text.Length > 0)
                            {

                                label1.Text = "-";
                                double resultaat;
                                resultaat = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                                textBox2.Clear();
                                textBox1.Text = resultaat.ToString();

                            }


                        }
                    }


                }
            }
        }

        private void btnmaal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && label1.Text.Length == 0)
            {
                textBox1.Text = textBox2.Text;
                label1.Text = "*";
                textBox2.Clear();
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("you didn't out a number in ",
                        "error",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);

                }

                else
                {
                    if (label1.Text == "*")
                    {
                        double resultaat;
                        resultaat = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                        textBox2.Clear();
                        textBox1.Text = resultaat.ToString();


                    }
                    else
                    {
                        if (label1.Text == "*")
                        {
                            double resultaat;
                            resultaat = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                            textBox2.Clear();
                            textBox1.Text = resultaat.ToString();

                        }
                        else
                        {
                            if (textBox1.Text.Length > 0 && label1.Text.Length > 0)
                            {

                                label1.Text = "*";
                                double resultaat;
                                resultaat = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                                textBox2.Clear();
                                textBox1.Text = resultaat.ToString();

                            }


                        }
                    }
                }
            }
        }

        private void btnPROCENT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && label1.Text.Length == 0)
            {
                textBox1.Text = textBox2.Text;
                label1.Text = "%";
                textBox2.Clear();
            }
            else
            {

                if (textBox2.Text == "")
                {
                    MessageBox.Show("you didn't out a number in ",
                        "error",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);

                }

                else
                {
                    if (label1.Text == "%")
                    {
                        double resultaat;
                        resultaat = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                        textBox2.Clear();
                        textBox1.Text = resultaat.ToString();


                    }
                    else
                    {
                        if (textBox1.Text.Length > 0 && label1.Text.Length > 0)
                        {

                            label1.Text = "%";
                            double delen, resultaat, maal;
                            delen = Convert.ToDouble(textBox1.Text) / 100;
                            maal = delen * Convert.ToDouble(textBox2.Text);
                            resultaat = maal;

                            textBox2.Clear();
                            textBox1.Text = resultaat.ToString();

                        }
                        else
                        {
                            if (textBox1.Text.Length > 0 && label1.Text.Length > 0)
                            {

                                label1.Text = "%";
                                double delen, resultaat, maal;
                                delen = Convert.ToDouble(textBox1.Text) / 100;
                                maal = delen * Convert.ToDouble(textBox2.Text);
                                resultaat = maal;

                                textBox2.Clear();
                                textBox1.Text = resultaat.ToString();

                            }


                        }
                    }
                }
            }
        }

        private void btnGEDEELT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && label1.Text.Length == 0)
            {
                textBox1.Text = textBox2.Text;
                label1.Text = "/";
                textBox2.Clear();
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("you didn't out a number in ",
                        "error",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);

                }


                else
                {
                    if (label1.Text == "/")
                    {
                        double resultaat;
                        resultaat = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                        textBox2.Clear();
                        textBox1.Text = resultaat.ToString();


                    }
                    else
                    {
                        if (label1.Text == "/")
                        {
                            double resultaat;
                            resultaat = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                            textBox2.Clear();
                            textBox1.Text = resultaat.ToString();

                        }
                        else
                        {
                            if (textBox1.Text.Length > 0 && label1.Text.Length > 0)
                            {

                                label1.Text = "/";
                                double resultaat;
                                resultaat = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                                textBox2.Clear();
                                textBox1.Text = resultaat.ToString();

                            }



                        }
                    }
                }
            }
        }

        private void btnAFSUITEN_Click(object sender, EventArgs e)
        {
            DialogResult atwoord;
            atwoord = MessageBox.Show("wil je dit programma afsluiten",
                 "afsluiten",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (atwoord == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnWISSEN_Click(object sender, EventArgs e)
        {
            DialogResult atwoord;
            atwoord = MessageBox.Show("wil je dit wissen",
                "wissen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (atwoord == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                label1.Text = "";
            }
        }

        private void btnGELIJKAAN_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("you didn't out a number in ",
                    "error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (label1.Text == "-")
                {
                    int resultaat;
                    resultaat = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                    textBox1.Text = resultaat.ToString();
                    textBox2.Clear();
                }
                else
                {
                    if (label1.Text == "+")
                    {
                        int resultaat;
                        resultaat = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                        textBox1.Text = resultaat.ToString();
                        textBox2.Clear();
                    }




                    else
                    {
                        if (label1.Text == "%")
                        {
                            double resultaat, delen, maal;
                            delen = Convert.ToDouble(textBox1.Text) / 100;
                            maal = delen * Convert.ToDouble(textBox2.Text);
                            resultaat = maal;
                            textBox1.Text = resultaat.ToString();
                            textBox2.Clear();


                        }
                        else
                        {
                            if (label1.Text == "/")
                            {
                                int resultaat;
                                resultaat = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                                textBox1.Text = resultaat.ToString();
                                textBox2.Clear();
                            }
                            else
                            {
                                if (label1.Text == "*")
                                {
                                    int resultaat;
                                    resultaat = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                                    textBox1.Text = resultaat.ToString();
                                    textBox2.Clear();
                                }
                            }
                        }
                    }
                }
            }

        }

        private void btnaply_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Blue || btn1.BackColor == Color.Yellow || btn1.BackColor == Color.Red || btn1.BackColor == Color.Purple || btn1.BackColor == Color.Green || btn1.BackColor==Color.Orange)
            {
                chbblauw.Checked = false;
                chbgeel.Checked = false;
                chbrood.Checked = false;
                btn1.BackColor = Color.FromArgb(244, 244, 244);
                btn2.BackColor = Color.FromArgb(244, 244, 244);
                btn3.BackColor = Color.FromArgb(244, 244, 244);
                btn4.BackColor = Color.FromArgb(244, 244, 244);
                btn5.BackColor = Color.FromArgb(244, 244, 244);
                btn6.BackColor = Color.FromArgb(244, 244, 244);
                btn7.BackColor = Color.FromArgb(244, 244, 244);
                btn8.BackColor = Color.FromArgb(244, 244, 244);
                btn9.BackColor = Color.FromArgb(244, 244, 244);
                btn0.BackColor = Color.FromArgb(244, 244, 244);
                btnAFSUITEN.BackColor = Color.FromArgb(244, 244, 244);
                btnaply.BackColor = Color.FromArgb(244, 244, 244);
                btnGEDEELT.BackColor = Color.FromArgb(244, 244, 244);
                btnGELIJKAAN.BackColor = Color.FromArgb(244, 244, 244);
                btnmaal.BackColor = Color.FromArgb(244, 244, 244);
                btnMIN.BackColor = Color.FromArgb(244, 244, 244); btnPLUS.BackColor = Color.FromArgb(244, 244, 244);
                btnPROCENT.BackColor = Color.FromArgb(244, 244, 244);
                btnWISSEN.BackColor = Color.FromArgb(244, 244, 244);

            }
           
                    else
                                {
                    if (chbgeel.Checked && chbrood.Checked)
                    {
                        btn1.BackColor = Color.Orange;
                        btn2.BackColor = Color.Orange;
                        btn3.BackColor = Color.Orange;
                        btn4.BackColor = Color.Orange;
                        btn5.BackColor = Color.Orange;
                        btn6.BackColor = Color.Orange;
                        btn7.BackColor = Color.Orange;
                        btn8.BackColor = Color.Orange;
                        btn9.BackColor = Color.Orange;
                        btn0.BackColor = Color.Orange;
                        btnAFSUITEN.BackColor = Color.Orange;
                        btnaply.BackColor = Color.Orange;
                        btnGEDEELT.BackColor = Color.Orange;
                        btnGELIJKAAN.BackColor = Color.Orange;
                        btnmaal.BackColor = Color.Orange;
                        btnPLUS.BackColor = Color.Orange;
                        btnPROCENT.BackColor = Color.Orange;
                        btnWISSEN.BackColor = Color.Orange;
                        btnMIN.BackColor = Color.Orange;
                    }
                else
                {
                    if (chbblauw.Checked && chbgeel.Checked)
                    {
                        btn1.BackColor = Color.Green;
                        btn2.BackColor = Color.Green;
                        btn3.BackColor = Color.Green;
                        btn4.BackColor = Color.Green;
                        btn5.BackColor = Color.Green;
                        btn6.BackColor = Color.Green;
                        btn7.BackColor = Color.Green;
                        btn8.BackColor = Color.Green;
                        btn9.BackColor = Color.Green;
                        btn0.BackColor = Color.Green;
                        btnAFSUITEN.BackColor = Color.Green;
                        btnaply.BackColor = Color.Green;
                        btnGEDEELT.BackColor = Color.Green;
                        btnGELIJKAAN.BackColor = Color.Green;
                        btnmaal.BackColor = Color.Green;
                        btnPLUS.BackColor = Color.Green;
                        btnPROCENT.BackColor = Color.Green;
                        btnWISSEN.BackColor = Color.Green;
                        btnMIN.BackColor = Color.Green;
                        }
                    else
                    {
                        if (chbblauw.Checked && chbrood.Checked)
                        {
                            btn1.BackColor = Color.Purple;
                            btn2.BackColor = Color.Purple;
                            btn3.BackColor = Color.Purple;
                            btn4.BackColor = Color.Purple;
                            btn5.BackColor = Color.Purple;
                            btn6.BackColor = Color.Purple;
                            btn7.BackColor = Color.Purple;
                            btn8.BackColor = Color.Purple;
                            btn9.BackColor = Color.Purple;
                            btn0.BackColor = Color.Purple;
                            btnAFSUITEN.BackColor = Color.Purple;
                            btnaply.BackColor = Color.Purple;
                            btnGEDEELT.BackColor = Color.Purple;
                            btnGELIJKAAN.BackColor = Color.Purple;
                            btnmaal.BackColor = Color.Purple;
                            btnPLUS.BackColor = Color.Purple;
                            btnPROCENT.BackColor = Color.Purple;
                            btnWISSEN.BackColor = Color.Purple;
                            btnMIN.BackColor = Color.Purple;
                        }


                        else
                        {
                if (chbblauw.Checked)
                {
                    btn1.BackColor = Color.Blue;
                    btn2.BackColor = Color.Blue;
                    btn3.BackColor = Color.Blue;
                    btn4.BackColor = Color.Blue;
                    btn5.BackColor = Color.Blue;
                    btn6.BackColor = Color.Blue;
                    btn7.BackColor = Color.Blue;
                    btn8.BackColor = Color.Blue;
                    btn9.BackColor = Color.Blue;
                    btn0.BackColor = Color.Blue;
                    btnAFSUITEN.BackColor = Color.Blue;
                    btnaply.BackColor = Color.Blue;
                    btnGEDEELT.BackColor = Color.Blue;
                    btnGELIJKAAN.BackColor = Color.Blue;
                    btnmaal.BackColor = Color.Blue;
                    btnPLUS.BackColor = Color.Blue;
                    btnPROCENT.BackColor = Color.Blue;
                    btnWISSEN.BackColor = Color.Blue;
                    btnMIN.BackColor = Color.Blue;
                }




                else
                {
                    if (chbgeel.Checked)
                    {
                        btn1.BackColor = Color.Yellow;
                        btn2.BackColor = Color.Yellow;
                        btn3.BackColor = Color.Yellow;
                        btn4.BackColor = Color.Yellow;
                        btn5.BackColor = Color.Yellow;
                        btn6.BackColor = Color.Yellow;
                        btn7.BackColor = Color.Yellow;
                        btn8.BackColor = Color.Yellow;
                        btn9.BackColor = Color.Yellow;
                        btn0.BackColor = Color.Yellow;
                        btnAFSUITEN.BackColor = Color.Yellow;
                        btnaply.BackColor = Color.Yellow;
                        btnGEDEELT.BackColor = Color.Yellow;
                        btnGELIJKAAN.BackColor = Color.Yellow;
                        btnmaal.BackColor = Color.Yellow;
                        btnPLUS.BackColor = Color.Yellow;
                        btnPROCENT.BackColor = Color.Yellow;
                        btnWISSEN.BackColor = Color.Yellow;
                        btnMIN.BackColor = Color.Yellow;
                    }


                    else
                    {
                        if (chbrood.Checked)
                        {
                            btn1.BackColor = Color.Red;
                            btn2.BackColor = Color.Red;
                            btn3.BackColor = Color.Red;
                            btn4.BackColor = Color.Red;
                            btn5.BackColor = Color.Red;
                            btn6.BackColor = Color.Red;
                            btn7.BackColor = Color.Red;
                            btn8.BackColor = Color.Red;
                            btn9.BackColor = Color.Red;
                            btn0.BackColor = Color.Red;
                            btnAFSUITEN.BackColor = Color.Red;
                            btnaply.BackColor = Color.Red;
                            btnGEDEELT.BackColor = Color.Red;
                            btnGELIJKAAN.BackColor = Color.Red;
                            btnmaal.BackColor = Color.Red;
                            btnPLUS.BackColor = Color.Red;
                            btnPROCENT.BackColor = Color.Red;
                            btnWISSEN.BackColor = Color.Red;
                            btnMIN.BackColor = Color.Red;
                        }


                       

                           
                                }

                            
                                }
                            }
                        }
                    }
                }
            }
        }
    }






