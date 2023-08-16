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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bookingName = new Label();
            textBox1 = new TextBox();
            personNo = new Label();
            comboBox1 = new ComboBox();
            timeName = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            BeverageItem = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(818, 173);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 52);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
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
            personNo.Click += personNo_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 32;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(1378, 178);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 40);
            comboBox1.TabIndex = 14;
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
            // textBox2
            // 
            textBox2.Location = new Point(128, 173);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 52);
            textBox2.TabIndex = 18;
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
            // textBox3
            // 
            textBox3.Location = new Point(1879, 173);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(382, 52);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
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
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(48, 485);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(2195, 709);
            dataGridView1.TabIndex = 22;
            // 
            // BeverageItem
            // 
            BeverageItem.AutoSize = true;
            BeverageItem.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BeverageItem.Location = new Point(992, 412);
            BeverageItem.Name = "BeverageItem";
            BeverageItem.Size = new Size(316, 48);
            BeverageItem.TabIndex = 21;
            BeverageItem.Text = "BOOKING LIST";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(776, 287);
            button2.Name = "button2";
            button2.Size = new Size(297, 66);
            button2.TabIndex = 34;
            button2.Text = "edit staff";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(322, 287);
            button1.Name = "button1";
            button1.Size = new Size(297, 66);
            button1.TabIndex = 33;
            button1.Text = "add staff";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1722, 287);
            button3.Name = "button3";
            button3.Size = new Size(297, 66);
            button3.TabIndex = 35;
            button3.Text = "RESET";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1269, 287);
            button4.Name = "button4";
            button4.Size = new Size(297, 66);
            button4.TabIndex = 36;
            button4.Text = "delete staff";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Window;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(992, 1228);
            button5.Name = "button5";
            button5.Size = new Size(297, 66);
            button5.TabIndex = 35;
            button5.Text = "back";
            button5.UseVisualStyleBackColor = false;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(BeverageItem);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(personNo);
            Controls.Add(comboBox1);
            Controls.Add(timeName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            Text = "Staff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label bookingName;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label personNo;
        private ComboBox comboBox1;
        private Label timeName;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label BeverageItem;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}