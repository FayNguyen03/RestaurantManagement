namespace RestaurantManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            BookingBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1600, 800);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BookingBtn
            // 
            BookingBtn.BackColor = SystemColors.Window;
            BookingBtn.BackgroundImageLayout = ImageLayout.Center;
            BookingBtn.FlatStyle = FlatStyle.Popup;
            BookingBtn.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            BookingBtn.Location = new Point(300, 839);
            BookingBtn.Name = "BookingBtn";
            BookingBtn.Size = new Size(276, 69);
            BookingBtn.TabIndex = 9;
            BookingBtn.Text = "BOOKING";
            BookingBtn.UseVisualStyleBackColor = false;
            BookingBtn.Click += BookingBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(620, 839);
            button2.Name = "button2";
            button2.Size = new Size(276, 69);
            button2.TabIndex = 10;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(946, 839);
            button3.Name = "button3";
            button3.Size = new Size(276, 69);
            button3.TabIndex = 11;
            button3.Text = "LOGIN";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1272, 839);
            button4.Name = "button4";
            button4.Size = new Size(276, 69);
            button4.TabIndex = 12;
            button4.Text = "LOGIN";
            button4.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 950);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BookingBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "main";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BookingBtn;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}