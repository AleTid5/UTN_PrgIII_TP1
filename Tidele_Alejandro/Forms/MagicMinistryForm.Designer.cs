namespace Tidele_Alejandro.Forms
{
    partial class MagicMinistryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicMinistryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.createBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalDisabled = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.disabledList = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeList = new System.Windows.Forms.ListView();
            this.activateBtn = new System.Windows.Forms.Button();
            this.activateAllBtn = new System.Windows.Forms.Button();
            this.disableBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Mago o Bruja";
            // 
            // createBox
            // 
            this.createBox.BackColor = System.Drawing.Color.BurlyWood;
            this.createBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createBox.ForeColor = System.Drawing.Color.Sienna;
            this.createBox.Location = new System.Drawing.Point(17, 32);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(238, 20);
            this.createBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.totalDisabled);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.disabledList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 487);
            this.panel1.TabIndex = 6;
            // 
            // totalDisabled
            // 
            this.totalDisabled.AutoSize = true;
            this.totalDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalDisabled.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalDisabled.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.totalDisabled.Location = new System.Drawing.Point(56, 454);
            this.totalDisabled.Name = "totalDisabled";
            this.totalDisabled.Size = new System.Drawing.Size(16, 16);
            this.totalDisabled.TabIndex = 24;
            this.totalDisabled.Text = "0";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.Black;
            this.createBtn.Location = new System.Drawing.Point(230, 4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(25, 25);
            this.createBtn.TabIndex = 23;
            this.createBtn.Text = "+";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(14, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // disabledList
            // 
            this.disabledList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.disabledList.Location = new System.Drawing.Point(17, 69);
            this.disabledList.Name = "disabledList";
            this.disabledList.Size = new System.Drawing.Size(238, 373);
            this.disabledList.TabIndex = 6;
            this.disabledList.UseCompatibleStateImageBehavior = false;
            this.disabledList.View = System.Windows.Forms.View.List;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.totalActive);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.activeList);
            this.panel2.Location = new System.Drawing.Point(517, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 487);
            this.panel2.TabIndex = 7;
            // 
            // totalActive
            // 
            this.totalActive.AutoSize = true;
            this.totalActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalActive.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalActive.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.totalActive.Location = new System.Drawing.Point(61, 454);
            this.totalActive.Name = "totalActive";
            this.totalActive.Size = new System.Drawing.Size(16, 16);
            this.totalActive.TabIndex = 25;
            this.totalActive.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(21, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Magos y Brujas activos en el Ministerio";
            // 
            // activeList
            // 
            this.activeList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.activeList.Location = new System.Drawing.Point(18, 69);
            this.activeList.Name = "activeList";
            this.activeList.Size = new System.Drawing.Size(238, 373);
            this.activeList.TabIndex = 7;
            this.activeList.UseCompatibleStateImageBehavior = false;
            this.activeList.View = System.Windows.Forms.View.List;
            // 
            // activateBtn
            // 
            this.activateBtn.BackColor = System.Drawing.Color.LightGreen;
            this.activateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateBtn.ForeColor = System.Drawing.Color.Snow;
            this.activateBtn.Location = new System.Drawing.Point(311, 12);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(175, 23);
            this.activateBtn.TabIndex = 19;
            this.activateBtn.Text = "Activar Mago o Bruja >";
            this.activateBtn.UseVisualStyleBackColor = false;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // activateAllBtn
            // 
            this.activateAllBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.activateAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateAllBtn.ForeColor = System.Drawing.Color.Snow;
            this.activateAllBtn.Location = new System.Drawing.Point(311, 44);
            this.activateAllBtn.Name = "activateAllBtn";
            this.activateAllBtn.Size = new System.Drawing.Size(175, 23);
            this.activateAllBtn.TabIndex = 20;
            this.activateAllBtn.Text = "Activar a todos >>";
            this.activateAllBtn.UseVisualStyleBackColor = false;
            this.activateAllBtn.Click += new System.EventHandler(this.activateAllBtn_Click);
            // 
            // disableBtn
            // 
            this.disableBtn.BackColor = System.Drawing.Color.Salmon;
            this.disableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableBtn.ForeColor = System.Drawing.Color.Snow;
            this.disableBtn.Location = new System.Drawing.Point(311, 77);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(175, 23);
            this.disableBtn.TabIndex = 21;
            this.disableBtn.Text = "Desactivar Mago o Bruja <";
            this.disableBtn.UseVisualStyleBackColor = false;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Tomato;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.Snow;
            this.removeBtn.Location = new System.Drawing.Point(311, 111);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(175, 23);
            this.removeBtn.TabIndex = 22;
            this.removeBtn.Text = "Mago o Bruja asesinado ...";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.ForeColor = System.Drawing.Color.Snow;
            this.goBack.Location = new System.Drawing.Point(311, 476);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(175, 23);
            this.goBack.TabIndex = 23;
            this.goBack.Text = "Finite";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // MagicMinistryForm
            // 
            this.AcceptButton = this.createBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Snitch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.goBack;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.activateAllBtn);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "MagicMinistryForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hogwarts School | Alumnos en Ministerio de Magia";
            this.Load += new System.EventHandler(this.MagicMinistryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView disabledList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView activeList;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.Button activateAllBtn;
        private System.Windows.Forms.Button disableBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label totalDisabled;
        private System.Windows.Forms.Label totalActive;
    }
}