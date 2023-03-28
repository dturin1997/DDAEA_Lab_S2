using System.Windows.Forms;

namespace manUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dni = textBox1.Text;
            string nombre = textBox2.Text;
            string apellido = textBox5.Text;
            string direccion = textBox3.Text;
            string telefono = textBox4.Text;
            string email = textBox6.Text;
            string fecha = dateTimePicker1.Text;

            dataGridView1.Rows.Add(dni, nombre, apellido, direccion, telefono, email, fecha);
        }
    }
}