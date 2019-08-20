using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GFOReport gFO = new GFOReport(EFFeederWorkTime.Text);
            string msg1 = gFO.dateTime.ToString("yyyy-MM-dd HH:mm");
            string msg2 = gFO.ElectricFuranceTimeFeed.ToString();

            string msg = msg1 + " " + msg2;

            MessageBox.Show(msg);

        }       

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LBTimer.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");           
        }
    }
}
