using Guia2._1Ejercicio1.Models;
using System.Reflection;

namespace Guia2._1Ejercicio1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular depto = new DepartamentoVehicular();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormPersona formPersona = new FormPersona();

            if (formPersona.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(formPersona.tbDNI.Text);
                string nombre = (formPersona.tbNombre.Text);
                var propietario = new Persona(dni, nombre);

                depto.RegistrarVehiculo(propietario);

                ActualizarUltimoRegistro();
            }


        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
           
            lbListar.Items.Clear();
            
            foreach (var registro in depto.ObtenerRegistros())
            {
                lbListar.Items.Add(registro);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstRegistros_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarUltimoRegistro()
        {
            lbRegistro.Items.Clear();
            string ultimoRegistro = depto.ObtenerUltimoRegistro();
            if (ultimoRegistro != null)
            {
                string[] partes = ultimoRegistro.Split('*');
                foreach (var parte in partes)
                {
                    if (!string.IsNullOrWhiteSpace(parte))
                    {
                        lbRegistro.Items.Add($"*{parte}");
                    }
                }
            }
        }
    }
}

