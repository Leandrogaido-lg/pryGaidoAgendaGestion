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
            lstContacto = new ComboBox();
            lstResultado = new ListBox();
            label1 = new Label();
            label2 = new Label();
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
            mtbNumero.PasswordChar = '#';
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
            // 
            // lstContacto
            // 
            lstContacto.FormattingEnabled = true;
            lstContacto.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            lstContacto.Location = new Point(175, 38);
            lstContacto.Name = "lstContacto";
            lstContacto.Size = new Size(102, 23);
            lstContacto.TabIndex = 6;
            lstContacto.TextChanged += lstContacto_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(12, 158);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(184, 64);
            lstResultado.TabIndex = 7;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 248);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha y Hora";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 248);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 9;
            label2.Text = "cantidad y numero";
            
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 272);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstResultado);
            Controls.Add(lstContacto);
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
        private ComboBox lstContacto;
        private ListBox lstResultado;
        private Label label1;
        private Label label2;
    }
}
