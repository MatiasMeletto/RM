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

        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form form)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = form;
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
        public FormPrincipal()
        {
            InitializeComponent();
            Bitmap imgFondo = new Bitmap(Application.StartupPath + @"\img\Sin título.jpg");
            panelPrincipal.BackgroundImage = imgFondo;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            AbrirFormularioHijo(new FormAccesorios());
        }
    }
}
