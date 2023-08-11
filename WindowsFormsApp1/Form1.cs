using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTAVSoloPublicScript.Logic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Logic logic;

        public Form1()
        {
            this.logic = new Logic();
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

            logic.suspend();

            this.timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.label1.Text = "READY";

            logic.resume();

            this.timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic.kill();
        }

    }
}
