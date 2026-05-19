namespace ShohojTel
{
    partial class Register
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SignUpButton = new Button();
            FullNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmPasswordTextBox = new TextBox();
            LoginButton = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.gas_petrol_station_pump_with_fuel_nozzle_flat_design_illustration_on_white_background_vector;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 682);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 89);
            label1.Name = "label1";
            label1.Size = new Size(97, 27);
            label1.TabIndex = 3;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(593, 219);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 4;
            label2.Text = "Email address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 335);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(597, 438);
            label4.Name = "label4";
            label4.Size = new Size(160, 27);
            label4.TabIndex = 6;
            label4.Text = "Confirm password";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.ActiveCaption;
            SignUpButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.Location = new Point(601, 534);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(281, 40);
            SignUpButton.TabIndex = 7;
            SignUpButton.Text = "Sign Up!";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullNameTextBox.Location = new Point(597, 130);
            FullNameTextBox.Multiline = true;
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "Enter your full name";
            FullNameTextBox.Size = new Size(285, 41);
            FullNameTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextBox.Location = new Point(597, 255);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Enter your email";
            EmailTextBox.Size = new Size(285, 39);
            EmailTextBox.TabIndex = 9;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(597, 376);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Enter your password";
            PasswordTextBox.Size = new Size(285, 41);
            PasswordTextBox.TabIndex = 10;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPasswordTextBox.Location = new Point(601, 476);
            ConfirmPasswordTextBox.Multiline = true;
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PlaceholderText = "Confirm your password";
            ConfirmPasswordTextBox.Size = new Size(281, 38);
            ConfirmPasswordTextBox.TabIndex = 11;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.GradientActiveCaption;
            LoginButton.Location = new Point(828, 598);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(92, 27);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "Log in!";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(601, 598);
            label5.Name = "label5";
            label5.Size = new Size(221, 27);
            label5.TabIndex = 13;
            label5.Text = "Already have an account?";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 685);
            Controls.Add(label5);
            Controls.Add(LoginButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(SignUpButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SignUpButton;
        private TextBox FullNameTextBox;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private Button LoginButton;
        private Label label5;
    }
}