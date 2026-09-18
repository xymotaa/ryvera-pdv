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
            TextSaudacao = new Label();
            TextSenha = new Label();
            BtnLogin = new Button();
            BtnCriarConta = new Button();
            txtCopyringt = new Label();
            linktxtRyvera = new LinkLabel();
            ImgLogin = new PictureBox();
            PanImgLogin = new Panel();
            TextBoxSenha = new TextBox();
            TextBoxEmail = new TextBox();
            TexEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)ImgLogin).BeginInit();
            PanImgLogin.SuspendLayout();
            SuspendLayout();
            // 
            // TextSaudacao
            // 
            TextSaudacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TextSaudacao.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextSaudacao.Location = new Point(56, 100);
            TextSaudacao.Name = "TextSaudacao";
            TextSaudacao.Size = new Size(261, 22);
            TextSaudacao.TabIndex = 0;
            TextSaudacao.Text = "Seja bem vindo!";
            TextSaudacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextSenha
            // 
            TextSenha.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextSenha.Location = new Point(56, 204);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(147, 38);
            TextSenha.TabIndex = 4;
            TextSenha.Text = "Informe o sua senha:";
            TextSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = SystemColors.AppWorkspace;
            BtnLogin.Location = new Point(56, 296);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(120, 35);
            BtnLogin.TabIndex = 6;
            BtnLogin.TabStop = false;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnCriarConta
            // 
            BtnCriarConta.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCriarConta.ForeColor = SystemColors.AppWorkspace;
            BtnCriarConta.Location = new Point(197, 296);
            BtnCriarConta.Name = "BtnCriarConta";
            BtnCriarConta.Size = new Size(120, 35);
            BtnCriarConta.TabIndex = 6;
            BtnCriarConta.TabStop = false;
            BtnCriarConta.Text = "Criar Conta";
            BtnCriarConta.UseVisualStyleBackColor = true;
            // 
            // txtCopyringt
            // 
            txtCopyringt.AutoSize = true;
            txtCopyringt.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCopyringt.Location = new Point(82, 352);
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
            linktxtRyvera.Location = new Point(204, 352);
            linktxtRyvera.Name = "linktxtRyvera";
            linktxtRyvera.Size = new Size(84, 14);
            linktxtRyvera.TabIndex = 8;
            linktxtRyvera.TabStop = true;
            linktxtRyvera.Text = "Ryvera Code";
            linktxtRyvera.LinkClicked += linktxtRyvera_LinkClicked;
            // 
            // ImgLogin
            // 
            ImgLogin.Image = Properties.Resources.imglogin;
            ImgLogin.Location = new Point(56, 54);
            ImgLogin.Name = "ImgLogin";
            ImgLogin.Size = new Size(292, 307);
            ImgLogin.SizeMode = PictureBoxSizeMode.Zoom;
            ImgLogin.TabIndex = 9;
            ImgLogin.TabStop = false;
            // 
            // PanImgLogin
            // 
            PanImgLogin.BackColor = SystemColors.AppWorkspace;
            PanImgLogin.Controls.Add(ImgLogin);
            PanImgLogin.Location = new Point(403, -1);
            PanImgLogin.Name = "PanImgLogin";
            PanImgLogin.Size = new Size(398, 452);
            PanImgLogin.TabIndex = 10;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.ForeColor = SystemColors.AppWorkspace;
            TextBoxSenha.Location = new Point(56, 245);
            TextBoxSenha.Multiline = true;
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PlaceholderText = "***************";
            TextBoxSenha.Size = new Size(261, 35);
            TextBoxSenha.TabIndex = 11;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.ForeColor = SystemColors.AppWorkspace;
            TextBoxEmail.Location = new Point(56, 166);
            TextBoxEmail.Multiline = true;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PlaceholderText = "email@example.com";
            TextBoxEmail.Size = new Size(261, 35);
            TextBoxEmail.TabIndex = 13;
            // 
            // TexEmail
            // 
            TexEmail.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexEmail.Location = new Point(56, 122);
            TexEmail.Name = "TexEmail";
            TexEmail.Size = new Size(147, 38);
            TexEmail.TabIndex = 12;
            TexEmail.Text = "Informe o sua senha:";
            TexEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxEmail);
            Controls.Add(TexEmail);
            Controls.Add(TextBoxSenha);
            Controls.Add(linktxtRyvera);
            Controls.Add(PanImgLogin);
            Controls.Add(BtnLogin);
            Controls.Add(txtCopyringt);
            Controls.Add(BtnCriarConta);
            Controls.Add(TextSenha);
            Controls.Add(TextSaudacao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login";
            ((System.ComponentModel.ISupportInitialize)ImgLogin).EndInit();
            PanImgLogin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextSaudacao;
        private Label TextSenha;
        private Button BtnLogin;
        private Button BtnCriarConta;
        private Label txtCopyringt;
        private LinkLabel linktxtRyvera;
        private PictureBox ImgLogin;
        private Panel PanImgLogin;
        private TextBox TextBoxSenha;
        private TextBox TextBoxEmail;
        private Label TexEmail;
        private TextBox TextCardEmail;
        private Panel PanLoginEmail;
    }
}