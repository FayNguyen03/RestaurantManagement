namespace RestaurantManagement
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            deleteBtn = new Button();
            resetBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            BeverageItem = new Label();
            CustAdd = new TextBox();
            label2 = new Label();
            CustName = new TextBox();
            label3 = new Label();
            CustPhone = new TextBox();
            personNo = new Label();
            button1 = new Button();
            CustomerDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(73, 49);
            label1.Name = "label1";
            label1.Size = new Size(325, 64);
            label1.TabIndex = 9;
            label1.Text = "CUSTOMER";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.Window;
            deleteBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Location = new Point(1282, 264);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(297, 66);
            deleteBtn.TabIndex = 48;
            deleteBtn.Text = "delete customer";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.Window;
            resetBtn.BackgroundImageLayout = ImageLayout.Center;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(1735, 264);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(297, 66);
            resetBtn.TabIndex = 47;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = SystemColors.Window;
            editBtn.BackgroundImageLayout = ImageLayout.Center;
            editBtn.FlatStyle = FlatStyle.Popup;
            editBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Location = new Point(789, 264);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(297, 66);
            editBtn.TabIndex = 46;
            editBtn.Text = "edit customer";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Window;
            addBtn.BackgroundImageLayout = ImageLayout.Center;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(335, 264);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(297, 66);
            addBtn.TabIndex = 45;
            addBtn.Text = "add customer";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // BeverageItem
            // 
            BeverageItem.AutoSize = true;
            BeverageItem.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BeverageItem.Location = new Point(1005, 389);
            BeverageItem.Name = "BeverageItem";
            BeverageItem.Size = new Size(352, 48);
            BeverageItem.TabIndex = 43;
            BeverageItem.Text = "CUSTOMER LIST";
            // 
            // CustAdd
            // 
            CustAdd.Location = new Point(1859, 176);
            CustAdd.Multiline = true;
            CustAdd.Name = "CustAdd";
            CustAdd.Size = new Size(382, 52);
            CustAdd.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1664, 182);
            label2.Name = "label2";
            label2.Size = new Size(143, 34);
            label2.TabIndex = 41;
            label2.Text = "ADDRESS";
            // 
            // CustName
            // 
            CustName.Location = new Point(269, 176);
            CustName.Multiline = true;
            CustName.Name = "CustName";
            CustName.Size = new Size(392, 52);
            CustName.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(164, 182);
            label3.Name = "label3";
            label3.Size = new Size(99, 34);
            label3.TabIndex = 39;
            label3.Text = "NAME";
            // 
            // CustPhone
            // 
            CustPhone.Location = new Point(1138, 176);
            CustPhone.Multiline = true;
            CustPhone.Name = "CustPhone";
            CustPhone.Size = new Size(354, 52);
            CustPhone.TabIndex = 38;
            // 
            // personNo
            // 
            personNo.AutoSize = true;
            personNo.Font = new Font("Perpetua Titling MT", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            personNo.Location = new Point(881, 182);
            personNo.Name = "personNo";
            personNo.Size = new Size(251, 34);
            personNo.TabIndex = 37;
            personNo.Text = "PHONE NUMBER";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1072, 1217);
            button1.Name = "button1";
            button1.Size = new Size(297, 66);
            button1.TabIndex = 50;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            // 
            // CustomerDGV
            // 
            CustomerDGV.AllowUserToOrderColumns = true;
            CustomerDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            CustomerDGV.BackgroundColor = SystemColors.ButtonFace;
            CustomerDGV.BorderStyle = BorderStyle.None;
            CustomerDGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            CustomerDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomerDGV.DefaultCellStyle = dataGridViewCellStyle2;
            CustomerDGV.GridColor = SystemColors.Control;
            CustomerDGV.Location = new Point(81, 498);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.ReadOnly = true;
            CustomerDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CustomerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CustomerDGV.RowHeadersVisible = false;
            CustomerDGV.RowHeadersWidth = 82;
            CustomerDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CustomerDGV.RowTemplate.Height = 41;
            CustomerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDGV.Size = new Size(2160, 672);
            CustomerDGV.TabIndex = 51;
            CustomerDGV.CellContentClick += CustomerDGV_CellContentClick;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(CustomerDGV);
            Controls.Add(button1);
            Controls.Add(deleteBtn);
            Controls.Add(resetBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(BeverageItem);
            Controls.Add(CustAdd);
            Controls.Add(label2);
            Controls.Add(CustName);
            Controls.Add(label3);
            Controls.Add(CustPhone);
            Controls.Add(personNo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button deleteBtn;
        private Button resetBtn;
        private Button editBtn;
        private Button addBtn;
        private Label BeverageItem;
        private TextBox CustAdd;
        private Label label2;
        private TextBox CustName;
        private Label label3;
        private TextBox CustPhone;
        private Label personNo;
        private Button button1;
        private DataGridView CustomerDGV;
    }
}