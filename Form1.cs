using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s_calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue,  enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 *q);
        }

       

         

       

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text=="0")
                txtResult.Text = " ";
            {
                if (num.Text== ".")
                {
                    if(!txtResult.Text. Contains ("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

       

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 350;
            txtResult.Width = 318;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 720;
            txtResult.Width = 666;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("confirm if you want to exit", "scientific calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if(exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg =  Convert.ToDouble(txtResult.Text); 
            logg =  Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);  
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            string f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);
            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();

                    break;


                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();

                    break;


                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();

                    break;

                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();

                    break;
                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();

                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();

                    break;


                default:
                    break;



            }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x, q, p,m;


            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);



            x = (q * p * m);
            txtResult.Text = Convert.ToString(x);

        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));

            txtResult.Text = Convert.ToString(a);
        }



        private void btnlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void btnper_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text)/ Convert.ToDouble(100);

            txtResult.Text = Convert.ToString(a);
        }

        private void btnoct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(txtResult.Text);
            t = Math.Tan(t);
            txtResult.Text = Convert.ToString(t);
        }

        private void btnsinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(txtResult.Text);
            s = Math.Sin(s);
            txtResult.Text = Convert.ToString(s);
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);  

            int i1= Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);



        }

        private void btnbin_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);

             
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtResult.Text);
            c = Math.Cos(c);
            txtResult.Text = Convert.ToString(c);
        }

        private void btncosh_Click(object sender, EventArgs e)
        {
            double ch = Convert.ToDouble(txtResult.Text);
            ch = Math.Cosh(ch);
            txtResult.Text = Convert.ToString(ch);
        }

        private void btntanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(txtResult.Text);
            th = Math.Tanh(th);
            txtResult.Text = Convert.ToString(th);
        }

        private void btnnhex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 350;
            txtResult.Width = 318;
        }
    }
}
