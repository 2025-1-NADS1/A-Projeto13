namespace EcoWatt
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.senha_input_text = new SATATextBox();
            this.Login_input_text = new SATATextBox();
            this.Panel_main = new SATAUiFramework.SATAPanel();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.ErroText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Conectabnt = new FrameworkTest.SATAButton();
            this.Panel_main.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // senha_input_text
            // 
            this.senha_input_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.senha_input_text.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.senha_input_text.BorderRadius = 5;
            this.senha_input_text.BorderSize = 3;
            this.senha_input_text.Icon = null;
            this.senha_input_text.IconSize = new System.Drawing.Size(20, 20);
            this.senha_input_text.Location = new System.Drawing.Point(59, 131);
            this.senha_input_text.Multiline = false;
            this.senha_input_text.Name = "senha_input_text";
            this.senha_input_text.PasswordChar = true;
            this.senha_input_text.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.senha_input_text.PlaceholderText = "Digite sua senha";
            this.senha_input_text.Size = new System.Drawing.Size(250, 35);
            this.senha_input_text.TabIndex = 1;
            this.senha_input_text.Text = "sataTextBox1";
            this.senha_input_text.Texts = "";
            this.senha_input_text.UnderlinedStyle = false;
            // 
            // Login_input_text
            // 
            this.Login_input_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login_input_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.Login_input_text.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.Login_input_text.BorderRadius = 5;
            this.Login_input_text.BorderSize = 3;
            this.Login_input_text.Icon = null;
            this.Login_input_text.IconSize = new System.Drawing.Size(20, 20);
            this.Login_input_text.Location = new System.Drawing.Point(58, 56);
            this.Login_input_text.Multiline = false;
            this.Login_input_text.Name = "Login_input_text";
            this.Login_input_text.PasswordChar = false;
            this.Login_input_text.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Login_input_text.PlaceholderText = "Digite seu login";
            this.Login_input_text.Size = new System.Drawing.Size(250, 35);
            this.Login_input_text.TabIndex = 2;
            this.Login_input_text.Text = "sataTextBox2";
            this.Login_input_text.Texts = "";
            this.Login_input_text.UnderlinedStyle = false;
            this.Login_input_text.Click += new System.EventHandler(this.sataTextBox2_Click);
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
            this.Panel_main.TabIndex = 4;
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
            this.sataPanel1.Controls.Add(this.ErroText);
            this.sataPanel1.Controls.Add(this.label2);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.Conectabnt);
            this.sataPanel1.Controls.Add(this.Login_input_text);
            this.sataPanel1.Controls.Add(this.senha_input_text);
            this.sataPanel1.Location = new System.Drawing.Point(218, 51);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(354, 278);
            this.sataPanel1.TabIndex = 3;
            // 
            // ErroText
            // 
            this.ErroText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErroText.AutoEllipsis = true;
            this.ErroText.AutoSize = true;
            this.ErroText.CausesValidation = false;
            this.ErroText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ErroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErroText.ForeColor = System.Drawing.Color.Brown;
            this.ErroText.Location = new System.Drawing.Point(58, 186);
            this.ErroText.Name = "ErroText";
            this.ErroText.Size = new System.Drawing.Size(12, 20);
            this.ErroText.TabIndex = 6;
            this.ErroText.Text = " .";
            this.ErroText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErroText.UseCompatibleTextRendering = true;
            this.ErroText.Click += new System.EventHandler(this.ErroText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(144, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(144, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // Conectabnt
            // 
            this.Conectabnt.ButtonText = "Conectar";
            this.Conectabnt.CheckedBackground = System.Drawing.Color.DarkBlue;
            this.Conectabnt.CheckedForeColor = System.Drawing.Color.White;
            this.Conectabnt.CheckedImageTint = System.Drawing.Color.White;
            this.Conectabnt.CheckedOutline = System.Drawing.Color.CornflowerBlue;
            this.Conectabnt.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.Conectabnt.Font = new System.Drawing.Font("Myriad Hebrew", 20.25F, System.Drawing.FontStyle.Bold);
            this.Conectabnt.HoverBackground = System.Drawing.Color.LightSteelBlue;
            this.Conectabnt.HoverForeColor = System.Drawing.Color.White;
            this.Conectabnt.HoverImage = null;
            this.Conectabnt.HoverImageTint = System.Drawing.Color.White;
            this.Conectabnt.HoverOutline = System.Drawing.Color.Empty;
            this.Conectabnt.Image = null;
            this.Conectabnt.ImageAutoCenter = true;
            this.Conectabnt.ImageExpand = new System.Drawing.Point(0, 0);
            this.Conectabnt.ImageOffset = new System.Drawing.Point(0, 0);
            this.Conectabnt.ImageTint = System.Drawing.Color.White;
            this.Conectabnt.IsToggleButton = false;
            this.Conectabnt.IsToggled = false;
            this.Conectabnt.Location = new System.Drawing.Point(103, 217);
            this.Conectabnt.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Conectabnt.Name = "Conectabnt";
            this.Conectabnt.NormalBackground = System.Drawing.Color.CornflowerBlue;
            this.Conectabnt.NormalForeColor = System.Drawing.Color.White;
            this.Conectabnt.NormalOutline = System.Drawing.Color.Empty;
            this.Conectabnt.OutlineThickness = 2F;
            this.Conectabnt.PressedBackground = System.Drawing.Color.SlateGray;
            this.Conectabnt.PressedForeColor = System.Drawing.Color.Silver;
            this.Conectabnt.PressedImageTint = System.Drawing.Color.White;
            this.Conectabnt.PressedOutline = System.Drawing.Color.Empty;
            this.Conectabnt.Rounding = new System.Windows.Forms.Padding(5);
            this.Conectabnt.Size = new System.Drawing.Size(166, 48);
            this.Conectabnt.TabIndex = 3;
            this.Conectabnt.TextAutoCenter = true;
            this.Conectabnt.TextOffset = new System.Drawing.Point(0, 0);
            this.Conectabnt.Click += new System.EventHandler(this.ConectaBnt_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Panel_main.ResumeLayout(false);
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATATextBox senha_input_text;
        private SATATextBox Login_input_text;
        private SATAUiFramework.SATAPanel Panel_main;
        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label label1;
        private FrameworkTest.SATAButton Conectabnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErroText;
    }
}