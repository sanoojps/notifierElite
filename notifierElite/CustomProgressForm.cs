﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace notifierElite
{
    public partial class CustomProgressForm : Form
    {
        public CustomProgressForm()
        {
            InitializeComponent();

            //get working area to launch the form at the right most corner 
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) - 10 , Screen.PrimaryScreen.WorkingArea.Height - this.Height - 100 );
            
           // MessageBox.Show((Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10).ToString());

            this.ShowInTaskbar = false;
             
          

        }

        public CustomProgressForm(int progressValue)
        {
            if (progressValue != 100)
            {


                this.progressBar1.Value = progressValue;
                this.labelProgressPercentage.Text = progressValue.ToString() + " %";
                // System.Threading.Thread.Sleep(1000); // Just for the demo... don't go sleeping
                this.labelFileDownloadSize.Text = null;
            }
            else
            {
                this.Close();
                this.Dispose();
            }
            
        }

        public void UpdateProgressBar(int progressValue)
        {
            if (progressValue != 100)
            {


                this.progressBar1.Value = progressValue;
                this.labelProgressPercentage.Text = progressValue.ToString() + " %";
                // System.Threading.Thread.Sleep(1000); // Just for the demo... don't go sleeping
                this.labelFileDownloadSize.Text = null;
            }
            else
            {
                this.Close();
                this.Dispose();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("buhahauuahauahaauahau");
            this.Close();
            this.Dispose();
        }

        void CustomProgressForm_Shown(object sender, System.EventArgs e)
        {
            MessageBox.Show(e.ToString());
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Opacity = 0.5;  
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                this.Opacity = 1;
            }
        }




    }
}
