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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bookingName = new Label();
            BeverageItem = new Label();
            button1 = new Button();
            button2 = new Button();
            BookingDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookingDGV).BeginInit();
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
            pictureBox1.Click += pictureBox1_Click;
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
            // BookingDGV
            // 
            BookingDGV.AllowUserToOrderColumns = true;
            BookingDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookingDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            BookingDGV.BackgroundColor = SystemColors.ButtonFace;
            BookingDGV.BorderStyle = BorderStyle.None;
            BookingDGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            BookingDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BookingDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BookingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BookingDGV.DefaultCellStyle = dataGridViewCellStyle2;
            BookingDGV.GridColor = SystemColors.Control;
            BookingDGV.Location = new Point(75, 244);
            BookingDGV.Name = "BookingDGV";
            BookingDGV.ReadOnly = true;
            BookingDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BookingDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BookingDGV.RowHeadersVisible = false;
            BookingDGV.RowHeadersWidth = 82;
            BookingDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BookingDGV.RowTemplate.Height = 41;
            BookingDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingDGV.Size = new Size(2160, 935);
            BookingDGV.TabIndex = 52;
            BookingDGV.CellContentClick += BookingDGV_CellContentClick;
            // 
            // ViewBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(BookingDGV);
            Controls.Add(button2);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)BookingDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label bookingName;
        private Label BeverageItem;
        private Button button1;
        private Button button2;
        private DataGridView BookingDGV;
    }
}