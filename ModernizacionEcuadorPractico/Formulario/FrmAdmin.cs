using ModernizacionEcuadorPractico.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernizacionEcuadorPractico.Formulario
{
    public partial class FrmAdmin : Form
    {
        private NominaController _controlador;
        public FrmAdmin()
        {
            InitializeComponent();
            _controlador = new NominaController();
        }

        private void ActualizarTabla()
        {
            // Refrescamos el DataGridView con la lista actualizada del controlador
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _controlador.ObtenerTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los datos de las cajas de texto (TextBox)
                string nombre = textBox1.Text;
                decimal salario = Convert.ToDecimal(textBox2.Text);
                int horas = Convert.ToInt32(textBox3.Text);

                // Enviamos los datos al controlador
                _controlador.RegistrarEmpleado(nombre, salario, horas);

                // Actualizamos la tabla
                ActualizarTabla();

                // Limpiamos las cajas
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                MessageBox.Show("Empleado registrado en la nómina con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos. Verifica que sean números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
