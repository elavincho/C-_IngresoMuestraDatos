namespace PrimerProyecto
{
    partial class Form1
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
            lblApellido = new Label();
            lblDocumento = new Label();
            lblTipo = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(194, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(401, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INGRESO POSTULANTES";
            lblTitulo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(48, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(48, 208);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocumento.ForeColor = SystemColors.ControlLightLight;
            lblDocumento.Location = new Point(410, 278);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(114, 25);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.ControlLightLight;
            lblTipo.Location = new Point(80, 278);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(53, 25);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(159, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 33);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(159, 200);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(240, 33);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(530, 275);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(240, 33);
            txtDocumento.TabIndex = 2;
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(159, 270);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(240, 33);
            cboTipo.TabIndex = 3;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.HotTrack;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(159, 376);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(240, 35);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.HotTrack;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.Location = new Point(447, 376);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(240, 35);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = Properties.Resources.ifts29Logo;
            label1.Location = new Point(568, 83);
            label1.MaximumSize = new Size(150, 150);
            label1.MinimumSize = new Size(150, 150);
            label1.Name = "label1";
            label1.Size = new Size(150, 150);
            label1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(btnLimpiar);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIMER PROYECTO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblTipo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Button btnLimpiar;
        private Button btnIngresar;
        private Label label1;
    }
}
