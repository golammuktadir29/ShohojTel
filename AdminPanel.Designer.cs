namespace ShohojTel
{
    partial class AdminPanel
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
            LogOutBtn = new Button();
            ShowReportsBtn = new Button();
            ReportsDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(ShowReportsBtn);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 590);
            panel1.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.FromArgb(192, 0, 192);
            LogOutBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(3, 522);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(152, 58);
            LogOutBtn.TabIndex = 1;
            LogOutBtn.Text = "Log out ?!";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // ShowReportsBtn
            // 
            ShowReportsBtn.BackColor = Color.Teal;
            ShowReportsBtn.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowReportsBtn.Location = new Point(3, 89);
            ShowReportsBtn.Name = "ShowReportsBtn";
            ShowReportsBtn.Size = new Size(152, 58);
            ShowReportsBtn.TabIndex = 0;
            ShowReportsBtn.Text = "Show Reports";
            ShowReportsBtn.UseVisualStyleBackColor = false;
            ShowReportsBtn.Click += ShowReportsBtn_Click;
            // 
            // ReportsDataGridView
            // 
            ReportsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsDataGridView.Location = new Point(170, -2);
            ReportsDataGridView.Name = "ReportsDataGridView";
            ReportsDataGridView.RowHeadersWidth = 51;
            ReportsDataGridView.Size = new Size(785, 590);
            ReportsDataGridView.TabIndex = 1;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 590);
            Controls.Add(ReportsDataGridView);
            Controls.Add(panel1);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReportsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ShowReportsBtn;
        private DataGridView ReportsDataGridView;
        private Button LogOutBtn;
    }
}