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

    public partial class frmProfesores : Form
    {
        Datos datos = new Datos();
        DataSet ds;

        public frmProfesores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProfesor profesor = new frmProfesor();
            profesor.Show();
        }

        private void frmProfesores_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Profesores");
                if (ds != null)
                {
                    dgvProfesores.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvProfesores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Matricula:{dgvProfesores.CurrentRow.Cells[0].Value}");
            frmProfesor profesor = new frmProfesor(Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value),
                                                dgvProfesores.CurrentRow.Cells[1].Value.ToString(),
                                                dgvProfesores.CurrentRow.Cells[2].Value.ToString(),
                                                dgvProfesores.CurrentRow.Cells[3].Value.ToString());
            profesor.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar El registro del Profesor : "
                + dgvProfesores.CurrentRow.Cells[1].Value.ToString() +
                  dgvProfesores.CurrentRow.Cells[2].Value.ToString() +
                  dgvProfesores.CurrentRow.Cells[3].Value.ToString(),
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                bool f = datos.ejecutarComando($"Delete from Profesores where Matricula=" +
                    $"{matricula}");
                if (f)
                {
                    MessageBox.Show("Registro Eliminado", "Sistemas");
                }
                else
                {
                    MessageBox.Show("Error", "Sistema");
                }
            }
        }
    }
}
