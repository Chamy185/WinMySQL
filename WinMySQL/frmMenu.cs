using WinMySQL.Views;

namespace WinMySQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias materias = new frmMaterias();
            materias.ShowDialog();
        }
    }
}
