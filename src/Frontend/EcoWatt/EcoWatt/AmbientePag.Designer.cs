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
            this.SuspendLayout();
            // 
            // grafic1
            // 
            this.grafic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grafic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.grafic1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grafic1.IsEnableHZoom = false;
            this.grafic1.IsEnableVZoom = false;
            this.grafic1.Location = new System.Drawing.Point(125, 15);
            this.grafic1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grafic1.Name = "grafic1";
            this.grafic1.ScrollGrace = 0D;
            this.grafic1.ScrollMaxX = 0D;
            this.grafic1.ScrollMaxY = 0D;
            this.grafic1.ScrollMaxY2 = 0D;
            this.grafic1.ScrollMinX = 0D;
            this.grafic1.ScrollMinY = 0D;
            this.grafic1.ScrollMinY2 = 0D;
            this.grafic1.Size = new System.Drawing.Size(328, 174);
            this.grafic1.TabIndex = 0;
            this.grafic1.UseExtendedPrintDialog = true;
            // 
            // AmbientePag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 448);
            this.Controls.Add(this.grafic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(680, 448);
            this.Name = "AmbientePag";
            this.Text = "AmbientePag";
            this.Load += new System.EventHandler(this.AmbientePag_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl grafic1;
    }
}