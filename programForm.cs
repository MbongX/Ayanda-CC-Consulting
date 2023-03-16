using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayanda_CC_Consulting
{
    public partial class programmerForm : Form
    {
        public programmerForm()
        {
            InitializeComponent();
        }

        private void programForm_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString();
            //string name = "Nobesuthu Sithole"; 
           // string stdID = "STHNOB004"; 
           // string course = "Bachelor of Science majoring in Applied Statistics and information systems"; 
           // string institution = "CPUT";


            lblProgDetails.Text = "The programmer is Nobesuthu Sithole with Student ID: STHNOB004 from CPUT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            programForm_ pg = new programForm_();
            pg.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
