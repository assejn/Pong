namespace Pongerino
{
    public partial class Form1 : Form
    {
        bool p1Up = false;
        bool p1Down = false;
        bool p2Up = false;
        bool p2Down = false;

        int playerOneScore = 0;
        int playerTwoScore = 0;
        int vertical_start_speed = 3;
        int horizontal_start_speed = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1Up = true;
                timer1.Start();
            }
            else if (e.KeyCode == Keys.S)
            {
                p1Down = true;
                timer1.Start();
            }           
            else if (e.KeyCode == Keys.Up)
            {
                p2Up = true;
                timer2.Start();
            }
            else if (e.KeyCode == Keys.Down)
            {
                p2Down = true;
                timer2.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1Up = false;
                timer1.Stop();
            }
            else if (e.KeyCode == Keys.S)
            {
                p1Down = false;
                timer1.Stop();
            }
            else if (e.KeyCode == Keys.Up)
            {
                p2Up = false;
                timer2.Stop();
            }
            else if (e.KeyCode == Keys.Down)
            {
                p2Down = false;
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p1Up && PlayerOne.Location.Y > 3) // 3 fits the distance from top to player best
            {
                PlayerOne.Top -= 9; // paddle move speed
            }
            else if (p1Down && PlayerOne.Location.Y < ClientSize.Height - PlayerOne.Height) // dynamic bottom border
            {
                PlayerOne.Top += 9;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (p2Up && PlayerTwo.Location.Y > 3)
            {
                PlayerTwo.Top -= 9;
            }
            else if (p2Down && PlayerTwo.Location.Y < ClientSize.Height - PlayerTwo.Height)
            {
                PlayerTwo.Top += 9;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Ball.Top -= vertical_start_speed;
            Ball.Left -= horizontal_start_speed;

            if (Ball.Left < 0)
            {
                Ball.Left = ClientSize.Width / 2;
                Ball.Top = ClientSize.Height / 2;
                horizontal_start_speed = 3;
                vertical_start_speed = 3;
                horizontal_start_speed = -horizontal_start_speed; // invert trajectory
                playerTwoScore++;
                label2.Text = playerTwoScore.ToString();
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = ClientSize.Width / 2;
                Ball.Top = ClientSize.Height / 2;
                horizontal_start_speed = 3;
                vertical_start_speed = 3;
                horizontal_start_speed = -horizontal_start_speed;
                playerOneScore++;
                label1.Text = playerOneScore.ToString();
            }

            if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
            {
                vertical_start_speed = -vertical_start_speed;
            }

            if (Ball.Bounds.IntersectsWith(PlayerOne.Bounds)) // if ball hits player
            {
                horizontal_start_speed = -horizontal_start_speed;
                horizontal_start_speed -= 2;
                
                if(vertical_start_speed > 0) // check vertical trajectory
                {
                    vertical_start_speed += 2;
                }
                else
                {
                    vertical_start_speed -= 2;
                }
            }

            else if (Ball.Bounds.IntersectsWith(PlayerTwo.Bounds))
            {
                horizontal_start_speed = -horizontal_start_speed;
                horizontal_start_speed += 2;

                if (vertical_start_speed > 0)
                {
                    vertical_start_speed += 2;
                }
                else
                {
                    vertical_start_speed -= 2;
                }
            }
        }
    }
}