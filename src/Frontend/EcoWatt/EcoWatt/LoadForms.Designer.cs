using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoWatt
{
    partial class LoadForms
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
            this.Panel_main = new SATAUiFramework.SATAPanel();
            this.NomeMorador_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sataCircularProgress1 = new SATAUiFramework.Controls.SATACircularProgress();
            this.Panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_main
            // 
            this.Panel_main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_main.BackColor2 = System.Drawing.Color.White;
            this.Panel_main.BorderColor = System.Drawing.Color.DarkGray;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.Panel_main.BorderRadius = borderRadius1;
            this.Panel_main.BorderThickness = 10;
            this.Panel_main.Controls.Add(this.NomeMorador_text);
            this.Panel_main.Controls.Add(this.label1);
            this.Panel_main.Controls.Add(this.sataCircularProgress1);
            this.Panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_main.Location = new System.Drawing.Point(0, 0);
            this.Panel_main.Name = "Panel_main";
            this.Panel_main.Size = new System.Drawing.Size(800, 450);
            this.Panel_main.TabIndex = 5;
            // 
            // NomeMorador_text
            // 
            this.NomeMorador_text.AutoSize = true;
            this.NomeMorador_text.BackColor = System.Drawing.Color.Transparent;
            this.NomeMorador_text.Font = new System.Drawing.Font("Impact", 23.25F);
            this.NomeMorador_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(115)))));
            this.NomeMorador_text.Location = new System.Drawing.Point(219, 136);
            this.NomeMorador_text.Name = "NomeMorador_text";
            this.NomeMorador_text.Size = new System.Drawing.Size(82, 39);
            this.NomeMorador_text.TabIndex = 2;
            this.NomeMorador_text.Text = "teste";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 23.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(210, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo";
            // 
            // sataCircularProgress1
            // 
            this.sataCircularProgress1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sataCircularProgress1.AnimationSpeed = 10;
            this.sataCircularProgress1.BackColor = System.Drawing.Color.White;
            this.sataCircularProgress1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.sataCircularProgress1.FilledColorAlpha = 200;
            this.sataCircularProgress1.FilledThickness = 10;
            this.sataCircularProgress1.IsAnimated = true;
            this.sataCircularProgress1.Location = new System.Drawing.Point(714, 12);
            this.sataCircularProgress1.Name = "sataCircularProgress1";
            this.sataCircularProgress1.Percentage = 35;
            this.sataCircularProgress1.ShowText = true;
            this.sataCircularProgress1.Size = new System.Drawing.Size(74, 76);
            this.sataCircularProgress1.TabIndex = 0;
            this.sataCircularProgress1.TextColor = System.Drawing.Color.Transparent;
            this.sataCircularProgress1.TextSize = 25;
            this.sataCircularProgress1.UnFilledColor = System.Drawing.Color.Transparent;
            this.sataCircularProgress1.UnfilledThickness = 24;
            // 
            // LoadForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForms";
            this.Text = "Form2";
            this.Panel_main.ResumeLayout(false);
            this.Panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel Panel_main;
        private SATAUiFramework.Controls.SATACircularProgress sataCircularProgress1;

       

        private Label label1;
        private Label NomeMorador_text;
    }
    }