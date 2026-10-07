namespace TAH.Widgets.UI
{
    public partial class FrmWidgets : Form
    {
        public FrmWidgets()
        {
            InitializeComponent();
        }
        string strSS = "00";
        string strMM = "00";
        string strHH = "00";
        string strDD = "00";

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number = Random.Shared.Next(1, 11);
            lblResult.Text = number.ToString();

            if (number >= 8)
            {
                lblMessage.Text = "You Win!";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Try Again!";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            int x = Random.Shared.Next(0, ClientSize.Width - btnCatchMe.Width);
            int y = Random.Shared.Next(0, ClientSize.Height - btnCatchMe.Height);

            btnCatchMe.Left = x;
            btnCatchMe.Top = y;
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            DateTime christmas = new DateTime(2026, 12, 25, 0, 0, 0);
            TimeSpan timeLeft = christmas - DateTime.Now;

            if (timeLeft.Seconds < 10)
            {
                strSS = "0" + timeLeft.Seconds.ToString();
            }
            else
            {
                strSS = timeLeft.Seconds.ToString();
            }
            
            if (timeLeft.Minutes < 10)
            {
                strMM = "0" + timeLeft.Minutes.ToString();
            }
            else
            {
                strMM = timeLeft.Minutes.ToString();
            }

            if (timeLeft.Hours < 10)
            {
                strHH = "0" + timeLeft.Hours.ToString();
            }
            else
            {
                strHH = timeLeft.Hours.ToString();
            }

            if (timeLeft.Days < 10)
            {
                strDD = "0" + timeLeft.Days.ToString();
            }
            else
            {
                strDD = timeLeft.Days.ToString();
            }

            lblTimer.Text = $"{strDD}:{strHH}:{strMM}:{strSS}";

            if (lblTimer.Text == "00:00:00:00")
            {
                lblTimerCaption2.Text = "Merry Christmas!";
                lblTimerCaption2.Location = new Point(290, 360);
            }

            if (lblTimer.Text == "00:00:0-1:00")
            {
                lblTimerCaption2.Text = "Christmas 2026 is over!";
                lblTimerCaption2.Location = new Point(260, 360);
            }

            if (lblTimerCaption2.ForeColor != Color.Red)
            {
                lblTimerCaption2.ForeColor = Color.Green;
            }
            else
            {
                lblTimerCaption2.ForeColor = Color.Red;
            }
        }
    }
}
