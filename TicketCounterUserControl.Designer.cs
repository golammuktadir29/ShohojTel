namespace ShohojTel
{
    partial class TicketCounterUserControl
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
            label1 = new Label();
            TicketBtn = new Button();
            NameTextBox = new TextBox();
            label2 = new Label();
            PhoneTextBox = new TextBox();
            label3 = new Label();
            NIDTextBox = new TextBox();
            label4 = new Label();
            EmailTextBox = new TextBox();
            DateTimePicker = new DateTimePicker();
            VehicleTypeComboBox = new ComboBox();
            FuelTypeComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 67);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TicketBtn
            // 
            TicketBtn.BackColor = Color.CornflowerBlue;
            TicketBtn.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TicketBtn.ForeColor = SystemColors.Desktop;
            TicketBtn.Location = new Point(158, 444);
            TicketBtn.Name = "TicketBtn";
            TicketBtn.Size = new Size(426, 56);
            TicketBtn.TabIndex = 1;
            TicketBtn.Text = "Submit Ticket";
            TicketBtn.UseVisualStyleBackColor = false;
            TicketBtn.Click += TicketBtn_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(158, 102);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 160);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Phone ";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(158, 211);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(125, 27);
            PhoneTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 301);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "NID number";
            // 
            // NIDTextBox
            // 
            NIDTextBox.Location = new Point(158, 343);
            NIDTextBox.Name = "NIDTextBox";
            NIDTextBox.Size = new Size(125, 27);
            NIDTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 67);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(373, 102);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(125, 27);
            EmailTextBox.TabIndex = 10;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(609, 100);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(250, 27);
            DateTimePicker.TabIndex = 11;
            // 
            // VehicleTypeComboBox
            // 
            VehicleTypeComboBox.FormattingEnabled = true;
            VehicleTypeComboBox.Location = new Point(373, 191);
            VehicleTypeComboBox.Name = "VehicleTypeComboBox";
            VehicleTypeComboBox.Size = new Size(151, 28);
            VehicleTypeComboBox.TabIndex = 12;
            VehicleTypeComboBox.SelectedIndexChanged += VehicleTypeComboBox_SelectedIndexChanged;
            // 
            // FuelTypeComboBox
            // 
            FuelTypeComboBox.FormattingEnabled = true;
            FuelTypeComboBox.Location = new Point(373, 284);
            FuelTypeComboBox.Name = "FuelTypeComboBox";
            FuelTypeComboBox.Size = new Size(151, 28);
            FuelTypeComboBox.TabIndex = 13;
            FuelTypeComboBox.SelectedIndexChanged += FuelTypeComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 160);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 14;
            label5.Text = "Vehicle Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 249);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 15;
            label6.Text = "Fuel Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(609, 67);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 16;
            label7.Text = "Refuelling Date ";
            // 
            // TicketCounterUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(FuelTypeComboBox);
            Controls.Add(VehicleTypeComboBox);
            Controls.Add(DateTimePicker);
            Controls.Add(EmailTextBox);
            Controls.Add(label4);
            Controls.Add(NIDTextBox);
            Controls.Add(label3);
            Controls.Add(PhoneTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(TicketBtn);
            Controls.Add(label1);
            Name = "TicketCounterUserControl";
            Size = new Size(892, 541);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button TicketBtn;
        private TextBox NameTextBox;
        private Label label2;
        private TextBox PhoneTextBox;
        private Label label3;
        private TextBox NIDTextBox;
        private Label label4;
        private TextBox EmailTextBox;
        private DateTimePicker DateTimePicker;
        private ComboBox VehicleTypeComboBox;
        private ComboBox FuelTypeComboBox;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
