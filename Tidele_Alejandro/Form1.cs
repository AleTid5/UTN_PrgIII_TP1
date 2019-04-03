using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tidele_Alejandro.Forms;
using Tidele_Alejandro.Models;

namespace Tidele_Alejandro
{
    public partial class Form1 : Form
    {
        public int magicianID = 0;
        public int magicianMinistryID = 0;
        public List<Magician> Magicians = new List<Magician>();
        public List<MagicMinistry> MagicMinistries = new List<MagicMinistry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BrujasYMagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagicianForm magicianForm = new MagicianForm();
            magicianForm.SetParentForm(this);
            //magicianForm.SetMagicians(this.magicians);
            magicianForm.ShowDialog();
        }
    }
}
