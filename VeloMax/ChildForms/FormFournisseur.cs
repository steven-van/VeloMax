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
    public partial class FormFournisseur : Form
    {
        public FormFournisseur()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxSiret.Text = textBoxNom.Text = textBoxContact.Text = textBoxAdresse.Text = string.Empty;
            comboBoxLibelle.ResetText();
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

            if (comboBoxLibelle.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Veuillez renseigner un libelle");
                return;
            }
            
            if(btnAddFournisseur.Text == "Ajouter")
            {
                string siret = textBoxSiret.Text;
                string nom = textBoxNom.Text;
                string contact = textBoxContact.Text;
                string adresse = textBoxAdresse.Text;
                string libelle = comboBoxLibelle.SelectedItem.ToString();
                DBVeloMax.AddFournisseur(siret, nom, contact, adresse, libelle);
                Clear();
            }
        }
    }
}
