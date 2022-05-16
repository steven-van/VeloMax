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

        private void btnOpenAddFournisseur_Click(object sender, EventArgs e)
        {
            formAddPiece.ClearInputs();
            formAddPiece.SaveInfo();
            formAddPiece.ShowDialog();
        }
    }
}
