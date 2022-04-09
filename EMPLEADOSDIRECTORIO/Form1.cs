using EMPLEADOSDIRECTORIO.DATOS;
using EMPLEADOSDIRECTORIO.MODELOS;
using System.Data;

namespace EMPLEADOSDIRECTORIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLHORITA.Text = DateTime.Now.ToString("hh:mm:ss");
            llenarGrid();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LBLDNI_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void LBLHORA_Click(object sender, EventArgs e)
        {

        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (TXTDNI.Text.Trim() == "")
            {
                MessageBox.Show("Insertar Dni válido");
            }
            else if (TXTNOMBRES.Text.Trim().Length < 5)
                MessageBox.Show("Ingresar nombre completo");
            else
            {
                try
                {
                    Empleado ex = new Empleado();
                    ex.Apellidos = TXTAPELLIDOS.Text.Trim().ToUpper();
                    ex.Nombres = TXTNOMBRES.Text.Trim().ToUpper();
                    ex.Documentos = TXTDNI.Text.Trim().ToUpper();
                    ex.Fecha = TXTFECHA.Value.Year + "-" + TXTFECHA.Value.Month + "-" + TXTFECHA.Value.Day;
                    if (EmpleadoCAD.guardar(ex))
                    {
                        llenarGrid();
                        MessageBox.Show("Guardado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Existe otro empleado con el mismo DNI");
                    }
                }
                catch (Exception em)
                {
                    MessageBox.Show(em.Message);

                }

                }
            }
        private void llenarGrid()
        {
            DataTable datos = EmpleadoCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                DTGLISTAR.DataSource = datos.DefaultView;
            }
        }

        private void DTGLISTAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    } 