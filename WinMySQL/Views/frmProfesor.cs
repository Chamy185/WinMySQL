using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace WinMySQL.Views
{
    public partial class frmProfesor : Form
    {
        int matricula = 0;
        bool uptading = false;
        Datos dt = new Datos();
        public frmProfesor()
        {
            InitializeComponent();
        }

        public frmProfesor(int matricula, String nombre, String appPaterno, String appMaterno)
        {
            InitializeComponent();
            this.matricula = matricula;
            txtNombre.Text = nombre;
            txtAppPaterno.Text = appPaterno;
            txtAppMaterno.Text = appMaterno;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int matricula = 0;
            if (uptading == false)
            {
                bool resultado = dt.ejecutarComando($"Insert into Profesores (Matricula,Nombre,App_Paterno,App_Materno) " +
                    $"values ({matricula = Convert.ToInt32(txtMatricula.Text)},'{txtNombre.Text}','{txtAppPaterno.Text}','{txtAppMaterno.Text}')");


                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Profesor");
                }

            }
            else
            {
                bool resultado = dt.ejecutarComando($"Update Profesores set Matricula='{matricula = Convert.ToInt32(txtMatricula.Text)}', Nombre='{txtNombre.Text}', App_Paterno='{txtAppPaterno.Text}', App_Materno='{txtAppMaterno.Text}' " +
                      $"where Matricula={matricula}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la información del Prfesor");
                }
            }




        }
    }
}
