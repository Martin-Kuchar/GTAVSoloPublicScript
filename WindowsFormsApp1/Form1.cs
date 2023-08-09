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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("ntdll.dll", PreserveSig = false)]
        public static extern void NtSuspendProcess(IntPtr processHandle);
        [DllImport("ntdll.dll", PreserveSig = false)]
        public static extern void NtResumeProcess(IntPtr processHandle);
        public Form1()
        {
            InitializeComponent();
        }

        private void suspend()
        {
            var processes = Process.GetProcessesByName("opera");
            foreach (var item in processes)
            {
                IntPtr h = item.Handle;
                NtSuspendProcess(h);
            }
        }

        private void resume()
        {
            var processes = Process.GetProcessesByName("opera");
            foreach (var item in processes)
            {
                IntPtr h = item.Handle;
                NtResumeProcess(h);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soloPublic();
            
        }

        private void soloPublic()
        {
            this.button1.Enabled = false;
            this.label1.Text = "Creating solo public session";

            this.suspend();

            this.timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.label1.Text = "READY";

            this.resume();

            this.timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
