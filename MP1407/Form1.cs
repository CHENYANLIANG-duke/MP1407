using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace MP1407
{
    public partial class Form1 : Form
    {
        int M_iResult;
        List<byte> devcomport = new List<byte>();
        List<byte> devcomport2 = new List<byte>();
        string[] ports = SerialPort.GetPortNames();
        private byte[] Key = new byte[(int)RDINT.MIFARE_ONE_DEF.CARD_KEY_LEN];
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            foreach (string port in ports)
            {
                ComportName.Items.Add(port);
            }
            try
            {
                ComportName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No detected COM !");
            }
        }

        private void btn_OpenReader_Click(object sender, EventArgs e)
        {
            uint intBar = 0;
            txtmsg.Clear();

            var com = Convert.ToInt32(ComportName.SelectedItem.ToString().Remove(0, 3));
            M_iResult = (int)RDINT.RDINTsys.OpenReader((byte)com, uint.Parse("38400"), "00000000", RDINT.TURN_ON_OFF.TURN_ON, uint.Parse("0"), out intBar);

            if (!(M_iResult == 0))
            {
                ShowStatus("Open Reader" + com.ToString() + " 失敗。錯誤代碼:" + M_iResult);
            }
            else
            {
                ShowStatus("Open Reader  com" + com.ToString() + " 成功");
                devcomport2.Add((byte)com);
            }

            btn_OpenReader.Enabled = false;
            btn_CloseReader.Enabled = true;
            btn_AutoReadUltraLight.Enabled = true;

        }

        private void btn_CloseReader_Click(object sender, EventArgs e)
        {
            timer1.Stop();
          
            txtmsg.Clear();

            for (int i = 0; i < devcomport2.Count; i++)
            {
                M_iResult = (int)RDINT.RDINTsys.CloseReader(devcomport2[i]);


                if (M_iResult == 0)
                {
                    ShowStatus("Close Reader" + (i + 1).ToString() + "成功");
                }
                else
                    ShowStatus("Close Reader" + (i + 1).ToString() + " 失敗。錯誤代碼:");
            }

            btn_CloseReader.Enabled = false;
            btn_OpenReader.Enabled = true;
            btn_AutoReadUltraLight.Enabled = true;
            txtthreadtime.Enabled = true;
        }

        private void btn_AutoReadUltraLight_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(txtthreadtime.Text);
            timer1.Start();
            txtthreadtime.Enabled = false;
            btn_AutoReadUltraLight.Enabled = false;
        }

        private void ShowStatus(String Msg)
        {
            txtmsg.Text += Msg + "\r\n";
        }

        private void readnfc2(int comNo)
        {
            txtmsg.Clear();
  
            try
            {
                //GET UID
                int i, j;
                byte Sak;
                byte[] Uid = new byte[(int)RDINT.OPENCARD_DEF.UID_LEN];
                byte[] Atqa = new byte[(int)RDINT.OPENCARD_DEF.ATQA_LEN];
                string strUID = "";

                //u1AutoFind設定TURN_ON，卡片關閉後必須重新靠卡，才可開啟卡片
                M_iResult = (int)RDINT.RDINTnon.OpenCard(devcomport2[comNo], (RDINT.TURN_ON_OFF)RDINT.TURN_ON_OFF.TURN_ON, Uid, Atqa, out Sak);
                if (M_iResult != 0)
                {
                    // ShowStatus("Open Card失敗。錯誤代碼:" + M_iResult);
                    return;
                }

                for (i = (int)RDINT.OPENCARD_DEF.UID_LEN - 1; i >= 0; i -= 1)
                {
                    if (Uid[i] == (int)RDINT.OPENCARD_DEF.UID_END)
                        break;
                }
              
                for (i = 3; i > -1; i--)
                {
                    strUID += Uid[i].ToString("X2");
                }

              //  strUID += "88";

                KBsimulation(strUID, "{ENTER}");

            }
            catch (Exception ex)
            {
              
            }
        }

        private void btn_CloseReader_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readnfc2(0);
        }

        private void KBsimulation(string InputData, string inputkey)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                txtmsg.Text = InputData;
            }
            else
            {
                Clipboard.SetDataObject(InputData, true);
                keybd_event(0x11, 0, 0, 0);
                keybd_event(0x56, 0, 0, 0);
                keybd_event(0x56, 0, 2, 0);
                keybd_event(0x11, 0, 2, 0);

                Thread.Sleep(50);

                SendKeys.Send(inputkey);
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }
    }
}
