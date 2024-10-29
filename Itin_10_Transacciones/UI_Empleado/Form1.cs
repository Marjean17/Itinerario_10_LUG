using BLL_Empleado;
using Entity;

namespace UI_Empleado
{
    public partial class Form1 : Form
    {
        List<Empleado_ui> listEmpleado = new List<Empleado_ui>();
        Empleado_bll empleado_Bll = new Empleado_bll();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado_ui empleado = new Empleado_ui();
                if (!long.TryParse(textBox1.Text, out long Dni)) throw new Exception("El DNI debe estar conformado por 11 dígitos");
                empleado.DNI = Dni;
                if (!double.TryParse(textBox3.Text, out double SueldoBruto)) throw new Exception("El sueldo debe estar expresado en números");
                empleado.SUELDOBRUTO = SueldoBruto;
                empleado.APELLIDONOMBRE = textBox2.Text;
                listEmpleado.Add(empleado);
                textBox1.Text = textBox2.Text = textBox3.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModd_Click(object sender, EventArgs e)
        {
            try
            {
                if (listEmpleado.Count < 1) throw new Exception("No hay cambios para confirmar");
                empleado_Bll.RegistrarListaEmpleados(listEmpleado);
                listEmpleado.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                listEmpleado.Clear();
                MessageBox.Show("lista correctamente borrada");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empleado_Bll.MostrarLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
