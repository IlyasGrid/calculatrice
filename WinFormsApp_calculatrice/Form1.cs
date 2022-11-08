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

        int resultat;

        private string GetResult()
        {
            int firstOPnumeric;
            int secondOPnumeric;
            
            firstOPnumeric = int.Parse(firstOP);
            secondOPnumeric = int.Parse(secondOP);

            if(theOperator =="+")
            {
                resultat = firstOPnumeric + secondOPnumeric;

            }else if(theOperator =="-")
            {
                resultat = firstOPnumeric - secondOPnumeric;
            }else if(theOperator=="*")
            {
                resultat= firstOPnumeric * secondOPnumeric;
            }else if(theOperator == "/")
            {
                resultat = firstOPnumeric / secondOPnumeric;
            }

            return resultat.ToString();
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
            operation += secondOP ;

            LblOPERATION.Text = operation;
            string res = GetResult();
            LblRESULTAT.Text = res;
        }

        private void BtnPLUS_Click(object sender, EventArgs e)
        {
            firstOP = collector;
            collector = "";
            theOperator = "+";
            operation = firstOP + theOperator; 
        }

        private void BtnMOIN_Click(object sender, EventArgs e)
        {
            firstOP = collector;
            collector = "";
            theOperator = "-";
            operation = firstOP + theOperator;
        }

        private void BtnMULTIPLIE_Click(object sender, EventArgs e)
        {
            firstOP = collector;
            collector = "";
            theOperator = "*";
            operation = firstOP + theOperator;
        }

        private void BtnDIVISE_Click(object sender, EventArgs e)
        {
            firstOP = collector;
            collector = "";
            theOperator = "/";
            operation = firstOP + theOperator;
        }

        private void LblRESULTAT_Click(object sender, EventArgs e)
        {
            
        }

        private void LblOPERATION_Click(object sender, EventArgs e)
        {
            LblOPERATION.Text = collector;
        }

        private void BtnSUPPRIMER_Click(object sender, EventArgs e)
        {
            collector = "";
            LblOPERATION.Text = "____";
            LblRESULTAT.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}