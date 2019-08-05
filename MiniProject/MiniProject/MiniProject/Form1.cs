using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        private List<PictureBox> ballList = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            Ball.Visible = false;
        }
      
        private void BallLocationSet(PictureBox ball)
        {
            Random rnd = new Random();
            ball.Location = new Point(rnd.Next(0, this.ClientSize.Width - ball.Width), rnd.Next(0, this.ClientSize.Height - ball.Height));
        }
        private Point Generator()
        {
            Random rnd = new Random();
            Point point = new Point(rnd.Next(0, this.ClientSize.Width), rnd.Next(0, this.ClientSize.Height));
            return point;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Ball.Visible = true;
            ballList.Add(Ball);
            BallLocationSet(Ball);
            moving(0);
        }
        public async void moving(int index)
        {
            int dx =1,dy= 1;          
            await Task.Run(() =>
            {
                while (true)
                {
                    if (ballList[index].Location.X + dx + ballList[index].Width > this.ClientSize.Width && ballList[index].Location.Y + dy + ballList[index].Height < this.ClientSize.Height)
                    {
                        dx = -1;
                        ballList[index].Location = new Point(this.ballList[index].Location.X + dx, this.ballList[index].Location.Y + dy);
                    }
                    if (ballList[index].Location.Y + dy + ballList[index].Height > this.ClientSize.Height)
                    {
                        dy = -1;
                        ballList[index].Location = new Point(this.ballList[index].Location.X + dx, this.ballList[index].Location.Y + dy);
                    }
                    if(ballList[index].Location.Y+dy<0)
                    {
                        dy = 1;
                        ballList[index].Location = new Point(this.ballList[index].Location.X + dx, this.ballList[index].Location.Y + dy);
                    }
                    if(ballList[index].Location.X+dx<0)
                    {
                        dx = 1;
                        ballList[index].Location = new Point(this.ballList[index].Location.X + dx, this.ballList[index].Location.Y + dy);
                    }
                    ballList[index].Location = new Point(this.ballList[index].Location.X + dx, this.ballList[index].Location.Y + dy);
                    Thread.Sleep(20);
                }
            });
        }
        private void addBallBtn_Click(object sender, EventArgs e)
        {
            ballList.Add(ImageCreator());
            for (int i = 0; i < ballList.Count(); i++)
            {
                moving(i);
            }
        }
        public PictureBox ImageCreator()
        {
            PictureBox p = new PictureBox()
            {
                Size = new Size(225, 225),
                Location = Generator(),
                Image = Image.FromFile(@"C:\Users\talpr\.dotnet\Mini Project - UI Thread\MiniProject\BALL.jpg")
            };
            BallLocationSet(p);
            this.Controls.Add(p);
            return p;
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
