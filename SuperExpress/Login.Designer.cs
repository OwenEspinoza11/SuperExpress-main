namespace SuperExpress
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LblUsuario = new Label();
            LblContraseña = new Label();
            LblProgresB = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            PBInicio = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 34);
            label1.Name = "label1";
            label1.Size = new Size(236, 34);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SECCION";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblUsuario.Location = new Point(48, 104);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(67, 20);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblContraseña.Location = new Point(48, 178);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(92, 20);
            LblContraseña.TabIndex = 2;
            LblContraseña.Text = "Contraseña:";
            // 
            // LblProgresB
            // 
            LblProgresB.AutoSize = true;
            LblProgresB.Location = new Point(393, 299);
            LblProgresB.Name = "LblProgresB";
            LblProgresB.Size = new Size(13, 15);
            LblProgresB.TabIndex = 3;
            LblProgresB.Text = "0";
            LblProgresB.Visible = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(172, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.Size = new Size(153, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(172, 175);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(153, 23);
            txtContraseña.TabIndex = 5;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(89, 228);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 37);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(271, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // PBInicio
            // 
            PBInicio.Location = new Point(-3, 283);
            PBInicio.Name = "PBInicio";
            PBInicio.Size = new Size(390, 31);
            PBInicio.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(434, 326);
            Controls.Add(PBInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(LblProgresB);
            Controls.Add(LblContraseña);
            Controls.Add(LblUsuario);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblUsuario;
        private Label LblContraseña;
        private Label LblProgresB;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnCancelar;
        private ProgressBar PBInicio;
    }
}