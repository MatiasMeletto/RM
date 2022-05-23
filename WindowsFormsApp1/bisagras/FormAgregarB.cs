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
    public partial class FormAgregarB : Form
    {
        List<Bisagra> bisagras = new List<Bisagra>();

        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("bisagras.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(bisagras));
            }
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
        private void Bloquear(bool i)
        {
            if (i)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                btnAgregar.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }
        public FormAgregarB()
        {
            InitializeComponent();
            LeerArchivo();
            Bloquear(true);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Bloquear(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> Errores = ValidarDatos();
            if (Errores.Count != 0)
            {
                foreach (string E in Errores)
                    MessageBox.Show(E);
                return;
            }

            Bisagra esc = new Bisagra(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
            bisagras.Add(esc);

            Bloquear(true);
        }

        private void FormAgregarB_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirLista();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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

                Bisagra esc = new Bisagra(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
                bisagras.Add(esc);

                Bloquear(true);
            }
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

                Bisagra esc = new Bisagra(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
                bisagras.Add(esc);

                Bloquear(true);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
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

                Bisagra esc = new Bisagra(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
                bisagras.Add(esc);

                Bloquear(true);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
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

                Bisagra esc = new Bisagra(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
                bisagras.Add(esc);

                Bloquear(true);
            }
        }
    }
}
