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

namespace WindowsFormsApp1.manijas
{
    public partial class FormEditarM : Form
    {
        List<Manija> manijas = new List<Manija>();
        int indice = -1;

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = manijas;
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
            using (StreamWriter streamWriter = new StreamWriter("manijas.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(manijas));
            }
        }
        public FormEditarM()
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
                var manija = manijas[dataGridView1.SelectedRows[0].Index];

                textBox1.Text = manija.Codigo;
                textBox2.Text = manija.Cantidad.ToString();
                textBox4.Text = manija.Descripcion;
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

            Manija m = new Manija(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
            manijas[indice] = m;

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
                manijas.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ActualizarGrilla();
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            panelEdicion.SendToBack();
            panelEdicion.Visible = false;
            panelEdicion.Enabled = false;
        }
    }
}
