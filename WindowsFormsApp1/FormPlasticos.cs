using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class FormPlasticos : Form
    {
        bool suelta = false;
        int indice = -1;
        List<Plastico> plasticos = new List<Plastico>();

        private void AbrirFormularioHijo(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        private void LeerArchivo()
        {
            FileInfo fi = new FileInfo("plasticos.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("plasticos.json"))
                {
                    plasticos = JsonConvert.DeserializeObject<List<Plastico>>(sr.ReadToEnd());
                }

                ActualizarGrilla();
            }
        }
        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("plasticos.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(plasticos));
            }
        }
        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plasticos;
        }
        public FormPlasticos()
        {
            InitializeComponent();
            panel1.Enabled = false;
            panel1.Visible = false;
            panel1.SendToBack();
            panelModificarCantidad.Visible = false;
            panelModificarCantidad.SendToBack();
            LeerArchivo();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void btnEditarlista_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void btnEditarCantidadS_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                suelta = true;
                panelModificarCantidad.Visible = true;
                panelModificarCantidad.BringToFront();
            }
            else
                MessageBox.Show("Debe seleccionar al menos un elemento");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelModificarCantidad.Visible = false;
            panelModificarCantidad.SendToBack();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (suelta)
                {
                    plasticos[indice].CantidadSuelta = int.Parse(textBox2.Text);
                    textBox2.Text = "";
                    indice = -1;
                    panelModificarCantidad.Visible = false;
                    panelModificarCantidad.SendToBack();
                    EscribirLista();
                    ActualizarGrilla();
                }
                else
                {
                    plasticos[indice].CantidadBolsas = int.Parse(textBox2.Text);
                    textBox2.Text = "";
                    indice = -1;
                    panelModificarCantidad.Visible = false;
                    panelModificarCantidad.SendToBack();
                    EscribirLista();
                    ActualizarGrilla();
                }
            }
        }
        private void FormPlasticos_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirLista();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            else
                indice = dataGridView1.SelectedRows[0].Index;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LeerArchivo();
        }

        private void btnEditarCantidadB_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                suelta = false;
                panelModificarCantidad.Visible = true;
                panelModificarCantidad.BringToFront();
            }
            else
                MessageBox.Show("Debe seleccionar al menos un elemento");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
            panel1.SendToBack();
            LeerArchivo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormAgregarP());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEditar());
        }
    }
}
