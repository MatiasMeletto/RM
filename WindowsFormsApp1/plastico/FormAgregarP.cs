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
    public partial class FormAgregarP : Form
    {
        List<Plastico> plasticos = new List<Plastico>();

        private void EscribirLista()
        {
            using (StreamWriter streamWriter = new StreamWriter("plasticos.json"))
            {
                streamWriter.Write(JsonConvert.SerializeObject(plasticos));
            }
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
                if(!resultado)
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
                textBox3.Enabled= true;
                textBox4.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }
        public FormAgregarP()
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
            Bloquear(false);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
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

            Plastico p = new Plastico(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
            plasticos.Add(p);

            Bloquear(true);
        }

        private void FormAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirLista();
        }
    }
}
