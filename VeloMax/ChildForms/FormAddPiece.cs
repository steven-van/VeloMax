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
        FormPiece formParent;
        string desc, categorie;
        DateTime dateI, dateD;
        int prixU, stock;

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
            numPrixU.Value = prixU;
            numStock.Value = stock;
            datePickerDateD.Value = dateD;
            datePickerDateI.Value = dateI;
        

        }

        public void SaveInfo()
        {
            btnAddPiece.Text = "Ajouter";
            btnAddPiece.BackColor = Color.FromArgb(54, 174, 124);
        }

        private void btnAddPiece_Click(object sender, EventArgs e)
        {

        }
    }
}
