using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoXeR_1._0
{
    public partial class Custom : Form
    {
        public Custom()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {

        }

        private void Hastebin_Click(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\";
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Could Not Find Dir /Doxs/");
            }
            else
            {

                string Custom = richTextBox1.Text;
                using (StreamWriter writer = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\dox.txt"))

                {
                    writer.WriteLine("" + Custom);
                }
            }

        }

        private void Custom_Load(object sender, EventArgs e)
        {
            string path2 = $"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\customdox.txt";
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }
        }

        private void nyX_Theme1_Click(object sender, EventArgs e)
        {
            string path2 = $"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\customdox.txt";
            if (!File.Exists(path2))
            {
                File.Delete(path2);
                File.Create(path2);
            }
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            Ssave();
        }
        private void Ssave()
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\";
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Could Not Find Dir /Doxs/");

                
            }
            else
            {

                string Custom = richTextBox2.Text;
                using (StreamWriter writer = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\customdox.txt"))

                {
                    writer.WriteLine("" + Custom);
                }
            }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Process.Start($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\customdox.txt");
            //string url = ""
            //GetReq($"")
        }
        public void uwu()
        {

            using (var wb = new WebClient())
            {
                string Cxstom = richTextBox2.Text;
                var data = new NameValueCollection();
                data[""] = "" + Cxstom + "\n";
                
                string oops = Cxstom;
                string url = "https://hastebin.com/documents";
                var response = wb.UploadValues(url, "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
                MessageBox.Show("This Option Might be Broken But The Code Has been Copyied to you're clipboard", "Warining!!");
                Clipboard.SetText("Your Hastebin code is : " + responseInString);
            }
        }
        public static string GetReq(string url)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            uwu();
        }
    }
}
