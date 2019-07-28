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
        private Action action;
        private int index;
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
        private int BallBoundaries(Point point,int index) // dx, dy = if =1  - > moving to the opposite side 
                                                     // else if = -1     -> moving to the negative side.
        {
            int dx=0, dy=0;
            // Boundaries //
            if (ballList[index].Location.X + point.X + Ball.Width > this.ClientSize.Width)
            {
                dx = -1;
                return dx;
            }
            if (ballList[index].Location.Y + point.Y + Ball.Height > this.ClientSize.Height)
            { 
                dy = -1;
                return dy;
            } 
            if (ballList[index].Location.X - point.X > ballList[index].Location.X)
            {
                dx = 1;
                return dx;
            }
            if (ballList[index].Location.Y - point.Y > ballList[index].Location.Y)
            {
                dy = 1;
                return dy;
            }
            return 0;
        }
        private void BallLocationSet(PictureBox ball)
        {
            Random rnd = new Random();
            ball.Location = new Point(rnd.Next(0, this.ClientSize.Width - ball.Width), rnd.Next(0, this.ClientSize.Height - ball.Height));
        }
        private void BallMovement(Point point,int index)
        {

            if (BallBoundaries(point,index) == -1 || BallBoundaries(point, index) == 1)
            {
            }
            else
            {
               ballList[ballList.LastIndexOf(ballList.Last())].Location = Generator();
            }
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
            startBtn.Visible = false;
            index = 0;
            ballList.Add(Ball);
            BallLocationSet(Ball);
            tasking();
            index++;
        }
        private async void tasking()
        {
            while (true)
            {
                BallMovement(Generator(), 0);
                await Task.Run(() =>
                {
                   BallMovement(Generator(), ballList.LastIndexOf(this.ballList.Last()));
                   Thread.Sleep(10);
                });

            }
        }

        private void addBallBtn_Click(object sender, EventArgs e)
        {
            ballList.Add(ImageCreator());
            index++;
            Task.Run(() =>
            {
                while (true)
                {
                    Action a = ()=>BallMovement(Generator(), index);
                    ballList[index].BeginInvoke(a);
                    Thread.Sleep(10);
                }

            });
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
        
    }
}
