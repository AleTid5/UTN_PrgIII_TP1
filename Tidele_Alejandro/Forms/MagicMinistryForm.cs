using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tidele_Alejandro.Forms
{
    public partial class MagicMinistryForm : Form
    {
        private new Form1 ParentForm;

        public MagicMinistryForm()
        {
            InitializeComponent();
        }

        public void SetParentForm(Form1 ParentForm) => this.ParentForm = ParentForm;

        private void MagicMinistryForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
