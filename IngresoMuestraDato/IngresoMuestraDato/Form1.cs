namespace IngresoMuestraDato
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en los TextBox
            string dato1 = txtDato1.Text;
            string dato2 = txtDato2.Text;

            // Mostrar los datos en un MessageBox
            MessageBox.Show($"Dato 1: {dato1}\nDato 2: {dato2}", "MUESTRA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Reseteamos los valores
            txtDato1.ResetText();
            txtDato2.ResetText();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            // Reseteamos los valores
            txtDato3.ResetText();
            txtDato4.ResetText();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            // Creamos las variables
            string dato1;
            string dato2;

            //Solicitamos el ingreso de datos a traves de un cuadro de dialogo
            dato1 = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el Dato 3", "Dato 3", "");

            dato2 = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el Dato 4", "Dato 4", "");

            // Mostramos los datos ingresados en el textBox
            txtDato3.Text = $"{dato1}";
            txtDato4.Text = $"{dato2}";
        }

        private void btnIngresar2_Click(object sender, EventArgs e)
        {
            // Creamos las variables
            string dato5;
            string dato6;

            //Solicitamos el ingreso de datos a traves de un cuadro de dialogo
            dato5 = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el Dato 5", "Dato 5", "");

            dato6 = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el Dato 6", "Dato 6", "");

            // Mostramos los datos ingresados en el textBox
            txtDato5.Text = $"{dato5}";
            txtDato6.Text = $"{dato6}";
        }

        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            // Reseteamos los valores
            txtDato5.ResetText();
            txtDato6.ResetText();
            txtNroMayor.ResetText();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            if (txtDato5.Text == "" || txtDato6.Text == "")
            {
                txtDato5.Text = "0";
                txtDato6.Text = "0";
            }

            int dato5 = int.Parse(txtDato5.Text);
            int dato6 = int.Parse(txtDato6.Text);

            if (dato5 > dato6)
            {
                txtNroMayor.Text = txtDato5.Text;
            }
            else if (dato5 < dato6)
            {
                txtNroMayor.Text = txtDato6.Text;
            }
            else
            {
                txtNroMayor.Text = "Iguales";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que quieres cerrar la aplicación?",
                "Confirmar Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario confirma, cerrar la aplicación
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
