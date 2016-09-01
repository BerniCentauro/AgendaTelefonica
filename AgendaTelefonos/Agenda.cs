using System;
using System.Windows.Forms;

namespace AgendaTelefonos
{
    public partial class Agenda : Form
    {
        // Atributos

        private AdminContactos adminContactos;

        /// <summary>
        /// Constructor
        /// </summary>
        public Agenda()
        {
            InitializeComponent();

            adminContactos = new AdminContactos();
            dgvContactos.DataSource = adminContactos.Tabla;
            tslFecha.Text = DateTime.Now.ToString("dd/mm/yyyy");
        }

        /// <summary>
        /// Limpiar formulario
        /// </summary>
        private void LimpiarForm()
        {
            tbxNombre.Text = "";
            tbxApellido.Text = "";
            tbxDireccion.Text = "";
            tbxCasa.Text = "";
            tbxTrabajo.Text = "";
        }

        /// <summary>
        /// Evento clic del botón agregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = tbxNombre.Text;
            contacto.Apellido = tbxApellido.Text;
            contacto.Direccion = tbxDireccion.Text;
            contacto.Casa = Convert.ToInt32(tbxCasa.Text);
            contacto.Trabajo = Convert.ToInt32(tbxTrabajo.Text);

            adminContactos.AgregarContacto(contacto);

            LimpiarForm();
            
            tslRegistros.Text = adminContactos.Registros + " registros";
        }

        /// <summary>
        /// Evento clic del menú abrir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mniAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Abrir";
            dialogo.Filter = "Archivo de texto|*.txt";
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); ;

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string filename = dialogo.FileName;

                adminContactos.Archivo = filename;
                adminContactos.CargarContactos();
            }

            tslRegistros.Text = adminContactos.Registros + " registros";
        }

        /// <summary>
        /// Evento clic del menú guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mniGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(adminContactos.Archivo))
            {
                SaveFileDialog dialogo = new SaveFileDialog();
                dialogo.Filter = "Archivo de texto|*.txt";
                dialogo.Title = "Guardar";
                dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); ;

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string filename = dialogo.FileName;

                    adminContactos.Archivo = filename;
                    adminContactos.GuardarContactos();

                    MessageBox.Show("Archivo guardado exitósamente", "Completado");
                }
            }
            else
            {
                adminContactos.GuardarContactos();

                MessageBox.Show("Archivo guardado exitósamente", "Completado");
            }
        }

        /// <summary>
        /// Evento clic del menú salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mniSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento clic del menú acerca de
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mniAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agenda por Berni Hidalgo. CopyLeft 2016", "Acerca de");
        }

        /// <summary>
        /// Evento clic del menú nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mniNuevo_Click(object sender, EventArgs e)
        {
            adminContactos = new AdminContactos();
            dgvContactos.DataSource = adminContactos.Tabla;
            tslRegistros.Text = "0 registros";
        }
    }
}
