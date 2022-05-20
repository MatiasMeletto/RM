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

namespace WindowsFormsApp1.escuadras
{
    public partial class FormEditarE : Form
    {
        List<Escuadra> escuadras = new List<Escuadra>();
        int indice = -1;

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = escuadras;
        }
        private void LeerArchivo()
        {
            FileInfo fi = new FileInfo("escuadras.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("escuadras.json"))
                {
                    escuadras = JsonConvert.DeserializeObject<List<Escuadra>>(sr.ReadToEnd());
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
            else
            {
                bool resultado = int.TryParse(textBox2.Text, out _);
                if (!resultado)
                {
                    Errores.Add("Debe ingresar un número en cantidad suelta");
                }
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                Errores.Add("Debe ingresar cantidad de bolsas");
            }
            else
            {
                bool resultado = int.TryParse(textBox3.Text, out _);
                if (!resultado)
                {
                    Errores.Add("Debe ingresar un número en cantidad bolsas");
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
            using (StreamWriter streamWriter = new StreamWriter("escuadras.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(escuadras));
            }
        }
        public FormEditarE()
        {
            InitializeComponent();
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            panelEdicion.SendToBack();
            LeerArchivo();
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

            Escuadra esc = new Escuadra(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
            escuadras[indice] = esc;

            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            panelEdicion.SendToBack();
            ActualizarGrilla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            EscribirLista();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Debe seleccionar al menos un elemento");
            else
            {
                var escuadra = escuadras[dataGridView1.SelectedRows[0].Index];

                textBox1.Text = escuadra.Codigo;
                textBox2.Text = escuadra.CantidadSuelta.ToString();
                textBox3.Text = escuadra.CantidadBolsas.ToString();
                textBox4.Text = escuadra.Descripcion;
                panelEdicion.Enabled = true;
                panelEdicion.Visible = true;
                panelEdicion.BringToFront();
            }
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
                escuadras.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ActualizarGrilla();
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
            panelEdicion.SendToBack();
        }
    }
}
