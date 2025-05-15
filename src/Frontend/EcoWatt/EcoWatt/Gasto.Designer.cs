namespace EcoWatt
{
    partial class Gasto
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
            SATAUiFramework.BorderRadius borderRadius3 = new SATAUiFramework.BorderRadius();
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.sataPanel2 = new SATAUiFramework.SATAPanel();
            this.Gasto_grafSata = new FrameworkTest.Charts.SATALineChart();
            this.VoltaMes_bnt = new FrameworkTest.SATAButton();
            this.proximoMes_bnt = new FrameworkTest.SATAButton();
            this.sataPanel3 = new SATAUiFramework.SATAPanel();
            this.sataPanel2.SuspendLayout();
            this.sataPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 30;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(115)))));
            this.sataPanel1.BackColor2 = System.Drawing.Color.Azure;
            this.sataPanel1.BorderColor = System.Drawing.Color.Transparent;
            borderRadius3.BottomLeft = 10;
            borderRadius3.BottomRight = 10;
            borderRadius3.TopLeft = 10;
            borderRadius3.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius3;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sataPanel1.Location = new System.Drawing.Point(0, 0);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(800, 75);
            this.sataPanel1.TabIndex = 0;
            this.sataPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sataPanel1_Paint);
            // 
            // sataPanel2
            // 
            this.sataPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.sataPanel2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.sataPanel2.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.sataPanel2.BorderRadius = borderRadius1;
            this.sataPanel2.BorderThickness = 0;
            this.sataPanel2.Controls.Add(this.sataPanel3);
            this.sataPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel2.Location = new System.Drawing.Point(0, 75);
            this.sataPanel2.Name = "sataPanel2";
            this.sataPanel2.Size = new System.Drawing.Size(800, 375);
            this.sataPanel2.TabIndex = 1;
            // 
            // Gasto_grafSata
            // 
            this.Gasto_grafSata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gasto_grafSata.AutoMaxValue = false;
            this.Gasto_grafSata.AutoScroll = true;
            this.Gasto_grafSata.AutoSize = true;
            this.Gasto_grafSata.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Gasto_grafSata.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.Gasto_grafSata.BackColor = System.Drawing.Color.Black;
            this.Gasto_grafSata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gasto_grafSata.CausesValidation = false;
            this.Gasto_grafSata.ChartPadding = 40;
            this.Gasto_grafSata.CustomXAxis = new string[0];
            this.Gasto_grafSata.DayColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.Gasto_grafSata.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gasto_grafSata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.Gasto_grafSata.GradientBackground = false;
            this.Gasto_grafSata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.Gasto_grafSata.LabelPosition = FrameworkTest.Charts.LabelPosition.Top;
            this.Gasto_grafSata.Location = new System.Drawing.Point(40, 6);
            this.Gasto_grafSata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gasto_grafSata.MaxValue = 30F;
            this.Gasto_grafSata.Name = "Gasto_grafSata";
            this.Gasto_grafSata.ShortDates = true;
            this.Gasto_grafSata.ShowGrid = true;
            this.Gasto_grafSata.Size = new System.Drawing.Size(709, 213);
            this.Gasto_grafSata.TabIndex = 0;
            this.Gasto_grafSata.UseBezier = true;
            this.Gasto_grafSata.UsePercent = false;
            // 
            // VoltaMes_bnt
            // 
            this.VoltaMes_bnt.ButtonText = "<";
            this.VoltaMes_bnt.CheckedBackground = System.Drawing.Color.SteelBlue;
            this.VoltaMes_bnt.CheckedForeColor = System.Drawing.Color.White;
            this.VoltaMes_bnt.CheckedImageTint = System.Drawing.Color.White;
            this.VoltaMes_bnt.CheckedOutline = System.Drawing.Color.SteelBlue;
            this.VoltaMes_bnt.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.VoltaMes_bnt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VoltaMes_bnt.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.VoltaMes_bnt.HoverForeColor = System.Drawing.Color.White;
            this.VoltaMes_bnt.HoverImage = null;
            this.VoltaMes_bnt.HoverImageTint = System.Drawing.Color.White;
            this.VoltaMes_bnt.HoverOutline = System.Drawing.Color.Empty;
            this.VoltaMes_bnt.Image = null;
            this.VoltaMes_bnt.ImageAutoCenter = true;
            this.VoltaMes_bnt.ImageExpand = new System.Drawing.Point(0, 0);
            this.VoltaMes_bnt.ImageOffset = new System.Drawing.Point(0, 0);
            this.VoltaMes_bnt.ImageTint = System.Drawing.Color.White;
            this.VoltaMes_bnt.IsToggleButton = false;
            this.VoltaMes_bnt.IsToggled = false;
            this.VoltaMes_bnt.Location = new System.Drawing.Point(40, 225);
            this.VoltaMes_bnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VoltaMes_bnt.Name = "VoltaMes_bnt";
            this.VoltaMes_bnt.NormalBackground = System.Drawing.Color.SteelBlue;
            this.VoltaMes_bnt.NormalForeColor = System.Drawing.Color.White;
            this.VoltaMes_bnt.NormalOutline = System.Drawing.Color.Empty;
            this.VoltaMes_bnt.OutlineThickness = 2F;
            this.VoltaMes_bnt.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.VoltaMes_bnt.PressedForeColor = System.Drawing.Color.White;
            this.VoltaMes_bnt.PressedImageTint = System.Drawing.Color.White;
            this.VoltaMes_bnt.PressedOutline = System.Drawing.Color.Empty;
            this.VoltaMes_bnt.Rounding = new System.Windows.Forms.Padding(5);
            this.VoltaMes_bnt.Size = new System.Drawing.Size(43, 48);
            this.VoltaMes_bnt.TabIndex = 1;
            this.VoltaMes_bnt.TextAutoCenter = true;
            this.VoltaMes_bnt.TextOffset = new System.Drawing.Point(0, 0);
            this.VoltaMes_bnt.Click += new System.EventHandler(this.VoltaMes_bnt_Click);
            // 
            // proximoMes_bnt
            // 
            this.proximoMes_bnt.ButtonText = ">";
            this.proximoMes_bnt.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.proximoMes_bnt.CheckedForeColor = System.Drawing.Color.White;
            this.proximoMes_bnt.CheckedImageTint = System.Drawing.Color.White;
            this.proximoMes_bnt.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.proximoMes_bnt.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.proximoMes_bnt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.proximoMes_bnt.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.proximoMes_bnt.HoverForeColor = System.Drawing.Color.White;
            this.proximoMes_bnt.HoverImage = null;
            this.proximoMes_bnt.HoverImageTint = System.Drawing.Color.White;
            this.proximoMes_bnt.HoverOutline = System.Drawing.Color.Empty;
            this.proximoMes_bnt.Image = null;
            this.proximoMes_bnt.ImageAutoCenter = true;
            this.proximoMes_bnt.ImageExpand = new System.Drawing.Point(0, 0);
            this.proximoMes_bnt.ImageOffset = new System.Drawing.Point(0, 0);
            this.proximoMes_bnt.ImageTint = System.Drawing.Color.White;
            this.proximoMes_bnt.IsToggleButton = false;
            this.proximoMes_bnt.IsToggled = false;
            this.proximoMes_bnt.Location = new System.Drawing.Point(165, 225);
            this.proximoMes_bnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.proximoMes_bnt.Name = "proximoMes_bnt";
            this.proximoMes_bnt.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.proximoMes_bnt.NormalForeColor = System.Drawing.Color.White;
            this.proximoMes_bnt.NormalOutline = System.Drawing.Color.Empty;
            this.proximoMes_bnt.OutlineThickness = 2F;
            this.proximoMes_bnt.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.proximoMes_bnt.PressedForeColor = System.Drawing.Color.White;
            this.proximoMes_bnt.PressedImageTint = System.Drawing.Color.White;
            this.proximoMes_bnt.PressedOutline = System.Drawing.Color.Empty;
            this.proximoMes_bnt.Rounding = new System.Windows.Forms.Padding(5);
            this.proximoMes_bnt.Size = new System.Drawing.Size(52, 48);
            this.proximoMes_bnt.TabIndex = 2;
            this.proximoMes_bnt.TextAutoCenter = true;
            this.proximoMes_bnt.TextOffset = new System.Drawing.Point(0, 0);
            this.proximoMes_bnt.Click += new System.EventHandler(this.proximoMes_bnt_Click);
            // 
            // sataPanel3
            // 
            this.sataPanel3.BackColor2 = System.Drawing.Color.White;
            this.sataPanel3.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel3.BorderRadius = borderRadius2;
            this.sataPanel3.BorderThickness = 0;
            this.sataPanel3.Controls.Add(this.Gasto_grafSata);
            this.sataPanel3.Controls.Add(this.VoltaMes_bnt);
            this.sataPanel3.Controls.Add(this.proximoMes_bnt);
            this.sataPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel3.Location = new System.Drawing.Point(0, 0);
            this.sataPanel3.Name = "sataPanel3";
            this.sataPanel3.Size = new System.Drawing.Size(800, 375);
            this.sataPanel3.TabIndex = 3;
            // 
            // Gasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sataPanel2);
            this.Controls.Add(this.sataPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gasto";
            this.Text = "Gasto";
            this.sataPanel2.ResumeLayout(false);
            this.sataPanel3.ResumeLayout(false);
            this.sataPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        protected SATAUiFramework.SATAPanel sataPanel1;
        private SATAUiFramework.SATAPanel sataPanel2;
        private FrameworkTest.Charts.SATALineChart Gasto_grafSata;
        private FrameworkTest.SATAButton proximoMes_bnt;
        private FrameworkTest.SATAButton VoltaMes_bnt;
        private SATAUiFramework.SATAPanel sataPanel3;
    }
}