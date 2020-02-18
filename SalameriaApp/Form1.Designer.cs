namespace SalameriaApp
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TipoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VendidosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CantidadLargosTextBox = new System.Windows.Forms.TextBox();
            this.CantidadCortosTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DineroLargosTextBox = new System.Windows.Forms.TextBox();
            this.DineroCortosTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiasTextBox = new System.Windows.Forms.TextBox();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.MyOtherTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReiniciarButton = new System.Windows.Forms.Button();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.DetenerButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendidosDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PrecioTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CantidadTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TipoTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(156, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analizador";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.PrecioTextBox.Location = new System.Drawing.Point(16, 43);
            this.PrecioTextBox.Multiline = true;
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.ReadOnly = true;
            this.PrecioTextBox.Size = new System.Drawing.Size(84, 41);
            this.PrecioTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTextBox.Location = new System.Drawing.Point(142, 88);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(139, 26);
            this.CantidadTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contador";
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoTextBox.Location = new System.Drawing.Point(142, 30);
            this.TipoTextBox.Multiline = true;
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.ReadOnly = true;
            this.TipoTextBox.Size = new System.Drawing.Size(139, 41);
            this.TipoTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Salami";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VendidosDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(15, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendidos";
            // 
            // VendidosDataGridView
            // 
            this.VendidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendidosDataGridView.Location = new System.Drawing.Point(17, 20);
            this.VendidosDataGridView.Name = "VendidosDataGridView";
            this.VendidosDataGridView.Size = new System.Drawing.Size(590, 219);
            this.VendidosDataGridView.TabIndex = 0;
            this.VendidosDataGridView.Tag = "n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(80, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Totales";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CantidadLargosTextBox);
            this.groupBox5.Controls.Add(this.CantidadCortosTextBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(20, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 96);
            this.groupBox5.TabIndex = 6;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DineroLargosTextBox);
            this.groupBox6.Controls.Add(this.DineroCortosTextBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(205, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 97);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dinero";
            // 
            // DineroLargosTextBox
            // 
            this.DineroLargosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineroLargosTextBox.Location = new System.Drawing.Point(80, 45);
            this.DineroLargosTextBox.Name = "DineroLargosTextBox";
            this.DineroLargosTextBox.ReadOnly = true;
            this.DineroLargosTextBox.Size = new System.Drawing.Size(147, 26);
            this.DineroLargosTextBox.TabIndex = 3;
            // 
            // DineroCortosTextBox
            // 
            this.DineroCortosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineroCortosTextBox.Location = new System.Drawing.Point(80, 17);
            this.DineroCortosTextBox.Name = "DineroCortosTextBox";
            this.DineroCortosTextBox.ReadOnly = true;
            this.DineroCortosTextBox.Size = new System.Drawing.Size(147, 26);
            this.DineroCortosTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Largos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cortos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReiniciarButton);
            this.groupBox1.Controls.Add(this.IniciarButton);
            this.groupBox1.Controls.Add(this.DetenerButton);
            this.groupBox1.Controls.Add(this.DiasTextBox);
            this.groupBox1.Controls.Add(this.HoraTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temporizador";
            // 
            // DiasTextBox
            // 
            this.DiasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasTextBox.Location = new System.Drawing.Point(68, 45);
            this.DiasTextBox.Name = "DiasTextBox";
            this.DiasTextBox.ReadOnly = true;
            this.DiasTextBox.Size = new System.Drawing.Size(60, 26);
            this.DiasTextBox.TabIndex = 3;
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraTextBox.Location = new System.Drawing.Point(68, 17);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.ReadOnly = true;
            this.HoraTextBox.Size = new System.Drawing.Size(60, 26);
            this.HoraTextBox.TabIndex = 2;
            this.HoraTextBox.TextChanged += new System.EventHandler(this.HoraTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Días";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 500;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // MyOtherTimer
            // 
            this.MyOtherTimer.Tick += new System.EventHandler(this.MyOtherTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalameriaApp.Properties.Resources.Captura1;
            this.pictureBox1.Location = new System.Drawing.Point(475, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SalameriaApp.Properties.Resources.account_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(447, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Resultados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReiniciarButton
            // 
            this.ReiniciarButton.BackgroundImage = global::SalameriaApp.Properties.Resources.Restart_16;
            this.ReiniciarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReiniciarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReiniciarButton.Location = new System.Drawing.Point(90, 88);
            this.ReiniciarButton.Name = "ReiniciarButton";
            this.ReiniciarButton.Size = new System.Drawing.Size(33, 26);
            this.ReiniciarButton.TabIndex = 6;
            this.ReiniciarButton.UseVisualStyleBackColor = true;
            this.ReiniciarButton.Click += new System.EventHandler(this.ReiniciarButton_Click);
            // 
            // IniciarButton
            // 
            this.IniciarButton.BackgroundImage = global::SalameriaApp.Properties.Resources.Play_16;
            this.IniciarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IniciarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.Location = new System.Drawing.Point(18, 88);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(33, 26);
            this.IniciarButton.TabIndex = 4;
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetenerButton
            // 
            this.DetenerButton.BackgroundImage = global::SalameriaApp.Properties.Resources.Pause_16;
            this.DetenerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DetenerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetenerButton.Location = new System.Drawing.Point(54, 88);
            this.DetenerButton.Name = "DetenerButton";
            this.DetenerButton.Size = new System.Drawing.Size(33, 26);
            this.DetenerButton.TabIndex = 5;
            this.DetenerButton.UseVisualStyleBackColor = true;
            this.DetenerButton.Click += new System.EventHandler(this.DetenerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalameriaApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VendidosDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DiasTextBox;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox CantidadLargosTextBox;
        private System.Windows.Forms.TextBox CantidadCortosTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox DineroLargosTextBox;
        private System.Windows.Forms.TextBox DineroCortosTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView VendidosDataGridView;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Button DetenerButton;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TipoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer MyOtherTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReiniciarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

