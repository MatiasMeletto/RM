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
    public partial class FormAgregarM : Form
    {
        List<Manija> manijas = new List<Manija>();

        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("manijas.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(manijas));
            }
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
        public FormAgregarM()
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

            Manija m = new Manija(textBox1.Text, int.Parse(textBox2.Text), textBox4.Text);
            manijas.Add(m);

            Bloquear(true);
        }

        private void FormAgregarM_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirLista();
        }
    }
}
