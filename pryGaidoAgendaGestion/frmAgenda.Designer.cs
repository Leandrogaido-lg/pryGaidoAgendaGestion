namespace pryGaidoAgendaGestion
{
    partial class frmAgenda
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
            btnRegistrar = new Button();
            lblContacto = new Label();
            lblNumero = new Label();
            mtbNumero = new MaskedTextBox();
            btnCancelar = new Button();
            lstResultado = new ListBox();
            lblFechaHora = new Label();
            lblCantidadNumero = new Label();
            txtContacto = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(268, 138);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F);
            lblContacto.Location = new Point(99, 61);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(99, 95);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Nùmero";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(177, 95);
            mtbNumero.Mask = "(351)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 23);
            mtbNumero.TabIndex = 3;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(187, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(12, 165);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(249, 79);
            lstResultado.TabIndex = 7;
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(222, 254);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(76, 15);
            lblFechaHora.TabIndex = 8;
            lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblCantidadNumero
            // 
            lblCantidadNumero.AutoSize = true;
            lblCantidadNumero.Location = new Point(-1, 254);
            lblCantidadNumero.Name = "lblCantidadNumero";
            lblCantidadNumero.Size = new Size(107, 15);
            lblCantidadNumero.TabIndex = 9;
            lblCantidadNumero.Text = "cantidad y numero";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(177, 61);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 10;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(88, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 30);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Gestion Agenda de Contacto";
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 278);
            Controls.Add(lblTitulo);
            Controls.Add(txtContacto);
            Controls.Add(lblCantidadNumero);
            Controls.Add(lblFechaHora);
            Controls.Add(lstResultado);
            Controls.Add(btnCancelar);
            Controls.Add(mtbNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Controls.Add(btnRegistrar);
            Name = "frmAgenda";
            Text = "Agenda de Gestion de Contacto";
            Load += frmAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label lblContacto;
        private Label lblNumero;
        private MaskedTextBox mtbNumero;
        private Button btnCancelar;
        private ListBox lstResultado;
        private Label lblFechaHora;
        private Label lblCantidadNumero;
        private TextBox txtContacto;
        private Label lblTitulo;
    }
}
