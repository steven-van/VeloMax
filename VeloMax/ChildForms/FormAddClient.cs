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
    public partial class FormAddClient : Form
    {
        FormClient formParent;

        public FormAddClient(FormClient parent)
        {
            InitializeComponent();
            formParent = parent;
        }

        private void FormAddClient_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Individu")
            {
                groupBoxBoutique.Enabled = false;
                groupBoxIndividu.Enabled = true;
            }
            if (comboBoxType.SelectedItem.ToString() == "Boutique")
            {
                groupBoxIndividu.Enabled = false;
                groupBoxBoutique.Enabled = true;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }
    }
}
