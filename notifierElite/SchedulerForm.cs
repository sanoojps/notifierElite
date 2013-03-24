using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace notifierElite
{
    public partial class SchedulerForm : Form
    {
        public SchedulerForm()
        {
            InitializeComponent();
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           
        }
      

        private void Save_Schedule_Click(object sender, EventArgs e)
        {
            
            string dateTimePickerText = dateTimePicker1.Text.ToString();
            string dateTimePickerTimeText = dateTimePicker2.Text.ToString();
            string checkedRadioButton = "";
            if (radioButtonMonthly.Checked == true)
            {
                checkedRadioButton = radioButtonMonthly.Text;
            }



            if (radioButtonWeekly.Checked == true)
            {
                checkedRadioButton = radioButtonWeekly.Text;
            }



            if (radioButtonDaily.Checked == true)
            {
                checkedRadioButton = radioButtonDaily.Text;
            }



            if (radioButtonDateOfChoice.Checked == true)
            {
                checkedRadioButton = radioButtonDateOfChoice.Text;
            }

            //MessageBox.Show("Date : " + dateTimePickerText + " " + "\nTime : " + dateTimePickerTimeText + "\nSchedule Chosen : " + checkedRadioButton.ToUpper());
            Schedule.Text = "Date : " + dateTimePickerText + " " + "  Time : " + dateTimePickerTimeText + "\n\nSchedule Chosen :" + checkedRadioButton.ToUpper();


           

        }

        private void Save_Schedule_MouseEnter(object sender, EventArgs e)
        {
            this.Save_Schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.Save_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), 
            //    ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.Save_Schedule.FlatStyle = FlatStyle.Popup;
        }

        private void Save_Schedule_MouseLeave(object sender, EventArgs e)
        {
            this.Save_Schedule.Cursor = System.Windows.Forms.Cursors.Default;
            //this.Save_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))),
            //    ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.Save_Schedule.FlatStyle = FlatStyle.Flat;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))),
            //    ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.Exit.FlatStyle = FlatStyle.Popup;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Exit.Cursor = System.Windows.Forms.Cursors.Default;
            //this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))),
            //    ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.Exit.FlatStyle = FlatStyle.Flat;
        }
    }
}
