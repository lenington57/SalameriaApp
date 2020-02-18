namespace SalameriaApp
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ResultadosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CantidadLargosTextBox = new System.Windows.Forms.TextBox();
            this.CantidadCortosTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RecomendacionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosChart)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultadosChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ResultadosChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ResultadosChart.Legends.Add(legend1);
            this.ResultadosChart.Location = new System.Drawing.Point(21, 14);
            this.ResultadosChart.Name = "ResultadosChart";
            this.ResultadosChart.Size = new System.Drawing.Size(352, 324);
            this.ResultadosChart.TabIndex = 0;
            this.ResultadosChart.Text = "chart1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CantidadLargosTextBox);
            this.groupBox5.Controls.Add(this.CantidadCortosTextBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(401, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 96);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cantidad";
            // 
            // CantidadLargosTextBox
            // 
            this.CantidadLargosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLargosTextBox.Location = new System.Drawing.Point(68, 45);
            this.CantidadLargosTextBox.Name = "CantidadLargosTextBox";
            this.CantidadLargosTextBox.ReadOnly = true;
            this.CantidadLargosTextBox.Size = new System.Drawing.Size(100, 26);
            this.CantidadLargosTextBox.TabIndex = 3;
            // 
            // CantidadCortosTextBox
            // 
            this.CantidadCortosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadCortosTextBox.Location = new System.Drawing.Point(68, 17);
            this.CantidadCortosTextBox.Name = "CantidadCortosTextBox";
            this.CantidadCortosTextBox.ReadOnly = true;
            this.CantidadCortosTextBox.Size = new System.Drawing.Size(100, 26);
            this.CantidadCortosTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Largos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cortos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RecomendacionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(404, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recomendación";
            // 
            // RecomendacionTextBox
            // 
            this.RecomendacionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecomendacionTextBox.Location = new System.Drawing.Point(19, 27);
            this.RecomendacionTextBox.Multiline = true;
            this.RecomendacionTextBox.Name = "RecomendacionTextBox";
            this.RecomendacionTextBox.ReadOnly = true;
            this.RecomendacionTextBox.Size = new System.Drawing.Size(194, 122);
            this.RecomendacionTextBox.TabIndex = 0;
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ResultadosChart);
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosChart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultadosChart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox CantidadLargosTextBox;
        private System.Windows.Forms.TextBox CantidadCortosTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RecomendacionTextBox;
    }
}