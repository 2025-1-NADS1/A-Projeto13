namespace testeCSV
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Carregar = new System.Windows.Forms.Button();
            this.grafic1 = new ZedGraph.ZedGraphControl();
            this.voltaMes = new System.Windows.Forms.Button();
            this.proximoMes = new System.Windows.Forms.Button();
            this.SensorTB = new System.Windows.Forms.TextBox();
            this.ConfirmarSensorBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Carregar
            // 
            this.Carregar.Location = new System.Drawing.Point(704, 52);
            this.Carregar.Name = "Carregar";
            this.Carregar.Size = new System.Drawing.Size(75, 23);
            this.Carregar.TabIndex = 2;
            this.Carregar.Text = "Carregar";
            this.Carregar.UseVisualStyleBackColor = true;
            this.Carregar.Click += new System.EventHandler(this.Carregar_Click);
            // 
            // grafic1
            // 
            this.grafic1.Location = new System.Drawing.Point(12, 12);
            this.grafic1.Name = "grafic1";
            this.grafic1.ScrollGrace = 0D;
            this.grafic1.ScrollMaxX = 0D;
            this.grafic1.ScrollMaxY = 0D;
            this.grafic1.ScrollMaxY2 = 0D;
            this.grafic1.ScrollMinX = 0D;
            this.grafic1.ScrollMinY = 0D;
            this.grafic1.ScrollMinY2 = 0D;
            this.grafic1.Size = new System.Drawing.Size(407, 383);
            this.grafic1.TabIndex = 3;
            this.grafic1.UseExtendedPrintDialog = true;
            this.grafic1.Load += new System.EventHandler(this.grafic1_Load);
            // 
            // voltaMes
            // 
            this.voltaMes.Location = new System.Drawing.Point(566, 33);
            this.voltaMes.Name = "voltaMes";
            this.voltaMes.Size = new System.Drawing.Size(40, 23);
            this.voltaMes.TabIndex = 4;
            this.voltaMes.Text = "<";
            this.voltaMes.UseVisualStyleBackColor = true;
            this.voltaMes.Click += new System.EventHandler(this.voltaMes_Click);
            // 
            // proximoMes
            // 
            this.proximoMes.Location = new System.Drawing.Point(612, 33);
            this.proximoMes.Name = "proximoMes";
            this.proximoMes.Size = new System.Drawing.Size(40, 23);
            this.proximoMes.TabIndex = 5;
            this.proximoMes.Text = ">";
            this.proximoMes.UseVisualStyleBackColor = true;
            this.proximoMes.Click += new System.EventHandler(this.proximoMes_Click);
            // 
            // SensorTB
            // 
            this.SensorTB.Location = new System.Drawing.Point(432, 36);
            this.SensorTB.Name = "SensorTB";
            this.SensorTB.Size = new System.Drawing.Size(128, 20);
            this.SensorTB.TabIndex = 6;
            
            // 
            // ConfirmarSensorBT
            // 
            this.ConfirmarSensorBT.Location = new System.Drawing.Point(438, 65);
            this.ConfirmarSensorBT.Name = "ConfirmarSensorBT";
            this.ConfirmarSensorBT.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarSensorBT.TabIndex = 7;
            this.ConfirmarSensorBT.Text = "Confirmar";
            this.ConfirmarSensorBT.UseVisualStyleBackColor = true;
            this.ConfirmarSensorBT.Click += new System.EventHandler(this.ConfirmarSensorBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmarSensorBT);
            this.Controls.Add(this.SensorTB);
            this.Controls.Add(this.proximoMes);
            this.Controls.Add(this.voltaMes);
            this.Controls.Add(this.grafic1);
            this.Controls.Add(this.Carregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Carregar;
        private ZedGraph.ZedGraphControl grafic1;
        private System.Windows.Forms.Button voltaMes;
        private System.Windows.Forms.Button proximoMes;
        private System.Windows.Forms.TextBox SensorTB;
        private System.Windows.Forms.Button ConfirmarSensorBT;
    }
}

