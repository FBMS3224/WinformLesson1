using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 800;

            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }

        private void MouseClickAndStopTimer(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer.Stop();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Error");
            }
        }

        private void MouseClickAndStartTimer(object sender, MouseEventArgs e)
        {
            timer.Start();
        }

        private void Btn_Stop_timer_Click(object sender, EventArgs e)
        {
            var mouse = e as MouseEventArgs;
            if (mouse.Button == MouseButtons.Left)
            {
                timer.Stop();
            }
            else if (mouse.Button == MouseButtons.Right)
            {
                MessageBox.Show("Error");
            }
        }


        bool isCheck = true;
        private void button1_Click(object sender, EventArgs e)
        {

            //this.BackColor = SystemColors.ControlDark;
            //BackColor = Color.Pink;

            //BackColor = Color.FromArgb(0, 0, 0);

            // ------------------------------------------
            // way 2
            //Random random = new Random();
            //int r = random.Next(0, 255);
            //int g = random.Next(0, 255);
            //int b = random.Next(0, 255);

            //BackColor = Color.FromArgb(r, g, b);

            //label1.Text = BackColor.ToString();


            // -----------------------------------------
            //if (isCheck)
            //{
            //    this.BackColor = Color.FromName("red");
            //    isCheck = false;
            //}
            //else
            //{
            //    BackColor = Color.LightGray;
            //    isCheck = true;
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Salam");
            //MessageBox.Show("Salam","Header");
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.YesNo);
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.OKCancel);
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.RetryCancel);
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.CancelTryContinue,MessageBoxIcon.Information);
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.CancelTryContinue,MessageBoxIcon.Warning);
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.CancelTryContinue,MessageBoxIcon.Question);
            //DialogResult netice =  MessageBox.Show("Salam","Header",MessageBoxButtons.CancelTryContinue,MessageBoxIcon.Asterisk);
            DialogResult netice = MessageBox.Show("Salam", "Header", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Exclamation);

            label2.Text = netice.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button mybutton = new Button();
            mybutton.Text = "Step";
            mybutton.BackColor = Color.Red;
            mybutton.Size = new Size(100, 50);
            mybutton.Location = new Point(650, 100);

            this.Controls.Add(mybutton);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackgroundImage = Resources._1000076408;

            

        }
    }
}