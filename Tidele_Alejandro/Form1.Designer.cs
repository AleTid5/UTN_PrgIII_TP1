namespace Tidele_Alejandro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrujasYMagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrujasYMagosToolStripMenuItem,
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones mágicas";
            // 
            // BrujasYMagosToolStripMenuItem
            // 
            this.BrujasYMagosToolStripMenuItem.Name = "BrujasYMagosToolStripMenuItem";
            this.BrujasYMagosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.BrujasYMagosToolStripMenuItem.Text = "Brujas y Magos";
            this.BrujasYMagosToolStripMenuItem.Click += new System.EventHandler(this.BrujasYMagosToolStripMenuItem_Click);
            // 
            // miembrosDelMinisterioDeMagiaToolStripMenuItem
            // 
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem.Name = "miembrosDelMinisterioDeMagiaToolStripMenuItem";
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem.Text = "Miembros del ministerio de magia";
            this.miembrosDelMinisterioDeMagiaToolStripMenuItem.Click += new System.EventHandler(this.miembrosDelMinisterioDeMagiaToolStripMenuItem_Click);
            // 
            // closeAll
            // 
            this.closeAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.closeAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAll.ForeColor = System.Drawing.Color.Snow;
            this.closeAll.Location = new System.Drawing.Point(282, 433);
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(234, 71);
            this.closeAll.TabIndex = 24;
            this.closeAll.Text = "Finite Incantatem";
            this.closeAll.UseVisualStyleBackColor = false;
            this.closeAll.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Magicians1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(3, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 479);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Morsmordre1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(522, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 479);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Tidele_Alejandro.Properties.Resources.Snitch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.closeAll;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.closeAll);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hogwarts School | Draco Dormiens Nunquam Titillandus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrujasYMagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miembrosDelMinisterioDeMagiaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button closeAll;
    }
}

