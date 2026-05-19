namespace ShohojTel
{
    partial class DashBoardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdatePassBtn = new Button();
            ClearFieldBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EmailTxtBox = new TextBox();
            OldPassTxtBox = new TextBox();
            NewPassTxtBox = new TextBox();
            ConfirmPassTxtBox = new TextBox();
            SuspendLayout();
            // 
            // UpdatePassBtn
            // 
            UpdatePassBtn.BackColor = SystemColors.ActiveCaption;
            UpdatePassBtn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdatePassBtn.Location = new Point(390, 408);
            UpdatePassBtn.Name = "UpdatePassBtn";
            UpdatePassBtn.Size = new Size(299, 39);
            UpdatePassBtn.TabIndex = 0;
            UpdatePassBtn.Text = "Update Password";
            UpdatePassBtn.UseVisualStyleBackColor = false;
            UpdatePassBtn.Click += UpdatePassBtn_Click;
            // 
            // ClearFieldBtn
            // 
            ClearFieldBtn.BackColor = SystemColors.ActiveCaption;
            ClearFieldBtn.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearFieldBtn.Location = new Point(390, 466);
            ClearFieldBtn.Name = "ClearFieldBtn";
            ClearFieldBtn.Size = new Size(299, 38);
            ClearFieldBtn.TabIndex = 1;
            ClearFieldBtn.Text = "Clear fields";
            ClearFieldBtn.UseVisualStyleBackColor = false;
            ClearFieldBtn.Click += ClearFieldBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 106);
            label1.Name = "label1";
            label1.Size = new Size(138, 27);
            label1.TabIndex = 2;
            label1.Text = "Email address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            label2.Location = new Point(233, 198);
            label2.Name = "label2";
            label2.Size = new Size(131, 26);
            label2.TabIndex = 3;
            label2.Text = "Old password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            label3.Location = new Point(233, 268);
            label3.Name = "label3";
            label3.Size = new Size(138, 26);
            label3.TabIndex = 4;
            label3.Text = "New password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            label4.Location = new Point(214, 333);
            label4.Name = "label4";
            label4.Size = new Size(170, 26);
            label4.TabIndex = 5;
            label4.Text = "Confirm password";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Font = new Font("Arial Narrow", 11.2F, FontStyle.Bold);
            EmailTxtBox.Location = new Point(390, 106);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.PlaceholderText = "Enter your email";
            EmailTxtBox.Size = new Size(299, 34);
            EmailTxtBox.TabIndex = 6;
            // 
            // OldPassTxtBox
            // 
            OldPassTxtBox.Font = new Font("Arial Narrow", 11.2F, FontStyle.Bold);
            OldPassTxtBox.Location = new Point(390, 198);
            OldPassTxtBox.Multiline = true;
            OldPassTxtBox.Name = "OldPassTxtBox";
            OldPassTxtBox.PasswordChar = '*';
            OldPassTxtBox.PlaceholderText = "Enter your old password";
            OldPassTxtBox.Size = new Size(299, 39);
            OldPassTxtBox.TabIndex = 7;
            // 
            // NewPassTxtBox
            // 
            NewPassTxtBox.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewPassTxtBox.Location = new Point(390, 268);
            NewPassTxtBox.Multiline = true;
            NewPassTxtBox.Name = "NewPassTxtBox";
            NewPassTxtBox.PasswordChar = '*';
            NewPassTxtBox.PlaceholderText = "Enter your new password";
            NewPassTxtBox.Size = new Size(299, 34);
            NewPassTxtBox.TabIndex = 8;
            // 
            // ConfirmPassTxtBox
            // 
            ConfirmPassTxtBox.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmPassTxtBox.Location = new Point(390, 333);
            ConfirmPassTxtBox.Multiline = true;
            ConfirmPassTxtBox.Name = "ConfirmPassTxtBox";
            ConfirmPassTxtBox.PasswordChar = '*';
            ConfirmPassTxtBox.PlaceholderText = "Enter confirmed password";
            ConfirmPassTxtBox.Size = new Size(299, 34);
            ConfirmPassTxtBox.TabIndex = 9;
            // 
            // DashBoardUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ConfirmPassTxtBox);
            Controls.Add(NewPassTxtBox);
            Controls.Add(OldPassTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClearFieldBtn);
            Controls.Add(UpdatePassBtn);
            Name = "DashBoardUserControl";
            Size = new Size(946, 569);
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdatePassBtn;
        private Button ClearFieldBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox EmailTxtBox;
        private TextBox OldPassTxtBox;
        private TextBox NewPassTxtBox;
        private TextBox ConfirmPassTxtBox;
    }
}
