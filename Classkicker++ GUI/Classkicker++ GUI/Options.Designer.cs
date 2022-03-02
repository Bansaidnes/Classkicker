namespace Classkicker___GUI
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.Low = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.High = new System.Windows.Forms.RadioButton();
            this.Ultra = new System.Windows.Forms.RadioButton();
            this.Custom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.Location = new System.Drawing.Point(164, 152);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(57, 24);
            this.Low.TabIndex = 0;
            this.Low.TabStop = true;
            this.Low.Text = "Low";
            this.Low.UseVisualStyleBackColor = true;
            this.Low.CheckedChanged += new System.EventHandler(this.Low_CheckedChanged);
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(260, 152);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(83, 24);
            this.Medium.TabIndex = 1;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.Location = new System.Drawing.Point(397, 152);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(62, 24);
            this.High.TabIndex = 2;
            this.High.TabStop = true;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            this.High.CheckedChanged += new System.EventHandler(this.High_CheckedChanged);
            // 
            // Ultra
            // 
            this.Ultra.AutoSize = true;
            this.Ultra.Location = new System.Drawing.Point(505, 152);
            this.Ultra.Name = "Ultra";
            this.Ultra.Size = new System.Drawing.Size(67, 24);
            this.Ultra.TabIndex = 3;
            this.Ultra.TabStop = true;
            this.Ultra.Text = "Ultra";
            this.Ultra.UseVisualStyleBackColor = true;
            this.Ultra.CheckedChanged += new System.EventHandler(this.Ultra_CheckedChanged);
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Location = new System.Drawing.Point(613, 152);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(80, 24);
            this.Custom.TabIndex = 4;
            this.Custom.TabStop = true;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Speed settings:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 49);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thread count:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "placeholder";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(460, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.Ultra);
            this.Controls.Add(this.High);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Low);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Low;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton High;
        private System.Windows.Forms.RadioButton Ultra;
        private System.Windows.Forms.RadioButton Custom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}