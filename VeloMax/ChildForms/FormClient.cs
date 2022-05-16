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

        public void DisplayClient()
        {
            DBVeloMax.DisplayAndSearch("SELECT idClient, type, adresse, courriel, telephone FROM Client;", dataGridViewClient);
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClient_Shown(object sender, EventArgs e)
        {
            DisplayClient();
        }

        private void btnOpenAddClient_Click(object sender, EventArgs e)
        {
            //formAddClient.ClearInputs();
            //formAddClient.SaveInfo();
            formAddClient.ShowDialog();
        }
    }
}
