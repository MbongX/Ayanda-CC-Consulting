using System.Drawing;
using System.Windows.Forms;

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
        //font family
        private void monospaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Constantia not monospace
            FontChanger("Constantia");
        }


        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Segoe UI
            FontChanger("Segoe UI");
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

        private void programDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programForm_ pf = new programForm_();
            pf.ShowDialog();
        }
        //font color
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontColorChanger("Blue");
        }


        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontColorChanger("Green");
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontColorChanger("Yellow");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontColorChanger("Red");
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontColorChanger("Black");
        }


        //add
        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validator(txtService.Text))
                lbAddedServices.Items.Add(txtService.Text);
            else
                MessageBox.Show("Enter the service","Add Service Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        //remove service
        private void removeServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveService();
        }
        //search
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool found = false;
            string Text = txtService.Text;

            if (Validator(Text))
            {

                for (int i = 0; i < lbAddedServices.Items.Count; i++)
                {
                    if (lbAddedServices.Items[i].ToString() == Text)
                    {
                        MessageBox.Show("Service Found : " + Text, "Search Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        found = true; 
                        break; 
                    }
                    else
                        continue;
                }
                if (found == false)
                {
                    MessageBox.Show("Service Not Found : " + Text, "Search Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


/*
                foreach (Object obj in lbAddedServices.Items.ToString())
                {
                    if (obj == Text)
                    {
                        MessageBox.Show("Service Found : " + Text, "Search Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        found = true;
                        break;
                    }
                    else
                    {

                        found = false;
                    }

                    if (!found)
                    {
                        MessageBox.Show("Service Found : " + Text, "Search Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
            }
            else 
            {
                MessageBox.Show("Enter the service", "Service not defined", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtService.Focus();
            }
        }
        //Display Services
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayService();
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
        //show programmer details
        private void programerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programmerForm progForm = new programmerForm();
            progForm.ShowDialog();
        }
        private void countServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int output = 0;
            foreach (object obj in lbAddedServices.Items)
            {
                output ++;

            }
            MessageBox.Show("Total Service Count : " + output, "Available Services By Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void removeServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Custom Function
        private bool Validator(string sample) 
        {
            bool result = false;
            sample= sample.Trim();
            if (string.IsNullOrEmpty(sample))
                result = false;
            else
                result = true;
            return result;
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
            //changinging the font of the entire form
            this.Font = new Font(font, 10, FontStyle.Regular);
            //we can change as per selected radio buttion and listbox item 
            
        }
        private void FontColorChanger(string color)
        {
            //changes the font color to the one selected by the user
            if(color =="Red")
            this.ForeColor = Color.Red;
            if (color == "Blue")
                this.ForeColor = Color.Blue;
            if (color == "Green")
                this.ForeColor = Color.Green;
            if (color == "Yellow")
                this.ForeColor = Color.Yellow;
            if (color == "Black")
                this.ForeColor = Color.Black;
        }

        private void RemoveService()
        {
            //removes a selected service
            if (Validator(txtService.Text))
            {
                lbAddedServices.Items.RemoveAt(lbAddedServices.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Enter the service", "Service not defined", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtService.Focus();
            }
                
        }

        private void DisplayService() 
        {
            //display all services 
            string output = "";
            foreach (object obj in lbAddedServices.Items)
            {
                output += obj.ToString() + Environment.NewLine;

            }
            MessageBox.Show(output, "Available Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}