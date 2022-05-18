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
    public partial class FormModele : Form
    {
        FormAddModele formAddModele;

        public FormModele()
        {
            InitializeComponent();
            formAddModele = new FormAddModele(this);
        }

        public void DisplayModele()
        {
            DBVeloMax.DisplayAndSearch("SELECT idModele, nom, grandeur, prixU, ligneP, dateI, dateD FROM Modele;", dataGridViewModele);
        }

        private void FormModele_Shown(object sender, EventArgs e)
        {
            DisplayModele();
        }

        private void btnOpenAddModele_Click(object sender, EventArgs e)
        {
            formAddModele.ClearInputs();
            formAddModele.SaveInfo();
            formAddModele.ShowDialog();
        }

        private void dataGridViewModele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddModele.ClearInputs();
                formAddModele.idModele = Convert.ToInt32(dataGridViewModele.Rows[e.RowIndex].Cells[2].Value);
                formAddModele.nom = dataGridViewModele.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAddModele.grandeur = dataGridViewModele.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAddModele.prixU = Convert.ToInt32(dataGridViewModele.Rows[e.RowIndex].Cells[5].Value);
                formAddModele.ligneP = dataGridViewModele.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAddModele.dateI = dataGridViewModele.Rows[e.RowIndex].Cells[7].Value.ToString() == "" ? DateTime.Now : Convert.ToDateTime(dataGridViewModele.Rows[e.RowIndex].Cells[7].Value);
                formAddModele.dateD = dataGridViewModele.Rows[e.RowIndex].Cells[8].Value.ToString() == "" ? DateTime.Now : Convert.ToDateTime(dataGridViewModele.Rows[e.RowIndex].Cells[8].Value);
                formAddModele.UpdateInfo();
                formAddModele.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce modèle ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteModele(Convert.ToInt32(dataGridViewModele.Rows[e.RowIndex].Cells[2].Value));
                    DisplayModele();
                }
                return;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DBVeloMax.DisplayAndSearch("SELECT idModele, nom, grandeur, prixU, ligneP, dateI, dateD FROM Modele WHERE nom LIKE '%" + textBoxSearch.Text + "%';", dataGridViewModele);
        }
    }
}
