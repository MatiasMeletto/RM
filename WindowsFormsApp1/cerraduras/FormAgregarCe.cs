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
    public partial class FormAgregarCe : Form
    {
        List<Cerradura> cerraduras = new List<Cerradura>();

        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("cerraduras.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(cerraduras));
            }
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
        private void Bloquear(bool i)
        {
            if (i)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
                btnAgregar.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox4.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }

        public FormAgregarCe()
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

            Cerradura c = new Cerradura(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
            cerraduras.Add(c);

            Bloquear(true);
        }

        private void FormAgregarCe_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirLista();
        }
    }
}
