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
    public partial class FormCommande : Form
    {
        FormAddCommande formAddCommande; 

        public FormCommande()
        {
            InitializeComponent();
            formAddCommande = new FormAddCommande(this);
        }

        private void FormCommande_Load(object sender, EventArgs e)
        {

        }

        public void DisplayCommandePiece()
        {
            DBVeloMax.DisplayAndSearch("SELECT idCommande, idPiece, idClient, quantite, dateC, adresseL, dateL FROM Commande NATURAL JOIN Achat_Piece;", dataGridViewAchatPiece);

        }

        public void DisplayCommandeModele()
        {
            DBVeloMax.DisplayAndSearch("SELECT idCommande, idModele, idClient, quantite, dateC, adresseL, dateL FROM Commande NATURAL JOIN Achat_Modele;", dataGridViewAchatModele);

        }

        private void FormCommande_Shown(object sender, EventArgs e)
        {
            DisplayCommandePiece();
            DisplayCommandeModele();


        }

        private void btnOpenAddCommande_Click(object sender, EventArgs e)
        {
            //formAddCommande.ClearInputs();
            //formAddCommande.SaveInfo();
            formAddCommande.ShowDialog();

        }

        private void textBoxSearchPiece_TextChanged(object sender, EventArgs e)
        {
            DBVeloMax.DisplayAndSearch("SELECT idCommande, idPiece, idClient, quantite, dateC, adresseL, dateL FROM Commande NATURAL JOIN Achat_Piece WHERE idCommande LIKE '%" + textBoxSearchPiece.Text + "%'", dataGridViewAchatPiece);

        }

        private void textBoxSearchModele_TextChanged(object sender, EventArgs e)
        {
            DBVeloMax.DisplayAndSearch("SELECT idCommande, idModele, idClient, quantite, dateC, adresseL, dateL FROM Commande NATURAL JOIN Achat_Modele WHERE idCommande LIKE '%" + textBoxSearchModele.Text + "%'", dataGridViewAchatModele);

        }

        private void dataGridViewAchatPiece_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddCommande.ClearInputs();
                //formAddClient.idClient = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[2].Value);
                //formAddClient.type = dataGridViewBoutique.Rows[e.RowIndex].Cells[3].Value.ToString();
                //formAddClient.adresse = dataGridViewBoutique.Rows[e.RowIndex].Cells[4].Value.ToString();
                //formAddClient.courriel = dataGridViewBoutique.Rows[e.RowIndex].Cells[5].Value.ToString();
                //formAddClient.telephone = dataGridViewBoutique.Rows[e.RowIndex].Cells[6].Value.ToString();
                //formAddClient.nom = dataGridViewBoutique.Rows[e.RowIndex].Cells[7].Value.ToString();
                //formAddClient.contact = dataGridViewBoutique.Rows[e.RowIndex].Cells[8].Value.ToString();
                //formAddClient.remise = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[9].Value);
                //formAddClient.volumeA = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[10].Value);
                formAddCommande.UpdateInfo();
                formAddCommande.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteClient(Convert.ToInt32(dataGridViewAchatPiece.Rows[e.RowIndex].Cells[2].Value));
                    DisplayCommandePiece();
                }
                return;
            }
        }

        private void dataGridViewAchatModele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddCommande.ClearInputs();
                //formAddClient.idClient = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[2].Value);
                //formAddClient.type = dataGridViewBoutique.Rows[e.RowIndex].Cells[3].Value.ToString();
                //formAddClient.adresse = dataGridViewBoutique.Rows[e.RowIndex].Cells[4].Value.ToString();
                //formAddClient.courriel = dataGridViewBoutique.Rows[e.RowIndex].Cells[5].Value.ToString();
                //formAddClient.telephone = dataGridViewBoutique.Rows[e.RowIndex].Cells[6].Value.ToString();
                //formAddClient.nom = dataGridViewBoutique.Rows[e.RowIndex].Cells[7].Value.ToString();
                //formAddClient.contact = dataGridViewBoutique.Rows[e.RowIndex].Cells[8].Value.ToString();
                //formAddClient.remise = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[9].Value);
                //formAddClient.volumeA = Convert.ToInt32(dataGridViewBoutique.Rows[e.RowIndex].Cells[10].Value);
                formAddCommande.UpdateInfo();
                formAddCommande.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteClient(Convert.ToInt32(dataGridViewAchatModele.Rows[e.RowIndex].Cells[2].Value));
                    DisplayCommandeModele();
                }
                return;
            }

        }
    }
}
