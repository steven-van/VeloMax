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
        string modele, piece, client, adresseL;
        DateTime dateC, dateL;
        int quantiteM, quantiteP;

        public FormAddCommande(FormCommande parent)
        {
            InitializeComponent();
            formParent = parent;
        }

        public void ClearInputs()
        {
            comboBoxModele.SelectedItem = comboBoxClient.SelectedItem = comboBoxPiece.SelectedItem = null;
            numModele.Value = numPiece.Value = 0;
            datePickerDateC.Value = datePickerDateL.Value = DateTime.Now;
            textBoxAdresseL.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            btnAddCommande.Text = "Modifier";
            btnAddCommande.BackColor = Color.FromArgb(249, 180, 45);
            comboBoxModele.Text = modele;
            comboBoxPiece.Text = piece;
            comboBoxClient.Text = client;
            numModele.Value = quantiteM;
            numPiece.Value = quantiteP;
            datePickerDateC.Value = dateC;
            datePickerDateL.Value = dateL;
            textBoxAdresseL.Text = adresseL;

        }

        public void SaveInfo()
        {
            btnAddCommande.Text = "Ajouter";
            btnAddCommande.BackColor = Color.FromArgb(54, 174, 124);
        }
        private void btnAddCommande_Click(object sender, EventArgs e)
        {

            if (btnAddCommande.Text == "Ajouter")
            {
                if(comboBoxModele.SelectedItem == null && comboBoxPiece.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez renseigner un modele ou une pièce a commander");
                    return;
                }
                if(textBoxAdresseL.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Veuillez renseigner une adresse de livraison");
                    return;
                }
                if(comboBoxClient.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez renseigner un client");
                    return;
                }
                if(datePickerDateL.Value < datePickerDateC.Value)
                {
                    MessageBox.Show("La date de livraison ne peut pas être antérieure à la date de commande");
                    return;
                }

                int idCl = Int32.Parse(comboBoxClient.SelectedItem.ToString().Split('-')[0]);
                string adresse = textBoxAdresseL.Text;
                DateTime dateCommande = datePickerDateC.Value;
                DateTime dateLivraison = datePickerDateL.Value;
                DBVeloMax.AddCommande(dateCommande, adresse, dateLivraison, idCl);
                int idCo = DBVeloMax.LastInsertedId();
                if (comboBoxModele.SelectedItem != null)
                {
                    int idM = Int32.Parse(comboBoxModele.SelectedItem.ToString().Split('-')[0]);

                    int qM = Convert.ToInt32(numModele.Value);
                    DBVeloMax.AddAchat_modele(idCo, idM, qM);
                }
                if (comboBoxPiece.SelectedItem != null)
                {
                    int idP = Int32.Parse(comboBoxPiece.SelectedItem.ToString().Split('-')[0]);

                    int qP = Convert.ToInt32(numPiece.Value);
                    DBVeloMax.AddAchat_piece(idCo, idP, qP);
                }
                ClearInputs();
            }
            if (btnAddCommande.Text == "Modifier")
            {
                //string siret = textBoxSiret.Text.Trim();
                //string nom = textBoxNom.Text.Trim();
                //string contact = textBoxContact.Text.Trim();
                //string adresse = textBoxAdresse.Text.Trim();
                //string libelle = comboBoxLibelle.SelectedItem.ToString().Trim();
                //DBVeloMax.UpdateFournisseur(siret, nom, contact, adresse, libelle);
                //ClearInputs();
                //this.Close();
            }
            formParent.DisplayCommandeModele();
            formParent.DisplayCommandePiece();

        }

        private void FormAddCommande_Shown(object sender, EventArgs e)
        {
            comboBoxClient.Items.Clear();
            comboBoxModele.Items.Clear();
            comboBoxPiece.Items.Clear();
            DBVeloMax.PopulateComboBox("SELECT idClient, type, courriel FROM Client", comboBoxClient, 3);
            DBVeloMax.PopulateComboBox("SELECT idModele, nom, grandeur, prixU, ligneP, stock FROM Modele WHERE stock > 0", comboBoxModele, 5);
            DBVeloMax.PopulateComboBox("SELECT idPiece, description, categorie, prixU, stock FROM Piece WHERE stock > 0", comboBoxPiece, 5);

        }
    }
}
