namespace PrimerProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Agregamos los valores al combo box
            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Extranjero");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Reseteamos todos los valores
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtDocumento.ResetText();
            cboTipo.ResetText();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string name = txtNombre.Text;
            string lastName = txtApellido.Text;
            string tipe = cboTipo.Text;
            int document = Convert.ToInt32(txtDocumento.Text);

            /* INSTANCIAMOS UN OBJETO DE LA CLASE Postulante */

            Postulante nuevoPostulante = new Postulante(name, lastName, tipe, document);


            /* mostramos en cuadro de dialogo la carga de la clase */

            MessageBox.Show("NOMBRE DEL POSTULANTE:  " + nuevoPostulante.Nombre + "  " +
            nuevoPostulante.Apellido + "  DOCUMENTO: " + nuevoPostulante.Tipo + "  " + nuevoPostulante.Documento,
                                "INGRESO DEL POSTULANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
