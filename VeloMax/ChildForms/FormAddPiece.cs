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
    public partial class FormAddPiece : Form
    {
        private readonly FormPiece formParent;
        public string desc, categorie;
        public DateTime dateI, dateD;
        public double prixU;
        public int idPiece, stock,delaiA;

        public FormAddPiece(FormPiece parent)
        {
            InitializeComponent();
            formParent = parent;
        }

        public void ClearInputs()
        {
            textBoxDesc.Text = string.Empty;
            numPrixU.Value = numStock.Value = numDelaiA.Value = 0;
            datePickerDateD.Value = datePickerDateI.Value = DateTime.Now;
            comboBoxCategorie.SelectedItem = null;
        }

        public void UpdateInfo()
        {
            btnAddPiece.Text = "Modifier";
            btnAddPiece.BackColor = Color.FromArgb(249, 180, 45);
            textBoxDesc.Text = desc;
            numPrixU.Value = Convert.ToDecimal(prixU);
            numStock.Value = Convert.ToDecimal(stock);
            datePickerDateD.Value = dateD;
            datePickerDateI.Value = dateI;
            comboBoxCategorie.Text = categorie;
            numDelaiA.Value = delaiA;

        }

        public void SaveInfo()
        {
            btnAddPiece.Text = "Ajouter";
            btnAddPiece.BackColor = Color.FromArgb(54, 174, 124);
        }

        private void btnAddPiece_Click(object sender, EventArgs e)
        {
            if(textBoxDesc.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez renseigner une description");
                return;
            }
            if(numPrixU.Value <= 0)
            {
                MessageBox.Show("Veuillez renseigner un prix unitaire");
                return;
            }
            if(numStock.Value <= 0)
            {
                MessageBox.Show("Veuillez renseigner un stock");
                return;

            }
            if (numDelaiA.Value <= 0)
            {
                MessageBox.Show("Veuillez renseigner un délai d'approvisionnements");
                return;

            }
            if (datePickerDateD.Value < datePickerDateI.Value)
            {
                MessageBox.Show("La date de discontinuation ne peut pas être antérieure à la date d'introduction");
                return;
            }
            if (comboBoxCategorie.SelectedItem == null)
            {
                MessageBox.Show("Veuillez renseigner une catégorie");
                return;
            }

            if (btnAddPiece.Text == "Ajouter")
            {
                string desc = textBoxDesc.Text.Trim();
                double prixU = Convert.ToDouble(numPrixU.Value);
                int stock = Convert.ToInt32(numStock.Value);
                int delaiA = Convert.ToInt32(numDelaiA.Value);
                DateTime dateI = datePickerDateI.Value;
                DateTime dateD = datePickerDateD.Value;
                string categorie = comboBoxCategorie.SelectedItem.ToString();
                DBVeloMax.AddPiece(desc, categorie, prixU, stock, dateI, dateD, delaiA);
                ClearInputs();
            }

            if (btnAddPiece.Text == "Modifier")
            {
                int piece = idPiece;
                string desc = textBoxDesc.Text.Trim();
                double prixU = Convert.ToDouble(numPrixU.Value);
                int stock = Convert.ToInt32(numStock.Value);
                int delaiA = Convert.ToInt32(numDelaiA.Value);
                DateTime dateI = datePickerDateI.Value;
                DateTime dateD = datePickerDateD.Value;
                string categorie = comboBoxCategorie.SelectedItem.ToString();
                DBVeloMax.UpdatePiece(idPiece, desc, categorie, prixU, stock, dateI, dateD, delaiA);
                ClearInputs();
                this.Close();
            }
            formParent.DisplayPiece();
        }
    }
}
