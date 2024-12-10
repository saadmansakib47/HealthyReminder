namespace HealthyReminder
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer hydrationTimer;
        private System.Timers.Timer walkingTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionally kept the app visible during testing
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int startHour = int.Parse(StartTimeTextBox.Text);
                int endHour = int.Parse(EndTimeTextBox.Text);
                int hydrationMinute = int.Parse(HydrationTextBox.Text);
                int walkingMinute = int.Parse(WalkingTextBox.Text);

                if (startHour < 0 || startHour > 23 || endHour < 0 || endHour > 23)
                {
                    MessageBox.Show("Please enter valid start and end hours (0-23).");
                    return;
                }
                if (hydrationMinute < 0 || hydrationMinute > 59 || walkingMinute < 0 || walkingMinute > 59)
                {
                    MessageBox.Show("Please enter valid reminder minutes (0-59).");
                    return;
                }

                hydrationTimer = new System.Timers.Timer(60 * 1000); 
                hydrationTimer.Elapsed += (s, ev) =>
                    CheckReminder(startHour, endHour, hydrationMinute, "Time to hydrate yourself!");

                walkingTimer = new System.Timers.Timer(60 * 1000); 
                walkingTimer.Elapsed += (s, ev) =>
                    CheckReminder(startHour, endHour, walkingMinute, "Time to take a walk!");

                hydrationTimer.Start();
                walkingTimer.Start();

                MessageBox.Show("Reminders started successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CheckReminder(int startHour, int endHour, int targetMinute, string message)
        {
            var now = DateTime.Now;

            if (now.Hour >= startHour && now.Hour < endHour && now.Minute == targetMinute)
            {
                ShowNotification(message);
            }
        }

        private void ShowNotification(string message)
        {
            using (NotifyIcon notifyIcon = new NotifyIcon())
            {
                notifyIcon.Visible = true;
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.BalloonTipTitle = "Healthy Reminder";
                notifyIcon.BalloonTipText = message;
                notifyIcon.ShowBalloonTip(5000); 
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void HydrationTextBox_TextChanged(object sender, EventArgs e) { }
        private void WalkingTextBox_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void StartTimeTextBox_TextChanged(object sender, EventArgs e) { }
        private void EndTimeTextBox_TextChanged(object sender, EventArgs e) { }
    }
}
