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

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Harry_Potter_Theme_Song);
            player.PlayLooping();
            System.IO.MemoryStream normal = new System.IO.MemoryStream(Properties.Resources.Harry_Potter_Cursor_Normal_Wand);
            System.IO.MemoryStream hover = new System.IO.MemoryStream(Properties.Resources.Harry_Hover);
            this.Cursor = new Cursor(normal);
            this.closeAll.Cursor = new Cursor(hover);
            this.button1.Cursor = this.closeAll.Cursor;
            this.button2.Cursor = this.closeAll.Cursor;
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
