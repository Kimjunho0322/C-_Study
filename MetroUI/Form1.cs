using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Diagnostics;
using System.Collections;


namespace MetroUI
{
    public partial class Form1 : MetroForm
    {
        int count = 0;
        int timerFlag = 0;
        int newsFlag = 0;
        string filename = "";
        string arg = "";
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroPanel1.Hide();

            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 7;
            metroComboBox3.SelectedIndex = 0;

            Timer.UseCustomForeColor = true;
            TaskManager.UseCustomForeColor = true;
            News.UseCustomForeColor = true;
            Download.UseCustomForeColor = true;
            Local.UseCustomForeColor = true;
            Google.UseCustomForeColor = true;
            Youtube.UseCustomForeColor = true;
            NotePad.UseCustomForeColor = true;
            Calc.UseCustomForeColor = true;

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
        }

        //뉴스 크롤러
        private void News_Click(object sender, EventArgs e)
        { 
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            if(timerFlag == 0)
            {
                Timer.UseTileImage = false;
                timerFlag = 1;
                timer.Interval = 1000; //인터벌은 밀리초 = 1초 간격
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            else
            {
                Timer.UseTileImage = true;
                timerFlag = 0;
                count = 0;
                timer.Tick -= timer_Tick;
                timer.Stop();
                Timer.TextAlign = ContentAlignment.BottomLeft;
                Timer.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
                Timer.Text = "Reset Timer";
                Timer.UseCustomBackColor = false;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                Timer.UseCustomBackColor = true;
                Timer.BackColor = Color.Pink;
                Timer.TextAlign = ContentAlignment.MiddleCenter;
                Timer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            }
            if (count > 59)
            {
                int minute = count / 60;
                int second = count - (minute * 60);
                Timer.Text = DateTime.Now.ToLongTimeString() + "\r\n" + $"{minute}분 {second}초 경과";
            }
            else
            {
                Timer.Text = DateTime.Now.ToLongTimeString() + "\r\n" + count + "초 경과";
            }
            if (count > 20) //타일 색 깜빡임
            {
                if(count % 2 == 0)
                {
                    Timer.BackColor = Color.DeepPink;
                }
                else
                {
                    Timer.BackColor = Color.Pink;
                }
            }

            if(count > 30)
            { 
                Console.Beep();

                Timer.UseTileImage = true;
                timerFlag = 0;
                count = 0;
                timer.Tick -= timer_Tick;
                timer.Stop();
                Timer.TextAlign = ContentAlignment.BottomLeft;
                Timer.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
                Timer.Text = "Rest Timer";
                Timer.UseCustomBackColor = false;
            }
        }

        private void Net_Click(object sender, EventArgs e)
        {
            if(((MetroTile)sender).Name == "Google")
            {
                arg = "http://www.google.co.kr";
            }
            else
            {
                arg = "http://www.youtube.co.kr";
            }

            using(Process myProcess = new Process())
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application.chrome.exe";
                myProcess.StartInfo.Arguments = arg;
                myProcess.Start();
            }
        }

        private void Exe_Click(object sender, EventArgs e)
        {
            if(((MetroTile)sender).Name == "NotePad")
            {
                filename = "notepad.exe";
            }
            else if (((MetroTile)sender).Name == "Calc")
            {
                filename = "calc.exe";
            }

            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = filename;
                myProcess.Start();
            }
        }

        private void Path_Click(object sender, EventArgs e)
        {
            if (((MetroTile)sender).Name == "Download")
            {
                filename = @"C:\Users\Junho0322\Downloads";
            }
            else if (((MetroTile)sender).Name == "Local")
            {
                filename = @"C:\";
            }

            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = filename;
                myProcess.Start();
            }
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^+{ESC}");
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList tiles = new ArrayList();
            tiles.Add(Timer);
            tiles.Add(TaskManager);
            tiles.Add(News);
            tiles.Add(Download);
            tiles.Add(Local);
            tiles.Add(Google);
            tiles.Add(Youtube);
            tiles.Add(NotePad);
            tiles.Add(Calc);

            switch (metroComboBox3.SelectedIndex)
            {
                case 0:
                    foreach(MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Black;
                    }
                    break;
                case 1:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.White;
                    }
                    break;
                case 2:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Blue;
                    }
                    break;
                case 3:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Purple;
                    }
                    break;
                case 4:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Red;
                    }
                    break;
            }

        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("chromedriver");
            foreach(Process proc in procs)
            {
                proc.Kill();
            }
        }
    }
}
