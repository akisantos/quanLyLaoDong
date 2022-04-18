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

        }
       

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainScreenBTN_Click(object sender, EventArgs e)
        {
            editModeBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            searchBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            accountManagerBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            searchBTN.BackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.BackColor = Color.FromArgb(45, 49, 250);
            editModeBTN.BackColor = Color.FromArgb(93, 139, 244);
            accountManagerBTN.BackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 49, 250);

            //openUserControl
            mainMenuControl1.Enabled = true;
            mainMenuControl1.Visible = true;


            searchControl1.Enabled = false;
            searchControl1.Visible = false;

            accountControl1.Enabled = false;
            accountControl1.Visible = false;

  

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            editModeBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            accountManagerBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            searchBTN.BackColor = Color.FromArgb(45, 49, 250);
            mainScreenBTN.BackColor = Color.FromArgb(93, 139, 244);
            editModeBTN.BackColor = Color.FromArgb(93, 139, 244);
            accountManagerBTN.BackColor = Color.FromArgb(93, 139, 244);

            searchBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 49, 250);


            //openUserControl
            mainMenuControl1.Enabled = false;
            mainMenuControl1.Visible = false;

            searchControl1.Enabled = true;
            searchControl1.Visible = true;
            accountControl1.Enabled = false;
            accountControl1.Visible = false;
     
 
        }

        private void editModeBTN_Click(object sender, EventArgs e)
        {
            searchBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            accountManagerBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            searchBTN.BackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.BackColor = Color.FromArgb(93, 139, 244);
            editModeBTN.BackColor = Color.FromArgb(45, 49, 250);
            accountManagerBTN.BackColor = Color.FromArgb(93, 139, 244);
            editModeBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 49, 250);
        }

        private void accountManagerBTN_Click(object sender, EventArgs e)
        {
            searchBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);
            editModeBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 139, 244);

            searchBTN.BackColor = Color.FromArgb(93, 139, 244);
            mainScreenBTN.BackColor = Color.FromArgb(93, 139, 244);
            editModeBTN.BackColor = Color.FromArgb(93, 139, 244);

            accountManagerBTN.BackColor = Color.FromArgb(45, 49, 250);

            accountManagerBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 49, 250);

            accountControl1.Enabled = true;
            accountControl1.Visible = true;

            mainMenuControl1.Enabled = false;
            mainMenuControl1.Visible = false;


            searchControl1.Enabled = false;
            searchControl1.Visible = false;
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
