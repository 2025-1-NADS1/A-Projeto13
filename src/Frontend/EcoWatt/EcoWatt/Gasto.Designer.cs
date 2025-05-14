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
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            FrameworkTest.Charts.SATALineChart.DataSet dataSet1 = new FrameworkTest.Charts.SATALineChart.DataSet();
            FrameworkTest.Charts.SATALineChart.DataSet dataSet2 = new FrameworkTest.Charts.SATALineChart.DataSet();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.sataPanel2 = new SATAUiFramework.SATAPanel();
            this.sataLineChart1 = new FrameworkTest.Charts.SATALineChart();
            this.sataPanel2.SuspendLayout();
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
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius2;
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
            this.sataPanel2.Controls.Add(this.sataLineChart1);
            this.sataPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel2.Location = new System.Drawing.Point(0, 75);
            this.sataPanel2.Name = "sataPanel2";
            this.sataPanel2.Size = new System.Drawing.Size(800, 375);
            this.sataPanel2.TabIndex = 1;
            // 
            // sataLineChart1
            // 
            this.sataLineChart1.AutoMaxValue = true;
            this.sataLineChart1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.sataLineChart1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.sataLineChart1.BackColor = System.Drawing.Color.Black;
            this.sataLineChart1.ChartPadding = 40;
            this.sataLineChart1.CustomXAxis = new string[0];
            dataSet1.Label = "Sample Dataset 1";
            dataSet1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            dataSet1.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            dataSet1.Points = new float[] {
        105F,
        65F,
        80F,
        120F,
        135F,
        65F,
        30F};
            dataSet2.Label = "Sample Dataset 2";
            dataSet2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(1)))));
            dataSet2.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(1)))));
            dataSet2.Points = new float[] {
        80F,
        90F,
        70F,
        100F,
        110F,
        50F,
        40F};
            this.sataLineChart1.DataSets.Add(dataSet1);
            this.sataLineChart1.DataSets.Add(dataSet2);
            this.sataLineChart1.DayColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.sataLineChart1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataLineChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.sataLineChart1.GradientBackground = true;
            this.sataLineChart1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.sataLineChart1.LabelPosition = FrameworkTest.Charts.LabelPosition.Top;
            this.sataLineChart1.Location = new System.Drawing.Point(40, 17);
            this.sataLineChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataLineChart1.MaxValue = 200F;
            this.sataLineChart1.Name = "sataLineChart1";
            this.sataLineChart1.ShortDates = true;
            this.sataLineChart1.Size = new System.Drawing.Size(712, 213);
            this.sataLineChart1.TabIndex = 0;
            this.sataLineChart1.UseBezier = true;
            this.sataLineChart1.UsePercent = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        protected SATAUiFramework.SATAPanel sataPanel1;
        private SATAUiFramework.SATAPanel sataPanel2;
        private FrameworkTest.Charts.SATALineChart sataLineChart1;
    }
}