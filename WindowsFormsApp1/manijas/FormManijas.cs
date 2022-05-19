using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.manijas;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1.manijas
{
    public partial class FormManijas : Form
    {
        int indice = -1;
        List<Manija> manijas = new List<Manija>();

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
            FileInfo fi = new FileInfo("manijas.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("manijas.json"))
                {
                    manijas = JsonConvert.DeserializeObject<List<Manija>>(sr.ReadToEnd());
                }

                ActualizarGrilla();
            }
        }
        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("manijas.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(manijas));
            }
        }
        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = manijas;
        }
        public FormManijas()
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

                    manijas[indice].Cantidad = int.Parse(textBox2.Text);
                    textBox2.Text = "";
                    indice = -1;
                    panelModificarCantidad.Visible = false;
                    panelModificarCantidad.SendToBack();
                    EscribirLista();
                    ActualizarGrilla();
                
            }
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
            AbrirFormularioHijo(new FormAgregarM());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormEditarM());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel1.SendToBack();
            LeerArchivo();
        }
    }
}
