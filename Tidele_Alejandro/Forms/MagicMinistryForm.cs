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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MagicMinistryForm_Load(object sender, EventArgs e)
        {
            this.InitializeCursor();

            foreach (string magician in this.ParentForm.MagicMinistry.InactiveMagicians)
            {
                ListViewItem list = new ListViewItem(magician);
                this.disabledList.Items.Add(list);
            }

            foreach (string magician in this.ParentForm.MagicMinistry.ActiveMagicians)
            {
                ListViewItem list = new ListViewItem(magician);
                this.activeList.Items.Add(list);
            }

            UpdateListCount();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string magician = this.createBox.Text.ToString();
            if (String.IsNullOrEmpty(magician) || String.IsNullOrWhiteSpace(magician)) return;

            this.createBox.Text = null;
            this.ParentForm.MagicMinistry.InactiveMagicians.Add(magician);
            ListViewItem listViewItem = new ListViewItem(magician);
            this.disabledList.Items.Add(listViewItem);

            UpdateListCount();
        }
        private void activateBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.disabledList.SelectedItems)
            {
                string magician = this.ParentForm.MagicMinistry.InactiveMagicians[listViewItem.Index];
                this.ParentForm.MagicMinistry.InactiveMagicians.RemoveAt(listViewItem.Index);
                this.ParentForm.MagicMinistry.ActiveMagicians.Add(magician);
                ListViewItem list = new ListViewItem(magician);
                this.activeList.Items.Add(list);
                this.disabledList.Items.RemoveAt(listViewItem.Index);
            }

            UpdateListCount();
        }

        private void activateAllBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.disabledList.Items)
            {
                string magician = this.ParentForm.MagicMinistry.InactiveMagicians[listViewItem.Index];
                this.ParentForm.MagicMinistry.InactiveMagicians.RemoveAt(listViewItem.Index);
                this.ParentForm.MagicMinistry.ActiveMagicians.Add(magician);
                ListViewItem list = new ListViewItem(magician);
                this.activeList.Items.Add(list);
                this.disabledList.Items.RemoveAt(listViewItem.Index);
            }

            UpdateListCount();
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.activeList.SelectedItems)
            {
                string magician = this.ParentForm.MagicMinistry.ActiveMagicians[listViewItem.Index];
                this.ParentForm.MagicMinistry.ActiveMagicians.RemoveAt(listViewItem.Index);
                this.ParentForm.MagicMinistry.InactiveMagicians.Add(magician);
                ListViewItem list = new ListViewItem(magician);
                this.disabledList.Items.Add(list);
                this.activeList.Items.RemoveAt(listViewItem.Index);
            }

            UpdateListCount();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in this.activeList.SelectedItems)
            {
                this.ParentForm.MagicMinistry.ActiveMagicians.RemoveAt(listViewItem.Index);
                this.activeList.Items.RemoveAt(listViewItem.Index);
            }

            UpdateListCount();
        }

        private void UpdateListCount()
        {
            this.totalActive.Text   = this.activeList.Items.Count.ToString();
            this.totalDisabled.Text = this.disabledList.Items.Count.ToString();
        }

        private void InitializeCursor()
        {
            this.Cursor = this.ParentForm.Cursor;
            this.createBtn.Cursor = this.ParentForm.closeAll.Cursor;
            this.activateBtn.Cursor = this.ParentForm.closeAll.Cursor;
            this.activateAllBtn.Cursor = this.ParentForm.closeAll.Cursor;
            this.disableBtn.Cursor = this.ParentForm.closeAll.Cursor;
            this.removeBtn.Cursor = this.ParentForm.closeAll.Cursor;
            this.goBack.Cursor = this.ParentForm.closeAll.Cursor;
        }
    }
}
