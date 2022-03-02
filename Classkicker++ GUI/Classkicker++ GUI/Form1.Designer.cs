namespace Classkicker___GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CodeError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox1.Location = new System.Drawing.Point(401, 169);
            this.textbox1.MaxLength = 6;
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(161, 47);
            this.textbox1.TabIndex = 0;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(662, 191);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 49);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(301, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Flood!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(478, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bot count:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(282, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bot name:";
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(239, 192);
            this.textBox3.MaxLength = 21;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 48);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(204, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(442, 99);
            this.button2.TabIndex = 7;
            this.button2.Text = "       Classkicker++";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current threads:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(301, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 73);
            this.button3.TabIndex = 9;
            this.button3.Text = "Verify code";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CodeError
            // 
            this.CodeError.AutoSize = true;
            this.CodeError.BackColor = System.Drawing.SystemColors.Control;
            this.CodeError.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeError.ForeColor = System.Drawing.Color.Red;
            this.CodeError.Location = new System.Drawing.Point(191, 264);
            this.CodeError.Name = "CodeError";
            this.CodeError.Size = new System.Drawing.Size(490, 42);
            this.CodeError.TabIndex = 10;
            this.CodeError.Text = "Error: Invalid code/Locked roster";
            this.CodeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CodeError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(301, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Verifying code....";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(868, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CodeError);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textbox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classkicker++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label CodeError;
        private System.Windows.Forms.Label label5;
    }
}
