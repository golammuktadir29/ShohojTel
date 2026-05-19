namespace ShohojTel
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
            panel2 = new Panel();
            dashBoardUserControl1 = new DashBoardUserControl();
            reportsUserControl1 = new ReportsUserControl();
            ticketCounterUserControl1 = new TicketCounterUserControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            LogOutBtn = new Button();
            TicketCounterBtn = new Button();
            DashBoardBtn = new Button();
            ReportsBtn = new Button();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dashBoardUserControl1);
            panel2.Controls.Add(reportsUserControl1);
            panel2.Controls.Add(ticketCounterUserControl1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 711);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dashBoardUserControl1
            // 
            dashBoardUserControl1.Location = new Point(307, 0);
            dashBoardUserControl1.Name = "dashBoardUserControl1";
            dashBoardUserControl1.Size = new Size(997, 699);
            dashBoardUserControl1.TabIndex = 3;
            // 
            // reportsUserControl1
            // 
            reportsUserControl1.Location = new Point(307, 0);
            reportsUserControl1.Name = "reportsUserControl1";
            reportsUserControl1.Size = new Size(997, 711);
            reportsUserControl1.TabIndex = 2;
            // 
            // ticketCounterUserControl1
            // 
            ticketCounterUserControl1.Location = new Point(307, 0);
            ticketCounterUserControl1.Name = "ticketCounterUserControl1";
            ticketCounterUserControl1.Size = new Size(997, 711);
            ticketCounterUserControl1.TabIndex = 1;
            ticketCounterUserControl1.Load += ticketCounterUserControl1_Load;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(310, 711);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(LogOutBtn);
            panel3.Controls.Add(TicketCounterBtn);
            panel3.Controls.Add(DashBoardBtn);
            panel3.Controls.Add(ReportsBtn);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 496);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-4, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackgroundImageLayout = ImageLayout.Zoom;
            LogOutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtn.ForeColor = Color.FromArgb(224, 224, 224);
            LogOutBtn.Image = Properties.Resources.log_out;
            LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutBtn.Location = new Point(-3, 422);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(310, 74);
            LogOutBtn.TabIndex = 4;
            LogOutBtn.Text = "Log out";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // TicketCounterBtn
            // 
            TicketCounterBtn.BackgroundImageLayout = ImageLayout.Zoom;
            TicketCounterBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TicketCounterBtn.ForeColor = Color.FromArgb(0, 192, 192);
            TicketCounterBtn.Image = Properties.Resources.ticketcounter;
            TicketCounterBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TicketCounterBtn.Location = new Point(0, 143);
            TicketCounterBtn.Name = "TicketCounterBtn";
            TicketCounterBtn.Size = new Size(310, 59);
            TicketCounterBtn.TabIndex = 1;
            TicketCounterBtn.Text = "Ticket Counter";
            TicketCounterBtn.UseVisualStyleBackColor = false;
            TicketCounterBtn.Click += TicketCounterBtn_Click;
            // 
            // DashBoardBtn
            // 
            DashBoardBtn.BackgroundImageLayout = ImageLayout.Zoom;
            DashBoardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardBtn.ForeColor = Color.FromArgb(0, 192, 192);
            DashBoardBtn.Image = Properties.Resources.settings;
            DashBoardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashBoardBtn.Location = new Point(0, 208);
            DashBoardBtn.Name = "DashBoardBtn";
            DashBoardBtn.Size = new Size(310, 59);
            DashBoardBtn.TabIndex = 2;
            DashBoardBtn.Text = "Dash Board";
            DashBoardBtn.UseVisualStyleBackColor = false;
            DashBoardBtn.Click += DashBoardBtn_Click;
            // 
            // ReportsBtn
            // 
            ReportsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ReportsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportsBtn.ForeColor = Color.FromArgb(0, 192, 192);
            ReportsBtn.Image = Properties.Resources.reports;
            ReportsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReportsBtn.Location = new Point(0, 264);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(310, 59);
            ReportsBtn.TabIndex = 3;
            ReportsBtn.Text = "Reports";
            ReportsBtn.UseVisualStyleBackColor = false;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 711);
            Controls.Add(panel2);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button TicketCounterBtn;
        private Button DashBoardBtn;
        private Panel panel3;
        private Button LogOutBtn;
        private Button ReportsBtn;
        private Label label1;
        private TicketCounterUserControl ticketCounterUserControl1;
        private ReportsUserControl reportsUserControl1;
        private DashBoardUserControl dashBoardUserControl1;
    }
}