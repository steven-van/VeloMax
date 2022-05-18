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
    public partial class FormPiece : Form
    {

        FormAddPiece formAddPiece;

        public FormPiece()
        {
            InitializeComponent();
            formAddPiece = new FormAddPiece(this);

        }

        public void DisplayPiece()
        {
            DBVeloMax.DisplayAndSearch("SELECT idPiece, description, categorie, prixU, stock, dateI, dateD, delaiA FROM Piece;", dataGridViewPiece);
        }


        private void FormPiece_Shown(object sender, EventArgs e)
        {
            DisplayPiece();
        }

        private void FormPiece_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPiece_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddPiece.ClearInputs();
                formAddPiece.idPiece = Convert.ToInt32(dataGridViewPiece.Rows[e.RowIndex].Cells[2].Value);
                formAddPiece.desc = dataGridViewPiece.Rows[e.RowIndex].Cells[3].Value.ToString();
                formAddPiece.categorie = dataGridViewPiece.Rows[e.RowIndex].Cells[4].Value.ToString();
                formAddPiece.prixU = Convert.ToDouble(dataGridViewPiece.Rows[e.RowIndex].Cells[5].Value);
                formAddPiece.stock = Convert.ToInt32(dataGridViewPiece.Rows[e.RowIndex].Cells[6].Value);
                formAddPiece.dateI = dataGridViewPiece.Rows[e.RowIndex].Cells[7].Value.ToString() == "" ? DateTime.Now : Convert.ToDateTime(dataGridViewPiece.Rows[e.RowIndex].Cells[7].Value); 
                formAddPiece.dateD = dataGridViewPiece.Rows[e.RowIndex].Cells[8].Value.ToString() == "" ? DateTime.Now : Convert.ToDateTime(dataGridViewPiece.Rows[e.RowIndex].Cells[8].Value);
                formAddPiece.delaiA = Convert.ToInt32(dataGridViewPiece.Rows[e.RowIndex].Cells[9].Value);
                formAddPiece.UpdateInfo();
                formAddPiece.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette pièce ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeletePiece(Convert.ToInt32(dataGridViewPiece.Rows[e.RowIndex].Cells[2].Value));
                    DisplayPiece();
                }
                return;
            }
        }

        private void btnOpenAddPiece_Click_1(object sender, EventArgs e)
        {
            formAddPiece.ClearInputs();
            formAddPiece.SaveInfo();
            formAddPiece.ShowDialog();
        }
    }
}
