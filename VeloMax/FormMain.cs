using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace VeloMax
{
    public partial class FormMain : Form
    {
        private Form currentChildForm;
        private IconButton activeBtn;
        private Panel leftBorderBtn; 

        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color yellow = Color.FromArgb(255, 205, 48);
            public static Color darkGrey = Color.FromArgb(51, 51, 76);
            public static Color white = Color.FromArgb(255, 255, 255);
        }

        private void OpenSubForm(Form childForm)
        {

            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DisableButton();
                activeBtn = (IconButton)senderBtn;
                activeBtn.TextAlign = ContentAlignment.MiddleCenter;
                activeBtn.ImageAlign = ContentAlignment.MiddleCenter;
                activeBtn.ForeColor = RGBColors.yellow;
                activeBtn.IconColor = RGBColors.yellow;
                leftBorderBtn.BackColor = RGBColors.yellow;
                leftBorderBtn.Location = new Point(0, activeBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconActiveForm.IconChar = activeBtn.IconChar;
                iconActiveForm.IconColor = activeBtn.IconColor;
                labelTitleActiveForm.Text = activeBtn.Text;
                labelTitleActiveForm.ForeColor = activeBtn.ForeColor;

            }
        }

        private void DisableButton()
        {
            if(activeBtn != null)
            {
                activeBtn.ForeColor = RGBColors.white;
                activeBtn.IconColor = RGBColors.white;
                activeBtn.TextAlign = ContentAlignment.MiddleLeft;
                activeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormFournisseur());

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormStats());
        }


        private void btnStock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormStock());
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormAddCommande());

        }

        private void btnModele_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormModele());
        }

        private void btnPiece_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormPiece());
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
            iconActiveForm.IconChar = IconChar.Home;
            iconActiveForm.IconColor = RGBColors.white;
            labelTitleActiveForm.ForeColor = RGBColors.white;
            labelTitleActiveForm.Text = "Home";


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelHours.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenSubForm(new ChildForms.FormClient());
        }
    }
}
