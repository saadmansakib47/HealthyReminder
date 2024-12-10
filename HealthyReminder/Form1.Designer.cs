namespace HealthyReminder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            StartTimeTextBox = new TextBox();
            EndTimeTextBox = new TextBox();
            HydrationTextBox = new TextBox();
            WalkingTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Start time :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 64);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "End time :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.CausesValidation = false;
            label3.Location = new Point(45, 92);
            label3.Name = "label3";
            label3.Size = new Size(174, 15);
            label3.TabIndex = 2;
            label3.Text = "Hydration Reminder (Minutes) :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.CausesValidation = false;
            label4.Location = new Point(55, 121);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 3;
            label4.Text = "Walking Reminder (Minutes) :";
            label4.Click += label4_Click;
            // 
            // StartTimeTextBox
            // 
            StartTimeTextBox.Location = new Point(225, 34);
            StartTimeTextBox.Name = "StartTimeTextBox";
            StartTimeTextBox.Size = new Size(100, 23);
            StartTimeTextBox.TabIndex = 4;
            StartTimeTextBox.TextChanged += StartTimeTextBox_TextChanged;
            // 
            // EndTimeTextBox
            // 
            EndTimeTextBox.Location = new Point(225, 61);
            EndTimeTextBox.Name = "EndTimeTextBox";
            EndTimeTextBox.Size = new Size(100, 23);
            EndTimeTextBox.TabIndex = 5;
            EndTimeTextBox.TextChanged += EndTimeTextBox_TextChanged;
            // 
            // HydrationTextBox
            // 
            HydrationTextBox.Location = new Point(225, 90);
            HydrationTextBox.Name = "HydrationTextBox";
            HydrationTextBox.Size = new Size(100, 23);
            HydrationTextBox.TabIndex = 6;
            HydrationTextBox.TextChanged += HydrationTextBox_TextChanged;
            // 
            // WalkingTextBox
            // 
            WalkingTextBox.Location = new Point(225, 118);
            WalkingTextBox.Name = "WalkingTextBox";
            WalkingTextBox.Size = new Size(100, 23);
            WalkingTextBox.TabIndex = 7;
            WalkingTextBox.TextChanged += WalkingTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(452, 224);
            Controls.Add(WalkingTextBox);
            Controls.Add(HydrationTextBox);
            Controls.Add(EndTimeTextBox);
            Controls.Add(StartTimeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox StartTimeTextBox;
        private TextBox EndTimeTextBox;
        private TextBox HydrationTextBox;
        private TextBox WalkingTextBox;
    }
}