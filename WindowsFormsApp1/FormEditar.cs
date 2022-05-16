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
    public partial class FormEditar : Form
    {
        List<Plastico> plasticos = new List<Plastico>();
        int indice = -1;

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plasticos;
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
        private List<string> ValidarDatos()
        {
            List<string> Errores = new List<string>();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Errores.Add("Debe ingresar codigo");
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                Errores.Add("Debe ingresar cantidad suelta");
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                Errores.Add("Debe ingresar cantidad bolsas");
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                Errores.Add("Debe ingresar descripcion");
            }

            return Errores;
        }
        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("plasticos.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(plasticos));
            }
        }
        public FormEditar()
        {
            InitializeComponent();
            panelEdicion.Visible = false;
            LeerArchivo();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            panelEdicion.SendToBack();
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
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
            
            Plastico p = new Plastico(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
            plasticos[indice] = p;

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar al menos un elemento");
            else
            {
                var plastico = plasticos[dataGridView1.SelectedRows[0].Index];

                textBox1.Text = plastico.Codigo;
                textBox2.Text = plastico.CantidadSuelta.ToString();
                textBox3.Text = plastico.CantidadBolsas.ToString();
                textBox4.Text = plastico.Descripcion;
                panelEdicion.Enabled = true;
                panelEdicion.Visible = true;
                panelEdicion.BringToFront();
            }

        }

        private void FormEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar al menos un elemento");
            }

            else if (MessageBox.Show("¿Seguro que quiere eliminar a este elemento?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                plasticos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ActualizarGrilla();
            }
        }
    }
}
