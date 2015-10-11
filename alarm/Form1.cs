using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace alarm
{
    
    public partial class Form1 : Form
    {
        bool a = true;
        int hour = 0, 
            minute = 0, 
            second = 0;

            

        public Form1()
        {
            InitializeComponent();           
        }

        
        
        private void Second_Click(object sender, EventArgs e)
        {

        }

        private void Hour_Click(object sender, EventArgs e)
        {

        }

        private void HourSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MinuteInput_TextChanged(object sender, EventArgs e)
        {
            //int value = int.Parse(this.Text);
           // if (value > 60 || value < 0)
               // a = false;
           // else
               // minute = value;
        }

        private void SecondInput_TextChanged(object sender, EventArgs e)
        {
            string value = SecondInput.Text;
            //if (value > 60 || value < 0)
               // a = false;
            //else
                second = int.Parse(value);
        }
        

        private void HourDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinuteDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TimeLeft_Click(object sender, EventArgs e)
        {

        }

        private void Set_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                hour = int.Parse(HourSelect.Text);
                timer2.Enabled = true;
                Set.Enabled = false;

                MessageBox.Show("闹钟已设！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("请输入正确的时间！");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定取消闹钟？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            timer2.Enabled = false;
            Set.Enabled = true;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CurrentTime_Click(object sender, EventArgs e)
        {
                 
        }

        private void TimeDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TimeDisplay.Text = System.DateTime.Now.ToLongTimeString();
            
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SecondDisplay.Text = SecondInput.Text;
            MinuteDisplay.Text = MinuteInput.Text;
            HourDisplay.Text = HourSelect.Text;

            if (second != 0) { second--;  }
            else
            {
                second = 59;
                if (minute != 0) { minute--;  }
                else
                {
                    minute = 59;
                    if (hour != 0) { hour--;  }
                    else
                    {
                        MessageBox.Show("时间到！");
                        HourDisplay.Text = "";
                        MinuteDisplay.Text = "";
                        SecondDisplay.Text = "";
                        Set.Enabled = true;
                    }

                }
            }
        }

       

        

 
    }
}
