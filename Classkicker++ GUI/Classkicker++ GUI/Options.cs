using System;
using System.Windows.Forms;
using System.IO;

namespace Classkicker___GUI
{
    public partial class Options : Form
    {
        public static int threads = Convert.ToInt32(File.ReadAllText(Form1.threadfile));
        public Options()
        {
            InitializeComponent();
            Low.BackColor = System.Drawing.Color.Transparent;
            Medium.BackColor = System.Drawing.Color.Transparent;
            High.BackColor = System.Drawing.Color.Transparent;
            Ultra.BackColor = System.Drawing.Color.Transparent;
            Custom.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Text = "Current threads: " + threads;
        }

        private void High_CheckedChanged(object sender, EventArgs e)
        {
            threads = 10000;
            label3.Text = "Current threads: " + threads;
            File.WriteAllText(Form1.threadfile, threads.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Custom.Checked)
            {
                label2.Show();
                textBox1.Show();
                button1.Show();
            }
            else
            {
                label2.Hide();
                textBox1.Hide();    
                button1.Hide();
            }
        }
        private void Ultra_CheckedChanged(object sender, EventArgs e)
        {
            threads = 15000;
            label3.Text = "Current threads: " + threads;
            File.WriteAllText(Form1.threadfile, threads.ToString());
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            threads = 7500;
            label3.Text = "Current threads: " + threads;
            File.WriteAllText(Form1.threadfile, threads.ToString());
        }

        private void Low_CheckedChanged(object sender, EventArgs e)
        {
            threads = 5000;
            label3.Text = "Current threads: " + threads;
            File.WriteAllText(Form1.threadfile, threads.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            threads = Convert.ToInt32(textBox1.Text);
            label3.Text = "Current threads: " + threads;
            File.WriteAllText(Form1.threadfile, threads.ToString());
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
