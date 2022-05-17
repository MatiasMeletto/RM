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
        private Button btnActual = null;
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
        private void BtnSeleccionado(Button button)
        {
            button.BackColor = Color.FromArgb(46, 51, 73);
            btnActual = button;
        }
        private void BtnDeseleccionado(Button button)
        {
            button.BackColor = Color.FromArgb(24, 30, 54);
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
            if (btnActual != null)
                BtnDeseleccionado(btnActual);
            panelNav.Height = btnPlasticos.Height;
            panelNav.Top = btnPlasticos.Top;
            panelNav.Left = btnPlasticos.Left;
            BtnSeleccionado(btnPlasticos);
            AbrirFormularioHijo(new FormPlasticos());
        }

        private void btnRuedas_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                BtnDeseleccionado(btnActual);           
            panelNav.Height = btnRuedas.Height;
            panelNav.Top = btnRuedas.Top;
            panelNav.Left = btnRuedas.Left;
            BtnSeleccionado(btnRuedas);
            AbrirFormularioHijo(new FormRuedas());
        }

        private void btnEscuadras_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                BtnDeseleccionado(btnActual);
            panelNav.Height = btnEscuadras.Height;
            panelNav.Top = btnEscuadras.Top;
            panelNav.Left = btnEscuadras.Left;
            BtnSeleccionado(btnEscuadras);
        }

        private void btnBisagras_Click(object sender, EventArgs e)
        {   
            if (btnActual != null)
                BtnDeseleccionado(btnActual);
            panelNav.Height = btnBisagras.Height;
            panelNav.Top = btnBisagras.Top;
            panelNav.Left = btnBisagras.Left;
            BtnSeleccionado(btnBisagras);
        }

        private void btnManijas_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                BtnDeseleccionado(btnActual);            
            panelNav.Height = btnManijas.Height;
            panelNav.Top = btnManijas.Top;
            panelNav.Left = btnManijas.Left;
            BtnSeleccionado(btnManijas);
        }

        private void btnCerraduras_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                BtnDeseleccionado(btnActual);
            panelNav.Height = btnCerraduras.Height;
            panelNav.Top = btnCerraduras.Top;
            panelNav.Left = btnCerraduras.Left;
            BtnSeleccionado(btnCerraduras);
        }

        private void btnCierres_Click(object sender, EventArgs e)
        {
            if (btnActual != null)
                BtnDeseleccionado(btnActual);
            panelNav.Height = btnCierres.Height;
            panelNav.Top = btnCierres.Top;
            panelNav.Left = btnCierres.Left;
            BtnSeleccionado(btnCierres);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            else
                return;  
            panelNav.Top = btnPlasticos.Top;
            panelNav.Left = btnPlasticos.Left;
            panelNav.Height = 259;
            BtnDeseleccionado(btnActual);
        }
    }
}
