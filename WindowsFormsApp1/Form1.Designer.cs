namespace WindowsFormsApp1
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.logoMenu = new System.Windows.Forms.PictureBox();
            this.btnPerfiles = new System.Windows.Forms.Button();
            this.btnAccesorios = new System.Windows.Forms.Button();
            this.panelAccesorios = new System.Windows.Forms.Panel();
            this.panelPerfiles = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logoMenu)).BeginInit();
            this.panelAccesorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoMenu
            // 
            this.logoMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoMenu.BackColor = System.Drawing.Color.Transparent;
            this.logoMenu.Image = ((System.Drawing.Image)(resources.GetObject("logoMenu.Image")));
            this.logoMenu.Location = new System.Drawing.Point(367, 118);
            this.logoMenu.Name = "logoMenu";
            this.logoMenu.Size = new System.Drawing.Size(900, 500);
            this.logoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoMenu.TabIndex = 0;
            this.logoMenu.TabStop = false;
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.btnPerfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerfiles.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnPerfiles.FlatAppearance.BorderSize = 0;
            this.btnPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfiles.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfiles.ForeColor = System.Drawing.Color.Black;
            this.btnPerfiles.Location = new System.Drawing.Point(367, 564);
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Size = new System.Drawing.Size(451, 54);
            this.btnPerfiles.TabIndex = 1;
            this.btnPerfiles.Text = "Perfiles";
            this.btnPerfiles.UseVisualStyleBackColor = false;
            // 
            // btnAccesorios
            // 
            this.btnAccesorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccesorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.btnAccesorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccesorios.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAccesorios.FlatAppearance.BorderSize = 0;
            this.btnAccesorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesorios.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnAccesorios.ForeColor = System.Drawing.Color.Black;
            this.btnAccesorios.Location = new System.Drawing.Point(816, 564);
            this.btnAccesorios.Name = "btnAccesorios";
            this.btnAccesorios.Size = new System.Drawing.Size(451, 54);
            this.btnAccesorios.TabIndex = 2;
            this.btnAccesorios.Text = "Accesorios";
            this.btnAccesorios.UseVisualStyleBackColor = false;
            this.btnAccesorios.Click += new System.EventHandler(this.btnAccesorios_Click);
            // 
            // panelAccesorios
            // 
            this.panelAccesorios.BackColor = System.Drawing.Color.Transparent;
            this.panelAccesorios.Controls.Add(this.panelPerfiles);
            this.panelAccesorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccesorios.Location = new System.Drawing.Point(0, 0);
            this.panelAccesorios.Name = "panelAccesorios";
            this.panelAccesorios.Size = new System.Drawing.Size(1600, 800);
            this.panelAccesorios.TabIndex = 3;
            this.panelAccesorios.Visible = false;
            // 
            // panelPerfiles
            // 
            this.panelPerfiles.Location = new System.Drawing.Point(218, 28);
            this.panelPerfiles.Name = "panelPerfiles";
            this.panelPerfiles.Size = new System.Drawing.Size(200, 100);
            this.panelPerfiles.TabIndex = 0;
            this.panelPerfiles.Visible = false;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.btnAccesorios);
            this.Controls.Add(this.btnPerfiles);
            this.Controls.Add(this.logoMenu);
            this.Controls.Add(this.panelAccesorios);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "formMenu";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.logoMenu)).EndInit();
            this.panelAccesorios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoMenu;
        private System.Windows.Forms.Button btnPerfiles;
        private System.Windows.Forms.Button btnAccesorios;
        private System.Windows.Forms.Panel panelAccesorios;
        private System.Windows.Forms.Panel panelPerfiles;
    }
}

