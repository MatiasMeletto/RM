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
    public partial class FormPrincipal : Form
    {
        #region Metodos
        private void AbrirFormularioHijo(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(form);
            panelPrincipal.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void EsconderMenu()
        {
            btnAccesorios.SendToBack();
            btnPerfiles.SendToBack();
            logoMenu.SendToBack();
        }
        #endregion
        #region Form
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            AbrirFormularioHijo(new FormAccesoriosMenu());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion
    }
}
