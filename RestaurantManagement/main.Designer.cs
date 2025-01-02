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
            customerBtn = new Button();
            staffBtn = new Button();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1615, 731);
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
            // customerBtn
            // 
            customerBtn.BackColor = SystemColors.Window;
            customerBtn.BackgroundImageLayout = ImageLayout.Center;
            customerBtn.FlatStyle = FlatStyle.Popup;
            customerBtn.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            customerBtn.Location = new Point(620, 839);
            customerBtn.Name = "customerBtn";
            customerBtn.Size = new Size(276, 69);
            customerBtn.TabIndex = 10;
            customerBtn.Text = "CUSTOMER";
            customerBtn.UseVisualStyleBackColor = false;
            customerBtn.Click += customerBtn_Click;
            // 
            // staffBtn
            // 
            staffBtn.BackColor = SystemColors.Window;
            staffBtn.BackgroundImageLayout = ImageLayout.Center;
            staffBtn.FlatStyle = FlatStyle.Popup;
            staffBtn.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            staffBtn.Location = new Point(946, 839);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(276, 69);
            staffBtn.TabIndex = 11;
            staffBtn.Text = "STAFF";
            staffBtn.UseVisualStyleBackColor = false;
            staffBtn.Click += staffBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = SystemColors.Window;
            logoutBtn.BackgroundImageLayout = ImageLayout.Center;
            logoutBtn.FlatStyle = FlatStyle.Popup;
            logoutBtn.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.Location = new Point(1272, 839);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(276, 69);
            logoutBtn.TabIndex = 12;
            logoutBtn.Text = "LOG OUT";
            logoutBtn.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 950);
            Controls.Add(logoutBtn);
            Controls.Add(staffBtn);
            Controls.Add(customerBtn);
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
        private Button customerBtn;
        private Button staffBtn;
        private Button logoutBtn;
    }
}