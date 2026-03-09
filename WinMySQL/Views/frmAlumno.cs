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
    public partial class frmAlumno : Form
    {
        int noControl = 0;
        int semestre = 0;
        bool uptading = false;
        Datos dt = new Datos();

        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int noControl, String nombre, String appPaterno, String appMaterno, int semestre)
        {
            InitializeComponent();
            this.noControl = noControl;
            txtNombre.Text = nombre;
            txtApellidoPaterno.Text = appPaterno;
            txtApellidoMaterno.Text = appMaterno;
            this.semestre = semestre;   

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int sem = 0;
            int numC = 0;
            if (uptading == false)
            {
                bool resultado = dt.ejecutarComando($"Insert into Alumnos (NoControl,Nombre,App_Paterno,App_Materno,Semestre) " +
                    $"values ({numC=Convert.ToInt32(txtNoControl.Text)},'{txtNombre.Text}','{txtApellidoPaterno.Text}','{txtApellidoMaterno.Text}',{sem=Convert.ToInt32(txtSemestre.Text)})");
                

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Alumno");
                }

            }
            else
            {
                bool resultado = dt.ejecutarComando($"Update Alumnos set NoControl='{numC = Convert.ToInt32(txtNoControl.Text)}', Nombre='{txtNombre.Text}', App_Paterno='{txtApellidoPaterno.Text}', App_Materno='{txtApellidoMaterno.Text}', Semestre={sem = Convert.ToInt32(txtSemestre.Text)} " +
                      $"where NoControl={noControl}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la información del alumno");
                }
            }
        }
    }
}
