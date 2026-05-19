namespace ShohojTel
{
    partial class ManagerLogin
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
            panel1 = new Panel();
            LoginBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(EmailTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(255, 255, 128);
            panel1.Location = new Point(175, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 453);
            panel1.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Black;
            LoginBtn.Location = new Point(392, 342);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(213, 36);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Log in ";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(238, 282);
            label4.Name = "label4";
            label4.Size = new Size(124, 48);
            label4.TabIndex = 5;
            label4.Text = "password :\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 189);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(375, 282);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(256, 27);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(375, 186);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(256, 27);
            EmailTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 192);
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 104);
            label2.Name = "label2";
            label2.Size = new Size(485, 35);
            label2.TabIndex = 1;
            label2.Text = "Log In to Manager Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 50);
            label1.Name = "label1";
            label1.Size = new Size(162, 35);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // ManagerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 238, 8);
            ClientSize = new Size(1311, 629);
            Controls.Add(panel1);
            Name = "ManagerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button LoginBtn;
    }
}