using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldMenuValeriaV
{
    public partial class frmHelloWorldMenu : Form

        /*
         * Created by: Valeria Veverita
         * Created on: 2018-09-11
         * Created for: ICS3U
         * Daily Assignment: Day 4 (Hello World with a menu bar
         * This program displays school name: when the user click on file/school and after clicks on the name of one school, the name is displaied on the screen. Also when the user click exit
         * the program end.
         */
    {
        public frmHelloWorldMenu()
        {
            InitializeComponent();
        }

        private void hekpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmHelloWorldMenu_Load(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //when exit button is clicked, we end the programm
            this.Close();
        }

        private void mniPeter_Click(object sender, EventArgs e)
        {
            //when press St. Peter, text changes
            lblSchool.Text = "  St. Peter\nHigh School";

        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            //when press Immaculata, text changes
            lblSchool.Text = "Immaculata\nHigh School";
        }

        private void mniTeresa_Click(object sender, EventArgs e)
        {
            //when press Immaculata, text changes
            lblSchool.Text = "Mother Teresa\n  High School";
        }

        private void mniNotre_Click(object sender, EventArgs e)
        {
            //when press Notre Dame, text changes
            lblSchool.Text = "Notre Dame\nHigh School";
        }

        private void mniSchool_Click(object sender, EventArgs e)
        {

        }
    }
}
