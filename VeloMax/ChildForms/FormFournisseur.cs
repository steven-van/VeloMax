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
        FormAddFournisseur formAddFournisseur; 

        public FormFournisseur()
        {
            InitializeComponent();
            formAddFournisseur = new FormAddFournisseur(this);
        }

        public void DisplayFournisseur()
        {
            DBVeloMax.DisplayAndSearch("SELECT siret, nom, contact, adresse, libelle FROM Fournisseur;", dataGridViewFournisseur);

        }

        private void btnOpenAddFournisseur_Click(object sender, EventArgs e)
        {
            formAddFournisseur.ClearInputs();
            formAddFournisseur.SaveInfo();
            formAddFournisseur.ShowDialog();
        }

        private void FormFournisseur_Shown(object sender, EventArgs e)
        {
            DisplayFournisseur();
        }

        private void dataGridViewFournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0) //Modifier
            {
                formAddFournisseur.ClearInputs();
                formAddFournisseur.siret = dataGridViewFournisseur.Rows[e.RowIndex].Cells[2].Value.ToString();
                formAddFournisseur.nom = dataGridViewFournisseur.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAddFournisseur.contact = dataGridViewFournisseur.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAddFournisseur.adresse = dataGridViewFournisseur.Rows[e.RowIndex].Cells[5].Value.ToString();
                formAddFournisseur.libelle = dataGridViewFournisseur.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAddFournisseur.UpdateInfo();
                formAddFournisseur.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce fournisseur ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteFournisseur(dataGridViewFournisseur.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayFournisseur();
                }
                return;
            }
        }

    }
}
