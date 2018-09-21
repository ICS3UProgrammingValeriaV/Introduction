using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternatValeriaV
{
    public partial class frmHelloWorldInternational : Form
    {
        public frmHelloWorldInternational()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picMap_Click(object sender, EventArgs e)
        {

        }

        private void rdoFrench_CheckedChanged(object sender, EventArgs e)
        {
            //this function translastes the text to french, when rdoFrench is pressed
            lblGreating.Text = "Bonjour, le monde!";

            //lblGreating.Location = 120, 79;
        }

        private void rdoGerman_CheckedChanged(object sender, EventArgs e)
        {
            //this function translastes the text to french, when rdoGerman is pressed
            lblGreating.Text = "Hallo, Welt!";
        }

        private void rdoEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreating.Text = "Hello, Wolrd!";
        }
    }
}
