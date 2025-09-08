namespace pryGaidoAgendaGestion
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vNumero = "";
        private void lstContacto_TextChanged(object sender, EventArgs e)
        {
            if (lstContacto.Text != "")
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = lstContacto.Text;
            vNumero = mtbNumero.Text;

            lstContacto.Items.Add("xx");
        }

        
        

        
    }
}
