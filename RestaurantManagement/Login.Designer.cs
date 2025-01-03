using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace RestaurantManagement
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Quote = new Label();
            ResName1 = new Label();
            ResName2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Password = new Label();
            LoginBtn = new Button();
            username = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(Quote);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 534);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 189);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Quote
            // 
            Quote.AllowDrop = true;
            Quote.AutoSize = true;
            Quote.Font = new Font("Palatino Linotype", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            Quote.ForeColor = SystemColors.ButtonFace;
            Quote.Location = new Point(446, 45);
            Quote.Name = "Quote";
            Quote.Size = new Size(679, 74);
            Quote.TabIndex = 8;
            Quote.Text = "Embark on a culinary journey\r\n through the vibrant flavors of Vietnam with a modern twist";
            Quote.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResName1
            // 
            ResName1.AutoSize = true;
            ResName1.Font = new Font("Old English Text MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            ResName1.Location = new Point(3, 209);
            ResName1.Name = "ResName1";
            ResName1.Size = new Size(531, 114);
            ResName1.TabIndex = 1;
            ResName1.Text = "Jennaisance";
            ResName1.Click += ResName1_Click;
            // 
            // ResName2
            // 
            ResName2.AutoSize = true;
            ResName2.Font = new Font("Perpetua Titling MT", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            ResName2.Location = new Point(121, 309);
            ResName2.Name = "ResName2";
            ResName2.Size = new Size(307, 51);
            ResName2.TabIndex = 2;
            ResName2.Text = "RESTAURANT";
            ResName2.Click += ResName2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(791, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 54);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(791, 324);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 54);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(540, 324);
            Password.Name = "Password";
            Password.Size = new Size(221, 44);
            Password.TabIndex = 6;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // Login
            // 
            LoginBtn.BackColor = SystemColors.Window;
            LoginBtn.BackgroundImageLayout = ImageLayout.Center;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(664, 415);
            LoginBtn.Name = "Login";
            LoginBtn.Size = new Size(276, 69);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += Login_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Perpetua Titling MT", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(540, 198);
            username.Name = "username";
            username.Size = new Size(214, 44);
            username.TabIndex = 8;
            username.Text = "UserName";
            // 
            // Res
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 723);
            Controls.Add(username);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ResName2);
            Controls.Add(ResName1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Res";
            Text = "Restaurant";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ResName1;
        private Label ResName2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Password;
        private Button LoginBtn;
        private Label Quote;
        private Label username;
    }
}