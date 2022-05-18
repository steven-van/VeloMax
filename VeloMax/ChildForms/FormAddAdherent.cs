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
    public partial class FormAddAdherent : Form
    {
        FormAdherent formParent;
        public string client, fidelite;
        public DateTime dateAdhesion;

        public FormAddAdherent(FormAdherent parent)
        {
            InitializeComponent();
            formParent = parent;

        }

        public void ClearInputs()
        {
            comboBoxClient.SelectedItem = comboBoxFidelite.SelectedItem = null;
            datePickerDateAdhesion.Value = DateTime.Now;
        }

        public void UpdateInfo()
        {
            btnAddAdherent.Text = "Modifier";
            comboBoxClient.Enabled = false;
            btnAddAdherent.BackColor = Color.FromArgb(249, 180, 45);
            comboBoxClient.SelectedItem = client;
            comboBoxFidelite.SelectedItem = fidelite;
            datePickerDateAdhesion.Value = dateAdhesion;

        }

        public void SaveInfo()
        {
            btnAddAdherent.Text = "Ajouter";
            comboBoxClient.Enabled = true;
            btnAddAdherent.BackColor = Color.FromArgb(54, 174, 124);
        }

        private void FormAddAdherent_Shown(object sender, EventArgs e)
        {
            comboBoxClient.Items.Clear();
            DBVeloMax.PopulateComboBox("SELECT idClient, nom, prenom FROM Individu;", comboBoxClient, 3);
        }


        private void btnAddAdherent_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez renseigner un client");
                return;
            }
            if (comboBoxFidelite.SelectedItem == null)
            {
                MessageBox.Show("Veuillez renseigner un programme de fidelité");
                return;
            }
            if (btnAddAdherent.Text == "Ajouter")
            {
                int idC = Int32.Parse(comboBoxClient.SelectedItem.ToString().Split('-')[0]);
                int idF = Int32.Parse(comboBoxFidelite.SelectedItem.ToString().Split('-')[0]);
                DateTime date = datePickerDateAdhesion.Value;
                DBVeloMax.AddAdhesion(idC, idF, date);
                ClearInputs();
            }
            if (btnAddAdherent.Text == "Modifier")
            {
                int idC = Convert.ToInt32(comboBoxClient.SelectedItem.ToString()[0]);
                int idF = Convert.ToInt32(comboBoxFidelite.SelectedItem.ToString()[0]);
                DateTime date = datePickerDateAdhesion.Value;
                //DBVeloMax.UpdateAdhesion(idC, idF, date);
                ClearInputs();
                this.Close();
            }
            formParent.DisplayAdherent();
        }
    }
}
