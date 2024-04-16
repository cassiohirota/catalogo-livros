namespace CatalogLivros {
    partial class FrmLogin {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.FrmLogin_Btn_Login = new System.Windows.Forms.Button();
            this.FrmLogin_Btn_Sair = new System.Windows.Forms.Button();
            this.FrmLogin_Lbl_Login = new System.Windows.Forms.Label();
            this.FrmLogin_Txt_Login = new System.Windows.Forms.TextBox();
            this.FrmLogin_Txt_Senha = new System.Windows.Forms.TextBox();
            this.FrmLogin_Lbl_Senha = new System.Windows.Forms.Label();
            this.FrmLogin_Lbl_CatalogoLivros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FrmLogin_Btn_Login
            // 
            this.FrmLogin_Btn_Login.Location = new System.Drawing.Point(397, 307);
            this.FrmLogin_Btn_Login.Name = "FrmLogin_Btn_Login";
            this.FrmLogin_Btn_Login.Size = new System.Drawing.Size(103, 35);
            this.FrmLogin_Btn_Login.TabIndex = 0;
            this.FrmLogin_Btn_Login.Text = "Login";
            this.FrmLogin_Btn_Login.UseVisualStyleBackColor = true;
            // 
            // FrmLogin_Btn_Sair
            // 
            this.FrmLogin_Btn_Sair.Location = new System.Drawing.Point(278, 307);
            this.FrmLogin_Btn_Sair.Name = "FrmLogin_Btn_Sair";
            this.FrmLogin_Btn_Sair.Size = new System.Drawing.Size(103, 35);
            this.FrmLogin_Btn_Sair.TabIndex = 1;
            this.FrmLogin_Btn_Sair.Text = "Sair";
            this.FrmLogin_Btn_Sair.UseVisualStyleBackColor = true;
            this.FrmLogin_Btn_Sair.Click += new System.EventHandler(this.FrmLogin_Btn_Sair_Click);
            // 
            // FrmLogin_Lbl_Login
            // 
            this.FrmLogin_Lbl_Login.AutoSize = true;
            this.FrmLogin_Lbl_Login.Location = new System.Drawing.Point(292, 182);
            this.FrmLogin_Lbl_Login.Name = "FrmLogin_Lbl_Login";
            this.FrmLogin_Lbl_Login.Size = new System.Drawing.Size(43, 16);
            this.FrmLogin_Lbl_Login.TabIndex = 2;
            this.FrmLogin_Lbl_Login.Text = "Login:";
            // 
            // FrmLogin_Txt_Login
            // 
            this.FrmLogin_Txt_Login.Location = new System.Drawing.Point(295, 201);
            this.FrmLogin_Txt_Login.Name = "FrmLogin_Txt_Login";
            this.FrmLogin_Txt_Login.Size = new System.Drawing.Size(193, 22);
            this.FrmLogin_Txt_Login.TabIndex = 3;
            // 
            // FrmLogin_Txt_Senha
            // 
            this.FrmLogin_Txt_Senha.Location = new System.Drawing.Point(295, 252);
            this.FrmLogin_Txt_Senha.Name = "FrmLogin_Txt_Senha";
            this.FrmLogin_Txt_Senha.Size = new System.Drawing.Size(193, 22);
            this.FrmLogin_Txt_Senha.TabIndex = 5;
            this.FrmLogin_Txt_Senha.UseSystemPasswordChar = true;
            // 
            // FrmLogin_Lbl_Senha
            // 
            this.FrmLogin_Lbl_Senha.AutoSize = true;
            this.FrmLogin_Lbl_Senha.Location = new System.Drawing.Point(292, 233);
            this.FrmLogin_Lbl_Senha.Name = "FrmLogin_Lbl_Senha";
            this.FrmLogin_Lbl_Senha.Size = new System.Drawing.Size(49, 16);
            this.FrmLogin_Lbl_Senha.TabIndex = 4;
            this.FrmLogin_Lbl_Senha.Text = "Senha:";
            // 
            // FrmLogin_Lbl_CatalogoLivros
            // 
            this.FrmLogin_Lbl_CatalogoLivros.AutoSize = true;
            this.FrmLogin_Lbl_CatalogoLivros.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmLogin_Lbl_CatalogoLivros.Location = new System.Drawing.Point(162, 88);
            this.FrmLogin_Lbl_CatalogoLivros.Name = "FrmLogin_Lbl_CatalogoLivros";
            this.FrmLogin_Lbl_CatalogoLivros.Size = new System.Drawing.Size(485, 56);
            this.FrmLogin_Lbl_CatalogoLivros.TabIndex = 6;
            this.FrmLogin_Lbl_CatalogoLivros.Text = "Catálogo de Livros";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FrmLogin_Lbl_CatalogoLivros);
            this.Controls.Add(this.FrmLogin_Txt_Senha);
            this.Controls.Add(this.FrmLogin_Lbl_Senha);
            this.Controls.Add(this.FrmLogin_Txt_Login);
            this.Controls.Add(this.FrmLogin_Lbl_Login);
            this.Controls.Add(this.FrmLogin_Btn_Sair);
            this.Controls.Add(this.FrmLogin_Btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FrmLogin_Btn_Login;
        private System.Windows.Forms.Button FrmLogin_Btn_Sair;
        private System.Windows.Forms.Label FrmLogin_Lbl_Login;
        private System.Windows.Forms.TextBox FrmLogin_Txt_Login;
        private System.Windows.Forms.TextBox FrmLogin_Txt_Senha;
        private System.Windows.Forms.Label FrmLogin_Lbl_Senha;
        private System.Windows.Forms.Label FrmLogin_Lbl_CatalogoLivros;
    }
}

