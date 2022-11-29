namespace WinFormsApp_calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string collector = "";
        string firstOP = "";
        string secondOP = "";
        string theOperator = "";
        string operation = "";

        double resultat;

        private double GetResult()
        {
            double firstOPnumeric;
            double secondOPnumeric;


            if (firstOP == "")
            {
                firstOP = "0";
            }
            if (secondOP == "")
            {
                secondOP = "0";
            }
            firstOPnumeric = double.Parse(firstOP);
            secondOPnumeric = double.Parse(secondOP);

            if (theOperator == "+")
            {
                resultat = firstOPnumeric + secondOPnumeric;

            }
            else if (theOperator == "-")
            {
                resultat = firstOPnumeric - secondOPnumeric;
            }
            else if (theOperator == "*")
            {
                if (firstOP == "")
                {
                    firstOPnumeric = 0;
                }
                if (secondOP == "")
                {
                    secondOPnumeric = 1;
                }



                resultat = firstOPnumeric * secondOPnumeric;
            }
            else if (theOperator == "/")
            {
                if (firstOP == "")
                {
                    firstOPnumeric = 0;
                }
                if (secondOP == "")
                {
                    secondOPnumeric = 1;
                }
                if (secondOPnumeric == 0)
                {
                    return resultat = (-9999999999999999);
                }
                resultat = (double)firstOPnumeric / (double)secondOPnumeric;
            }


            return resultat;
        }



        private void BtnZERO_Click(object sender, EventArgs e)
        {
            collector += "0";
            LblOPERATION.Text = collector;
        }

        private void BtnUN_Click(object sender, EventArgs e)
        {
            collector += "1";
            LblOPERATION.Text = collector;
        }
        private void BtnDEUX_Click(object sender, EventArgs e)
        {
            collector += "2";
            LblOPERATION.Text = collector;
        }

        private void BtnTROIS_Click(object sender, EventArgs e)
        {
            collector += "3";
            LblOPERATION.Text = collector;
        }

        private void BtnQUATRE_Click(object sender, EventArgs e)
        {
            collector += "4";
            LblOPERATION.Text = collector;
        }

        private void BtnCINQ_Click(object sender, EventArgs e)
        {
            collector += "5";
            LblOPERATION.Text = collector;
        }

        private void BtnSIX_Click(object sender, EventArgs e)
        {
            collector += "6";
            LblOPERATION.Text = collector;
        }

        private void BtnSEPT_Click(object sender, EventArgs e)
        {
            collector += "7";
            LblOPERATION.Text = collector;
        }

        private void BtnHUIT_Click(object sender, EventArgs e)
        {
            collector += "8";
            LblOPERATION.Text = collector;
        }

        private void BtnNEUF_Click(object sender, EventArgs e)
        {
            collector += "9";
            LblOPERATION.Text = collector;
        }

        private void BtnEGALE_Click(object sender, EventArgs e)
        {
            secondOP = collector;
            collector = "";
            operation += secondOP;

            LblOPERATION.Text = operation;
            if (GetResult() == -9999999999999999)
            {
                LblRESULTAT.Text = "can't divise by zero ";
            }
            else
            {
                LblRESULTAT.Text = GetResult().ToString();
            }
        }

        private void BtnPLUS_Click(object sender, EventArgs e)
        {
            if (firstOP == "")
            {
                firstOP = collector;
            }
            else
            {
                secondOP = collector;
                firstOP = GetResult().ToString();
                secondOP = "";
            }
            collector = "";
            theOperator = "+";
            operation = firstOP + theOperator;
        }

        private void BtnMOIN_Click(object sender, EventArgs e)
        {
            if (firstOP == "")
            {
                firstOP = collector;
            }
            else
            {
                secondOP = collector;
                firstOP = GetResult().ToString();
                secondOP = "";
            }
            collector = "";
            theOperator = "-";
            operation = firstOP + theOperator;
        }

        private void BtnMULTIPLIE_Click(object sender, EventArgs e)
        {
            if (firstOP == "")
            {
                firstOP = collector;
            }
            else
            {
                secondOP = collector;
                firstOP = GetResult().ToString();
                secondOP = "";
            }
            collector = "";
            theOperator = "*";
            operation = firstOP + theOperator;
        }

        private void BtnDIVISE_Click(object sender, EventArgs e)
        {
            if (firstOP == "")
            {
                firstOP = collector;
            }
            else
            {
                secondOP = collector;
                firstOP = GetResult().ToString();
                secondOP = "";
            }
            collector = "";
            theOperator = "/";
            operation = firstOP + theOperator;
        }

        private void LblRESULTAT_Click(object sender, EventArgs e)
        {

        }

        private void LblOPERATION_Click(object sender, EventArgs e)
        {

        }

        private void BtnSUPPRIMER_Click(object sender, EventArgs e)
        {
            collector = "";
            LblOPERATION.Text = "____";
            LblRESULTAT.Text = "0";
            firstOP = "";
            secondOP = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad0)
            {
                BtnZERO.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                BtnUN.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                BtnDEUX.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                BtnTROIS.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                BtnQUATRE.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                BtnCINQ.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                BtnSIX.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                BtnSEPT.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                BtnHUIT.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                BtnNEUF.PerformClick();
            }



        }



    }
}