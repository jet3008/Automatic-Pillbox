namespace pastillero_v3
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.time1 = new System.Windows.Forms.NumericUpDown();
            this.time2 = new System.Windows.Forms.NumericUpDown();
            this.time3 = new System.Windows.Forms.NumericUpDown();
            this.time4 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_config = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.can1 = new System.Windows.Forms.NumericUpDown();
            this.can2 = new System.Windows.Forms.NumericUpDown();
            this.can3 = new System.Windows.Forms.NumericUpDown();
            this.can4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.time1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.can1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.can2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.can3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.can4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(146, 154);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(120, 22);
            this.time1.TabIndex = 1;
            // 
            // time2
            // 
            this.time2.Location = new System.Drawing.Point(272, 154);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(120, 22);
            this.time2.TabIndex = 2;
            // 
            // time3
            // 
            this.time3.Location = new System.Drawing.Point(398, 154);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(120, 22);
            this.time3.TabIndex = 3;
            // 
            // time4
            // 
            this.time4.Location = new System.Drawing.Point(524, 154);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(111, 22);
            this.time4.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(573, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(573, 54);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(90, 23);
            this.btn_conectar.TabIndex = 6;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(684, 54);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(104, 23);
            this.btn_desconectar.TabIndex = 7;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(17, 184);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(246, 50);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Cambiar Tiempo/Asignar cantidad pastillas";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(348, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(675, 410);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(118, 29);
            this.btn_config.TabIndex = 16;
            this.btn_config.Text = "Configuracion";
            this.btn_config.UseVisualStyleBackColor = true;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(686, 390);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(46, 17);
            this.lbl_tipo.TabIndex = 17;
            this.lbl_tipo.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiempo pastillas";
            // 
            // can1
            // 
            this.can1.Location = new System.Drawing.Point(146, 126);
            this.can1.Name = "can1";
            this.can1.Size = new System.Drawing.Size(120, 22);
            this.can1.TabIndex = 19;
            // 
            // can2
            // 
            this.can2.Location = new System.Drawing.Point(272, 125);
            this.can2.Name = "can2";
            this.can2.Size = new System.Drawing.Size(120, 22);
            this.can2.TabIndex = 20;
            // 
            // can3
            // 
            this.can3.Location = new System.Drawing.Point(398, 125);
            this.can3.Name = "can3";
            this.can3.Size = new System.Drawing.Size(120, 22);
            this.can3.TabIndex = 21;
            // 
            // can4
            // 
            this.can4.Location = new System.Drawing.Point(524, 126);
            this.can4.Name = "can4";
            this.can4.Size = new System.Drawing.Size(111, 22);
            this.can4.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad pastilas";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.can4);
            this.Controls.Add(this.can3);
            this.Controls.Add(this.can2);
            this.Controls.Add(this.can1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.time4);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.time1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.can1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.can2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.can3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.can4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown time1;
        private System.Windows.Forms.NumericUpDown time2;
        private System.Windows.Forms.NumericUpDown time3;
        private System.Windows.Forms.NumericUpDown time4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown can1;
        private System.Windows.Forms.NumericUpDown can2;
        private System.Windows.Forms.NumericUpDown can3;
        private System.Windows.Forms.NumericUpDown can4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}