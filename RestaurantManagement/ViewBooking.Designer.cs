namespace RestaurantManagement
{
    partial class ViewBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooking));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bookingName = new Label();
            BeverageItem = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(bookingName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2310, 132);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2176, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 81);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // bookingName
            // 
            bookingName.AutoSize = true;
            bookingName.Font = new Font("Perpetua Titling MT", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bookingName.ForeColor = SystemColors.ButtonFace;
            bookingName.Location = new Point(73, 49);
            bookingName.Name = "bookingName";
            bookingName.Size = new Size(444, 64);
            bookingName.TabIndex = 9;
            bookingName.Text = "VIEW BOOKING";
            // 
            // BeverageItem
            // 
            BeverageItem.AutoSize = true;
            BeverageItem.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BeverageItem.Location = new Point(992, 176);
            BeverageItem.Name = "BeverageItem";
            BeverageItem.Size = new Size(316, 48);
            BeverageItem.TabIndex = 15;
            BeverageItem.Text = "BOOKING LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(73, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(2188, 913);
            dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(680, 1212);
            button1.Name = "button1";
            button1.Size = new Size(297, 66);
            button1.TabIndex = 31;
            button1.Text = "DELETE BOOKING";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1324, 1212);
            button2.Name = "button2";
            button2.Size = new Size(297, 66);
            button2.TabIndex = 32;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            // 
            // ViewBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(BeverageItem);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += ViewBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label bookingName;
        private Label BeverageItem;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}