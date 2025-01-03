namespace RestaurantManagement
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bookingName = new Label();
            StaffPhone = new TextBox();
            personNo = new Label();
            StaffGender = new ComboBox();
            timeName = new Label();
            StaffName = new TextBox();
            label1 = new Label();
            StaffPass = new TextBox();
            label2 = new Label();
            StaffListName = new Label();
            editBtn = new Button();
            addBtn = new Button();
            resetBtn = new Button();
            deleteBtn = new Button();
            StaffDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StaffDGV).BeginInit();
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
            panel1.TabIndex = 3;
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
            bookingName.Size = new Size(181, 64);
            bookingName.TabIndex = 9;
            bookingName.Text = "staff";
            // 
            // StaffPhone
            // 
            StaffPhone.Location = new Point(818, 173);
            StaffPhone.Multiline = true;
            StaffPhone.Name = "StaffPhone";
            StaffPhone.Size = new Size(354, 52);
            StaffPhone.TabIndex = 16;
            // 
            // personNo
            // 
            personNo.AutoSize = true;
            personNo.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            personNo.Location = new Point(561, 179);
            personNo.Name = "personNo";
            personNo.Size = new Size(251, 34);
            personNo.TabIndex = 15;
            personNo.Text = "PHONE NUMBER";
            // 
            // StaffGender
            // 
            StaffGender.FormattingEnabled = true;
            StaffGender.ItemHeight = 32;
            StaffGender.Items.AddRange(new object[] { "Male", "Female" });
            StaffGender.Location = new Point(1378, 178);
            StaffGender.Name = "StaffGender";
            StaffGender.Size = new Size(241, 40);
            StaffGender.TabIndex = 14;
            // 
            // timeName
            // 
            timeName.AutoSize = true;
            timeName.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            timeName.Location = new Point(1217, 179);
            timeName.Name = "timeName";
            timeName.Size = new Size(134, 34);
            timeName.TabIndex = 13;
            timeName.Text = "GENDER";
            // 
            // StaffName
            // 
            StaffName.Location = new Point(128, 173);
            StaffName.Multiline = true;
            StaffName.Name = "StaffName";
            StaffName.Size = new Size(392, 52);
            StaffName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 179);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 17;
            label1.Text = "NAME";
            // 
            // StaffPass
            // 
            StaffPass.Location = new Point(1879, 173);
            StaffPass.Multiline = true;
            StaffPass.Name = "StaffPass";
            StaffPass.Size = new Size(382, 52);
            StaffPass.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1684, 179);
            label2.Name = "label2";
            label2.Size = new Size(176, 34);
            label2.TabIndex = 19;
            label2.Text = "PASSWORD";
            // 
            // StaffListName
            // 
            StaffListName.AutoSize = true;
            StaffListName.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StaffListName.Location = new Point(992, 412);
            StaffListName.Name = "StaffListName";
            StaffListName.Size = new Size(237, 48);
            StaffListName.TabIndex = 21;
            StaffListName.Text = "STAFF LIST";
            // 
            // editBtn
            // 
            editBtn.BackColor = SystemColors.Window;
            editBtn.BackgroundImageLayout = ImageLayout.Center;
            editBtn.FlatStyle = FlatStyle.Popup;
            editBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Location = new Point(776, 287);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(297, 66);
            editBtn.TabIndex = 34;
            editBtn.Text = "edit staff";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Window;
            addBtn.BackgroundImageLayout = ImageLayout.Center;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(322, 287);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(297, 66);
            addBtn.TabIndex = 33;
            addBtn.Text = "add staff";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.Window;
            resetBtn.BackgroundImageLayout = ImageLayout.Center;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(1722, 287);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(297, 66);
            resetBtn.TabIndex = 35;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.Window;
            deleteBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Location = new Point(1269, 287);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(297, 66);
            deleteBtn.TabIndex = 36;
            deleteBtn.Text = "delete staff";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // StaffDGV
            // 
            StaffDGV.AllowUserToOrderColumns = true;
            StaffDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StaffDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            StaffDGV.BackgroundColor = SystemColors.ButtonFace;
            StaffDGV.BorderStyle = BorderStyle.None;
            StaffDGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            StaffDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StaffDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            StaffDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            StaffDGV.DefaultCellStyle = dataGridViewCellStyle2;
            StaffDGV.GridColor = SystemColors.Control;
            StaffDGV.Location = new Point(73, 486);
            StaffDGV.Name = "StaffDGV";
            StaffDGV.ReadOnly = true;
            StaffDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            StaffDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            StaffDGV.RowHeadersVisible = false;
            StaffDGV.RowHeadersWidth = 82;
            StaffDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            StaffDGV.RowTemplate.Height = 41;
            StaffDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StaffDGV.Size = new Size(2160, 769);
            StaffDGV.TabIndex = 52;
            StaffDGV.CellContentClick += StaffDGV_CellContentClick;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(StaffDGV);
            Controls.Add(deleteBtn);
            Controls.Add(resetBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(StaffListName);
            Controls.Add(StaffPass);
            Controls.Add(label2);
            Controls.Add(StaffName);
            Controls.Add(label1);
            Controls.Add(StaffPhone);
            Controls.Add(panel1);
            Controls.Add(personNo);
            Controls.Add(StaffGender);
            Controls.Add(timeName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StaffDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label bookingName;
        private PictureBox pictureBox1;
        private TextBox StaffPhone;
        private Label personNo;
        private ComboBox StaffGender;
        private Label timeName;
        private TextBox StaffName;
        private Label label1;
        private TextBox StaffPass;
        private Label label2;
        private Label StaffListName;
        private Button editBtn;
        private Button addBtn;
        private Button resetBtn;
        private Button deleteBtn;
        private DataGridView StaffDGV;
    }
}