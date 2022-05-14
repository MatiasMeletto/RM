namespace WindowsFormsApp1
{
    partial class FormAccesorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccesorios));
            this.btnAccesoriosVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccesoriosVolverMenu
            // 
            this.btnAccesoriosVolverMenu.BackColor = System.Drawing.Color.Gray;
            this.btnAccesoriosVolverMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccesoriosVolverMenu.BackgroundImage")));
            this.btnAccesoriosVolverMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccesoriosVolverMenu.FlatAppearance.BorderSize = 0;
            this.btnAccesoriosVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesoriosVolverMenu.Location = new System.Drawing.Point(12, 12);
            this.btnAccesoriosVolverMenu.Name = "btnAccesoriosVolverMenu";
            this.btnAccesoriosVolverMenu.Size = new System.Drawing.Size(62, 32);
            this.btnAccesoriosVolverMenu.TabIndex = 1;
            this.btnAccesoriosVolverMenu.UseVisualStyleBackColor = false;
            this.btnAccesoriosVolverMenu.Click += new System.EventHandler(this.btnAccesoriosVolverMenu_Click);
            // 
            // FormAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.btnAccesoriosVolverMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccesorios";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccesoriosVolverMenu;
    }
}