using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取主屏幕信息
            Data.PrimaryScreen = Screen.PrimaryScreen;

            //定义大小
            Size = new Size(300, 200);

            //居中显示
            Location = new Point((Data.PrimaryScreen.Bounds.Width - Size.Width) / 2, (Data.PrimaryScreen.Bounds.Height - Size.Height) / 2);
            LoadForm();
        }
        private void LoadForm()
        {
            //挂起控件
            SuspendLayout();

            //清空控件
            Controls.Clear();

            Data.Button_ProjectNew = new Button
            {
                Text = "新建项目",
                Size = new Size(100, 30),
                Location = new Point(90, 40)
            };
            Data.Button_ProjectNew.MouseClick += new MouseEventHandler(ProjectNew_MouseClick);

            Data.Button_ProjectOpen = new Button
            {
                Text = "打开项目",
                Size = new Size(100, 30),
                Location = new Point(90, 85)
            };
            Data.Button_ProjectOpen.MouseClick += new MouseEventHandler(ProjectOpen_MouseClick);

            //添加控件
            Controls.Add(Data.Button_ProjectNew);
            Controls.Add(Data.Button_ProjectOpen);

            //加载控件
            ResumeLayout(false);
        }

        private void ProjectNew_MouseClick(object sender, MouseEventArgs e)
        {
            //挂起控件
            SuspendLayout();

            //清空控件
            Controls.Clear();

            Data.TextBox_ProjectName = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(70, 60)
            };

            Data.Button_ProjectNewOk = new Button
            {
                Text = "确定",
                Size = new Size(70, 30),
                Location = new Point(200, 100)
            };
            Data.Button_ProjectNewOk.MouseClick += new MouseEventHandler(ProjectNewOk_MouseClick);

            Data.Button_ProjectNewBack = new Button
            {
                Text = "返回",
                Size = new Size(70, 30),
                Location = new Point(120, 100)
            };
            Data.Button_ProjectNewBack.MouseClick += new MouseEventHandler(ProjectNewBack_MouseClick);

            Controls.Add(Data.TextBox_ProjectName);
            Controls.Add(Data.Button_ProjectNewOk);
            Controls.Add(Data.Button_ProjectNewBack);

            //加载控件
            ResumeLayout(false);
        }
        private void ProjectOpen_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void ProjectNewOk_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void ProjectNewBack_MouseClick(object sender, MouseEventArgs e)
        {
            LoadForm();
        }
    }
}
