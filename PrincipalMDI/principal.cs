using manUsuario;
namespace PrincipalMDI
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}