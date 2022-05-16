using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormEditorP : Form
    {
        private void AbrirFormularioHijo(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelEditor.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        public FormEditorP()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormAgregarP());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEditar());
        }
    }
}
