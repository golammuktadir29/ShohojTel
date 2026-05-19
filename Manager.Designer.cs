namespace ShohojTel
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            panel1 = new Panel();
            ShowTicketBtn = new Button();
            label1 = new Label();
            LogoutBtn = new Button();
            panel2 = new Panel();
            TicketDataGridView = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TicketDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(ShowTicketBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoutBtn);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 622);
            panel1.TabIndex = 0;
            // 
            // ShowTicketBtn
            // 
            ShowTicketBtn.BackColor = Color.Red;
            ShowTicketBtn.Location = new Point(46, 137);
            ShowTicketBtn.Name = "ShowTicketBtn";
            ShowTicketBtn.Size = new Size(168, 50);
            ShowTicketBtn.TabIndex = 2;
            ShowTicketBtn.Text = "Show Ticket";
            ShowTicketBtn.UseVisualStyleBackColor = false;
            ShowTicketBtn.Click += ShowTicketBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(46, 376);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Logout";
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.BackgroundImage = (Image)resources.GetObject("LogoutBtn.BackgroundImage");
            LogoutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Location = new Point(46, 315);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(46, 47);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(TicketDataGridView);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(272, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 622);
            panel2.TabIndex = 0;
            // 
            // TicketDataGridView
            // 
            TicketDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketDataGridView.Location = new Point(0, 80);
            TicketDataGridView.Name = "TicketDataGridView";
            TicketDataGridView.RowHeadersWidth = 51;
            TicketDataGridView.Size = new Size(991, 542);
            TicketDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(106, 9);
            label2.Name = "label2";
            label2.Size = new Size(378, 52);
            label2.TabIndex = 1;
            label2.Text = "Manager Dashboard";
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 621);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TicketDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button LogoutBtn;
        private Label label1;
        private Button ShowTicketBtn;
        private Label label2;
        private DataGridView TicketDataGridView;
    }
}
