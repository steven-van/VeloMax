using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeloMax.ChildForms
{
    public partial class FormAddCommande : Form
    {
        FormCommande formParent;

        public FormAddCommande(FormCommande parent)
        {
            InitializeComponent();
            formParent = parent;
        }


        public void ClearInputs()
        {
            //textBoxSiret.Text = textBoxNom.Text = textBoxContact.Text = textBoxAdresse.Text = string.Empty;
            //comboBoxLibelle.SelectedItem = null;
        }



        public void UpdateInfo()
        {
            //btnAddFournisseur.Text = "Modifier";
            //textBoxSiret.Enabled = false;
            //btnAddFournisseur.BackColor = Color.FromArgb(249, 180, 45);
            //textBoxSiret.Text = siret;
            //textBoxNom.Text = nom;
            //textBoxContact.Text = contact;
            //textBoxAdresse.Text = adresse;
            //comboBoxLibelle.Text = libelle;

        }

        public void SaveInfo()
        {
            //btnAddFournisseur.Text = "Ajouter";
            //textBoxSiret.Enabled = true;
            //btnAddFournisseur.BackColor = Color.FromArgb(54, 174, 124);
        }
        private void btnAddCommande_Click(object sender, EventArgs e)
        {

        }
    }
}
