namespace WindowsFormsApp1.ruedas
{
    partial class FormEditarR
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
            this.components = new System.ComponentModel.Container();
            this.panelEdicion = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.textBoxCantidadB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCantidadS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSueltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBolsasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plasticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdicion
            // 
            this.panelEdicion.Controls.Add(this.btnEditar);
            this.panelEdicion.Controls.Add(this.btnEliminar);
            this.panelEdicion.Controls.Add(this.dataGridView1);
            this.panelEdicion.Controls.Add(this.btnVolver);
            this.panelEdicion.Controls.Add(this.panel1);
            this.panelEdicion.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdicion.Location = new System.Drawing.Point(0, 0);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.Size = new System.Drawing.Size(520, 640);
            this.panelEdicion.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditar.Location = new System.Drawing.Point(263, 522);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 36);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminar.Location = new System.Drawing.Point(374, 522);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 36);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.cantidadSueltaDataGridViewTextBoxColumn,
            this.cantidadBolsasDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.ruedaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(438, 478);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnVolver.Location = new System.Drawing.Point(12, 592);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 36);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDescripcion);
            this.panel1.Controls.Add(this.btnCancelarEdicion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAceptarEdicion);
            this.panel1.Controls.Add(this.textBoxCantidadB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxCantidadS);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCodigo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 640);
            this.panel1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(12, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancelar edicion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(325, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Confirmar edicion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(97, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descripcion:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxDescripcion.Location = new System.Drawing.Point(102, 340);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(310, 125);
            this.textBoxDescripcion.TabIndex = 20;
            this.textBoxDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDescripcion_KeyDown);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelarEdicion.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEdicion.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelarEdicion.Location = new System.Drawing.Point(12, 592);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(183, 36);
            this.btnCancelarEdicion.TabIndex = 23;
            this.btnCancelarEdicion.Text = "Cancelar edicion";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(97, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cantidad Bolsas:";
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnAceptarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarEdicion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEdicion.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAceptarEdicion.Location = new System.Drawing.Point(325, 592);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(183, 36);
            this.btnAceptarEdicion.TabIndex = 22;
            this.btnAceptarEdicion.Text = "Confirmar edicion";
            this.btnAceptarEdicion.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidadB
            // 
            this.textBoxCantidadB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCantidadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCantidadB.Location = new System.Drawing.Point(102, 251);
            this.textBoxCantidadB.Name = "textBoxCantidadB";
            this.textBoxCantidadB.Size = new System.Drawing.Size(310, 34);
            this.textBoxCantidadB.TabIndex = 18;
            this.textBoxCantidadB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCantidadB_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(97, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad suelta:";
            // 
            // textBoxCantidadS
            // 
            this.textBoxCantidadS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCantidadS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCantidadS.Location = new System.Drawing.Point(102, 171);
            this.textBoxCantidadS.Name = "textBoxCantidadS";
            this.textBoxCantidadS.Size = new System.Drawing.Size(310, 34);
            this.textBoxCantidadS.TabIndex = 16;
            this.textBoxCantidadS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCantidadS_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(97, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCodigo.Location = new System.Drawing.Point(102, 88);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(310, 34);
            this.textBoxCodigo.TabIndex = 14;
            this.textBoxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigo_KeyDown);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // cantidadSueltaDataGridViewTextBoxColumn
            // 
            this.cantidadSueltaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadSueltaDataGridViewTextBoxColumn.DataPropertyName = "CantidadSuelta";
            this.cantidadSueltaDataGridViewTextBoxColumn.HeaderText = "CantidadSuelta";
            this.cantidadSueltaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadSueltaDataGridViewTextBoxColumn.Name = "cantidadSueltaDataGridViewTextBoxColumn";
            // 
            // cantidadBolsasDataGridViewTextBoxColumn
            // 
            this.cantidadBolsasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadBolsasDataGridViewTextBoxColumn.DataPropertyName = "CantidadBolsas";
            this.cantidadBolsasDataGridViewTextBoxColumn.HeaderText = "CantidadBolsas";
            this.cantidadBolsasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadBolsasDataGridViewTextBoxColumn.Name = "cantidadBolsasDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // ruedaBindingSource
            // 
            this.ruedaBindingSource.DataSource = typeof(WindowsFormsApp1.ruedas.Rueda);
            // 
            // plasticoBindingSource
            // 
            this.plasticoBindingSource.DataSource = typeof(WindowsFormsApp1.Plastico);
            // 
            // FormEditarR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(520, 640);
            this.Controls.Add(this.panelEdicion);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarR";
            this.Text = "EditarR";
            this.panelEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEdicion;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCantidadB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCantidadS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.BindingSource plasticoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSueltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBolsasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ruedaBindingSource;
    }
}