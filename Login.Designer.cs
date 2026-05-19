namespace ShohojTel
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            PumpManagerLoginBtn = new Button();
            label5 = new Label();
            AdminLoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(621, 428);
            button1.Name = "button1";
            button1.Size = new Size(296, 55);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LoginBtn;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.gas_petrol_station_pump_with_fuel_nozzle_flat_design_illustration_on_white_background_vector;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(570, 784);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.Location = new Point(621, 149);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Enter your email";
            EmailTextBox.Size = new Size(400, 43);
            EmailTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(621, 311);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Enter your password";
            PasswordTextBox.Size = new Size(400, 44);
            PasswordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(621, 102);
            label1.Name = "label1";
            label1.Size = new Size(96, 34);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 253);
            label2.Name = "label2";
            label2.Size = new Size(159, 34);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(621, 509);
            label3.Name = "label3";
            label3.Size = new Size(258, 33);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account ?";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(885, 508);
            button2.Name = "button2";
            button2.Size = new Size(130, 34);
            button2.TabIndex = 7;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = false;
            button2.Click += SignupBtn;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(621, 608);
            label4.Name = "label4";
            label4.Size = new Size(243, 33);
            label4.TabIndex = 8;
            label4.Text = "Pump manager login ?";
            // 
            // PumpManagerLoginBtn
            // 
            PumpManagerLoginBtn.BackColor = SystemColors.ActiveCaption;
            PumpManagerLoginBtn.Location = new Point(870, 610);
            PumpManagerLoginBtn.Name = "PumpManagerLoginBtn";
            PumpManagerLoginBtn.Size = new Size(166, 34);
            PumpManagerLoginBtn.TabIndex = 9;
            PumpManagerLoginBtn.Text = "Pump Manager Login";
            PumpManagerLoginBtn.UseVisualStyleBackColor = false;
            PumpManagerLoginBtn.Click += PumpManagerLoginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(635, 693);
            label5.Name = "label5";
            label5.Size = new Size(145, 33);
            label5.TabIndex = 10;
            label5.Text = "Admin login?";
            // 
            // AdminLoginBtn
            // 
            AdminLoginBtn.BackColor = SystemColors.ActiveCaption;
            AdminLoginBtn.Location = new Point(787, 692);
            AdminLoginBtn.Name = "AdminLoginBtn";
            AdminLoginBtn.Size = new Size(130, 34);
            AdminLoginBtn.TabIndex = 11;
            AdminLoginBtn.Text = "Admin Login";
            AdminLoginBtn.UseVisualStyleBackColor = false;
            AdminLoginBtn.Click += AdminLoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 779);
            Controls.Add(AdminLoginBtn);
            Controls.Add(label5);
            Controls.Add(PumpManagerLoginBtn);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button PumpManagerLoginBtn;
        private Label label5;
        private Button AdminLoginBtn;
    }
}
