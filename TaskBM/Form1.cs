using Microsoft.Win32;
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
using Win32Interop.WinHandles;

namespace TaskBM
{
    public partial class configWindow : Form
    {
        public configWindow()
        {
            InitializeComponent();
        }

        private void configWindow_Shown(object sender, EventArgs e)
        {
            if (Process.GetProcesses().Count(p => p.ProcessName == thisProcessname) > 1)
                AppFullClose();

            regStripeSet();
            WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        public static String thisProcessname = Process.GetCurrentProcess().ProcessName;
        public static RegistryKey startupReg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static bool registryKey = startupReg.GetValue("TaskBarModifer") == null ? false : true;//registry state
        private const string PrimaryClassName = "Shell_TrayWnd";//Name of taskbar class

        static void CheckTaskbar()
        {
            if (PrimaryClassName == TopLevelWindowUtils.GetForegroundWindow().GetClassName())//Checking on selected taskbar
            {
                user32.keybd_event(0, 0, 0, 0);
                user32.SetForegroundWindow(user32.GetDesktopWindow());//not work without click(previous line)
            }
        }

        void AppFullClose()//ckoing app
        {
            notifyIcon.Visible = false;
            this.Close();
        }

        void regStripeSet()//updating notify icon stripe
        {
            regeditStateStrip.Checked = registryKey;
        }

        void ChengeReg()
        {
            if (registryKey)
            {
                startupReg.DeleteValue("TaskBarModifer", false);//delete startup
                registryKey = false;
            }
            else
            {
                startupReg.SetValue("TaskBarModifer", Application.ExecutablePath);//add startup
                registryKey = true;
            }

            regStripeSet();
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            CheckTaskbar();
        }
        private void regeditStateStrip_Click(object sender, EventArgs e)
        {
            ChengeReg();
        }

        private void exitStrip_Click(object sender, EventArgs e)
        {
            AppFullClose();
        }
    }
}
