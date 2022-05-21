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

namespace WindowsFormsApp1.bisagras
{
    public partial class FormBisagras : Form
    {
        bool suelta = false;
        int indice = -1;
        List<Bisagra> bisagras = new List<Bisagra>();

        private void AbrirFormularioHijo(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        private List<string> ValidarDatos()
        {
            List<string> Errores = new List<string>();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                Errores.Add("Debe ingresar una cantidad");
            }
            else
            {
                bool resultado = int.TryParse(textBox2.Text, out _);
                if (!resultado)
                {
                    Errores.Add("Debe ingresar un número en la cantidad");
                }
            }
            return Errores;
        }
        private void LeerArchivo()
        {
            FileInfo fi = new FileInfo("bisagras.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("bisagras.json"))
                {
                    bisagras = JsonConvert.DeserializeObject<List<Bisagra>>(sr.ReadToEnd());
                }

                ActualizarGrilla();
            }
        }
        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("bisagras.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(bisagras));
            }
        }
        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bisagras;
        }
        public FormBisagras()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel1.Enabled = false;
            panel1.SendToBack();
            panelModificarCantidad.Visible = false;
            panelModificarCantidad.Enabled = false;
            panelModificarCantidad.SendToBack();
            LeerArchivo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel1.SendToBack();
            LeerArchivo();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnEditarLista_Click(object sender, EventArgs e)
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
                panelModificarCantidad.Enabled = true;
                panelModificarCantidad.BringToFront();
            }
            else
                MessageBox.Show("Debe seleccionar al menos un elemento");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> Errores = ValidarDatos();
                if (Errores.Count != 0)
                {
                    foreach (string E in Errores)
                        MessageBox.Show(E);
                    return;
                }

                if (suelta)
                {
                    bisagras[indice].CantidadSuelta = int.Parse(textBox2.Text);
                    textBox2.Text = "";
                    indice = -1;
                    panelModificarCantidad.Visible = false;
                    panelModificarCantidad.SendToBack();
                    EscribirLista();
                    ActualizarGrilla();
                }
                else
                {
                    bisagras[indice].CantidadBolsas = int.Parse(textBox2.Text);
                    textBox2.Text = "";
                    indice = -1;
                    panelModificarCantidad.Visible = false;
                    panelModificarCantidad.SendToBack();
                    EscribirLista();
                    ActualizarGrilla();
                }
            }
        }

        private void btnEditarCantidadB_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                suelta = false;
                panelModificarCantidad.Visible = true;
                panelModificarCantidad.Enabled = true;
                panelModificarCantidad.BringToFront();
            }
            else
                MessageBox.Show("Debe seleccionar al menos un elemento");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            else
                indice = dataGridView1.SelectedRows[0].Index;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormAgregarB());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEditarB());
        }
    }
}
