namespace TaskBM
{
    partial class configWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configWindow));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.regeditStateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.notifContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Taskbar Modificator";
            this.notifyIcon.Visible = true;
            // 
            // notifContextMenu
            // 
            this.notifContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regeditStateStrip,
            this.exitStrip});
            this.notifContextMenu.Name = "notifContextMenu";
            this.notifContextMenu.ShowCheckMargin = true;
            this.notifContextMenu.ShowImageMargin = false;
            this.notifContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // regeditStateStrip
            // 
            this.regeditStateStrip.CheckOnClick = true;
            this.regeditStateStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.regeditStateStrip.Name = "regeditStateStrip";
            this.regeditStateStrip.Size = new System.Drawing.Size(180, 22);
            this.regeditStateStrip.Text = "Start with system";
            this.regeditStateStrip.Click += new System.EventHandler(this.regeditStateStrip_Click);
            // 
            // exitStrip
            // 
            this.exitStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitStrip.Name = "exitStrip";
            this.exitStrip.Size = new System.Drawing.Size(180, 22);
            this.exitStrip.Text = "Exit";
            this.exitStrip.Click += new System.EventHandler(this.exitStrip_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // configWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 322);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "configWindow";
            this.Text = "Taskbar Modifer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Shown += new System.EventHandler(this.configWindow_Shown);
            this.notifContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifContextMenu;
        private System.Windows.Forms.ToolStripMenuItem regeditStateStrip;
        private System.Windows.Forms.ToolStripMenuItem exitStrip;
        private System.Windows.Forms.Timer timerCheck;
    }
}

