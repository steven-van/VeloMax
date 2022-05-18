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

        public void DisplayCommande()
        {
            DBVeloMax.DisplayAndSearch("SELECT idCommande, dateC, adresseL, dateL, idClient, type FROM Commande NATURAL JOIN Client", dataGridViewCommande);

        }

        private void FormCommande_Shown(object sender, EventArgs e)
        {
            DisplayCommande();
                    
        }

        private void btnOpenAddCommande_Click(object sender, EventArgs e)
        {
            //formAddFournisseur.ClearInputs();
            //formAddFournisseur.SaveInfo();
            formAddCommande.ShowDialog();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DBVeloMax.DisplayAndSearch("SELECT idCommande, dateC, adresseL, dateL, idClient, type FROM Commande NATURAL JOIN Client WHERE idCommande LIKE '%" + textBoxSearch.Text + "%';", dataGridViewCommande);
        }
    }
}
