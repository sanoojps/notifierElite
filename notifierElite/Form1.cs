using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using NotificationWindow;

using System.Runtime.InteropServices;

namespace notifierElite
{
    public partial class StaplesSBC : Form
    {
        private WindowsServiceMonitor MonTone;
        private WindowsServiceMonitor serViceMon;

       

        public StaplesSBC()
        {
            InitializeComponent();
            //contextMenuStrip1.Renderer = new MyRenderer();

             this.notifyIcon1.ShowBalloonTip(30);

           // this.popupNotifier1.Popup();

             this.MonTone = new WindowsServiceMonitor();

             Thread monThread = new Thread(this.MonTone.StartMonitor);
             monThread.Name = "WindowsServiceMonitor";
            monThread.Start();
            //this.MonTone.StartMonitor();

            #region EventMechanismToShowPopUP

            this.serViceMon = new WindowsServiceMonitor();


            this.serViceMon.MessageRecieved +=

                    pipeClient_MessageRecieved;

                
        }


      


        void pipeClient_MessageRecieved(string message)
        {
            /*
            this.notifyIcon1.BalloonTipText =
               message.ToString() +
               "Success! Staples® EasyTech™ Small Business Class has" +
               " detected  and fixed a potential issue " +
               "with this computer.";

            this.notifyIcon1.ShowBalloonTip(1);
            */
            // this.popupNotifier1.Popup();

           this.Invoke(new WindowsServiceMonitor.MessageReceivedHandler(
               pipeClient_DisplayMessage), new object[] { message });
        }


        void pipeClient_DisplayMessage(string message)
        {
            
            this.notifyIcon1.BalloonTipText =
              message.ToString() +
              "Success! Staples® EasyTech™ Small Business Class has" +
              " detected \nand fixed a potential issue " +
              "with this computer.";

            this.notifyIcon1.ShowBalloonTip(1);
           
            this.popupNotifier1.ContentText = ""
                + "Success! Staples® EasyTech™ Small Business Class has detected and fixed a potential issue with this computer.\n"+ Environment.NewLine
                + message.ToString()
                ;
           this.popupNotifier1.Popup();
        }



        #endregion


        /*
        private void MonTone_MessageRecieved(string message)
        {
            this.Invoke(new WindowsServiceMonitor.MessageReceivedHandler(
                Display_MonTone_MessageRecieved), new object[] { message });
        }

        private void Display_MonTone_MessageRecieved(string message)
        {
            //this.popupNotifier1.Popup();
            this.notifyIcon1.BalloonTipText = @"                        " +
               message.ToString() +
               Environment.NewLine +
               @"Success!  Staples® EasyTech™ Small Business Class has detected and fixed a potential issue with this computer";
            this.notifyIcon1.ShowBalloonTip(5);
        }

         */


