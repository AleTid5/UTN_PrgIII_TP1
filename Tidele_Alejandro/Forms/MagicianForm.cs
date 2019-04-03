using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tidele_Alejandro.Models;
using static System.Linq.Enumerable;

namespace Tidele_Alejandro.Forms
{
    public partial class MagicianForm : Form
    {
        private int magicianId = 0;
        private new Form1 ParentForm;
        private Magician CurrentMagician;
        private BindingList<Magician> BindedList;

        public MagicianForm()
        {
            InitializeComponent();
        }

        public void SetParentForm(Form1 ParentForm) => this.ParentForm = ParentForm;

        private void MagicianForm_Load(object sender, EventArgs e)
        {
            this.Age.Text = this.getAge();
            this.House.SelectedItem = "Gryffindor";
            BindedList = new BindingList<Magician>(this.ParentForm.Magicians);
            this.dgvMagicians.DataSource = BindedList;
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            this.NameBox.Text = "";
            this.LastnameBox.Text = "";
            this.BornDate.Text = "31/7/1980";
            this.Magician.Checked = true;
            this.Age.Text = this.getAge();
            this.House.SelectedItem = "Gryffindor";
            this.cb0.Checked = false;
            this.cb1.Checked = false;
            this.cb2.Checked = false;
            this.cb3.Checked = false;
            this.cb4.Checked = false;
            this.cb5.Checked = false;
            this.magicianId = 0;
        }

        private void create_Click(object sender, EventArgs e)
        {
            this.CurrentMagician = new Magician
            {
                Name = this.NameBox.Text.ToString(),
                Lastname = this.LastnameBox.Text,
                Borndate = this.BornDate.Value,
                Kind = this.getKindSelected(),
                House = this.House.SelectedItem.ToString()
            };

            this.CurrentMagician.Subjects.Add(this.cb0.Checked);
            this.CurrentMagician.Subjects.Add(this.cb1.Checked);
            this.CurrentMagician.Subjects.Add(this.cb2.Checked);
            this.CurrentMagician.Subjects.Add(this.cb3.Checked);
            this.CurrentMagician.Subjects.Add(this.cb4.Checked);
            this.CurrentMagician.Subjects.Add(this.cb5.Checked);

            if (!this.CurrentMagician.Validate())
            {
                MessageBox.Show("El formulario de inscripción a Hogwarts es inválido!");
                return;
            }

            if (this.magicianId != 0)
            {
                this.CurrentMagician.Id = this.magicianId;
                int i = 0;

                foreach (Magician magician in this.ParentForm.Magicians)
                {
                    if (magician.Id == this.CurrentMagician.Id) break;
                    i++;
                }

                this.ParentForm.Magicians[i] = this.CurrentMagician;
            } else
            {
                this.ParentForm.magicianID++;
                this.CurrentMagician.Id = this.ParentForm.magicianID;
                this.ParentForm.Magicians.Add(CurrentMagician);
            }

            this.cleanBtn_Click(sender, e);
            BindedList.ResetBindings();
        }

        private void BornDate_ValueChanged(object sender, EventArgs e)
        {
            this.Age.Text = this.getAge();
        }

        private string getAge()
        {
            int age = DateTime.Today.Year - this.BornDate.Value.Year;
         
            return age + (age == 1 ? " Año" : " Años");
        }

        private string getKindSelected()
        {
            return this.Magician.Checked ? this.Magician.Text :
                   this.Witch.Checked ? this.Witch.Text : this.Muggle.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (null == this.dgvMagicians.CurrentRow) return;

            Object objectSelected;
            objectSelected = this.dgvMagicians.CurrentRow.DataBoundItem;
            Magician selectedMagician = (Magician) objectSelected;
            this.magicianId = selectedMagician.Id;
            this.SetEditableForm(selectedMagician);

            BindedList.ResetBindings();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (null == this.dgvMagicians.CurrentRow) return;

            Object objectSelected;
            objectSelected = this.dgvMagicians.CurrentRow.DataBoundItem;
            Magician selectedMagician = (Magician) objectSelected;
            this.ParentForm.Magicians.Remove(selectedMagician);

            BindedList.ResetBindings();
        }

        private void SetEditableForm(Magician magician)
        {
            this.NameBox.Text = magician.Name;
            this.LastnameBox.Text = magician.Lastname;
            this.BornDate.Value = magician.Borndate;
            this.House.SelectedItem = magician.House;
            this.SetKindMagicianForm(magician.Kind);
            this.SetSubjectsMagicianForm(magician.Subjects);
        }

        private void SetKindMagicianForm(string kind)
        {
            this.Magician.Checked = false;
            this.Witch.Checked = false;
            this.Muggle.Checked = false;

            switch (kind)
            {
                case "Mago":
                    this.Magician.Checked = true;
                    break;
                case "Bruja":
                    this.Witch.Checked = true;
                    break;
                default:
                    this.Muggle.Checked = true;
                    break;
            }
        }

        private void SetSubjectsMagicianForm(List<bool> subject)
        {
            this.cb0.Checked = subject[0];
            this.cb1.Checked = subject[1];
            this.cb2.Checked = subject[2];
            this.cb3.Checked = subject[3];
            this.cb4.Checked = subject[4];
            this.cb5.Checked = subject[5];
        }
    }
}
