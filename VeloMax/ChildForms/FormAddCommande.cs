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
    public partial class FormAddCommande : Form
    {

        FormCommande formParent;

        public FormAddCommande(FormCommande parent)
        {
            InitializeComponent();
            formParent = parent;
        }

  

        private void btnAddCommande_Click(object sender, EventArgs e)
        {

        }
    }
}
