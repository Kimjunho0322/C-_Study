
namespace MetroUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.News = new MetroFramework.Controls.MetroTile();
            this.Local = new MetroFramework.Controls.MetroTile();
            this.TaskManager = new MetroFramework.Controls.MetroTile();
            this.Google = new MetroFramework.Controls.MetroTile();
            this.Youtube = new MetroFramework.Controls.MetroTile();
            this.NotePad = new MetroFramework.Controls.MetroTile();
            this.Calc = new MetroFramework.Controls.MetroTile();
            this.Download = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.Timer = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(65, 22);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(580, 26);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel2.TabIndex = 0;
            this.htmlLabel2.Text = "THEME : ";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(60, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(580, 61);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "COLOR :";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(51, 22);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(580, 96);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel3.TabIndex = 2;
            this.htmlLabel3.Text = "FONT :";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.metroComboBox1.Location = new System.Drawing.Point(652, 20);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Deafult",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red"});
            this.metroComboBox2.Location = new System.Drawing.Point(652, 55);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 4;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(652, 90);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox3.TabIndex = 5;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // News
            // 
            this.News.ActiveControl = null;
            this.News.Location = new System.Drawing.Point(33, 275);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(140, 140);
            this.News.TabIndex = 7;
            this.News.Text = "News Crawler";
            this.News.TileImage = ((System.Drawing.Image)(resources.GetObject("News.TileImage")));
            this.News.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.News.UseSelectable = true;
            this.News.UseTileImage = true;
            this.News.Click += new System.EventHandler(this.News_Click);
            // 
            // Local
            // 
            this.Local.ActiveControl = null;
            this.Local.Location = new System.Drawing.Point(246, 305);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(110, 110);
            this.Local.TabIndex = 9;
            this.Local.Text = "Local";
            this.Local.TileImage = ((System.Drawing.Image)(resources.GetObject("Local.TileImage")));
            this.Local.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Local.UseSelectable = true;
            this.Local.UseTileImage = true;
            // 
            // TaskManager
            // 
            this.TaskManager.ActiveControl = null;
            this.TaskManager.Location = new System.Drawing.Point(362, 305);
            this.TaskManager.Name = "TaskManager";
            this.TaskManager.Size = new System.Drawing.Size(110, 110);
            this.TaskManager.TabIndex = 10;
            this.TaskManager.Text = "TaskManager";
            this.TaskManager.TileImage = ((System.Drawing.Image)(resources.GetObject("TaskManager.TileImage")));
            this.TaskManager.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TaskManager.UseSelectable = true;
            this.TaskManager.UseTileImage = true;
            this.TaskManager.Click += new System.EventHandler(this.TaskManager_Click);
            // 
            // Google
            // 
            this.Google.ActiveControl = null;
            this.Google.Location = new System.Drawing.Point(539, 140);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(100, 100);
            this.Google.TabIndex = 11;
            this.Google.Text = "Google";
            this.Google.TileImage = ((System.Drawing.Image)(resources.GetObject("Google.TileImage")));
            this.Google.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Google.UseSelectable = true;
            this.Google.UseTileImage = true;
            // 
            // Youtube
            // 
            this.Youtube.ActiveControl = null;
            this.Youtube.Location = new System.Drawing.Point(645, 140);
            this.Youtube.Name = "Youtube";
            this.Youtube.Size = new System.Drawing.Size(100, 100);
            this.Youtube.TabIndex = 12;
            this.Youtube.Text = "Youtube";
            this.Youtube.TileImage = ((System.Drawing.Image)(resources.GetObject("Youtube.TileImage")));
            this.Youtube.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Youtube.UseSelectable = true;
            this.Youtube.UseTileImage = true;
            // 
            // NotePad
            // 
            this.NotePad.ActiveControl = null;
            this.NotePad.Location = new System.Drawing.Point(539, 246);
            this.NotePad.Name = "NotePad";
            this.NotePad.Size = new System.Drawing.Size(100, 100);
            this.NotePad.TabIndex = 13;
            this.NotePad.Text = "NotePad";
            this.NotePad.TileImage = ((System.Drawing.Image)(resources.GetObject("NotePad.TileImage")));
            this.NotePad.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NotePad.UseSelectable = true;
            this.NotePad.UseTileImage = true;
            // 
            // Calc
            // 
            this.Calc.ActiveControl = null;
            this.Calc.Location = new System.Drawing.Point(645, 246);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(100, 100);
            this.Calc.TabIndex = 14;
            this.Calc.Text = "Calc";
            this.Calc.TileImage = ((System.Drawing.Image)(resources.GetObject("Calc.TileImage")));
            this.Calc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Calc.UseSelectable = true;
            this.Calc.UseTileImage = true;
            // 
            // Download
            // 
            this.Download.ActiveControl = null;
            this.Download.Location = new System.Drawing.Point(246, 189);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(110, 110);
            this.Download.TabIndex = 8;
            this.Download.Text = "Download";
            this.Download.TileImage = ((System.Drawing.Image)(resources.GetObject("Download.TileImage")));
            this.Download.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Download.UseSelectable = true;
            this.Download.UseTileImage = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Timer
            // 
            this.Timer.ActiveControl = null;
            this.Timer.Location = new System.Drawing.Point(33, 125);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(140, 140);
            this.Timer.TabIndex = 15;
            this.Timer.Text = "Rest Timer";
            this.Timer.TileImage = ((System.Drawing.Image)(resources.GetObject("Timer.TileImage")));
            this.Timer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Timer.UseSelectable = true;
            this.Timer.UseTileImage = true;
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.NotePad);
            this.Controls.Add(this.Youtube);
            this.Controls.Add(this.Google);
            this.Controls.Add(this.TaskManager);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.News);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Name = "Form1";
            this.Text = "TaskManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroTile News;
        private MetroFramework.Controls.MetroTile Download;
        private MetroFramework.Controls.MetroTile Local;
        private MetroFramework.Controls.MetroTile TaskManager;
        private MetroFramework.Controls.MetroTile Google;
        private MetroFramework.Controls.MetroTile Youtube;
        private MetroFramework.Controls.MetroTile NotePad;
        private MetroFramework.Controls.MetroTile Calc;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTile Timer;
    }
}

