namespace IngresantesIFTS29
{
    partial class FormIFTS29
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblLogo = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(242, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(339, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingresantes IFTS N° 29";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(61, 144);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 37);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(242, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 33);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(61, 213);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(123, 37);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(242, 213);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(316, 33);
            txtApellido.TabIndex = 2;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocumento.ForeColor = SystemColors.ControlLightLight;
            lblDocumento.Location = new Point(61, 265);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(162, 37);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento:";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(242, 272);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(316, 33);
            txtDocumento.TabIndex = 2;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Image = Properties.Resources.ifts29Logo;
            lblLogo.Location = new Point(607, 151);
            lblLogo.MaximumSize = new Size(150, 150);
            lblLogo.MinimumSize = new Size(150, 150);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(150, 150);
            lblLogo.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.HotTrack;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(242, 368);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 41);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(416, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 41);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormIFTS29
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblLogo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FormIFTS29";
            Text = "Ingresantes IFTS N° 29";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblLogo;
        private Button btnLimpiar;
        private Button btnGuardar;
    }
}
