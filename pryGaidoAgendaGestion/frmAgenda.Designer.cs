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
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(283, 132);
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
            lblContacto.Location = new Point(97, 36);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(101, 72);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Nùmero";
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(175, 74);
            mtbNumero.Mask = "(000)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(102, 23);
            mtbNumero.TabIndex = 3;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(202, 132);
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
            lblCantidadNumero.Location = new Point(0, 248);
            lblCantidadNumero.Name = "lblCantidadNumero";
            lblCantidadNumero.Size = new Size(107, 15);
            lblCantidadNumero.TabIndex = 9;
            lblCantidadNumero.Text = "cantidad y numero";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(175, 36);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 10;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 278);
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
    }
}
