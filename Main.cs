using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoXeR_1._0
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void vitalityButton1_Click(object sender, EventArgs e)
        {

        }

        private void nyX_Button1_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        { // Stops Client 
            Environment.Exit(0);
        }

        private void nyX_Button2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            Custom custom = new Custom();
            custom.Show();
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            Dox dox = new Dox();
            dox.Show();

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }
    }
}
