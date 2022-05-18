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
    public partial class FormClient : Form
    {
        FormAddClient formAddClient;

        public FormClient()
        {
            InitializeComponent();
            formAddClient = new FormAddClient(this);
        }

        public void DisplayIndividu()
        {
            DBVeloMax.DisplayAndSearch("SELECT idClient, type, adresse, courriel, telephone, nom, prenom FROM Client NATURAL JOIN Individu;", dataGridViewIndividu);
        }

        public void DisplayBoutique()
        {
            DBVeloMax.DisplayAndSearch("SELECT idClient, type, adresse, courriel, telephone, nom, contact, remise, volumeA FROM Client NATURAL JOIN Boutique;", dataGridViewBoutique);
        }


        private void FormClient_Shown(object sender, EventArgs e)
        {
            DisplayIndividu();
            DisplayBoutique();
        }

        private void btnOpenAddClient_Click(object sender, EventArgs e)
        {
            formAddClient.ClearInputs();
            formAddClient.SaveInfo();
            formAddClient.ShowDialog();
        }

        private void dataGridViewIndividu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddClient.ClearInputs();
                formAddClient.idClient = Convert.ToInt32(dataGridViewIndividu.Rows[e.RowIndex].Cells[2].Value);
                formAddClient.type = dataGridViewIndividu.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAddClient.adresse = dataGridViewIndividu.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAddClient.courriel = dataGridViewIndividu.Rows[e.RowIndex].Cells[5].Value.ToString();
                formAddClient.telephone = dataGridViewIndividu.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAddClient.nom = dataGridViewIndividu.Rows[e.RowIndex].Cells[7].Value.ToString();
                formAddClient.prenomI = dataGridViewIndividu.Rows[e.RowIndex].Cells[8].Value.ToString();
                formAddClient.UpdateInfo();
                formAddClient.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteClient(Convert.ToInt32(dataGridViewIndividu.Rows[e.RowIndex].Cells[2].Value));
                    DisplayIndividu();
                }
                return;
            }
        }

        private void dataGridViewBoutique_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddClient.ClearInputs();
                formAddClient.idClient = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[2].Value);
                formAddClient.type = dataGridViewBoutique.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAddClient.adresse = dataGridViewBoutique.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAddClient.courriel = dataGridViewBoutique.Rows[e.RowIndex].Cells[5].Value.ToString();
                formAddClient.telephone = dataGridViewBoutique.Rows[e.RowIndex].Cells[6].Value.ToString();
                formAddClient.nom = dataGridViewBoutique.Rows[e.RowIndex].Cells[7].Value.ToString();
                formAddClient.contact = dataGridViewBoutique.Rows[e.RowIndex].Cells[8].Value.ToString();
                formAddClient.remise = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[9].Value);
                formAddClient.volumeA = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[10].Value);
                formAddClient.UpdateInfo();
                formAddClient.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteClient(Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[2].Value));
                    DisplayBoutique();
                }
                return;
            }
        }
    }
}