        #region MouseHoverColorChange

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                //get { return Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135))))); }
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Yellow; }
            }
        }

        #endregion


        //sets the visibility of the form to invisble so that the form is not show on launch
        //also set are forms - showOnTaskbar property and WindowStateMinimized - are set to false .. which is not necessary

        /*
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }
        */


        #region MouseEventsFor-exitToolStripMenuItem

        private void exitToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
           
           
            //this.exitToolStripMenuItem.BackColor = 
              //  System.Drawing.Color.FromArgb(((int)(((byte)(100)))), 
                //((int)(((byte)(118)))), 
                //((int)(((byte)(135)))));
              //this.exitToolStripMenuItem.Font = 
                //new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           

           
            this.exitToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

            
            this.exitToolStripMenuItem.Font = null;
           

        }

        #endregion

        #region MouseEventsFor-aboutToolStripMenuItem

        private void aboutToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

           
            this.aboutToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            

        }

        private void aboutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

           
            this.aboutToolStripMenuItem.Font = null;
          


        }

        #endregion


        #region MouseEventsFor-chatWithATechNowToolStripMenuItem

        private void chatWithATechNowToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

          
            this.chatWithATechNowToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
        }

        private void chatWithATechNowToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
           
            this.chatWithATechNowToolStripMenuItem.Font = null;
           
        }

        #endregion

        #region MouseEventsFor-myDeviceInfoToolStripMenuItem

        private void myDeviceInfoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
           
            this.myDeviceInfoToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
        }

        private void myDeviceInfoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
            this.myDeviceInfoToolStripMenuItem.Font = null;
            

        }

        #endregion


        #region MouseEventsFor-executeDetailedOptimizationToolStripMenuItem

        private void executeDetailedOptimizationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
           
            this.executeDetailedOptimizationToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            

        }

        private void executeDetailedOptimizationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
           
            this.executeDetailedOptimizationToolStripMenuItem.Font = null;
           

        }

        #endregion



        #region MouseEventsFor-optimizePerformanceNowToolStripMenuItem

        private void optimizePerformanceNowToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            this.optimizePerformanceNowToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          

        }

        private void optimizePerformanceNowToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
          
            this.optimizePerformanceNowToolStripMenuItem.Font = null;
           

        }

        #endregion


        #region MouseEventsFor-schedulePerformanceOptimizationToolStripMenuItem

        private void schedulePerformanceOptimizationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            this.schedulePerformanceOptimizationToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

          

        }

        private void schedulePerformanceOptimizationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

            
            this.schedulePerformanceOptimizationToolStripMenuItem.Font = null;
            
        }

        #endregion



        #region MouseEventsFor-staplesEasyTechSmallBusinessClassToolStripMenuItem

        private void staplesEasyTechSmallBusinessClassToolStripMenuItem_MouseEnter(
            object sender, EventArgs e)
        {

            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 9.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          
        }

        private void staplesEasyTechSmallBusinessClassToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {

            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
        }

        #endregion


        #region Show/Hide SchedulerForm
        //SchedulerForm theSchedule = new SchedulerForm();

        
        private void schedulePerformanceOptimizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*

            try
            {
                theSchedule.Show();


            }
            catch (System.ObjectDisposedException)
            {
                SchedulerForm theSchedule = new SchedulerForm();
                theSchedule.ShowDialog();
            }

            finally
            {

            }
             */
           
            System.Threading.Thread T = new System.Threading.Thread(callScheduleForm);
            T.Name = "callScheduleForm";
            T.Start();

        }

        #endregion


        #region Show/Hide optimizePerformanceNow



        private void optimizePerformanceNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread LaunchProgressForm = new Thread(LaunchProgress);
            LaunchProgressForm.Name = "LaunchProgressForm";
            LaunchProgressForm.Start();

           

        }

        #endregion

        #region Exit

        //on exit visibility is set back to visibile so as to exit the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kill the system event watcher
            MonTone.Dispose();
            base.SetVisibleCore(true);

            base.Close();
            base.Dispose();

            Application.Exit();


        }

        #endregion




        private void callScheduleForm()
        {
            LaunchScheduler();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.popupNotifier1.Popup();
        }


        #region SetWindowPos

        /*
       //bring window to the front
       [DllImport("user32.dll")]
       static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

       
        BOOL WINAPI SetWindowPos(
 _In_      HWND hWnd,
 _In_opt_  HWND hWndInsertAfter,
 _In_      int X,
 _In_      int Y,
 _In_      int cx,
 _In_      int cy,
 _In_      UINT uFlags
);
        */


        /*
        To bring form to front if it has alreday been launched
        static private IntPtr HWND_TOPMOST = new IntPtr(-1);
        static private IntPtr HWND_BOTTOM = new IntPtr(1);
        static private IntPtr HWND_NOTOPMOST = new IntPtr(-1);
        static private IntPtr HWND_TOP = new IntPtr(0);

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_SHOWWINDOW = 0x0040;

        static public void MakeTopMost(Form f)
        {

            SetWindowPos(f.Handle, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        
        
        
        }

        */

        #endregion

        private void LaunchProgress()
        {
            CustomProgressForm theProgress = new CustomProgressForm();


            if ((Application.OpenForms["CustomProgressForm"] as CustomProgressForm) != null)
            {
                //bring window to the front

                //MakeTopMost(theSchedule);

                ShowWindowAsTopMost Show = new ShowWindowAsTopMost();
                Show.setWindowPosition(theProgress);

            }

            else
            {
                Application.EnableVisualStyles();
                Application.Run(theProgress);
            }
        }

        private void LaunchScheduler()
        {

            SchedulerForm theSchedule = new SchedulerForm();
            if ((Application.OpenForms["SchedulerForm"] as SchedulerForm) != null)
            {
                //bring window to the front

                //MakeTopMost(theSchedule);

                ShowWindowAsTopMost Show = new ShowWindowAsTopMost();
                Show.setWindowPosition(theSchedule);

            }

            else
            {
                Application.EnableVisualStyles();
                Application.Run(theSchedule);
            }
 
        }


    }
}
