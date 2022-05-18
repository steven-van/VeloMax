﻿using System;
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
    public partial class FormAdherent : Form
    {
        FormAddAdherent formAddAdherent;

        public FormAdherent()
        {
            InitializeComponent();
            formAddAdherent = new FormAddAdherent(this);
        }

        public void DisplayAdherent()
        {
            DBVeloMax.DisplayAndSearch("SELECT idFidelite, description,  idClient, nom, prenom, dateAdhesion, duree, rabais FROM Adhesion NATURAL JOIN Individu NATURAL JOIN Fidelite;", dataGridViewAdhesion);

        }

        private void FormAdherent_Shown(object sender, EventArgs e)
        {
            DisplayAdherent();
        }

        private void btnOpenAddCommande_Click(object sender, EventArgs e)
        {
            formAddAdherent.ClearInputs();
            formAddAdherent.SaveInfo();
            formAddAdherent.ShowDialog();
        }

        private void dataGridViewAdhesion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //Modifier
            {
                formAddAdherent.ClearInputs();
                formAddAdherent.client = String.Format("{0} - {1} - {2}", dataGridViewAdhesion.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridViewAdhesion.Rows[e.RowIndex].Cells[5].Value.ToString(), dataGridViewAdhesion.Rows[e.RowIndex].Cells[6].Value.ToString());
                formAddAdherent.fidelite = String.Format("{0} - {1}", dataGridViewAdhesion.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridViewAdhesion.Rows[e.RowIndex].Cells[3].Value.ToString());
                formAddAdherent.UpdateInfo();
                formAddAdherent.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1) //Supprimer
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce fournisseur ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBVeloMax.DeleteFournisseur(dataGridViewAdhesion.Rows[e.RowIndex].Cells[4].Value.ToString());
                    DisplayAdherent();
                }
                return;
            }
        }
    }
}