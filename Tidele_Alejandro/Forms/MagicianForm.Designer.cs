namespace Tidele_Alejandro.Forms
{
    partial class MagicianForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicianForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Age = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.House = new System.Windows.Forms.ComboBox();
            this.Preferences = new System.Windows.Forms.GroupBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb0 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kind = new System.Windows.Forms.GroupBox();
            this.Muggle = new System.Windows.Forms.RadioButton();
            this.Witch = new System.Windows.Forms.RadioButton();
            this.Magician = new System.Windows.Forms.RadioButton();
            this.BornDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMagicians = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Preferences.SuspendLayout();
            this.Kind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagicians)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.cleanBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.House);
            this.panel1.Controls.Add(this.Preferences);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Kind);
            this.panel1.Controls.Add(this.BornDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LastnameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(232, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 295);
            this.panel1.TabIndex = 0;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Age.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Age.Location = new System.Drawing.Point(416, 82);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(112, 19);
            this.Age.TabIndex = 19;
            this.Age.Text = "TextToBeChanged";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.DarkRed;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Snow;
            this.create.Location = new System.Drawing.Point(374, 264);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(132, 23);
            this.create.TabIndex = 18;
            this.create.Text = "Crear";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackColor = System.Drawing.Color.DimGray;
            this.cleanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanBtn.ForeColor = System.Drawing.Color.Snow;
            this.cleanBtn.Location = new System.Drawing.Point(56, 264);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(132, 23);
            this.cleanBtn.TabIndex = 17;
            this.cleanBtn.Text = "Obliviate!";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(415, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Casa";
            // 
            // House
            // 
            this.House.BackColor = System.Drawing.Color.BurlyWood;
            this.House.Cursor = System.Windows.Forms.Cursors.Hand;
            this.House.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.House.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.House.ForeColor = System.Drawing.Color.Sienna;
            this.House.FormattingEnabled = true;
            this.House.Items.AddRange(new object[] {
            "Gryffindor",
            "Slytherin",
            "Hufflepuff",
            "Ravenclaw"});
            this.House.Location = new System.Drawing.Point(418, 122);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(88, 21);
            this.House.TabIndex = 15;
            // 
            // Preferences
            // 
            this.Preferences.Controls.Add(this.cb5);
            this.Preferences.Controls.Add(this.cb2);
            this.Preferences.Controls.Add(this.cb4);
            this.Preferences.Controls.Add(this.cb1);
            this.Preferences.Controls.Add(this.cb3);
            this.Preferences.Controls.Add(this.cb0);
            this.Preferences.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold);
            this.Preferences.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Preferences.Location = new System.Drawing.Point(56, 158);
            this.Preferences.Name = "Preferences";
            this.Preferences.Size = new System.Drawing.Size(450, 100);
            this.Preferences.TabIndex = 14;
            this.Preferences.TabStop = false;
            this.Preferences.Text = "Asignaturas del año";
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.Location = new System.Drawing.Point(233, 73);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(128, 20);
            this.cb5.TabIndex = 5;
            this.cb5.Text = "Transformaciones";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cb2.Location = new System.Drawing.Point(6, 73);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(63, 20);
            this.cb2.TabIndex = 2;
            this.cb2.Text = "Vuelo";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cb4.Location = new System.Drawing.Point(233, 46);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(93, 20);
            this.cb4.TabIndex = 4;
            this.cb4.Text = "Herbología";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cb1.Location = new System.Drawing.Point(6, 46);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(119, 20);
            this.cb1.TabIndex = 1;
            this.cb1.Text = "Encantamientos";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cb3.Location = new System.Drawing.Point(233, 19);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(212, 20);
            this.cb3.TabIndex = 3;
            this.cb3.Text = "Defensa contra las artes oscuras";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb0
            // 
            this.cb0.AutoSize = true;
            this.cb0.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cb0.Location = new System.Drawing.Point(6, 19);
            this.cb0.Name = "cb0";
            this.cb0.Size = new System.Drawing.Size(177, 20);
            this.cb0.TabIndex = 0;
            this.cb0.Text = "Astronomía y Adivinación";
            this.cb0.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(415, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edad";
            // 
            // Kind
            // 
            this.Kind.Controls.Add(this.Muggle);
            this.Kind.Controls.Add(this.Witch);
            this.Kind.Controls.Add(this.Magician);
            this.Kind.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold);
            this.Kind.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Kind.Location = new System.Drawing.Point(205, 106);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(204, 46);
            this.Kind.TabIndex = 12;
            this.Kind.TabStop = false;
            this.Kind.Text = "Género";
            // 
            // Muggle
            // 
            this.Muggle.AutoSize = true;
            this.Muggle.Font = new System.Drawing.Font("Poor Richard", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Muggle.Location = new System.Drawing.Point(138, 19);
            this.Muggle.Name = "Muggle";
            this.Muggle.Size = new System.Drawing.Size(62, 18);
            this.Muggle.TabIndex = 2;
            this.Muggle.Text = "Muggle";
            this.Muggle.UseVisualStyleBackColor = true;
            // 
            // Witch
            // 
            this.Witch.AutoSize = true;
            this.Witch.Font = new System.Drawing.Font("Poor Richard", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Witch.Location = new System.Drawing.Point(73, 19);
            this.Witch.Name = "Witch";
            this.Witch.Size = new System.Drawing.Size(53, 18);
            this.Witch.TabIndex = 1;
            this.Witch.Text = "Bruja";
            this.Witch.UseVisualStyleBackColor = true;
            // 
            // Magician
            // 
            this.Magician.AutoSize = true;
            this.Magician.Checked = true;
            this.Magician.Font = new System.Drawing.Font("Poor Richard", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Magician.Location = new System.Drawing.Point(6, 19);
            this.Magician.Name = "Magician";
            this.Magician.Size = new System.Drawing.Size(52, 18);
            this.Magician.TabIndex = 0;
            this.Magician.TabStop = true;
            this.Magician.Text = "Mago";
            this.Magician.UseVisualStyleBackColor = true;
            // 
            // BornDate
            // 
            this.BornDate.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BornDate.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.BornDate.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.BornDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.BornDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BornDate.Location = new System.Drawing.Point(205, 80);
            this.BornDate.MaxDate = new System.DateTime(2019, 4, 2, 0, 0, 0, 0);
            this.BornDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BornDate.Name = "BornDate";
            this.BornDate.Size = new System.Drawing.Size(204, 20);
            this.BornDate.TabIndex = 8;
            this.BornDate.Value = new System.DateTime(1980, 7, 31, 0, 0, 0, 0);
            this.BornDate.ValueChanged += new System.EventHandler(this.BornDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(202, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(56, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // LastnameBox
            // 
            this.LastnameBox.BackColor = System.Drawing.Color.BurlyWood;
            this.LastnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastnameBox.ForeColor = System.Drawing.Color.Sienna;
            this.LastnameBox.Location = new System.Drawing.Point(56, 124);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(134, 20);
            this.LastnameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.BurlyWood;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.ForeColor = System.Drawing.Color.Sienna;
            this.NameBox.Location = new System.Drawing.Point(56, 81);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(132, 20);
            this.NameBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Hogwarts;
            this.panel2.Location = new System.Drawing.Point(259, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Slytherin;
            this.panel4.Location = new System.Drawing.Point(386, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 62);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Hufflepuff;
            this.panel5.Location = new System.Drawing.Point(591, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 62);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Ravenclaw;
            this.panel6.Location = new System.Drawing.Point(688, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 62);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Gryffindor;
            this.panel3.Location = new System.Drawing.Point(288, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 62);
            this.panel3.TabIndex = 2;
            // 
            // dgvMagicians
            // 
            this.dgvMagicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagicians.Location = new System.Drawing.Point(12, 313);
            this.dgvMagicians.Name = "dgvMagicians";
            this.dgvMagicians.Size = new System.Drawing.Size(776, 163);
            this.dgvMagicians.TabIndex = 4;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.DarkRed;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.Snow;
            this.remove.Location = new System.Drawing.Point(657, 482);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(132, 23);
            this.remove.TabIndex = 21;
            this.remove.Text = "Avada Kedavra!";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.Desktop;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Snow;
            this.edit.Location = new System.Drawing.Point(517, 482);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(132, 23);
            this.edit.TabIndex = 20;
            this.edit.Text = "Imperio!";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(12, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MagicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Snitch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dgvMagicians);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hogwarts School | Alta de Brujas y Magos (ABM)";
            this.Load += new System.EventHandler(this.MagicianForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Preferences.ResumeLayout(false);
            this.Preferences.PerformLayout();
            this.Kind.ResumeLayout(false);
            this.Kind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagicians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BornDate;
        private System.Windows.Forms.GroupBox Kind;
        private System.Windows.Forms.GroupBox Preferences;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Magician;
        private System.Windows.Forms.RadioButton Muggle;
        private System.Windows.Forms.RadioButton Witch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox House;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.DataGridView dgvMagicians;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button button3;
    }
}