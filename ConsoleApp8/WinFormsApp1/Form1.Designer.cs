namespace WinFormsApp1
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            Btn_Stop_timer = new Button();
            StartTimerBTBN = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // Btn_Stop_timer
            // 
            Btn_Stop_timer.Location = new Point(126, 88);
            Btn_Stop_timer.Name = "Btn_Stop_timer";
            Btn_Stop_timer.Size = new Size(75, 23);
            Btn_Stop_timer.TabIndex = 0;
            Btn_Stop_timer.Text = "Stop timer";
            Btn_Stop_timer.UseVisualStyleBackColor = true;
            Btn_Stop_timer.Click += Btn_Stop_timer_Click;
            Btn_Stop_timer.MouseClick += MouseClickAndStopTimer;
            // 
            // StartTimerBTBN
            // 
            StartTimerBTBN.Location = new Point(222, 88);
            StartTimerBTBN.Name = "StartTimerBTBN";
            StartTimerBTBN.Size = new Size(75, 23);
            StartTimerBTBN.TabIndex = 2;
            StartTimerBTBN.Text = "Start Timer";
            StartTimerBTBN.UseVisualStyleBackColor = true;
            StartTimerBTBN.MouseClick += MouseClickAndStartTimer;
            // 
            // button1
            // 
            button1.Location = new Point(352, 88);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 168);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(149, 334);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 338);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // button3
            // 
            button3.Location = new Point(193, 216);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackgroundImage = Properties.Resources.Flag_map_of_Azerbaijan;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(442, 72);
            button4.Name = "button4";
            button4.Size = new Size(346, 331);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(StartTimerBTBN);
            Controls.Add(Btn_Stop_timer);
            Name = "Form1";
            Text = "Form1";
            Load += Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Stop_timer;
        private Button StartTimerBTBN;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}