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
        public MagicMinistry MagicMinistry = new MagicMinistry();

        public Form1()
        {
            InitializeComponent();
        }

        private void BrujasYMagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagicianForm magicianForm = new MagicianForm();
            magicianForm.SetParentForm(this);
            magicianForm.ShowDialog();
        }

        private void miembrosDelMinisterioDeMagiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagicMinistryForm magicMinistryForm = new MagicMinistryForm();
            magicMinistryForm.SetParentForm(this);
            magicMinistryForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BrujasYMagosToolStripMenuItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem_Click(sender, e);
        }
    }
}
