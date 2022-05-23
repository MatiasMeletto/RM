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

namespace WindowsFormsApp1.cerraduras
{
    public partial class FormEditarCe : Form
    {
        List<Cerradura> cerraduras = new List<Cerradura>();
        int indice = -1;

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cerraduras;
        }
        private void LeerArchivo()
        {
            FileInfo fi = new FileInfo("cerraduras.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("cerraduras.json"))
                {
                    cerraduras = JsonConvert.DeserializeObject<List<Cerradura>>(sr.ReadToEnd());
                }

                ActualizarGrilla();
            }
        }
        private List<string> ValidarDatos()
        {
            List<string> Errores = new List<string>();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Errores.Add("Debe ingresar codigo");
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                Errores.Add("Debe ingresar cantidad");
            }
            else
            {
                bool resultado = int.TryParse(textBox2.Text, out _);
                if (!resultado)
                {
                    Errores.Add("Debe ingresar un número en cantidad");
                }
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                Errores.Add("Debe ingresar descripcion");
            }

            return Errores;
        }
        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("cerraduras.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(cerraduras));
            }
        }
        public FormEditarCe()
        {
            InitializeComponent();
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            panelEdicion.SendToBack();
            LeerArchivo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar al menos un elemento");
            else
            {
                var cerradura = cerraduras[dataGridView1.SelectedRows[0].Index];

                textBox1.Text = cerradura.Codigo;
                textBox2.Text = cerradura.Cantidad.ToString();
                textBox4.Text = cerradura.Descripcion;
                panelEdicion.Enabled = true;
                panelEdicion.Visible = true;
                panelEdicion.BringToFront();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            EscribirLista();
            this.Close();
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            List<string> Errores = ValidarDatos();

            if (Errores.Count() != 0)
            {
                foreach (string E in Errores)
                {
                    MessageBox.Show(E);
                }
                return;
            }

            Cerradura c = new Cerradura(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
            cerraduras[indice] = c;

            panelEdicion.SendToBack();
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            ActualizarGrilla();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                return;
            else
                indice = dataGridView1.SelectedRows[0].Index;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar al menos un elemento");
            }

            else if (MessageBox.Show("¿Seguro que quiere eliminar a este elemento?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cerraduras.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ActualizarGrilla();
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            panelEdicion.SendToBack();
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> Errores = ValidarDatos();

                if (Errores.Count() != 0)
                {
                    foreach (string E in Errores)
                    {
                        MessageBox.Show(E);
                    }
                    return;
                }

                Cerradura c = new Cerradura(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
                cerraduras[indice] = c;

                panelEdicion.SendToBack();
                panelEdicion.Visible = false;
                panelEdicion.Enabled = false;
                ActualizarGrilla();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> Errores = ValidarDatos();

                if (Errores.Count() != 0)
                {
                    foreach (string E in Errores)
                    {
                        MessageBox.Show(E);
                    }
                    return;
                }

                Cerradura c = new Cerradura(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
                cerraduras[indice] = c;

                panelEdicion.SendToBack();
                panelEdicion.Visible = false;
                panelEdicion.Enabled = false;
                ActualizarGrilla();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> Errores = ValidarDatos();

                if (Errores.Count() != 0)
                {
                    foreach (string E in Errores)
                    {
                        MessageBox.Show(E);
                    }
                    return;
                }

                Cerradura c = new Cerradura(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
                cerraduras[indice] = c;

                panelEdicion.SendToBack();
                panelEdicion.Visible = false;
                panelEdicion.Enabled = false;
                ActualizarGrilla();
            }
        }
    }
}
