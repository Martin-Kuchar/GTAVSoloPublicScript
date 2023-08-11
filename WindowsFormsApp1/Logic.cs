using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GTAVSoloPublicScript.Logic
{
    internal class Logic
    {
        [DllImport("ntdll.dll", PreserveSig = false)]
        public static extern void NtSuspendProcess(IntPtr processHandle);
        [DllImport("ntdll.dll", PreserveSig = false)]
        public static extern void NtResumeProcess(IntPtr processHandle);

        public Logic() { }

        public void suspend()
        {
            var processes = Process.GetProcessesByName("gta5");
            foreach (var item in processes)
            {
                IntPtr h = item.Handle;
                NtSuspendProcess(h);
            }
        }

        public void resume()
        {
            var processes = Process.GetProcessesByName("gta5");
            foreach (var item in processes)
            {
                IntPtr h = item.Handle;
                NtResumeProcess(h);
            }
        }

        public void kill()
        {
            var processes = Process.GetProcessesByName("gta5");
            foreach (var item in processes)
            {
                item.Kill();
            }
        }
    }
}
