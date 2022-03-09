using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace hosts_reader
{
    public partial class Form1 : Form
    {
        public static int ghp { get; set; }
        public void timer_Tick(object sender, EventArgs e)
        {
            if (ghp == 240)
            {
                ghp = 0;
            }
            else
            {
                ghp++;


                label1.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
            }
        }
        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);
        public Form1()
        {
            InitializeComponent();

        }

        public void parse(string url)
        {
            if (isFilter.Checked == false) {
                if (isIp.Checked == false)
                {
                    WebClient web = new WebClient();
                    System.IO.Stream stream = web.OpenRead(url);
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                    {
                        string text = reader.ReadToEnd();
                        sendLog(text);
                    }
                }
                else
                {
                    WebClient web = new WebClient();
                    System.IO.Stream stream = web.OpenRead($"https://{url}/growtopia/server_data.php");
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                    {
                        string text = reader.ReadToEnd();
                        sendLog(text);
                    }
                }
            }
            else
            {
                if (isIp.Checked == false)
                {
                    WebClient web = new WebClient();
                    System.IO.Stream stream = web.OpenRead(url);
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                    {
                        string text = reader.ReadToEnd();
                        string[] retard = text.Split(new string[] { "type|" }, StringSplitOptions.None);
                        sendLog(retard[0]);
                    }
                }
                else
                {
                    WebClient web = new WebClient();
                    System.IO.Stream stream = web.OpenRead($"https://{url}/growtopia/server_data.php");
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                    {
                        string text = reader.ReadToEnd();
                        string[] retard = text.Split(new string[] { "type|" }, StringSplitOptions.None);
                        sendLog(retard[0]);
                    }
                }
            }

        }
        public void sendLog(string text)
        {
            logs.AppendText(text.Replace("\n",Environment.NewLine));
            logs.AppendText(Environment.NewLine);
            logs.AppendText(Environment.NewLine);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sendLog($"Proccessing [{url.Text}]");
            parse(url.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCtF77sHHJwQt3B38X6m7rTw");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logs.Clear();
        }
    }
}
