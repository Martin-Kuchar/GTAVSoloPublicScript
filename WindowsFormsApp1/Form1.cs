using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soloPublic();
            
        }

        private void soloPublic()
        {
            this.button1.Enabled = false;
            this.label1.Text = "Creating solo public session";

            Process p = new Process();
            p.StartInfo.FileName = "pssuspend";
            p.StartInfo.Arguments = "opera";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();

            this.timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.label1.Text = "READY";

            Process p = new Process();
            p.StartInfo.FileName = "pssuspend";
            p.StartInfo.Arguments = "opera -r";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            this.timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName("opera");
            foreach (var item in processes)
            {
                
            }
        }
    }
}
