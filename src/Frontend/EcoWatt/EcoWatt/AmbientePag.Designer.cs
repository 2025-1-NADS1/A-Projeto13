namespace EcoWatt
{
    partial class AmbientePag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MediaGasto_text = new System.Windows.Forms.Label();
            this.Ambiente_text = new System.Windows.Forms.Label();
            this.WattMaior = new System.Windows.Forms.Label();
            this.WattsMeio = new System.Windows.Forms.Label();
            this.WattMenor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Volta_mes = new System.Windows.Forms.Button();
            this.avanca_mes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMenor = new System.Windows.Forms.Label();
            this.dataMeio = new System.Windows.Forms.Label();
            this.dataMaior = new System.Windows.Forms.Label();
            this.AmbienteChar = new FrameworkTest.Charts.SATALineChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MediaGasto_text);
            this.panel1.Controls.Add(this.Ambiente_text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 74);
            this.panel1.TabIndex = 1;
            // 
            // MediaGasto_text
            // 
            this.MediaGasto_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaGasto_text.AutoSize = true;
            this.MediaGasto_text.Enabled = false;
            this.MediaGasto_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaGasto_text.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaGasto_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MediaGasto_text.Location = new System.Drawing.Point(419, 22);
            this.MediaGasto_text.Margin = new System.Windows.Forms.Padding(0);
            this.MediaGasto_text.Name = "MediaGasto_text";
            this.MediaGasto_text.Size = new System.Drawing.Size(151, 25);
            this.MediaGasto_text.TabIndex = 1;
            this.MediaGasto_text.Text = "Gasto KWatt";
            this.MediaGasto_text.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ambiente_text
            // 
            this.Ambiente_text.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ambiente_text.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ambiente_text.Location = new System.Drawing.Point(0, 0);
            this.Ambiente_text.Margin = new System.Windows.Forms.Padding(0);
            this.Ambiente_text.Name = "Ambiente_text";
            this.Ambiente_text.Size = new System.Drawing.Size(178, 74);
            this.Ambiente_text.TabIndex = 0;
            this.Ambiente_text.Text = "Ambiente";
            this.Ambiente_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ambiente_text.UseCompatibleTextRendering = true;
            this.Ambiente_text.Click += new System.EventHandler(this.Ambiente_text_Click);
            // 
            // WattMaior
            // 
            this.WattMaior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WattMaior.AutoSize = true;
            this.WattMaior.BackColor = System.Drawing.Color.Red;
            this.WattMaior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WattMaior.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WattMaior.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WattMaior.Location = new System.Drawing.Point(314, 44);
            this.WattMaior.Name = "WattMaior";
            this.WattMaior.Size = new System.Drawing.Size(89, 31);
            this.WattMaior.TabIndex = 4;
            this.WattMaior.Text = "label1";
            // 
            // WattsMeio
            // 
            this.WattsMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WattsMeio.AutoSize = true;
            this.WattsMeio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WattsMeio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WattsMeio.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WattsMeio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WattsMeio.Location = new System.Drawing.Point(314, 86);
            this.WattsMeio.Name = "WattsMeio";
            this.WattsMeio.Size = new System.Drawing.Size(89, 31);
            this.WattsMeio.TabIndex = 5;
            this.WattsMeio.Text = "label2";
            // 
            // WattMenor
            // 
            this.WattMenor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WattMenor.AutoSize = true;
            this.WattMenor.BackColor = System.Drawing.Color.Goldenrod;
            this.WattMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WattMenor.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WattMenor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WattMenor.Location = new System.Drawing.Point(314, 128);
            this.WattMenor.Name = "WattMenor";
            this.WattMenor.Size = new System.Drawing.Size(89, 31);
            this.WattMenor.TabIndex = 6;
            this.WattMenor.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.AmbienteChar);
            this.panel2.Controls.Add(this.Volta_mes);
            this.panel2.Controls.Add(this.avanca_mes);
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(595, 263);
            this.panel2.TabIndex = 7;
            // 
            // Volta_mes
            // 
            this.Volta_mes.AllowDrop = true;
            this.Volta_mes.Dock = System.Windows.Forms.DockStyle.Left;
            this.Volta_mes.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volta_mes.Location = new System.Drawing.Point(5, 5);
            this.Volta_mes.Name = "Volta_mes";
            this.Volta_mes.Size = new System.Drawing.Size(47, 253);
            this.Volta_mes.TabIndex = 3;
            this.Volta_mes.Text = "<";
            this.Volta_mes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Volta_mes.UseVisualStyleBackColor = true;
            this.Volta_mes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Volta_mes_MouseClick);
            // 
            // avanca_mes
            // 
            this.avanca_mes.Dock = System.Windows.Forms.DockStyle.Right;
            this.avanca_mes.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.avanca_mes.Location = new System.Drawing.Point(543, 5);
            this.avanca_mes.Name = "avanca_mes";
            this.avanca_mes.Size = new System.Drawing.Size(47, 253);
            this.avanca_mes.TabIndex = 2;
            this.avanca_mes.Text = ">";
            this.avanca_mes.UseVisualStyleBackColor = true;
            this.avanca_mes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.avanca_mes_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 341);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel3.Size = new System.Drawing.Size(607, 182);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataMenor);
            this.panel4.Controls.Add(this.dataMeio);
            this.panel4.Controls.Add(this.dataMaior);
            this.panel4.Controls.Add(this.WattMaior);
            this.panel4.Controls.Add(this.WattMenor);
            this.panel4.Controls.Add(this.WattsMeio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 172);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data com maiores gasto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataMenor
            // 
            this.dataMenor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMenor.AutoSize = true;
            this.dataMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.dataMenor.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.dataMenor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dataMenor.Location = new System.Drawing.Point(97, 128);
            this.dataMenor.Name = "dataMenor";
            this.dataMenor.Size = new System.Drawing.Size(87, 29);
            this.dataMenor.TabIndex = 9;
            this.dataMenor.Text = "label3";
            // 
            // dataMeio
            // 
            this.dataMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMeio.AutoSize = true;
            this.dataMeio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.dataMeio.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.dataMeio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dataMeio.Location = new System.Drawing.Point(97, 88);
            this.dataMeio.Name = "dataMeio";
            this.dataMeio.Size = new System.Drawing.Size(87, 29);
            this.dataMeio.TabIndex = 8;
            this.dataMeio.Text = "label2";
            // 
            // dataMaior
            // 
            this.dataMaior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMaior.AutoSize = true;
            this.dataMaior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.dataMaior.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold);
            this.dataMaior.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dataMaior.Location = new System.Drawing.Point(97, 46);
            this.dataMaior.Name = "dataMaior";
            this.dataMaior.Size = new System.Drawing.Size(87, 29);
            this.dataMaior.TabIndex = 7;
            this.dataMaior.Text = "label1";
            // 
            // AmbienteChar
            // 
            this.AmbienteChar.AutoMaxValue = false;
            this.AmbienteChar.AxisColor = System.Drawing.Color.Gray;
            this.AmbienteChar.BackColor = System.Drawing.Color.Black;
            this.AmbienteChar.ChartPadding = 40;
            this.AmbienteChar.CustomXAxis = new string[0];
            this.AmbienteChar.DayColor = System.Drawing.Color.DarkGray;
            this.AmbienteChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmbienteChar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AmbienteChar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AmbienteChar.GradientBackground = true;
            this.AmbienteChar.GridColor = System.Drawing.Color.LightGray;
            this.AmbienteChar.LabelPosition = FrameworkTest.Charts.LabelPosition.Top;
            this.AmbienteChar.Location = new System.Drawing.Point(52, 5);
            this.AmbienteChar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AmbienteChar.MaxValue = 30F;
            this.AmbienteChar.Name = "AmbienteChar";
            this.AmbienteChar.ShortDates = true;
            this.AmbienteChar.Size = new System.Drawing.Size(491, 253);
            this.AmbienteChar.TabIndex = 4;
            this.AmbienteChar.UseBezier = true;
            this.AmbienteChar.UsePercent = false;
            // 
            // AmbientePag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AmbientePag";
            this.Text = "AmbientePag";
            this.Load += new System.EventHandler(this.AmbientePag_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ambiente_text;
        private System.Windows.Forms.Label MediaGasto_text;
        private System.Windows.Forms.Label WattMaior;
        private System.Windows.Forms.Label WattsMeio;
        private System.Windows.Forms.Label WattMenor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dataMeio;
        private System.Windows.Forms.Label dataMaior;
        private System.Windows.Forms.Label dataMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volta_mes;
        private System.Windows.Forms.Button avanca_mes;
        private FrameworkTest.Charts.SATALineChart AmbienteChar;
    }
}