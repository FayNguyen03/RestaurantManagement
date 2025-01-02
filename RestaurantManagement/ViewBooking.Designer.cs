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
            deleteBtn = new Button();
            resetBtn = new Button();
            BookingDGV = new DataGridView();
            addBtn = new Button();
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
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.Window;
            deleteBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Location = new Point(973, 1212);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(297, 66);
            deleteBtn.TabIndex = 31;
            deleteBtn.Text = "DELETE BOOKING";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.Window;
            resetBtn.BackgroundImageLayout = ImageLayout.Center;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(1546, 1212);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(297, 66);
            resetBtn.TabIndex = 32;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
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
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Window;
            addBtn.BackgroundImageLayout = ImageLayout.Center;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(427, 1212);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(297, 66);
            addBtn.TabIndex = 53;
            addBtn.Text = "INSERT BOOKING";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // ViewBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(addBtn);
            Controls.Add(BookingDGV);
            Controls.Add(resetBtn);
            Controls.Add(deleteBtn);
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
        private Button deleteBtn;
        private Button resetBtn;
        private DataGridView BookingDGV;
        private Button addBtn;
    }
}