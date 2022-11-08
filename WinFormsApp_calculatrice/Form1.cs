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

        int firstOPnumeric;
        int secondOPnumeric;
        int resultat ;


        private void BtnZERO_Click(object sender, EventArgs e)
        {
            collector += "0";
        }             

        private void BtnUN_Click(object sender, EventArgs e)
        {
            collector += "1";
        }
       private void BtnDEUX_Click(object sender, EventArgs e)
        {
            collector += "2";
        }
      
        private void BtnTROIS_Click(object sender, EventArgs e)
        {
            collector += "3";
        }

        private void BtnQUATRE_Click(object sender, EventArgs e)
        {
            collector += "4";
        }

        private void BtnCINQ_Click(object sender, EventArgs e)
        {
            collector += "5";
        }

        private void BtnSIX_Click(object sender, EventArgs e)
        {
            collector += "6";
        }

        private void BtnSEPT_Click(object sender, EventArgs e)
        {
            collector += "7";
        }

        private void BtnHUIT_Click(object sender, EventArgs e)
        {
            collector += "8";
        }

        private void BtnNEUF_Click(object sender, EventArgs e)
        {
            collector += "9";
        }

        private void BtnEGALE_Click(object sender, EventArgs e)
        {
            secondOP = collector;
            collector = "";
            operation += secondOP ;
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
            LblRESULTAT.Text = "resultat";
        }

        private void LblOPERATION_Click(object sender, EventArgs e)
        {
            LblOPERATION.Text = collector;
        }

  
    }
}