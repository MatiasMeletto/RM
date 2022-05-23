using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ruedas;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1.ruedas
{
    public partial class FormEditarR : Form
    {
        List<Rueda> ruedas = new List<Rueda>();
        int indice = -1;

        private void ActualizarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ruedas;
        }
        private void LeerArchivo()
        {
            FileInfo fi = new FileInfo("ruedas.json");

            if (fi.Exists)
            {
                using (StreamReader sr = new StreamReader("ruedas.json"))
                {
                    ruedas = JsonConvert.DeserializeObject<List<Rueda>>(sr.ReadToEnd());
                }

                ActualizarGrilla();
            }
        }
        private List<string> ValidarDatos()
        {
            List<string> Errores = new List<string>();

            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                Errores.Add("Debe ingresar codigo");
            }

            if (string.IsNullOrEmpty(textBoxCantidadS.Text))
            {
                Errores.Add("Debe ingresar cantidad suelta");
            }
            else
            {
                bool resultado = int.TryParse(textBoxCantidadS.Text, out _);
                if (!resultado)
                {
                    Errores.Add("Debe ingresar un número en cantidad suelta");
                }
            }

            if (string.IsNullOrEmpty(textBoxCantidadB.Text))
            {
                Errores.Add("Debe ingresar cantidad de bolsas");
            }
            else
            {
                bool resultado = int.TryParse(textBoxCantidadB.Text, out _);
                if (!resultado)
                {
                    Errores.Add("Debe ingresar un número en cantidad bolsas");
                }
            }

            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                Errores.Add("Debe ingresar descripcion");
            }

            return Errores;
        }
        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("ruedas.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(ruedas));
            }
        }
        public FormEditarR()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel1.Enabled = false;
            panel1.SendToBack();
            LeerArchivo();
        }

        private void button2_Click(object sender, EventArgs e)
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

            Rueda r = new Rueda(textBoxCodigo.Text, int.Parse(textBoxCantidadS.Text), int.Parse(textBoxCantidadB.Text), textBoxDescripcion.Text);
            ruedas[indice] = r;

            panel1.SendToBack();
            panel1.Visible = false;
            panel1.Enabled = false;
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
                var rueda = ruedas[dataGridView1.SelectedRows[0].Index];

                textBoxCodigo.Text = rueda.Codigo;
                textBoxCantidadS.Text = rueda.CantidadSuelta.ToString();
                textBoxCantidadB.Text = rueda.CantidadBolsas.ToString();
                textBoxDescripcion.Text = rueda.Descripcion;
                panel1.Enabled = true;
                panel1.Visible = true;
                panel1.BringToFront();
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
                ruedas.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ActualizarGrilla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
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

                Rueda r = new Rueda(textBoxCodigo.Text, int.Parse(textBoxCantidadS.Text), int.Parse(textBoxCantidadB.Text), textBoxDescripcion.Text);
                ruedas[indice] = r;

                panel1.SendToBack();
                panel1.Visible = false;
                panel1.Enabled = false;
                ActualizarGrilla();
            }
        }

        private void textBoxCantidadS_KeyDown(object sender, KeyEventArgs e)
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

                Rueda r = new Rueda(textBoxCodigo.Text, int.Parse(textBoxCantidadS.Text), int.Parse(textBoxCantidadB.Text), textBoxDescripcion.Text);
                ruedas[indice] = r;

                panel1.SendToBack();
                panel1.Visible = false;
                panel1.Enabled = false;
                ActualizarGrilla();
            }
        }

        private void textBoxCantidadB_KeyDown(object sender, KeyEventArgs e)
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

                Rueda r = new Rueda(textBoxCodigo.Text, int.Parse(textBoxCantidadS.Text), int.Parse(textBoxCantidadB.Text), textBoxDescripcion.Text);
                ruedas[indice] = r;

                panel1.SendToBack();
                panel1.Visible = false;
                panel1.Enabled = false;
                ActualizarGrilla();
            }
        }

        private void textBoxDescripcion_KeyDown(object sender, KeyEventArgs e)
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

                Rueda r = new Rueda(textBoxCodigo.Text, int.Parse(textBoxCantidadS.Text), int.Parse(textBoxCantidadB.Text), textBoxDescripcion.Text);
                ruedas[indice] = r;

                panel1.SendToBack();
                panel1.Visible = false;
                panel1.Enabled = false;
                ActualizarGrilla();
            }
        }
    }
}
