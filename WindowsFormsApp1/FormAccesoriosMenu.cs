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
    public partial class FormAccesoriosMenu : Form
    {
        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form form)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelCambiableAccesorios.Controls.Add(form);
            panelCambiableAccesorios.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public FormAccesoriosMenu()
        {
            InitializeComponent();
        }

        private void btnAccesoriosVolverMenu_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void btnPlasticos_Click(object sender, EventArgs e)
        {
            btnPlasticos.BackColor = Color.FromArgb(46, 51, 73);
            AbrirFormularioHijo(new FormPlasticos());
            User.Text = "Plasticos asdfjkwfa";
        }

        private void btnPlasticos_Leave(object sender, EventArgs e)
        {
            btnPlasticos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRuedas_Click(object sender, EventArgs e)
        {
            btnRuedas.BackColor = Color.FromArgb(46, 51, 73);
            AbrirFormularioHijo(new FormRuedas());
        }

        private void btnEscuadras_Click(object sender, EventArgs e)
        {
            btnEscuadras.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnBisagras_Click(object sender, EventArgs e)
        {
            btnBisagras.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnManijas_Click(object sender, EventArgs e)
        {
            btnManijas.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCerraduras_Click(object sender, EventArgs e)
        {
            btnCerraduras.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCierres_Click(object sender, EventArgs e)
        {
            btnCierres.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRuedas_Leave(object sender, EventArgs e)
        {
            btnRuedas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEscuadras_Leave(object sender, EventArgs e)
        {
            btnEscuadras.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBisagras_Leave(object sender, EventArgs e)
        {
            btnBisagras.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnManijas_Leave(object sender, EventArgs e)
        {
            btnManijas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCerraduras_Leave(object sender, EventArgs e)
        {
            btnCerraduras.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCierres_Leave(object sender, EventArgs e)
        {
            btnCierres.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            else
                return;
        }
    }
}
