namespace EcoWatt
{
    partial class InformacaoPessoal
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
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.Panel_main = new SATAUiFramework.SATAPanel();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpf_text_input = new SATATextBox();
            this.Nome_text_input = new SATATextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idade_text_input = new SATATextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endereço_text_input = new SATATextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Login_text_input = new SATATextBox();
            this.Panel_main.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_main
            // 
            this.Panel_main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_main.BackColor2 = System.Drawing.Color.White;
            this.Panel_main.BorderColor = System.Drawing.Color.Transparent;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.Panel_main.BorderRadius = borderRadius1;
            this.Panel_main.BorderThickness = 10;
            this.Panel_main.Controls.Add(this.sataPanel1);
            this.Panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_main.Location = new System.Drawing.Point(0, 0);
            this.Panel_main.Name = "Panel_main";
            this.Panel_main.Size = new System.Drawing.Size(800, 450);
            this.Panel_main.TabIndex = 5;
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.Transparent;
            this.sataPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(115)))));
            this.sataPanel1.BorderColor = System.Drawing.Color.Transparent;
            borderRadius2.BottomLeft = 20;
            borderRadius2.BottomRight = 5;
            borderRadius2.TopLeft = 5;
            borderRadius2.TopRight = 30;
            this.sataPanel1.BorderRadius = borderRadius2;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.label5);
            this.sataPanel1.Controls.Add(this.Login_text_input);
            this.sataPanel1.Controls.Add(this.label4);
            this.sataPanel1.Controls.Add(this.endereço_text_input);
            this.sataPanel1.Controls.Add(this.label3);
            this.sataPanel1.Controls.Add(this.idade_text_input);
            this.sataPanel1.Controls.Add(this.label2);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.Nome_text_input);
            this.sataPanel1.Controls.Add(this.cpf_text_input);
            this.sataPanel1.Location = new System.Drawing.Point(42, 12);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(731, 413);
            this.sataPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(144, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(144, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // cpf_text_input
            // 
            this.cpf_text_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.cpf_text_input.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.cpf_text_input.BorderRadius = 5;
            this.cpf_text_input.BorderSize = 3;
            this.cpf_text_input.Icon = null;
            this.cpf_text_input.IconSize = new System.Drawing.Size(20, 20);
            this.cpf_text_input.Location = new System.Drawing.Point(59, 131);
            this.cpf_text_input.Multiline = false;
            this.cpf_text_input.Name = "cpf_text_input";
            this.cpf_text_input.PasswordChar = true;
            this.cpf_text_input.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cpf_text_input.PlaceholderText = "CPF";
            this.cpf_text_input.Size = new System.Drawing.Size(250, 35);
            this.cpf_text_input.TabIndex = 1;
            this.cpf_text_input.Text = "sataTextBox1";
            this.cpf_text_input.Texts = "";
            this.cpf_text_input.UnderlinedStyle = false;
            this.cpf_text_input.Click += new System.EventHandler(this.senha_input_text_Click);
            // 
            // Nome_text_input
            // 
            this.Nome_text_input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nome_text_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.Nome_text_input.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.Nome_text_input.BorderRadius = 5;
            this.Nome_text_input.BorderSize = 3;
            this.Nome_text_input.Icon = null;
            this.Nome_text_input.IconSize = new System.Drawing.Size(20, 20);
            this.Nome_text_input.Location = new System.Drawing.Point(59, 56);
            this.Nome_text_input.Multiline = false;
            this.Nome_text_input.Name = "Nome_text_input";
            this.Nome_text_input.PasswordChar = false;
            this.Nome_text_input.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Nome_text_input.PlaceholderText = "NOME";
            this.Nome_text_input.Size = new System.Drawing.Size(250, 35);
            this.Nome_text_input.TabIndex = 2;
            this.Nome_text_input.Text = "sataTextBox2";
            this.Nome_text_input.Texts = "";
            this.Nome_text_input.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(144, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "IDADE";
            // 
            // idade_text_input
            // 
            this.idade_text_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.idade_text_input.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.idade_text_input.BorderRadius = 5;
            this.idade_text_input.BorderSize = 3;
            this.idade_text_input.Icon = null;
            this.idade_text_input.IconSize = new System.Drawing.Size(20, 20);
            this.idade_text_input.Location = new System.Drawing.Point(59, 224);
            this.idade_text_input.Multiline = false;
            this.idade_text_input.Name = "idade_text_input";
            this.idade_text_input.PasswordChar = true;
            this.idade_text_input.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.idade_text_input.PlaceholderText = "IDADE";
            this.idade_text_input.Size = new System.Drawing.Size(250, 35);
            this.idade_text_input.TabIndex = 6;
            this.idade_text_input.Text = "sataTextBox1";
            this.idade_text_input.Texts = "";
            this.idade_text_input.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(111, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "ENDEREÇO";
            // 
            // endereço_text_input
            // 
            this.endereço_text_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.endereço_text_input.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.endereço_text_input.BorderRadius = 5;
            this.endereço_text_input.BorderSize = 3;
            this.endereço_text_input.Icon = null;
            this.endereço_text_input.IconSize = new System.Drawing.Size(20, 20);
            this.endereço_text_input.Location = new System.Drawing.Point(59, 312);
            this.endereço_text_input.Multiline = false;
            this.endereço_text_input.Name = "endereço_text_input";
            this.endereço_text_input.PasswordChar = true;
            this.endereço_text_input.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.endereço_text_input.PlaceholderText = "ENDEREÇO";
            this.endereço_text_input.Size = new System.Drawing.Size(250, 35);
            this.endereço_text_input.TabIndex = 8;
            this.endereço_text_input.Text = "sataTextBox1";
            this.endereço_text_input.Texts = "";
            this.endereço_text_input.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(513, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "LOGIN";
            // 
            // Login_text_input
            // 
            this.Login_text_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.Login_text_input.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.Login_text_input.BorderRadius = 5;
            this.Login_text_input.BorderSize = 3;
            this.Login_text_input.Icon = null;
            this.Login_text_input.IconSize = new System.Drawing.Size(20, 20);
            this.Login_text_input.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Login_text_input.Location = new System.Drawing.Point(428, 103);
            this.Login_text_input.Multiline = false;
            this.Login_text_input.Name = "Login_text_input";
            this.Login_text_input.PasswordChar = true;
            this.Login_text_input.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Login_text_input.PlaceholderText = "LOGIN";
            this.Login_text_input.Size = new System.Drawing.Size(250, 35);
            this.Login_text_input.TabIndex = 10;
            this.Login_text_input.Text = "sataTextBox1";
            this.Login_text_input.Texts = "";
            this.Login_text_input.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_main.ResumeLayout(false);
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel Panel_main;
        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SATATextBox Nome_text_input;
        private SATATextBox cpf_text_input;
        private System.Windows.Forms.Label label5;
        private SATATextBox Login_text_input;
        private System.Windows.Forms.Label label4;
        private SATATextBox endereço_text_input;
        private System.Windows.Forms.Label label3;
        private SATATextBox idade_text_input;
    }
}