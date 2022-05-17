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
    public partial class FormAddClient : Form
    {
        FormClient formParent;
        public string type, adresse, courriel, telephone, nom, prenomI, contact;
        public int idClient, volumeA, remise;

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public FormAddClient(FormClient parent)
        {
            InitializeComponent();
            formParent = parent;
        }

        public void ClearInputs()
        {
            comboBoxType.SelectedItem = null;
            textBoxAdresse.Text = textBoxCourriel.Text = textBoxTelephone.Text = textBoxNomI.Text = textBoxPrenom.Text = textBoxNomB.Text = textBoxContact.Text = string.Empty;
            numVolumeA.Value = numRemise.Value = 0;
        }

        public void UpdateInfo()
        {
            btnAddClient.Text = "Modifier";
            btnAddClient.BackColor = Color.FromArgb(249, 180, 45);
            comboBoxType.SelectedItem = type;
            textBoxAdresse.Text = adresse;
            textBoxCourriel.Text = courriel;
            textBoxTelephone.Text = telephone;
            if(type == "Individu")
            {
                textBoxNomI.Text = nom;
                textBoxPrenom.Text = prenomI;
            }
            if(type == "Boutique")
            {
                textBoxNomB.Text = nom;
                textBoxContact.Text = contact;
                numRemise.Value = Convert.ToDecimal(remise);
                numVolumeA.Value = volumeA;
            }

        }

        public void SaveInfo()
        {
            btnAddClient.Text = "Ajouter";
            btnAddClient.BackColor = Color.FromArgb(54, 174, 124);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedItem != null)
            {
                if (comboBoxType.SelectedItem.ToString() == "Individu")
                {
                    groupBoxBoutique.Enabled = false;
                    groupBoxIndividu.Enabled = true;
                }
                if (comboBoxType.SelectedItem.ToString() == "Boutique")
                {
                    groupBoxIndividu.Enabled = false;
                    groupBoxBoutique.Enabled = true;
                }
            }

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Veuillez renseigner un type de client");
                return;
            }

            if(textBoxCourriel.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez renseigner un courriel");
                return;
            }

            if (textBoxTelephone.Text.Trim().Length < 1 || textBoxTelephone.Text.Trim().Length < 10)
            {
                MessageBox.Show("Veuillez renseigner un numéro de téléphone dans le bon format");
                return;
            }


            if (comboBoxType.SelectedItem.ToString() == "Individu")
            {
                if (textBoxNomI.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Veuillez renseigner un nom");
                    return;
                }

                if (textBoxPrenom.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Veuillez renseigner un prenom");
                    return;
                }
            }

            if (comboBoxType.SelectedItem.ToString() == "Boutique")
            {
                if (textBoxNomB.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Veuillez renseigner un nom de boutique");
                    return;
                }

                if (textBoxContact.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Veuillez renseigner un nom de contact");
                    return;
                }

                if (numVolumeA.Value <= 0)
                {
                    MessageBox.Show("Veuillez renseigner un volume d'achat");
                    return;
                }

                if (numRemise.Value <= 0)
                {
                    MessageBox.Show("Veuillez renseigner une remise entre 0 et 100");
                    return;
                }
            }

            if (btnAddClient.Text == "Ajouter")
            {
                string type = comboBoxType.SelectedItem.ToString();
                string adresse = textBoxAdresse.Text.Trim();
                string courriel = textBoxCourriel.Text.Trim();
                string tel = textBoxTelephone.Text.Trim();
                DBVeloMax.AddClient(type, adresse, courriel, tel);
                int id = DBVeloMax.LastInsertedId();
                if(type == "Individu")
                {
                    string nomI = textBoxNomI.Text.Trim();
                    string prenom = textBoxPrenom.Text.Trim();
                    DBVeloMax.AddClientIndividu(id, nomI, prenom);
                }

                if (type == "Boutique")
                {
                    string nomB = textBoxNomB.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    int volumeA = Convert.ToInt32(numVolumeA.Value);
                    int remise = Convert.ToInt32(numRemise.Value);
                    DBVeloMax.AddClientBoutique(id, nomB, contact, remise, volumeA);
                }
                ClearInputs();
            }
            if (btnAddClient.Text == "Modifier")
            {
                string type = comboBoxType.SelectedItem.ToString();
                string adresse = textBoxAdresse.Text.Trim();
                string courriel = textBoxCourriel.Text.Trim();
                string tel = textBoxTelephone.Text.Trim();
                if (type == "Individu")
                {
                    string nomI = textBoxNomI.Text.Trim();
                    string prenom = textBoxPrenom.Text.Trim();
                    //DBVeloMax.UpdateClientIndividu(idClient, nom, prenom);
                }

                if (type == "Boutique")
                {
                    string nomB = textBoxNomB.Text.Trim();
                    string contact = textBoxContact.Text.Trim();
                    int volumeA = Convert.ToInt32(numVolumeA.Value);
                    int remise = Convert.ToInt32(numRemise.Value);

                    //DBVeloMax.UpdateClientBoutique(idClient, nomB, contact, remise, volumeA);
                }
                ClearInputs();
                this.Close();
            }
            formParent.DisplayBoutique();
            formParent.DisplayIndividu();
        }
    }
}
