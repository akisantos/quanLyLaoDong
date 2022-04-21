using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyLaoDong
{
    public partial class fMainScreen : Form
    {
        public fMainScreen()
        {
            InitializeComponent();

            mainMenuControl1.Enabled = true;
            mainMenuControl1.Visible = true;


            searchControl1.Enabled = false;
            searchControl1.Visible = false;

            accountControl1.Enabled = false;
            accountControl1.Visible = false;

            phanCongControl1.Enabled = false;
            phanCongControl1.Visible = false;

        }
       

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainScreenBTN_Click(object sender, EventArgs e)
        {


            accountManagerBTN.BackColor = Color.FromArgb(56, 143, 129);
  
            accountControl1.Enabled = false;
            accountControl1.Visible = false;
            accountManagerBTN.IconColor = Color.FromArgb(126, 199, 174);
            accountManagerBTN.ForeColor = Color.FromArgb(126, 199, 174); 


            editModeBTN.BackColor = Color.FromArgb(56, 143, 129);

            phanCongControl1.Enabled = false;
            phanCongControl1.Visible = false;
            editModeBTN.IconColor = Color.FromArgb(126, 199, 174);
            editModeBTN.ForeColor = Color.FromArgb(126, 199, 174);

            searchBTN.BackColor = Color.FromArgb(56, 143, 129);

            searchControl1.Enabled = false;
            searchControl1.Visible = false;
            searchBTN.IconColor = Color.FromArgb(126, 199, 174);
            searchBTN.ForeColor = Color.FromArgb(126, 199, 174);
            

            mainScreenBTN.BackColor = Color.FromArgb(33, 129, 115);

            mainScreenBTN.IconColor = Color.White;
            mainScreenBTN.ForeColor = Color.White;
            mainMenuControl1.Enabled = true;
            mainMenuControl1.Visible = true;

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {

            accountManagerBTN.BackColor = Color.FromArgb(56, 143, 129);

            accountControl1.Enabled = false;
            accountControl1.Visible = false;
            accountManagerBTN.IconColor = Color.FromArgb(126, 199, 174);
            accountManagerBTN.ForeColor = Color.FromArgb(126, 199, 174);


            editModeBTN.BackColor = Color.FromArgb(56, 143, 129);

            phanCongControl1.Enabled = false;
            phanCongControl1.Visible = false;
            editModeBTN.IconColor = Color.FromArgb(126, 199, 174);
            editModeBTN.ForeColor = Color.FromArgb(126, 199, 174);

            searchBTN.BackColor = Color.FromArgb(33, 129, 115);

            searchControl1.Enabled = true;
            searchControl1.Visible = true;
            searchBTN.IconColor = Color.White;
            searchBTN.ForeColor = Color.White;


            mainScreenBTN.BackColor = Color.FromArgb(56, 143, 129);

            mainScreenBTN.IconColor = Color.FromArgb(126, 199, 174);
            mainScreenBTN.ForeColor = Color.FromArgb(126, 199, 174);
            mainMenuControl1.Enabled = false;
            mainMenuControl1.Visible = false;


        }

        private void editModeBTN_Click(object sender, EventArgs e)
        {

            accountManagerBTN.BackColor = Color.FromArgb(56, 143, 129);
            accountControl1.Enabled = false;
            accountControl1.Visible = false;
            accountManagerBTN.IconColor = Color.FromArgb(126, 199, 174);
            accountManagerBTN.ForeColor = Color.FromArgb(126, 199, 174);


            editModeBTN.BackColor = Color.FromArgb(33, 129, 115);
            phanCongControl1.Enabled = true;
            phanCongControl1.Visible = true;
            editModeBTN.IconColor = Color.White;
            editModeBTN.ForeColor = Color.White;

            searchBTN.BackColor = Color.FromArgb(56, 143, 129);
            searchControl1.Enabled = false;
            searchControl1.Visible = false;
            searchBTN.IconColor = Color.FromArgb(126, 199, 174);
            searchBTN.ForeColor = Color.FromArgb(126, 199, 174);


            mainScreenBTN.BackColor = Color.FromArgb(56, 143, 129);
            mainScreenBTN.IconColor = Color.FromArgb(126, 199, 174);
            mainScreenBTN.ForeColor = Color.FromArgb(126, 199, 174);
            mainMenuControl1.Enabled = false;
            mainMenuControl1.Visible = false;


        }

        private void accountManagerBTN_Click(object sender, EventArgs e)
        {

            accountManagerBTN.BackColor = Color.FromArgb(33, 129, 115);
            accountControl1.Enabled = true;
            accountControl1.Visible = true;
            accountManagerBTN.IconColor = Color.White;
            accountManagerBTN.ForeColor = Color.White;


            editModeBTN.BackColor = Color.FromArgb(56, 143, 129);
            phanCongControl1.Enabled = false;
            phanCongControl1.Visible = false;
            editModeBTN.IconColor = Color.FromArgb(126, 199, 174);
            editModeBTN.ForeColor = Color.FromArgb(126, 199, 174);

            searchBTN.BackColor = Color.FromArgb(56, 143, 129);

            searchControl1.Enabled = false;
            searchControl1.Visible = false;
            searchBTN.IconColor = Color.FromArgb(126, 199, 174);
            searchBTN.ForeColor = Color.FromArgb(126, 199, 174);


            mainScreenBTN.BackColor = Color.FromArgb(56, 143, 129);
            mainScreenBTN.IconColor = Color.FromArgb(126, 199, 174);
            mainScreenBTN.ForeColor = Color.FromArgb(126, 199, 174);
            mainMenuControl1.Enabled = false;
            mainMenuControl1.Visible = false;

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void accountControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void mainMenuControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void searchControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
