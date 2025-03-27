namespace IngresantesIFTS29
{
    public partial class FormIFTS29 : Form
    {

        Ingresantes alumnosIngresantes = null;
        public FormIFTS29()
        {
            alumnosIngresantes = new Ingresantes();
            InitializeComponent();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtDocumento.ResetText();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Guardado Exitoso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
