
namespace APOD_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.ShowTodaysImageCheckBox = new System.Windows.Forms.CheckBox();
            this.LimitRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageTodayTextBox = new System.Windows.Forms.TextBox();
            this.ImageCopyrightText = new System.Windows.Forms.Label();
            this.ImageCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(18, 18);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 0;
            this.MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImageTodayTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LimitRangeCheckBox);
            this.groupBox1.Controls.Add(this.ShowTodaysImageCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración";
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(18, 249);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(290, 23);
            this.LaunchButton.TabIndex = 2;
            this.LaunchButton.Text = "Ir a la fecha de lanzamiento del APOD";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // ShowTodaysImageCheckBox
            // 
            this.ShowTodaysImageCheckBox.AutoSize = true;
            this.ShowTodaysImageCheckBox.Location = new System.Drawing.Point(17, 34);
            this.ShowTodaysImageCheckBox.Name = "ShowTodaysImageCheckBox";
            this.ShowTodaysImageCheckBox.Size = new System.Drawing.Size(244, 21);
            this.ShowTodaysImageCheckBox.TabIndex = 0;
            this.ShowTodaysImageCheckBox.Text = "Muestra la imagen de hoy al inicio";
            this.ShowTodaysImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // LimitRangeCheckBox
            // 
            this.LimitRangeCheckBox.AutoSize = true;
            this.LimitRangeCheckBox.Location = new System.Drawing.Point(17, 78);
            this.LimitRangeCheckBox.Name = "LimitRangeCheckBox";
            this.LimitRangeCheckBox.Size = new System.Drawing.Size(215, 21);
            this.LimitRangeCheckBox.TabIndex = 1;
            this.LimitRangeCheckBox.Text = "Limitar intervalo al año actual";
            this.LimitRangeCheckBox.UseVisualStyleBackColor = true;
            this.LimitRangeCheckBox.CheckedChanged += new System.EventHandler(this.LimitRangeCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagenes descargadas hoy";
            // 
            // ImageTodayTextBox
            // 
            this.ImageTodayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ImageTodayTextBox.Location = new System.Drawing.Point(212, 121);
            this.ImageTodayTextBox.Name = "ImageTodayTextBox";
            this.ImageTodayTextBox.ReadOnly = true;
            this.ImageTodayTextBox.Size = new System.Drawing.Size(59, 22);
            this.ImageTodayTextBox.TabIndex = 3;
            // 
            // ImageCopyrightText
            // 
            this.ImageCopyrightText.AutoSize = true;
            this.ImageCopyrightText.Location = new System.Drawing.Point(15, 494);
            this.ImageCopyrightText.Name = "ImageCopyrightText";
            this.ImageCopyrightText.Size = new System.Drawing.Size(218, 17);
            this.ImageCopyrightText.TabIndex = 3;
            this.ImageCopyrightText.Text = "Copyright y créditos de la imagen";
            // 
            // ImageCopyrightTextBox
            // 
            this.ImageCopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ImageCopyrightTextBox.Location = new System.Drawing.Point(18, 526);
            this.ImageCopyrightTextBox.Name = "ImageCopyrightTextBox";
            this.ImageCopyrightTextBox.ReadOnly = true;
            this.ImageCopyrightTextBox.Size = new System.Drawing.Size(290, 22);
            this.ImageCopyrightTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 597);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1057, 150);
            this.textBox1.TabIndex = 6;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePictureBox.Location = new System.Drawing.Point(369, 18);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(700, 530);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 7;
            this.ImagePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 772);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageCopyrightTextBox);
            this.Controls.Add(this.ImageCopyrightText);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MonthCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ImageTodayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox LimitRangeCheckBox;
        private System.Windows.Forms.CheckBox ShowTodaysImageCheckBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label ImageCopyrightText;
        private System.Windows.Forms.TextBox ImageCopyrightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ImagePictureBox;
    }
}

