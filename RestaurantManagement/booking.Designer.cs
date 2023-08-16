namespace RestaurantManagement
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bookingName = new Label();
            Date = new Label();
            dateTimePicker1 = new DateTimePicker();
            timeName = new Label();
            comboBox1 = new ComboBox();
            personNo = new Label();
            textBox1 = new TextBox();
            Beverage = new GroupBox();
            label4 = new Label();
            BeverageNo = new Label();
            label1 = new Label();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            BeverageItem = new Label();
            Beverage6 = new CheckBox();
            Beverage5 = new CheckBox();
            Beverage4 = new CheckBox();
            Beverage3 = new CheckBox();
            Beverage2 = new CheckBox();
            Beverage1 = new CheckBox();
            Sets = new GroupBox();
            label5 = new Label();
            SetsNo = new Label();
            setsPrice = new Label();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            setsItem = new Label();
            checkBox1 = new CheckBox();
            Set5 = new CheckBox();
            Set4 = new CheckBox();
            Set3 = new CheckBox();
            Set2 = new CheckBox();
            Set1 = new CheckBox();
            payment = new GroupBox();
            label3 = new Label();
            textBox28 = new TextBox();
            label2 = new Label();
            textBox27 = new TextBox();
            textBox26 = new TextBox();
            pamentTip = new Label();
            label7 = new Label();
            textBox37 = new TextBox();
            button1 = new Button();
            BookingBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Beverage.SuspendLayout();
            Sets.SuspendLayout();
            payment.SuspendLayout();
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
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            bookingName.Size = new Size(290, 64);
            bookingName.TabIndex = 9;
            bookingName.Text = "BOOKING";
            bookingName.Click += bookingName_Click;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Location = new Point(73, 205);
            Date.Name = "Date";
            Date.Size = new Size(117, 44);
            Date.TabIndex = 6;
            Date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(231, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(523, 39);
            dateTimePicker1.TabIndex = 7;
            // 
            // timeName
            // 
            timeName.AutoSize = true;
            timeName.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            timeName.Location = new Point(858, 210);
            timeName.Name = "timeName";
            timeName.Size = new Size(106, 44);
            timeName.TabIndex = 8;
            timeName.Text = "Time";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Day", "Night" });
            comboBox1.Location = new Point(1029, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 40);
            comboBox1.TabIndex = 10;
            // 
            // personNo
            // 
            personNo.AutoSize = true;
            personNo.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            personNo.Location = new Point(1501, 210);
            personNo.Name = "personNo";
            personNo.Size = new Size(227, 44);
            personNo.TabIndex = 11;
            personNo.Text = "No. People";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1769, 205);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 49);
            textBox1.TabIndex = 12;
            // 
            // Beverage
            // 
            Beverage.Controls.Add(label4);
            Beverage.Controls.Add(BeverageNo);
            Beverage.Controls.Add(label1);
            Beverage.Controls.Add(textBox12);
            Beverage.Controls.Add(textBox13);
            Beverage.Controls.Add(textBox10);
            Beverage.Controls.Add(textBox11);
            Beverage.Controls.Add(textBox8);
            Beverage.Controls.Add(textBox9);
            Beverage.Controls.Add(textBox6);
            Beverage.Controls.Add(textBox7);
            Beverage.Controls.Add(textBox4);
            Beverage.Controls.Add(textBox5);
            Beverage.Controls.Add(textBox3);
            Beverage.Controls.Add(textBox2);
            Beverage.Controls.Add(BeverageItem);
            Beverage.Controls.Add(Beverage6);
            Beverage.Controls.Add(Beverage5);
            Beverage.Controls.Add(Beverage4);
            Beverage.Controls.Add(Beverage3);
            Beverage.Controls.Add(Beverage2);
            Beverage.Controls.Add(Beverage1);
            Beverage.Font = new Font("Perpetua Titling MT", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage.Location = new Point(99, 337);
            Beverage.Name = "Beverage";
            Beverage.Size = new Size(992, 711);
            Beverage.TabIndex = 13;
            Beverage.TabStop = false;
            Beverage.Text = "Beverage";
            Beverage.Enter += Beverage_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 634);
            label4.Name = "label4";
            label4.Size = new Size(338, 43);
            label4.TabIndex = 27;
            label4.Text = "BEVERAGE TOTAL";
            // 
            // BeverageNo
            // 
            BeverageNo.AutoSize = true;
            BeverageNo.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BeverageNo.Location = new Point(759, 87);
            BeverageNo.Name = "BeverageNo";
            BeverageNo.Size = new Size(209, 43);
            BeverageNo.TabIndex = 26;
            BeverageNo.Text = "QUANTITY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(621, 87);
            label1.Name = "label1";
            label1.Size = new Size(123, 43);
            label1.TabIndex = 25;
            label1.Text = "PRICE";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(797, 556);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(129, 56);
            textBox12.TabIndex = 24;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(619, 554);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(129, 56);
            textBox13.TabIndex = 23;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(797, 465);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(129, 56);
            textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(619, 463);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(129, 56);
            textBox11.TabIndex = 23;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(797, 383);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(129, 56);
            textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(619, 381);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(129, 56);
            textBox9.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(797, 303);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 56);
            textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(619, 301);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 56);
            textBox7.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(797, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 56);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(619, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 56);
            textBox5.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(797, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 56);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(619, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 56);
            textBox2.TabIndex = 15;
            // 
            // BeverageItem
            // 
            BeverageItem.AutoSize = true;
            BeverageItem.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            BeverageItem.Location = new Point(72, 87);
            BeverageItem.Name = "BeverageItem";
            BeverageItem.Size = new Size(127, 43);
            BeverageItem.TabIndex = 14;
            BeverageItem.Text = "ITEMS";
            // 
            // Beverage6
            // 
            Beverage6.AutoSize = true;
            Beverage6.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage6.Location = new Point(31, 569);
            Beverage6.Name = "Beverage6";
            Beverage6.Size = new Size(551, 41);
            Beverage6.TabIndex = 5;
            Beverage6.Text = "Non-Alcoholic (Water, Tea, Coffee,...)";
            Beverage6.UseVisualStyleBackColor = true;
            // 
            // Beverage5
            // 
            Beverage5.AutoSize = true;
            Beverage5.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage5.Location = new Point(31, 478);
            Beverage5.Name = "Beverage5";
            Beverage5.Size = new Size(590, 41);
            Beverage5.TabIndex = 4;
            Beverage5.Text = "Artisanal Spirits (Gins, Vodkas, Tequilas)";
            Beverage5.UseVisualStyleBackColor = true;
            // 
            // Beverage4
            // 
            Beverage4.AutoSize = true;
            Beverage4.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage4.Location = new Point(31, 396);
            Beverage4.Name = "Beverage4";
            Beverage4.Size = new Size(342, 41);
            Beverage4.TabIndex = 3;
            Beverage4.Text = "Whiskies and Cognacs";
            Beverage4.UseVisualStyleBackColor = true;
            // 
            // Beverage3
            // 
            Beverage3.AutoSize = true;
            Beverage3.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage3.Location = new Point(31, 316);
            Beverage3.Name = "Beverage3";
            Beverage3.Size = new Size(245, 41);
            Beverage3.TabIndex = 2;
            Beverage3.Text = "Craft Cocktails";
            Beverage3.UseVisualStyleBackColor = true;
            // 
            // Beverage2
            // 
            Beverage2.AutoSize = true;
            Beverage2.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage2.Location = new Point(31, 236);
            Beverage2.Name = "Beverage2";
            Beverage2.Size = new Size(199, 41);
            Beverage2.TabIndex = 1;
            Beverage2.Text = "Fine Wines";
            Beverage2.UseVisualStyleBackColor = true;
            // 
            // Beverage1
            // 
            Beverage1.AutoSize = true;
            Beverage1.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage1.Location = new Point(31, 154);
            Beverage1.Name = "Beverage1";
            Beverage1.Size = new Size(206, 41);
            Beverage1.TabIndex = 0;
            Beverage1.Text = "Champagne";
            Beverage1.UseVisualStyleBackColor = true;
            // 
            // Sets
            // 
            Sets.Controls.Add(label5);
            Sets.Controls.Add(SetsNo);
            Sets.Controls.Add(setsPrice);
            Sets.Controls.Add(textBox14);
            Sets.Controls.Add(textBox15);
            Sets.Controls.Add(textBox16);
            Sets.Controls.Add(textBox17);
            Sets.Controls.Add(textBox18);
            Sets.Controls.Add(textBox19);
            Sets.Controls.Add(textBox20);
            Sets.Controls.Add(textBox21);
            Sets.Controls.Add(textBox22);
            Sets.Controls.Add(textBox23);
            Sets.Controls.Add(textBox24);
            Sets.Controls.Add(textBox25);
            Sets.Controls.Add(setsItem);
            Sets.Controls.Add(checkBox1);
            Sets.Controls.Add(Set5);
            Sets.Controls.Add(Set4);
            Sets.Controls.Add(Set3);
            Sets.Controls.Add(Set2);
            Sets.Controls.Add(Set1);
            Sets.Font = new Font("Perpetua Titling MT", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Sets.Location = new Point(1226, 337);
            Sets.Name = "Sets";
            Sets.Size = new Size(1006, 698);
            Sets.TabIndex = 27;
            Sets.TabStop = false;
            Sets.Text = "LUXURY SETS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(72, 634);
            label5.Name = "label5";
            label5.Size = new Size(247, 43);
            label5.TabIndex = 28;
            label5.Text = "MEAL TOTAL";
            // 
            // SetsNo
            // 
            SetsNo.AutoSize = true;
            SetsNo.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            SetsNo.Location = new Point(759, 87);
            SetsNo.Name = "SetsNo";
            SetsNo.Size = new Size(209, 43);
            SetsNo.TabIndex = 26;
            SetsNo.Text = "QUANTITY";
            // 
            // setsPrice
            // 
            setsPrice.AutoSize = true;
            setsPrice.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            setsPrice.Location = new Point(621, 87);
            setsPrice.Name = "setsPrice";
            setsPrice.Size = new Size(123, 43);
            setsPrice.TabIndex = 25;
            setsPrice.Text = "PRICE";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(797, 556);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(129, 56);
            textBox14.TabIndex = 24;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(619, 554);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(129, 56);
            textBox15.TabIndex = 23;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(797, 465);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(129, 56);
            textBox16.TabIndex = 24;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(619, 463);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(129, 56);
            textBox17.TabIndex = 23;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(797, 383);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(129, 56);
            textBox18.TabIndex = 22;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(619, 381);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(129, 56);
            textBox19.TabIndex = 21;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(797, 303);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(129, 56);
            textBox20.TabIndex = 20;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(619, 301);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(129, 56);
            textBox21.TabIndex = 19;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(797, 223);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(129, 56);
            textBox22.TabIndex = 18;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(619, 221);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(129, 56);
            textBox23.TabIndex = 17;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(797, 141);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(129, 56);
            textBox24.TabIndex = 16;
            // 
            // textBox25
            // 
            textBox25.Location = new Point(619, 139);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(129, 56);
            textBox25.TabIndex = 15;
            // 
            // setsItem
            // 
            setsItem.AutoSize = true;
            setsItem.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            setsItem.Location = new Point(72, 87);
            setsItem.Name = "setsItem";
            setsItem.Size = new Size(127, 43);
            setsItem.TabIndex = 14;
            setsItem.Text = "ITEMS";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(31, 569);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(396, 41);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Serenity Danang (6 dishes)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Set5
            // 
            Set5.AutoSize = true;
            Set5.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set5.Location = new Point(31, 478);
            Set5.Name = "Set5";
            Set5.Size = new Size(389, 41);
            Set5.TabIndex = 4;
            Set5.Text = "Exquisite Hanoi (7 dishes)";
            Set5.UseVisualStyleBackColor = true;
            // 
            // Set4
            // 
            Set4.AutoSize = true;
            Set4.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set4.Location = new Point(31, 396);
            Set4.Name = "Set4";
            Set4.Size = new Size(510, 41);
            Set4.TabIndex = 3;
            Set4.Text = "Royal Lotus (Plant-based) (6 dishes)";
            Set4.UseVisualStyleBackColor = true;
            Set4.CheckedChanged += Set4_CheckedChanged;
            // 
            // Set3
            // 
            Set3.AutoSize = true;
            Set3.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set3.Location = new Point(31, 316);
            Set3.Name = "Set3";
            Set3.Size = new Size(392, 41);
            Set3.TabIndex = 2;
            Set3.Text = "Majestic Hoi An (7 dishes)";
            Set3.UseVisualStyleBackColor = true;
            // 
            // Set2
            // 
            Set2.AutoSize = true;
            Set2.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set2.Location = new Point(31, 236);
            Set2.Name = "Set2";
            Set2.Size = new Size(385, 41);
            Set2.TabIndex = 1;
            Set2.Text = "Opulent Saigon (7 dishes)";
            Set2.UseVisualStyleBackColor = true;
            // 
            // Set1
            // 
            Set1.AutoSize = true;
            Set1.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set1.Location = new Point(31, 154);
            Set1.Name = "Set1";
            Set1.Size = new Size(497, 41);
            Set1.TabIndex = 0;
            Set1.Text = "Hue's Royal Indulgence(10 dishes)";
            Set1.TextAlign = ContentAlignment.BottomLeft;
            Set1.UseVisualStyleBackColor = true;
            // 
            // payment
            // 
            payment.Controls.Add(label3);
            payment.Controls.Add(textBox28);
            payment.Controls.Add(label2);
            payment.Controls.Add(textBox27);
            payment.Controls.Add(textBox26);
            payment.Controls.Add(pamentTip);
            payment.Controls.Add(label7);
            payment.Controls.Add(textBox37);
            payment.Font = new Font("Perpetua Titling MT", 15F, FontStyle.Bold, GraphicsUnit.Point);
            payment.Location = new Point(99, 1050);
            payment.Name = "payment";
            payment.Size = new Size(2053, 233);
            payment.TabIndex = 27;
            payment.TabStop = false;
            payment.Text = "Payments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1630, 165);
            label3.Name = "label3";
            label3.Size = new Size(186, 43);
            label3.TabIndex = 31;
            label3.Text = "BALANCE";
            // 
            // textBox28
            // 
            textBox28.Location = new Point(1842, 161);
            textBox28.Name = "textBox28";
            textBox28.Size = new Size(291, 56);
            textBox28.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1036, 87);
            label2.Name = "label2";
            label2.Size = new Size(279, 43);
            label2.TabIndex = 29;
            label2.Text = "GRAND TOTAL";
            // 
            // textBox27
            // 
            textBox27.Location = new Point(1336, 78);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(291, 56);
            textBox27.TabIndex = 28;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(746, 160);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(291, 56);
            textBox26.TabIndex = 27;
            // 
            // pamentTip
            // 
            pamentTip.AutoSize = true;
            pamentTip.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            pamentTip.Location = new Point(602, 165);
            pamentTip.Name = "pamentTip";
            pamentTip.Size = new Size(74, 43);
            pamentTip.TabIndex = 26;
            pamentTip.Text = "TIP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(153, 87);
            label7.Name = "label7";
            label7.Size = new Size(241, 43);
            label7.TabIndex = 25;
            label7.Text = "SERVICE FEE";
            // 
            // textBox37
            // 
            textBox37.Location = new Point(453, 78);
            textBox37.Name = "textBox37";
            textBox37.Size = new Size(291, 56);
            textBox37.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1985, 247);
            button1.Name = "button1";
            button1.Size = new Size(276, 53);
            button1.TabIndex = 29;
            button1.Text = "RESET";
            button1.UseVisualStyleBackColor = false;
            // 
            // BookingBtn
            // 
            BookingBtn.BackColor = SystemColors.Window;
            BookingBtn.BackgroundImageLayout = ImageLayout.Center;
            BookingBtn.FlatStyle = FlatStyle.Popup;
            BookingBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BookingBtn.Location = new Point(1985, 162);
            BookingBtn.Name = "BookingBtn";
            BookingBtn.Size = new Size(276, 53);
            BookingBtn.TabIndex = 28;
            BookingBtn.Text = "ADD BOOKING";
            BookingBtn.UseVisualStyleBackColor = false;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(button1);
            Controls.Add(BookingBtn);
            Controls.Add(payment);
            Controls.Add(Sets);
            Controls.Add(Beverage);
            Controls.Add(textBox1);
            Controls.Add(personNo);
            Controls.Add(comboBox1);
            Controls.Add(timeName);
            Controls.Add(dateTimePicker1);
            Controls.Add(Date);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Beverage.ResumeLayout(false);
            Beverage.PerformLayout();
            Sets.ResumeLayout(false);
            Sets.PerformLayout();
            payment.ResumeLayout(false);
            payment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label bookingName;
        private Label Date;
        private DateTimePicker dateTimePicker1;
        private Label timeName;
        private ComboBox comboBox1;
        private Label personNo;
        private TextBox textBox1;
        private GroupBox Beverage;
        private CheckBox Beverage6;
        private CheckBox Beverage5;
        private CheckBox Beverage4;
        private CheckBox Beverage3;
        private CheckBox Beverage2;
        private CheckBox Beverage1;
        private Label BeverageItem;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label BeverageNo;
        private Label label1;
        private GroupBox Sets;
        private Label SetsNo;
        private Label setsPrice;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private Label setsItem;
        private CheckBox checkBox1;
        private CheckBox Set5;
        private CheckBox Set4;
        private CheckBox Set3;
        private CheckBox Set2;
        private CheckBox Set1;
        private GroupBox payment;
        private Label pamentTip;
        private Label label7;
        private TextBox textBox37;
        private Label label3;
        private TextBox textBox28;
        private Label label2;
        private TextBox textBox27;
        private TextBox textBox26;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button BookingBtn;
    }
}