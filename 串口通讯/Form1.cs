using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
 
namespace 串口通讯
{
    public partial class Form1 : Form
    {        

        SerialPort com = new SerialPort();
        String revice_date;


        int value, speed_screen=2;
        bool draw_theard_flag = true;
        bool com_stat = false;
        
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            screen_label.Text = speed_screen.ToString();
            serialport_state.Text = "关闭";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string name in ports )
            {
                port_name.Items.Add(name.ToString());

            }
            port_name.Text  = port_name.Items[0].ToString();


            port_buandrate.Items.Add("1200");
            port_buandrate.Items.Add("2400");
            port_buandrate.Items.Add("4800");
            port_buandrate.Items.Add("9600");
            port_buandrate.Items.Add("19200");
            port_buandrate.Items.Add("38400");
            port_buandrate.Items.Add("43000");
            port_buandrate.Items.Add("56000");
            port_buandrate.Items.Add("57600");
            port_buandrate.Items.Add("115200");
            port_buandrate.Items.Add("123456789");
            port_buandrate.Text  = "115200";


            port_parity.Items.Add("无校验");
            port_parity.Items.Add("奇校验");
            port_parity.Items.Add("偶校验");
            port_parity.Text = "无校验";

            prot_datebit.Items.Add("5");
            prot_datebit.Items.Add("6");
            prot_datebit.Items.Add("7");
            prot_datebit.Items.Add("8");
            prot_datebit.Text = "8";

            prot_stopbit.Items.Add("1");
            prot_stopbit.Items.Add("1.5");
            prot_stopbit.Items.Add("2");
            prot_stopbit.Text = "1";    

            com.DataReceived += new SerialDataReceivedEventHandler(revicdate);
        }

        private void protswitch_Click(object sender, EventArgs e)
        {
           
            Thread th_draw = new Thread(new ThreadStart(darw_picture));
            
            if (!com_stat)
            {
                
               com.PortName =  port_name.Text;

                com.BaudRate = Convert.ToInt32(port_buandrate.Text);

                string s = port_parity.Text.Trim();
                if (s.CompareTo("无校验") == 0)
                {
                    com.Parity = Parity.None;
                }
                if (s.CompareTo("奇校验") == 0)
                {
                    com.Parity = Parity.Odd;
                }
                if (s.CompareTo("偶校验") == 0)
                {
                    com.Parity = Parity.Even;
                }
                else
                {
                    com.Parity = Parity.None;
                }

                com.DataBits = Convert.ToInt32(prot_datebit.Text);

                int prot_stopbits = Convert.ToInt32(prot_stopbit.SelectedValue);
                if (1 == prot_stopbits)
                {
                    com.StopBits = StopBits.One;
                }
                else if (1.5 == prot_stopbits)
                {
                    com.StopBits = StopBits.OnePointFive;
                }
                else if (2 == prot_stopbits)
                {
                    com.StopBits = StopBits.Two;
                }
                else
                {
                    com.StopBits = StopBits.One;
                }
                com.Open();

                protswitch.Text = "close";
                serialport_state.Text = "打开";
                com_stat = true;                
                
                if(draw_theard_flag)
                {
                    th_draw.Start();
                    draw_theard_flag = false;
                }

            }
            else
            {
                protswitch.Text = "open";
                com_stat = false;
                serialport_state.Text = "关闭";
                com.Close();
                //th_draw.Abort();
            }

        }

        private void revicdate(object sender, SerialDataReceivedEventArgs r)
        {
            revice_date = "";
            revice_date = com.ReadExisting();
            showdatebox.Text += revice_date;
            value = Convert.ToInt32(revice_date);
        }

        public void darw_picture()
        {
            int x = 0, flage = 0, start_location = 50;
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black);

            Point p1 = new Point();
            Point p2 = new Point();

            Point p3 = new Point();
            Point p4 = new Point();

            p3.Y = 150;
            p4.Y = 50;


            while (true)
            {
                while (com_stat)
                {
                    p1.X = start_location + x;
                    p1.Y = 150 - 100 * value;
                    p2.X = start_location + 1 + x++;
                    p2.Y = 150 - 100 * value;
                    g.DrawLine(p, p1, p2);

                    if( flage != value )
                    {
                        p3.X = start_location + x;                       
                        p4.X = start_location + x++;                        
                        g.DrawLine(p, p3, p4);
                        flage = value;
                    }

                    System.Threading.Thread.Sleep(speed_screen);
                    if (x > 700)
                    {
                        g.Clear(Color.White);
                        x = 0;
                    }

                }
            }


        }

        private void add_screen_Click(object sender, EventArgs e)
        {
            if (speed_screen > 1)
                speed_screen -= 1;
            screen_label.Text = speed_screen.ToString();
        }

        private void clear_revicebox_Click(object sender, EventArgs e)
        {
            showdatebox.Text = "";
        }

        private void div_screen_Click(object sender, EventArgs e)
        {
            speed_screen += 1;
            screen_label.Text = speed_screen.ToString();
        }
    }
}


