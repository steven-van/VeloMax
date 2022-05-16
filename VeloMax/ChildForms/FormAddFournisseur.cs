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
    public partial class FormAddFournisseur : Form
    {
        private readonly FormFournisseur formParent;
        public string siret, nom, contact, adresse, libelle;

        public FormAddFournisseur(FormFournisseur parent)
        {
            InitializeComponent();
            formParent = parent;
        }

        public void ClearInputs()
        {
            textBoxSiret.Text = textBoxNom.Text = textBoxContact.Text = textBoxAdresse.Text = string.Empty;
            comboBoxLibelle.SelectedItem = null;
        }

        public void UpdateInfo()
        {
            btnAddFournisseur.Text = "Modifier";
            textBoxSiret.Enabled = false;
            btnAddFournisseur.BackColor = Color.FromArgb(249, 180, 45);
            textBoxSiret.Text = siret;
            textBoxNom.Text = nom;
            textBoxContact.Text = contact;
            textBoxAdresse.Text = adresse;
            comboBoxLibelle.Text = libelle;

        }

        public void SaveInfo()
        {
            btnAddFournisseur.Text = "Ajouter";
            textBoxSiret.Enabled = true;
            btnAddFournisseur.BackColor = Color.FromArgb(54, 174, 124);
        }

        private void textBoxSiret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddFournisseur_Click(object sender, EventArgs e)
        {
            if (textBoxSiret.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez renseigner un siret");
                return;
            }
            if (textBoxSiret.Text.Trim().Length != 14)
            {
                MessageBox.Show("Le siret doit contenir 14 chiffres");
                return;
            }
            if (textBoxNom.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez renseigner un nom");
                return;
            }
            if (textBoxContact.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez renseigner le nom du contact");
                return;
            }

            if (textBoxAdresse.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez renseigner une adresse");
                return;
            }

            if (comboBoxLibelle.SelectedItem == null)
            {
                MessageBox.Show("Veuillez renseigner un libelle");
                return;
            }
            
            if(btnAddFournisseur.Text == "Ajouter")
            {
                string siret = textBoxSiret.Text.Trim();
                string nom = textBoxNom.Text.Trim();
                string contact = textBoxContact.Text.Trim();
                string adresse = textBoxAdresse.Text.Trim();
                string libelle = comboBoxLibelle.SelectedItem.ToString().Trim();
                DBVeloMax.AddFournisseur(siret, nom, contact, adresse, libelle);
                ClearInputs();
            }
            if (btnAddFournisseur.Text == "Modifier")
            {
                string siret = textBoxSiret.Text.Trim();
                string nom = textBoxNom.Text.Trim();
                string contact = textBoxContact.Text.Trim();
                string adresse = textBoxAdresse.Text.Trim();
                string libelle = comboBoxLibelle.SelectedItem.ToString().Trim();
                DBVeloMax.UpdateFournisseur(siret, nom, contact, adresse, libelle);
                ClearInputs();
                this.Close();
            }
            formParent.DisplayFournisseur();
        }


    }
}
