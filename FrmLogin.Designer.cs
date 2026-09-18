namespace Ryvera_PDV
{
    partial class FrmLogin
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
            textSaudacao = new Label();
            btnEmail = new Button();
            textLogin = new Label();
            btnSenha = new Button();
            txtSenha = new Label();
            btnLogin = new Button();
            btnCriarConta = new Button();
            txtCopyringt = new Label();
            linktxtRyvera = new LinkLabel();
            SuspendLayout();
            // 
            // textSaudacao
            // 
            textSaudacao.AutoSize = true;
            textSaudacao.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSaudacao.Location = new Point(39, 96);
            textSaudacao.Name = "textSaudacao";
            textSaudacao.Size = new Size(160, 22);
            textSaudacao.TabIndex = 0;
            textSaudacao.Text = "Seja bem vindo!";
            textSaudacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEmail
            // 
            btnEmail.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmail.Location = new Point(39, 149);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(266, 35);
            btnEmail.TabIndex = 1;
            btnEmail.TabStop = false;
            btnEmail.Text = "Insira seu e-mail:";
            btnEmail.TextAlign = ContentAlignment.MiddleLeft;
            btnEmail.UseVisualStyleBackColor = true;
            // 
            // textLogin
            // 
            textLogin.AutoSize = true;
            textLogin.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLogin.Location = new Point(39, 132);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(147, 14);
            textLogin.TabIndex = 2;
            textLogin.Text = "Informe o seu e-mail";
            textLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSenha
            // 
            btnSenha.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSenha.Location = new Point(39, 215);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(266, 35);
            btnSenha.TabIndex = 3;
            btnSenha.TabStop = false;
            btnSenha.Text = "Insira sua senha:";
            btnSenha.TextAlign = ContentAlignment.MiddleLeft;
            btnSenha.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(39, 198);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(147, 14);
            txtSenha.TabIndex = 4;
            txtSenha.Text = "Informe o sua senha:";
            txtSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(39, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 35);
            btnLogin.TabIndex = 5;
            btnLogin.TabStop = false;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriarConta.Location = new Point(185, 267);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(120, 35);
            btnCriarConta.TabIndex = 6;
            btnCriarConta.TabStop = false;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            // 
            // txtCopyringt
            // 
            txtCopyringt.AutoSize = true;
            txtCopyringt.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCopyringt.Location = new Point(60, 324);
            txtCopyringt.Name = "txtCopyringt";
            txtCopyringt.Size = new Size(126, 14);
            txtCopyringt.TabIndex = 7;
            txtCopyringt.Text = "Desenvolvido pela";
            txtCopyringt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linktxtRyvera
            // 
            linktxtRyvera.AutoSize = true;
            linktxtRyvera.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linktxtRyvera.LinkColor = Color.DimGray;
            linktxtRyvera.Location = new Point(186, 324);
            linktxtRyvera.Name = "linktxtRyvera";
            linktxtRyvera.Size = new Size(84, 14);
            linktxtRyvera.TabIndex = 8;
            linktxtRyvera.TabStop = true;
            linktxtRyvera.Text = "Ryvera Code";
            linktxtRyvera.LinkClicked += linktxtRyvera_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(linktxtRyvera);
            Controls.Add(txtCopyringt);
            Controls.Add(btnCriarConta);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(btnSenha);
            Controls.Add(textLogin);
            Controls.Add(btnEmail);
            Controls.Add(textSaudacao);
            Name = "FrmLogin";
            Text = "Tela Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textSaudacao;
        private Button btnEmail;
        private Label textLogin;
        private Button btnSenha;
        private Label txtSenha;
        private Button btnLogin;
        private Button btnCriarConta;
        private Label txtCopyringt;
        private LinkLabel linktxtRyvera;
    }
}