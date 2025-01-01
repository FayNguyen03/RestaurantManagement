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
            DateTimePicker CustDate;
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            bookingName = new Label();
            Date = new Label();
            timeName = new Label();
            personNo = new Label();
            CustPeople = new TextBox();
            Beverage = new GroupBox();
            beverageBtn = new Button();
            bevCost = new Label();
            BeverageNo = new Label();
            label1 = new Label();
            nonQuantity = new TextBox();
            nonPrice = new TextBox();
            spiritQuantity = new TextBox();
            spiritPrice = new TextBox();
            whiskiesQuantity = new TextBox();
            whiskiesPrice = new TextBox();
            cocktailQuantity = new TextBox();
            cocktailPrice = new TextBox();
            fineQuantity = new TextBox();
            finePrice = new TextBox();
            champQuantity = new TextBox();
            champPrice = new TextBox();
            BeverageItem = new Label();
            Beverage6 = new CheckBox();
            Beverage5 = new CheckBox();
            Beverage4 = new CheckBox();
            Beverage3 = new CheckBox();
            Beverage2 = new CheckBox();
            Beverage1 = new CheckBox();
            Sets = new GroupBox();
            setBtn = new Button();
            setCost = new Label();
            SetsNo = new Label();
            setsPrice = new Label();
            danangQuantity = new TextBox();
            danangPrice = new TextBox();
            hanoiQuantity = new TextBox();
            hanoiPrice = new TextBox();
            lotusQuantity = new TextBox();
            lotusPrice = new TextBox();
            hoiQuantity = new TextBox();
            hoiPrice = new TextBox();
            saigonQuantity = new TextBox();
            saigonPrice = new TextBox();
            hueQuantity = new TextBox();
            huePrice = new TextBox();
            setsItem = new Label();
            Set6 = new CheckBox();
            Set5 = new CheckBox();
            Set4 = new CheckBox();
            Set3 = new CheckBox();
            Set2 = new CheckBox();
            Set1 = new CheckBox();
            payment = new GroupBox();
            label3 = new Label();
            BalanceTb = new TextBox();
            label2 = new Label();
            grandTotal = new TextBox();
            deposit = new TextBox();
            pamentTip = new Label();
            label7 = new Label();
            serviceFee = new TextBox();
            resetBtn = new Button();
            BookingBtn = new Button();
            custIDCb = new ComboBox();
            label4 = new Label();
            custName = new Label();
            ViewBooking = new Button();
            timeCb = new ComboBox();
            CustDate = new DateTimePicker();
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
            // timeName
            // 
            timeName.AutoSize = true;
            timeName.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            timeName.Location = new Point(789, 205);
            timeName.Name = "timeName";
            timeName.Size = new Size(106, 44);
            timeName.TabIndex = 8;
            timeName.Text = "Time";
            // 
            // personNo
            // 
            personNo.AutoSize = true;
            personNo.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            personNo.Location = new Point(1173, 205);
            personNo.Name = "personNo";
            personNo.Size = new Size(227, 44);
            personNo.TabIndex = 11;
            personNo.Text = "No. People";
            // 
            // CustPeople
            // 
            CustPeople.Location = new Point(1406, 200);
            CustPeople.Multiline = true;
            CustPeople.Name = "CustPeople";
            CustPeople.Size = new Size(108, 49);
            CustPeople.TabIndex = 12;
            // 
            // Beverage
            // 
            Beverage.Controls.Add(beverageBtn);
            Beverage.Controls.Add(bevCost);
            Beverage.Controls.Add(BeverageNo);
            Beverage.Controls.Add(label1);
            Beverage.Controls.Add(nonQuantity);
            Beverage.Controls.Add(nonPrice);
            Beverage.Controls.Add(spiritQuantity);
            Beverage.Controls.Add(spiritPrice);
            Beverage.Controls.Add(whiskiesQuantity);
            Beverage.Controls.Add(whiskiesPrice);
            Beverage.Controls.Add(cocktailQuantity);
            Beverage.Controls.Add(cocktailPrice);
            Beverage.Controls.Add(fineQuantity);
            Beverage.Controls.Add(finePrice);
            Beverage.Controls.Add(champQuantity);
            Beverage.Controls.Add(champPrice);
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
            // 
            // beverageBtn
            // 
            beverageBtn.BackColor = SystemColors.ActiveCaptionText;
            beverageBtn.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            beverageBtn.ForeColor = SystemColors.ButtonFace;
            beverageBtn.Location = new Point(453, 634);
            beverageBtn.Name = "beverageBtn";
            beverageBtn.Size = new Size(123, 62);
            beverageBtn.TabIndex = 28;
            beverageBtn.Text = "Sum";
            beverageBtn.UseVisualStyleBackColor = false;
            beverageBtn.Click += beverageBtn_Click;
            // 
            // bevCost
            // 
            bevCost.AutoSize = true;
            bevCost.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            bevCost.Location = new Point(602, 644);
            bevCost.Name = "bevCost";
            bevCost.Size = new Size(194, 43);
            bevCost.TabIndex = 27;
            bevCost.Text = "TOTAL: $0";
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
            // nonQuantity
            // 
            nonQuantity.Enabled = false;
            nonQuantity.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            nonQuantity.Location = new Point(797, 556);
            nonQuantity.Name = "nonQuantity";
            nonQuantity.Size = new Size(129, 50);
            nonQuantity.TabIndex = 24;
            nonQuantity.Text = "0";
            nonQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // nonPrice
            // 
            nonPrice.Enabled = false;
            nonPrice.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            nonPrice.Location = new Point(619, 554);
            nonPrice.Name = "nonPrice";
            nonPrice.Size = new Size(129, 50);
            nonPrice.TabIndex = 23;
            nonPrice.Text = "8.5";
            nonPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // spiritQuantity
            // 
            spiritQuantity.Enabled = false;
            spiritQuantity.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            spiritQuantity.Location = new Point(797, 465);
            spiritQuantity.Name = "spiritQuantity";
            spiritQuantity.Size = new Size(129, 50);
            spiritQuantity.TabIndex = 24;
            spiritQuantity.Text = "0";
            spiritQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // spiritPrice
            // 
            spiritPrice.Enabled = false;
            spiritPrice.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            spiritPrice.Location = new Point(619, 463);
            spiritPrice.Name = "spiritPrice";
            spiritPrice.Size = new Size(129, 50);
            spiritPrice.TabIndex = 23;
            spiritPrice.Text = "30.25";
            spiritPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // whiskiesQuantity
            // 
            whiskiesQuantity.Enabled = false;
            whiskiesQuantity.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            whiskiesQuantity.Location = new Point(797, 383);
            whiskiesQuantity.Name = "whiskiesQuantity";
            whiskiesQuantity.Size = new Size(129, 50);
            whiskiesQuantity.TabIndex = 22;
            whiskiesQuantity.Text = "0";
            whiskiesQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // whiskiesPrice
            // 
            whiskiesPrice.Enabled = false;
            whiskiesPrice.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            whiskiesPrice.Location = new Point(619, 381);
            whiskiesPrice.Name = "whiskiesPrice";
            whiskiesPrice.Size = new Size(129, 50);
            whiskiesPrice.TabIndex = 21;
            whiskiesPrice.Text = "45.25";
            whiskiesPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cocktailQuantity
            // 
            cocktailQuantity.Enabled = false;
            cocktailQuantity.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            cocktailQuantity.Location = new Point(797, 303);
            cocktailQuantity.Name = "cocktailQuantity";
            cocktailQuantity.Size = new Size(129, 50);
            cocktailQuantity.TabIndex = 20;
            cocktailQuantity.Text = "0";
            cocktailQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // cocktailPrice
            // 
            cocktailPrice.Enabled = false;
            cocktailPrice.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            cocktailPrice.Location = new Point(619, 301);
            cocktailPrice.Name = "cocktailPrice";
            cocktailPrice.Size = new Size(129, 50);
            cocktailPrice.TabIndex = 19;
            cocktailPrice.Text = "10.25";
            cocktailPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // fineQuantity
            // 
            fineQuantity.Enabled = false;
            fineQuantity.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            fineQuantity.Location = new Point(797, 223);
            fineQuantity.Name = "fineQuantity";
            fineQuantity.Size = new Size(129, 50);
            fineQuantity.TabIndex = 18;
            fineQuantity.Text = "0";
            fineQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // finePrice
            // 
            finePrice.Enabled = false;
            finePrice.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            finePrice.Location = new Point(619, 221);
            finePrice.Name = "finePrice";
            finePrice.Size = new Size(129, 50);
            finePrice.TabIndex = 17;
            finePrice.Text = "85.75";
            finePrice.TextAlign = HorizontalAlignment.Right;
            // 
            // champQuantity
            // 
            champQuantity.Enabled = false;
            champQuantity.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            champQuantity.Location = new Point(797, 141);
            champQuantity.Name = "champQuantity";
            champQuantity.Size = new Size(129, 50);
            champQuantity.TabIndex = 16;
            champQuantity.Text = "0";
            champQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // champPrice
            // 
            champPrice.Enabled = false;
            champPrice.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            champPrice.Location = new Point(615, 139);
            champPrice.Name = "champPrice";
            champPrice.Size = new Size(129, 50);
            champPrice.TabIndex = 15;
            champPrice.Text = "75.5";
            champPrice.TextAlign = HorizontalAlignment.Right;
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
            Beverage6.CheckedChanged += Beverage6_CheckedChanged;
            // 
            // Beverage5
            // 
            Beverage5.AutoSize = true;
            Beverage5.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Beverage5.Location = new Point(31, 478);
            Beverage5.Name = "Beverage5";
            Beverage5.Size = new Size(353, 41);
            Beverage5.TabIndex = 4;
            Beverage5.Text = "Gins, Vodkas, Tequilas";
            Beverage5.UseVisualStyleBackColor = true;
            Beverage5.CheckedChanged += Beverage5_CheckedChanged;
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
            Beverage4.CheckedChanged += Beverage4_CheckedChanged;
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
            Beverage3.CheckedChanged += Beverage3_CheckedChanged;
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
            Beverage2.CheckedChanged += Beverage2_CheckedChanged;
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
            Beverage1.CheckedChanged += Beverage1_CheckedChanged;
            // 
            // Sets
            // 
            Sets.Controls.Add(setBtn);
            Sets.Controls.Add(setCost);
            Sets.Controls.Add(SetsNo);
            Sets.Controls.Add(setsPrice);
            Sets.Controls.Add(danangQuantity);
            Sets.Controls.Add(danangPrice);
            Sets.Controls.Add(hanoiQuantity);
            Sets.Controls.Add(hanoiPrice);
            Sets.Controls.Add(lotusQuantity);
            Sets.Controls.Add(lotusPrice);
            Sets.Controls.Add(hoiQuantity);
            Sets.Controls.Add(hoiPrice);
            Sets.Controls.Add(saigonQuantity);
            Sets.Controls.Add(saigonPrice);
            Sets.Controls.Add(hueQuantity);
            Sets.Controls.Add(huePrice);
            Sets.Controls.Add(setsItem);
            Sets.Controls.Add(Set6);
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
            // setBtn
            // 
            setBtn.BackColor = SystemColors.ActiveCaptionText;
            setBtn.Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            setBtn.ForeColor = SystemColors.ButtonFace;
            setBtn.Location = new Point(452, 634);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(123, 62);
            setBtn.TabIndex = 29;
            setBtn.Text = "Sum";
            setBtn.UseVisualStyleBackColor = false;
            setBtn.Click += setBtn_Click;
            // 
            // setCost
            // 
            setCost.AutoSize = true;
            setCost.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            setCost.Location = new Point(619, 641);
            setCost.Name = "setCost";
            setCost.Size = new Size(194, 43);
            setCost.TabIndex = 28;
            setCost.Text = "TOTAL: $0";
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
            // danangQuantity
            // 
            danangQuantity.Enabled = false;
            danangQuantity.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            danangQuantity.Location = new Point(797, 556);
            danangQuantity.Name = "danangQuantity";
            danangQuantity.Size = new Size(129, 53);
            danangQuantity.TabIndex = 24;
            danangQuantity.Text = "0";
            danangQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // danangPrice
            // 
            danangPrice.Enabled = false;
            danangPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            danangPrice.Location = new Point(619, 554);
            danangPrice.Name = "danangPrice";
            danangPrice.Size = new Size(129, 53);
            danangPrice.TabIndex = 23;
            danangPrice.Text = "50.5";
            danangPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // hanoiQuantity
            // 
            hanoiQuantity.Enabled = false;
            hanoiQuantity.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            hanoiQuantity.Location = new Point(797, 465);
            hanoiQuantity.Name = "hanoiQuantity";
            hanoiQuantity.Size = new Size(129, 53);
            hanoiQuantity.TabIndex = 24;
            hanoiQuantity.Text = "0";
            hanoiQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // hanoiPrice
            // 
            hanoiPrice.Enabled = false;
            hanoiPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            hanoiPrice.Location = new Point(619, 463);
            hanoiPrice.Name = "hanoiPrice";
            hanoiPrice.Size = new Size(129, 53);
            hanoiPrice.TabIndex = 23;
            hanoiPrice.Text = "49";
            hanoiPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lotusQuantity
            // 
            lotusQuantity.Enabled = false;
            lotusQuantity.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lotusQuantity.Location = new Point(797, 383);
            lotusQuantity.Name = "lotusQuantity";
            lotusQuantity.Size = new Size(129, 53);
            lotusQuantity.TabIndex = 22;
            lotusQuantity.Text = "0";
            lotusQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // lotusPrice
            // 
            lotusPrice.Enabled = false;
            lotusPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lotusPrice.Location = new Point(619, 381);
            lotusPrice.Name = "lotusPrice";
            lotusPrice.Size = new Size(129, 53);
            lotusPrice.TabIndex = 21;
            lotusPrice.Text = "45";
            lotusPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // hoiQuantity
            // 
            hoiQuantity.Enabled = false;
            hoiQuantity.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            hoiQuantity.Location = new Point(797, 303);
            hoiQuantity.Name = "hoiQuantity";
            hoiQuantity.Size = new Size(129, 53);
            hoiQuantity.TabIndex = 20;
            hoiQuantity.Text = "0";
            hoiQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // hoiPrice
            // 
            hoiPrice.Enabled = false;
            hoiPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            hoiPrice.Location = new Point(619, 301);
            hoiPrice.Name = "hoiPrice";
            hoiPrice.Size = new Size(129, 53);
            hoiPrice.TabIndex = 19;
            hoiPrice.Text = "50";
            hoiPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // saigonQuantity
            // 
            saigonQuantity.Enabled = false;
            saigonQuantity.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            saigonQuantity.Location = new Point(797, 223);
            saigonQuantity.Name = "saigonQuantity";
            saigonQuantity.Size = new Size(129, 53);
            saigonQuantity.TabIndex = 18;
            saigonQuantity.Text = "0";
            saigonQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // saigonPrice
            // 
            saigonPrice.Enabled = false;
            saigonPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            saigonPrice.Location = new Point(619, 221);
            saigonPrice.Name = "saigonPrice";
            saigonPrice.Size = new Size(129, 53);
            saigonPrice.TabIndex = 17;
            saigonPrice.Text = "52";
            saigonPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // hueQuantity
            // 
            hueQuantity.Enabled = false;
            hueQuantity.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            hueQuantity.Location = new Point(797, 141);
            hueQuantity.Name = "hueQuantity";
            hueQuantity.Size = new Size(129, 53);
            hueQuantity.TabIndex = 16;
            hueQuantity.Text = "0";
            hueQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // huePrice
            // 
            huePrice.Enabled = false;
            huePrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            huePrice.Location = new Point(619, 139);
            huePrice.Name = "huePrice";
            huePrice.Size = new Size(129, 53);
            huePrice.TabIndex = 15;
            huePrice.Text = "65";
            huePrice.TextAlign = HorizontalAlignment.Right;
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
            // Set6
            // 
            Set6.AutoSize = true;
            Set6.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set6.Location = new Point(31, 569);
            Set6.Name = "Set6";
            Set6.Size = new Size(396, 41);
            Set6.TabIndex = 5;
            Set6.Text = "Serenity Danang (6 dishes)";
            Set6.UseVisualStyleBackColor = true;
            Set6.CheckedChanged += Set6_CheckedChanged;
            // 
            // Set5
            // 
            Set5.AutoSize = true;
            Set5.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Set5.Location = new Point(31, 480);
            Set5.Name = "Set5";
            Set5.Size = new Size(389, 41);
            Set5.TabIndex = 4;
            Set5.Text = "Exquisite Hanoi (7 dishes)";
            Set5.UseVisualStyleBackColor = true;
            Set5.CheckedChanged += Set5_CheckedChanged;
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
            Set3.CheckedChanged += Set3_CheckedChanged;
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
            Set2.CheckedChanged += Set2_CheckedChanged;
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
            Set1.CheckedChanged += Set1_CheckedChanged;
            // 
            // payment
            // 
            payment.Controls.Add(label3);
            payment.Controls.Add(BalanceTb);
            payment.Controls.Add(label2);
            payment.Controls.Add(grandTotal);
            payment.Controls.Add(deposit);
            payment.Controls.Add(pamentTip);
            payment.Controls.Add(label7);
            payment.Controls.Add(serviceFee);
            payment.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            payment.Location = new Point(99, 1050);
            payment.Name = "payment";
            payment.Size = new Size(1702, 233);
            payment.TabIndex = 27;
            payment.TabStop = false;
            payment.Text = "Payments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1127, 160);
            label3.Name = "label3";
            label3.Size = new Size(186, 43);
            label3.TabIndex = 31;
            label3.Text = "BALANCE";
            // 
            // BalanceTb
            // 
            BalanceTb.Enabled = false;
            BalanceTb.Location = new Point(1339, 156);
            BalanceTb.Name = "BalanceTb";
            BalanceTb.Size = new Size(291, 53);
            BalanceTb.TabIndex = 30;
            BalanceTb.Text = "0.0";
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
            // grandTotal
            // 
            grandTotal.Enabled = false;
            grandTotal.Location = new Point(1336, 78);
            grandTotal.Name = "grandTotal";
            grandTotal.Size = new Size(291, 53);
            grandTotal.TabIndex = 28;
            grandTotal.Text = "0.0";
            // 
            // deposit
            // 
            deposit.Location = new Point(454, 155);
            deposit.Name = "deposit";
            deposit.Size = new Size(291, 53);
            deposit.TabIndex = 27;
            deposit.Text = "0.0";
            deposit.TextChanged += deposit_TextChanged;
            // 
            // pamentTip
            // 
            pamentTip.AutoSize = true;
            pamentTip.Font = new Font("Goudy Old Style", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            pamentTip.Location = new Point(213, 160);
            pamentTip.Name = "pamentTip";
            pamentTip.Size = new Size(171, 43);
            pamentTip.TabIndex = 26;
            pamentTip.Text = "DEPOSIT";
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
            // serviceFee
            // 
            serviceFee.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            serviceFee.Location = new Point(453, 78);
            serviceFee.Name = "serviceFee";
            serviceFee.Size = new Size(291, 50);
            serviceFee.TabIndex = 15;
            serviceFee.Text = "0.0";
            serviceFee.TextChanged += serviceFee_TextChanged;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.Window;
            resetBtn.BackgroundImageLayout = ImageLayout.Center;
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(1900, 1153);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(276, 53);
            resetBtn.TabIndex = 29;
            resetBtn.Text = "RESET";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // BookingBtn
            // 
            BookingBtn.BackColor = SystemColors.Window;
            BookingBtn.BackgroundImageLayout = ImageLayout.Center;
            BookingBtn.FlatStyle = FlatStyle.Popup;
            BookingBtn.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BookingBtn.Location = new Point(1900, 1068);
            BookingBtn.Name = "BookingBtn";
            BookingBtn.Size = new Size(276, 53);
            BookingBtn.TabIndex = 28;
            BookingBtn.Text = "ADD BOOKING";
            BookingBtn.UseVisualStyleBackColor = false;
            BookingBtn.Click += BookingBtn_Click;
            // 
            // custIDCb
            // 
            custIDCb.DropDownStyle = ComboBoxStyle.DropDownList;
            custIDCb.FormattingEnabled = true;
            custIDCb.Items.AddRange(new object[] { "Day", "Night" });
            custIDCb.Location = new Point(1711, 207);
            custIDCb.Name = "custIDCb";
            custIDCb.Size = new Size(226, 40);
            custIDCb.TabIndex = 31;
            custIDCb.SelectionChangeCommitted += custIDCb_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1548, 203);
            label4.Name = "label4";
            label4.Size = new Size(157, 44);
            label4.TabIndex = 30;
            label4.Text = "CUSTID";
            // 
            // custName
            // 
            custName.AutoSize = true;
            custName.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            custName.ForeColor = Color.IndianRed;
            custName.Location = new Point(1570, 267);
            custName.Name = "custName";
            custName.Size = new Size(0, 44);
            custName.TabIndex = 32;
            // 
            // ViewBooking
            // 
            ViewBooking.BackColor = SystemColors.Window;
            ViewBooking.BackgroundImageLayout = ImageLayout.Center;
            ViewBooking.FlatStyle = FlatStyle.Popup;
            ViewBooking.Font = new Font("Perpetua Titling MT", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBooking.Location = new Point(1900, 1240);
            ViewBooking.Name = "ViewBooking";
            ViewBooking.Size = new Size(276, 53);
            ViewBooking.TabIndex = 33;
            ViewBooking.Text = "VIEW BOOKING";
            ViewBooking.UseVisualStyleBackColor = false;
            ViewBooking.Click += ViewBooking_Click;
            // 
            // timeCb
            // 
            timeCb.FormattingEnabled = true;
            timeCb.Items.AddRange(new object[] { "Day", "Night" });
            timeCb.Location = new Point(896, 210);
            timeCb.Name = "timeCb";
            timeCb.Size = new Size(235, 40);
            timeCb.TabIndex = 10;
            // 
            // CustDate
            // 
            CustDate.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            CustDate.Location = new Point(196, 210);
            CustDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            CustDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            CustDate.Name = "CustDate";
            CustDate.Size = new Size(558, 39);
            CustDate.TabIndex = 7;
            CustDate.TabStop = false;
            CustDate.Value = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2310, 1320);
            Controls.Add(ViewBooking);
            Controls.Add(custName);
            Controls.Add(custIDCb);
            Controls.Add(label4);
            Controls.Add(resetBtn);
            Controls.Add(BookingBtn);
            Controls.Add(payment);
            Controls.Add(Sets);
            Controls.Add(Beverage);
            Controls.Add(CustPeople);
            Controls.Add(personNo);
            Controls.Add(timeCb);
            Controls.Add(timeName);
            Controls.Add(CustDate);
            Controls.Add(Date);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Booking_Load;
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
        private DateTimePicker CustDate;
        private Label timeName;
        private Label personNo;
        private TextBox CustPeople;
        private GroupBox Beverage;
        private CheckBox Beverage6;
        private CheckBox Beverage5;
        private CheckBox Beverage4;
        private CheckBox Beverage3;
        private CheckBox Beverage2;
        private CheckBox Beverage1;
        private Label BeverageItem;
        private TextBox nonQuantity;
        private TextBox nonPrice;
        private TextBox spiritQuantity;
        private TextBox spiritPrice;
        private TextBox whiskiesQuantity;
        private TextBox whiskiesPrice;
        private TextBox cocktailQuantity;
        private TextBox cocktailPrice;
        private TextBox fineQuantity;
        private TextBox finePrice;
        private TextBox champQuantity;
        private TextBox champPrice;
        private Label BeverageNo;
        private Label label1;
        private GroupBox Sets;
        private Label SetsNo;
        private Label setsPrice;
        private TextBox danangQuantity;
        private TextBox danangPrice;
        private TextBox hanoiQuantity;
        private TextBox hanoiPrice;
        private TextBox lotusQuantity;
        private TextBox lotusPrice;
        private TextBox hoiQuantity;
        private TextBox hoiPrice;
        private TextBox saigonQuantity;
        private TextBox saigonPrice;
        private TextBox hueQuantity;
        private TextBox huePrice;
        private Label setsItem;
        private CheckBox Set6;
        private CheckBox Set5;
        private CheckBox Set4;
        private CheckBox Set3;
        private CheckBox Set2;
        private CheckBox Set1;
        private GroupBox payment;
        private Label pamentTip;
        private Label label7;
        private TextBox serviceFee;
        private Label label3;
        private TextBox BalanceTb;
        private Label label2;
        private TextBox grandTotal;
        private TextBox deposit;
        private PictureBox pictureBox1;
        private Label bevCost;
        private Label setCost;
        private Button resetBtn;
        private Button BookingBtn;
        private Button beverageBtn;
        private Button setBtn;
        private ComboBox custIDCb;
        private Label label4;
        private Label custName;
        private Button ViewBooking;
        private ComboBox timeCb;
    }
}