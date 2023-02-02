using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTEK
{
    
    public partial class Form1 : Form
    {
        int koef = 1;
       // DateTime MonThuSun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, /*(int)DayOfWeek.Monday,*/ (int)DateTime.Now.Day, (int)DateTime.Now.Hour, (int)DateTime.Now.Minute, (int)DateTime.Now.Second);
        
        DateTime[] redTime = { new DateTime(DateTime.Now.Year, DateTime.Now.Month, /*(int)DayOfWeek.Monday,*/ (int)DateTime.Now.Day, (int)DateTime.Now.Hour, (int)DateTime.Now.Minute, (int)DateTime.Now.Second) };
        DateTime time = DateTime.Now;
        DateTime tempTime;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
            
            checkDay();
            label1.Font = new Font("Arial", 30, FontStyle.Regular);
            label1.Text = string.Empty;
            //time = time.Subtract(TimeSpan.FromHours(2 * time.Hour - k));
            //  time = Convert.ToDateTime(time.Subtract(tempTime));

            TimeSpan temp = time.Subtract(tempTime);
            DateTime time2 = new DateTime() - temp;
            time = time2;

            //time -= time.Subtract(tempTime);

            //this.Width = 400;
            

            timer1.Interval = 1000; // 500 миллисекунд
            timer1.Enabled = true;
            
            timer1.Tick += timer1_Tick;

            //label2.Text = redTime[0].ToString("ddd, dd MMM yyy HH':'mm':'ss");
            //label2.Text = redTime[0].ToString("ddd");
            


        }
        void checkDay()
        {
            bool check = false;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        if (DateTime.Now.Hour < 1 || (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 13) || DateTime.Now.Hour >= 21)
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour < 1)
                            {
                                k = 1;
                            }
                            else if (DateTime.Now.Hour - 13 < 0)
                            {
                                k = 13;
                            }
                            else
                            {
                                tempTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 1, 0, 0);
                                check = true;
                            }
                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 9 < 0)
                            {
                                k = 9;
                            }
                            else if (DateTime.Now.Hour - 21 < 0)
                            {
                                k = 21;
                            }
                        }
                        break;
                    }
                case DayOfWeek.Tuesday: 
                    {
                        if (DateTime.Now.Hour < 1 || (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 9) || (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 21))
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour < 1)
                            {
                                k = 1;
                            }
                            else if (DateTime.Now.Hour - 9 < 0)
                            {
                                k = 9;
                            }
                            else
                            {
                                k = 21;
                            }
                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 5 < 0)
                            {
                                k = 5;
                            }
                            else if (DateTime.Now.Hour - 17 < 0)
                            {
                                k = 17;
                            }
                        }
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        if ((DateTime.Now.Hour >= 1 && DateTime.Now.Hour < 5) || (DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 17))
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour < 5)
                            {
                                k = 5;
                            }
                            else
                            {
                                k = 17;
                            }
                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 1 < 0)
                            {
                                k = 1;
                            }
                            else if (DateTime.Now.Hour - 13 < 0)
                            {
                                k = 13;
                            }
                        }

                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        if (DateTime.Now.Hour < 1 || (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 13) || DateTime.Now.Hour >= 21)
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour < 1)
                            {
                                k = 1;
                            }
                            else if (DateTime.Now.Hour - 13 < 0)
                            {
                                k = 13;
                            }
                            else
                            {
                                tempTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+1, 1, 0, 0);
                                check = true;
                            }
                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 9 < 0)
                            {
                                k = 9;
                            }
                            else if(DateTime.Now.Hour - 21 < 0)
                            {
                                k = 21;
                            }
                        }
                        
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        if (DateTime.Now.Hour < 1 || (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 9) || (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 21))
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour - 1 < 0)
                            {
                                k = 1;
                            }
                            else if (DateTime.Now.Hour - 9 < 0)
                            {
                                k = 9;
                            }
                            else 
                            {
                                k = 21;
                            }

                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 5 < 0)
                            {
                                k = 5;
                            }
                            else if (DateTime.Now.Hour - 17 < 0)
                            {
                                k = 17;
                            }
                        }
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        if ((DateTime.Now.Hour >= 1 && DateTime.Now.Hour < 5) || (DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 17))
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour - 5 < 0)
                            {
                                k = 5;
                            }
                            else
                            {
                                k = 17;
                            }
                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 1 < 0)
                            {
                                k = 1;
                            }
                            else if (DateTime.Now.Hour - 13 < 0)
                            {
                                k = 13;
                            }
                        }
                        break;
                    }
                case DayOfWeek.Sunday:
                    {
                        if ((DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 13) || DateTime.Now.Hour >= 21)
                        {
                            label1.ForeColor = Color.Red;
                            if (DateTime.Now.Hour - 13 < 0)
                            {
                                k = 13;
                            }
                            else
                            {
                                tempTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 1, 0, 0);
                                check = true;
                            }
                        }
                        else
                        {
                            label1.ForeColor = Color.Green;
                            if (DateTime.Now.Hour - 9 < 0)
                            {
                                k = 9;
                            }
                            else if (DateTime.Now.Hour - 21 < 0)
                            {
                                k = 21;
                            }
                        }
                        break;
                    }
                    default:
                    {
                        return;
                    }
            }
            if (!check)
            {
                tempTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, k, 0, 0);
            }
            
        }
        // обработчик события Tick таймера
        void timer1_Tick(object sender, EventArgs e)
        {           
            show_time();
        }
        // обработчик нажатия на кнопку
        void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        void show_time()
        {
           // time = DateTime.Now;
            time = time.Subtract(TimeSpan.FromSeconds(1));
            //label1.Text = time.ToString("ddd, dd MMM yyy HH':'mm':'ss'");
            label1.Text = time.ToString("HH':'mm':'ss");
        }
    }




}
