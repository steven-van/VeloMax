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
    public partial class FormAddModele : Form
    {
        private readonly FormModele formParent;
        public int idModele, stock;
        public string nom, grandeur, ligneP;
        public double prixU;
        public DateTime dateI, dateD;

        public FormAddModele(FormModele parent)
        {
            InitializeComponent();
            formParent = parent;

        }

        private void FormCommande_Load(object sender, EventArgs e)
        {

        }

        public void ClearInputs()
        {
            textBoxNom.Text = string.Empty;
            comboBoxGrandeur.SelectedItem = comboBoxLigneP.SelectedItem = null;
            numPrixU.Value = 0;
            datePickerDateI.Value = datePickerDateI.Value = DateTime.Now;

        }

        public void UpdateInfo()
        {
            btnAddModele.Text = "Modifier";
            btnAddModele.BackColor = Color.FromArgb(249, 180, 45);
            textBoxNom.Text = nom;
            comboBoxGrandeur.Text = grandeur;
            numPrixU.Value = Convert.ToDecimal(prixU);
            comboBoxLigneP.Text = ligneP;
            numStock.Value = stock;
            datePickerDateD.Value = dateD;
            datePickerDateI.Value = dateI;


        }

        public void SaveInfo()
        {
            btnAddModele.Text = "Ajouter";
            btnAddModele.BackColor = Color.FromArgb(54, 174, 124);
        }

        private void btnAddModele_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Trim().Length < 1 )
            {
                MessageBox.Show("Veuillez entrer un nom");
                return;
            }
            if (comboBoxGrandeur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une grandeur");
                return;
            }
            if (numPrixU.Value <= 0)
            {
                MessageBox.Show("Veuillez entrer un prix unitaire");
                return;
            }
       
            if (comboBoxLigneP.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une ligne de produit");
                return;
            }

            if (datePickerDateD.Value < datePickerDateI.Value)
            {
                MessageBox.Show("La date de discontinuation ne doit pas être antérieure à la date d'introduction");
                return;
            }

            if (btnAddModele.Text == "Ajouter")
            {
                string nom = textBoxNom.Text.Trim();
                string grandeur = comboBoxGrandeur.SelectedItem.ToString();
                double prixU = Convert.ToDouble(numPrixU.Value);
                string ligneP = comboBoxLigneP.SelectedItem.ToString();
                DateTime dateI = datePickerDateI.Value;
                DateTime dateD = datePickerDateD.Value;
                int stock = Convert.ToInt32(numStock.Value);
                DBVeloMax.AddModele(nom,grandeur,prixU,ligneP,dateI,dateD, stock);
                ClearInputs();
            }
            if (btnAddModele.Text == "Modifier")
            {
                string nom = textBoxNom.Text.Trim();
                string grandeur = comboBoxGrandeur.SelectedItem.ToString();
                double prixU = Convert.ToDouble(numPrixU.Value);
                string ligneP = comboBoxLigneP.SelectedItem.ToString();
                DateTime dateI = datePickerDateI.Value;
                DateTime dateD = datePickerDateD.Value;
                int stock = Convert.ToInt32(numStock.Value);

                DBVeloMax.UpdateModele(idModele, nom, grandeur, prixU, ligneP,dateI, dateD, stock);
                ClearInputs();
                this.Close();
            }
            formParent.DisplayModele();
        }
    }
}
