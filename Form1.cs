namespace Ayanda_CC_Consulting
{
    public partial class AyandaCCConsulting : Form
    {
        public AyandaCCConsulting()
        {
            InitializeComponent();
        }
        //global Variables
        private double makeoverValue = 0, hairStylingValue = 0, manicureValue = 0, permMakeupValue = 0,discountValue=0, makeoverValue2 = 0, hairStylingValue2 = 0, manicureValue2 = 0,permMakeupValue2 =0;
        private const double moValue = 125.00, hsValue = 60.00, mValue = 35.00, pmValue = 200.00, discount10 = 0.10, discount20 = 0.20, discountNull = 0.00;

        private void arielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChanger("Ariel");
        }

        //initializing form Controls
        private string currentValue = "", totalValue = "", addedService = "";

        private void monospaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Constantia not monospace
            FontChanger("Constantia");
        }

        private void castellaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //consolas not castella
            FontChanger("Consolas");
        }



        private void bellMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChanger("Bell MT");
        }

        private void AyandaCCConsulting_Load(object sender, EventArgs e)
        {
            //on load the following elements should not be accessible by the user
            txtCurrentService.Enabled = false;
            txtServiceTotal.Enabled = false; 
        }

        //File Menustrip
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sum = CalculateMethod(); //look into parameterizing this function call
            txtCurrentService.Text = sum.ToString("C");
            if (rbNone.Checked)
            {
                discountValue = discountNull;
            }
            if (rbTen.Checked)
            {
                discountValue = discount10;
            }
            if (rbTwenty.Checked)
            {
                discountValue = discount20;
            }
            txtServiceTotal.Text = (sum - (sum*discountValue)).ToString("C");
        }
        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit(); ; //later to be a function call
        }

        //edit menustrip
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clearing out everything on the form
            CLearForm();
        }
        //about menustrip
        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void programerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Custom Function
        private bool Validator(string sample) 
        {
            
            return false; //placeholder to avoid exception during buildtime
        }
        private double CalculateMethod() //calculate and return current service cost before 
        {
            //lbAddedServices;
            double sum = 0.00;
            {
                if (rbNone.Checked)
                {
                    discountValue = discountNull;
                }
                if (rbTen.Checked)
                {
                    discountValue = discount10;
                }
                if (rbTwenty.Checked)
                {
                    discountValue = discount20;
                }
            }

            {
                if (rbHairstyling.Checked)
                {
                    hairStylingValue = hsValue;
                }
                if (rbMakeover.Checked)
                {
                    makeoverValue = moValue;
                }
                if (rbManicure.Checked)
                {
                    manicureValue = mValue;
                }
                if (rbPermanent.Checked)
                {
                    permMakeupValue = pmValue;
                }
            }

            {
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(1) && lbAddedServices.GetSelected(2) && lbAddedServices.GetSelected(3))
                {
                    makeoverValue2 = moValue;
                    hairStylingValue2 = hsValue;
                    manicureValue2 = mValue;
                    permMakeupValue2 = pmValue; 
                }
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(1) && lbAddedServices.GetSelected(2))
                {
                    makeoverValue2 = moValue;
                    hairStylingValue2 = hsValue;
                    manicureValue2 = mValue;
                }
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(1) && lbAddedServices.GetSelected(3))
                {
                    makeoverValue2 = moValue;
                    hairStylingValue2 = hsValue;
                    permMakeupValue2 = pmValue;
                }
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(2) && lbAddedServices.GetSelected(3))
                {
                    makeoverValue2 = moValue;
                    manicureValue2 = mValue;
                    permMakeupValue2 = pmValue;
                }
                if (lbAddedServices.GetSelected(1) && lbAddedServices.GetSelected(2) && lbAddedServices.GetSelected(3))
                {
                    hairStylingValue2 = hsValue;
                    manicureValue2 = mValue;
                    permMakeupValue2 = pmValue;
                }
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(1))
                {
                    makeoverValue2 = moValue;
                    hairStylingValue2 = hsValue;
                }
                if (lbAddedServices.GetSelected(2) && lbAddedServices.GetSelected(3))
                {
                    manicureValue2 = mValue;
                    permMakeupValue2 = pmValue;
                }
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(2))
                {
                    makeoverValue2 = moValue;
                    manicureValue2 = mValue;
                }
                if (lbAddedServices.GetSelected(1) && lbAddedServices.GetSelected(3))
                {
                    hairStylingValue2 = hsValue;
                    permMakeupValue2 = pmValue;
                }
                if (lbAddedServices.GetSelected(0) && lbAddedServices.GetSelected(3))
                {
                    makeoverValue2 = moValue;
                    permMakeupValue2 = pmValue;
                }
                if (lbAddedServices.GetSelected(0))
                {
                    makeoverValue2 = moValue;
                }
                if (lbAddedServices.GetSelected(1))
                {
                    hairStylingValue2 = hsValue;
                }
                if(lbAddedServices.GetSelected(2))   
                {
                    manicureValue2 = mValue;
                }
                if(lbAddedServices.GetSelected(3))
                {
                    permMakeupValue2 = pmValue;
                }
            }
            sum = hairStylingValue + manicureValue + permMakeupValue + makeoverValue + hairStylingValue2 + manicureValue2 + permMakeupValue2 + makeoverValue2;
            return sum; //placeholder to avoid exception
        }
        private void Exit() 
        {
            this.Close();
        }
        private void CLearForm() 
        {
            rbNone.Checked = false;
            rbTen.Checked = false;
            rbTwenty.Checked = false;
            //Services Groupbox Items
            rbHairstyling.Checked = false;
            rbMakeover.Checked = false;
            rbManicure.Checked = false;
            rbPermanent.Checked = false;
            //clearing out the textboxes
            txtCurrentService.Text = "";
            txtServiceTotal.Text = "";
            txtService.Text = "";
            //listbox deselecting items
            lbAddedServices.SelectedIndex = -1;
        }
        private void FontChanger(string font)
        {
            this.Font = new Font(font, 10, FontStyle.Regular);
        }

    }
}