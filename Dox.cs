using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoXeR_1._0
{
    public partial class Dox : Form
    {
        public Dox()
        {
            InitializeComponent();
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Dox_Load(object sender, EventArgs e)
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\";
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Could Not Create Dir /Doxs/");
                Directory.CreateDirectory(path);
                MessageBox.Show("Created Dir /Doxs/");
            }
            else
            {

            }
            string path2 = $"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\dox.txt";
            if (!File.Exists(path2))
            {
                File.Create(path2);
            }

        }

        private void nyX_CheckBox1_CheckedChanged(object sender)
        {
            using (StreamWriter writer = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\dox.txt"))
            {
                writer.WriteLine("                       /$$$$$$$   /$$$$$$  /$$   /$$ /$$$$$$$$ /$$$$$$$ ");
                writer.WriteLine("                      | $$__  $$ /$$__  $$| $$  / $$| $$_____/| $$__  $$");
                writer.WriteLine("                      | $$  \\ $$| $$  \\ $$|  $$/ $$/| $$      | $$  \\ $$");
                writer.WriteLine("                      | $$  | $$| $$  | $$ \\  $$$$/ | $$$$$   | $$  | $$");
                writer.WriteLine("                      | $$  | $$| $$  | $$  >$$  $$ | $$__/   | $$  | $$");
                writer.WriteLine("                      | $$  | $$| $$  | $$ /$$/\\  $$| $$      | $$  | $$");
                writer.WriteLine("                      | $$$$$$$/|  $$$$$$/| $$  \\ $$| $$$$$$$$| $$$$$$$/");
                writer.WriteLine("                      |_______/  \\______/ |__/  |__/|________/|_______/");
            }
        }

        private void nyX_CheckBox2_CheckedChanged(object sender)
        {
            using (StreamWriter writer = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\dox.txt"))
            {
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                writer.WriteLine("FORMATTED BY DOXER ON GITHUB ");
            }
        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {
            

            
        }


        private void siticoneRoundedTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\dox.txt");
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\Doxs\\dox.txt"))
            {
                if (siticoneRoundedTextBox26.Text == "First Name")
                {
                    siticoneRoundedTextBox26.Text = "UNKNOWN";
                }
                if (siticoneRoundedTextBox21.Text == "Email")
                {
                    siticoneRoundedTextBox21.Text = "UNKNOWN";
                }
                if (siticoneRoundedTextBox25.Text == "Lastname")
                {
                    siticoneRoundedTextBox25.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox22.Text == "Phone Number")
                {
                    siticoneRoundedTextBox22.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox23.Text == "Address")
                {
                    siticoneRoundedTextBox23.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox18.Text == "Job")
                {
                    siticoneRoundedTextBox18.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox17.Text == "Pictures")
                {
                    siticoneRoundedTextBox17.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox24.Text == "IP")
                {
                    siticoneRoundedTextBox24.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox19.Text == "Instagram")
                {
                    siticoneRoundedTextBox19.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox20.Text == "FaceBook")
                {
                    siticoneRoundedTextBox20.Text = "UNKNOWN";

                }
                if (siticoneRoundedTextBox15.Text == "Credits")
                {
                    siticoneRoundedTextBox15.Text = "UWU";

                }
                if (siticoneRoundedTextBox16.Text == "Doxed By")
                {
                    siticoneRoundedTextBox16.Text = "UNKNOWN";

                }
                writer.WriteLine("                       /$$$$$$$   /$$$$$$  /$$   /$$ /$$$$$$$$ /$$$$$$$ ");
                writer.WriteLine("                      | $$__  $$ /$$__  $$| $$  / $$| $$_____/| $$__  $$");
                writer.WriteLine("                      | $$  \\ $$| $$  \\ $$|  $$/ $$/| $$      | $$  \\ $$");
                writer.WriteLine("                      | $$  | $$| $$  | $$ \\  $$$$/ | $$$$$   | $$  | $$");
                writer.WriteLine("                      | $$  | $$| $$  | $$  >$$  $$ | $$__/   | $$  | $$");
                writer.WriteLine("                      | $$  | $$| $$  | $$ /$$/\\  $$| $$      | $$  | $$");
                writer.WriteLine("                      | $$$$$$$/|  $$$$$$/| $$  \\ $$| $$$$$$$$| $$$$$$$/");
                writer.WriteLine("                      |_______/  \\______/ |__/  |__/|________/|_______/");
                string doxed = siticoneRoundedTextBox16.Text;
                writer.WriteLine("                                        Doxed By : " + doxed);

                writer.WriteLine("\n");
                writer.WriteLine("##########Info###########");
                writer.WriteLine("0x1 = Basic Info FN,LA,PH,AD,PI,JO");
                writer.WriteLine("0x2 = Socials FC,IN,ETC");
                writer.WriteLine("0x3 = Accounts IP,EMAIL");
                writer.WriteLine("0x4 = Reason");
                writer.WriteLine("0x5 = Credits ");
                writer.WriteLine("##########Info###########");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                //writer.WriteLine("\n");

                string first = siticoneRoundedTextBox26.Text;
                string last = siticoneRoundedTextBox25.Text;
                string phone = siticoneRoundedTextBox22.Text;
                string addy = siticoneRoundedTextBox23.Text;
                string job = siticoneRoundedTextBox18.Text;
                string pic = siticoneRoundedTextBox17.Text;

                writer.WriteLine("##########(0x1)###########");
                writer.WriteLine("--> First Name > " + first);
                writer.WriteLine("--> Last Name > " + last);
                writer.WriteLine("--> Phone Number > " + phone);
                writer.WriteLine("--> Addy > " + addy);
                writer.WriteLine("--> Job > " + job);
                writer.WriteLine("--> pic > " + pic);
                writer.WriteLine("##########(0x1)###########");
                writer.WriteLine("\n");
                string email = siticoneRoundedTextBox21.Text;
                string ip = siticoneRoundedTextBox24.Text;
                writer.WriteLine("##########(0x2)###########");
                string instagram = siticoneRoundedTextBox19.Text;
                string facebook = siticoneRoundedTextBox20.Text;
                writer.WriteLine("--> Instagram > " + instagram);
                writer.WriteLine("--> FaceBook  > " + facebook);
                writer.WriteLine("##########(0x2)###########");
                writer.WriteLine("\n");
                writer.WriteLine("##########(0x3)###########");
                writer.WriteLine("--> email  > " + email);
                writer.WriteLine("--> ip  > " + ip);
                writer.WriteLine("##########(0x3)###########");
                writer.WriteLine("\n");






                //writer.WriteLine("\n");
                //writer.WriteLine("\n");
                //writer.WriteLine("\n");
                //writer.WriteLine("\n");
                //writer.WriteLine("\n");

                string reason = siticoneRoundedTextBox14.Text;
                writer.WriteLine("##########(0x4)###########");
                writer.WriteLine("--> Reason >  " + reason);
                writer.WriteLine("##########(0x4)###########");
                writer.WriteLine("\n");
                writer.WriteLine("\n");
                string credits = siticoneRoundedTextBox15.Text;
                writer.WriteLine("##########(0x5)###########");
                writer.WriteLine("--> Credits > " + credits);
                writer.WriteLine("--> FORMATTED BY NOMAT ON GITHUB : https://github.com/NanoSecc/DoXer/");
                writer.WriteLine("##########(0x5)###########");
            }
        }
    }
}
