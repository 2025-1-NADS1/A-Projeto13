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
            this.components = new System.ComponentModel.Container();
            this.grafic1 = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MediaGasto_text = new System.Windows.Forms.Label();
            this.Ambiente_text = new System.Windows.Forms.Label();
            this.avanca_mes = new System.Windows.Forms.Button();
            this.Volta_mes = new System.Windows.Forms.Button();
            this.dataMaior = new System.Windows.Forms.Label();
            this.dataMeio = new System.Windows.Forms.Label();
            this.dataMenor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafic1
            // 
            this.grafic1.AutoSize = true;
            this.grafic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grafic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.grafic1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grafic1.IsEnableHZoom = false;
            this.grafic1.IsEnableVZoom = false;
            this.grafic1.Location = new System.Drawing.Point(131, 80);
            this.grafic1.Margin = new System.Windows.Forms.Padding(6);
            this.grafic1.MinimumSize = new System.Drawing.Size(425, 243);
            this.grafic1.Name = "grafic1";
            this.grafic1.ScrollGrace = 0D;
            this.grafic1.ScrollMaxX = 0D;
            this.grafic1.ScrollMaxY = 0D;
            this.grafic1.ScrollMaxY2 = 0D;
            this.grafic1.ScrollMinX = 0D;
            this.grafic1.ScrollMinY = 0D;
            this.grafic1.ScrollMinY2 = 0D;
            this.grafic1.Size = new System.Drawing.Size(425, 243);
            this.grafic1.TabIndex = 0;
            this.grafic1.UseExtendedPrintDialog = true;
            this.grafic1.Load += new System.EventHandler(this.grafic1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MediaGasto_text);
            this.panel1.Controls.Add(this.Ambiente_text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 74);
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
            this.MediaGasto_text.Location = new System.Drawing.Point(551, 22);
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
            // avanca_mes
            // 
            this.avanca_mes.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.avanca_mes.Location = new System.Drawing.Point(591, 188);
            this.avanca_mes.Name = "avanca_mes";
            this.avanca_mes.Size = new System.Drawing.Size(47, 37);
            this.avanca_mes.TabIndex = 2;
            this.avanca_mes.Text = ">";
            this.avanca_mes.UseVisualStyleBackColor = true;
            this.avanca_mes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.avanca_mes_MouseClick);
            // 
            // Volta_mes
            // 
            this.Volta_mes.AllowDrop = true;
            this.Volta_mes.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volta_mes.Location = new System.Drawing.Point(46, 188);
            this.Volta_mes.Name = "Volta_mes";
            this.Volta_mes.Size = new System.Drawing.Size(47, 37);
            this.Volta_mes.TabIndex = 3;
            this.Volta_mes.Text = "<";
            this.Volta_mes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Volta_mes.UseVisualStyleBackColor = true;
            this.Volta_mes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Volta_mes_MouseClick);
            // 
            // dataMaior
            // 
            this.dataMaior.AutoSize = true;
            this.dataMaior.BackColor = System.Drawing.Color.Red;
            this.dataMaior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataMaior.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMaior.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataMaior.Location = new System.Drawing.Point(298, 339);
            this.dataMaior.Name = "dataMaior";
            this.dataMaior.Size = new System.Drawing.Size(89, 31);
            this.dataMaior.TabIndex = 4;
            this.dataMaior.Text = "label1";
            // 
            // dataMeio
            // 
            this.dataMeio.AutoSize = true;
            this.dataMeio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataMeio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataMeio.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMeio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataMeio.Location = new System.Drawing.Point(298, 381);
            this.dataMeio.Name = "dataMeio";
            this.dataMeio.Size = new System.Drawing.Size(89, 31);
            this.dataMeio.TabIndex = 5;
            this.dataMeio.Text = "label2";
            // 
            // dataMenor
            // 
            this.dataMenor.AutoSize = true;
            this.dataMenor.BackColor = System.Drawing.Color.Goldenrod;
            this.dataMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataMenor.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMenor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataMenor.Location = new System.Drawing.Point(298, 427);
            this.dataMenor.Name = "dataMenor";
            this.dataMenor.Size = new System.Drawing.Size(89, 31);
            this.dataMenor.TabIndex = 6;
            this.dataMenor.Text = "label3";
            // 
            // AmbientePag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 559);
            this.Controls.Add(this.dataMenor);
            this.Controls.Add(this.dataMeio);
            this.Controls.Add(this.dataMaior);
            this.Controls.Add(this.Volta_mes);
            this.Controls.Add(this.avanca_mes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grafic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AmbientePag";
            this.Text = "AmbientePag";
            this.Load += new System.EventHandler(this.AmbientePag_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl grafic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ambiente_text;
        private System.Windows.Forms.Label MediaGasto_text;
        private System.Windows.Forms.Button avanca_mes;
        private System.Windows.Forms.Button Volta_mes;
        private System.Windows.Forms.Label dataMaior;
        private System.Windows.Forms.Label dataMeio;
        private System.Windows.Forms.Label dataMenor;
    }
}