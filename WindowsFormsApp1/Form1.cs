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
    public partial class formMenu : Form
    {
        private Form formularioActivo = null;
        private void abrirFormularioHijo(Form form)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelAccesorios.Controls.Add(form);
            panelAccesorios.Tag = form;
            panelAccesorios.BringToFront();
            form.Show();
        }
        private void ComienzoPaneles()
        {
            //setea los paneles al iniciar el programa
            panelAccesorios.Visible = false;
            panelPerfiles.Visible = false;
        }
        private void EsconderPaneles()
        {
            if (panelAccesorios.Visible)
                panelAccesorios.Visible = false;
            if (panelPerfiles.Visible)
                panelPerfiles.Visible = false;
        }
        private void MostrarPanel(Panel panel)
        {
            if (!panel.Visible)
            {
                EsconderPaneles();
                panel.Visible = true;
            }
            else 
                panel.Visible = false;
        }
        public formMenu()
        {
            InitializeComponent();
            Bitmap imgFondo = new Bitmap(Application.StartupPath + @"\img\Sin título.jpg");
            this.BackgroundImage = imgFondo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            ComienzoPaneles();
            panelAccesorios.SendToBack();
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelAccesorios );
            abrirFormularioHijo(new FormAccesorios());
        }
    }
}
