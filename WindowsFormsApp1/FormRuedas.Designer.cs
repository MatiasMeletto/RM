namespace WindowsFormsApp1
{
    partial class FormRuedas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditarCantidadB = new System.Windows.Forms.Button();
            this.panelModificarCantidad = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEditarCantidadS = new System.Windows.Forms.Button();
            this.btnEditarLista = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelModificarCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(463, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 640);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button1.Location = new System.Drawing.Point(497, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(143, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 62);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar accesorios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(143, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(238, 62);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar accesorios";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditarCantidadB
            // 
            this.btnEditarCantidadB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarCantidadB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(254)))), ((int)(((byte)(164)))));
            this.btnEditarCantidadB.FlatAppearance.BorderSize = 0;
            this.btnEditarCantidadB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCantidadB.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnEditarCantidadB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarCantidadB.Location = new System.Drawing.Point(373, 672);
            this.btnEditarCantidadB.Name = "btnEditarCantidadB";
            this.btnEditarCantidadB.Size = new System.Drawing.Size(200, 38);
            this.btnEditarCantidadB.TabIndex = 14;
            this.btnEditarCantidadB.Text = "Modificar cantidad /b";
            this.btnEditarCantidadB.UseVisualStyleBackColor = false;
            // 
            // panelModificarCantidad
            // 
            this.panelModificarCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModificarCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModificarCantidad.Controls.Add(this.btnCerrar);
            this.panelModificarCantidad.Controls.Add(this.label1);
            this.panelModificarCantidad.Controls.Add(this.textBox2);
            this.panelModificarCantidad.Location = new System.Drawing.Point(390, 315);
            this.panelModificarCantidad.Name = "panelModificarCantidad";
            this.panelModificarCantidad.Size = new System.Drawing.Size(405, 151);
            this.panelModificarCantidad.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCerrar.Location = new System.Drawing.Point(382, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 27);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresar cantidad que se va a usar:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox2.Location = new System.Drawing.Point(34, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 24);
            this.textBox2.TabIndex = 6;
            // 
            // btnEditarCantidadS
            // 
            this.btnEditarCantidadS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarCantidadS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(254)))), ((int)(((byte)(164)))));
            this.btnEditarCantidadS.FlatAppearance.BorderSize = 0;
            this.btnEditarCantidadS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCantidadS.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnEditarCantidadS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarCantidadS.Location = new System.Drawing.Point(167, 672);
            this.btnEditarCantidadS.Name = "btnEditarCantidadS";
            this.btnEditarCantidadS.Size = new System.Drawing.Size(200, 38);
            this.btnEditarCantidadS.TabIndex = 12;
            this.btnEditarCantidadS.Text = "Modificar cantidad /s ";
            this.btnEditarCantidadS.UseVisualStyleBackColor = false;
            // 
            // btnEditarLista
            // 
            this.btnEditarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(254)))), ((int)(((byte)(164)))));
            this.btnEditarLista.FlatAppearance.BorderSize = 0;
            this.btnEditarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLista.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnEditarLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarLista.Location = new System.Drawing.Point(1028, 672);
            this.btnEditarLista.Name = "btnEditarLista";
            this.btnEditarLista.Size = new System.Drawing.Size(131, 38);
            this.btnEditarLista.TabIndex = 11;
            this.btnEditarLista.Text = "Editar lista";
            this.btnEditarLista.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.Location = new System.Drawing.Point(167, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 39);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Codigo de accesorio...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 502);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormRuedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(233)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1326, 800);
            this.Controls.Add(this.btnEditarCantidadB);
            this.Controls.Add(this.panelModificarCantidad);
            this.Controls.Add(this.btnEditarCantidadS);
            this.Controls.Add(this.btnEditarLista);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRuedas";
            this.Text = "FormRuedas";
            this.panel1.ResumeLayout(false);
            this.panelModificarCantidad.ResumeLayout(false);
            this.panelModificarCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditarCantidadB;
        private System.Windows.Forms.Panel panelModificarCantidad;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEditarCantidadS;
        private System.Windows.Forms.Button btnEditarLista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}