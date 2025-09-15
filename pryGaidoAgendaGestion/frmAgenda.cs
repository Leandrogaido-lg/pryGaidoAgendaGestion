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
        int vContador = 0;
        DateTime vFecha = DateTime.Now;
        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
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
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstResultado.Items.Add("Contacto:" + vContacto + "Numero:" + vNumero);
            txtContacto.Text = "";
            mtbNumero.Text = "";
            vContador = vContador + 1;
            lblCantidadNumero.Text = "Cantidad de contactos registrados:" + vContador;
            lblFechaHora.Text = "Fecha y hora de registro:" + vFecha;

        }
        private void LimpiarControles()
        {
            txtContacto.Clear();
            mtbNumero.Clear();
            txtContacto.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            LimpiarControles();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
    }
}
