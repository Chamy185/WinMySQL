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
    public partial class frmMaterias : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            frmMateria Materia = new frmMateria();
            Materia.ShowDialog();
        }

        private void frmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"ID:{ dgvMaterias.CurrentRow.Cells[0].Value}");
            frmMateria materia = new frmMateria(Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
                                                dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                                                dgvMaterias.CurrentRow.Cells[2].Value.ToString());
            materia.ShowDialog();

        }
    }
}
