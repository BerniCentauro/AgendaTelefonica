using System;
using System.Data;
using System.IO;

namespace AgendaTelefonos
{
    class AdminContactos
    {
        // Atributos

        private DataTable tabla;
        private string archivo;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public AdminContactos()
        {
            tabla = new DataTable();

            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Casa");
            tabla.Columns.Add("Trabajo");

        }

        /// <summary>
        /// Propiedad tabla
        /// </summary>
        public DataTable Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }

        /// <summary>
        /// Propiedad archivo
        /// </summary>
        public String Archivo
        {
            get { return archivo; }
            set { archivo = value; }
        }

        /// <summary>
        /// Propiedad registros
        /// </summary>
        public int Registros
        {
            get { return tabla.Rows.Count; }
            private set { }
        }

        /// <summary>
        /// Agregar un contacto a la tabla
        /// </summary>
        /// <param name="contacto">Contacto a agregar</param>
        public void AgregarContacto(Contacto contacto)
        {
            if (tabla != null)
            {
                DataRow dr = tabla.NewRow();
                dr["Nombre"] = contacto.Nombre;
                dr["Apellidos"] = contacto.Apellido;
                dr["Direccion"] = contacto.Direccion;
                dr["Casa"] = contacto.Casa;
                dr["Trabajo"] = contacto.Trabajo;

                tabla.Rows.Add(dr);
            }
        }

        public void EliminarContacto()
        {

        }

        /// <summary>
        /// Guardar los contactos en el archivo
        /// </summary>
        public void GuardarContactos()
        {
            StreamWriter agenda = new StreamWriter(archivo);

            foreach (DataRow dr in tabla.Rows)
            {
                string linea = dr["Nombre"] + "," + dr["Apellidos"] + "," + dr["Direccion"] + "," + dr["Casa"] + "," + dr["Trabajo"];
                agenda.WriteLine(linea);
            }

            agenda.Close();
        }

        /// <summary>
        /// Cargar lista de contactos desde un archivos
        /// </summary>
        /// <returns>Devuelve una lista de contactos</returns>
        public void CargarContactos()
        {
            TextReader lector = new StreamReader(archivo);

            tabla.Clear();

            string linea = null;

            do
            {
                linea = lector.ReadLine();

                if (linea != null)
                {
                    string[] array = linea.Split(',');

                    Contacto contacto = new Contacto();
                    contacto.Nombre = array[0];
                    contacto.Apellido = array[1];
                    contacto.Direccion = array[2];
                    contacto.Casa = Convert.ToInt32(array[3]);
                    contacto.Trabajo = Convert.ToInt32(array[4]);

                    AgregarContacto(contacto);
                }

            } while (linea != null);

            lector.Close();
        }
    }
}
