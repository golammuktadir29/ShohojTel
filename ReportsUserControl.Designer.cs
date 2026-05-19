namespace ShohojTel
{
    partial class ReportsUserControl
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
            ReportTextBox = new RichTextBox();
            ReportBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 116);
            label1.Name = "label1";
            label1.Size = new Size(790, 35);
            label1.TabIndex = 0;
            label1.Text = "Detailed explanation of your report(should not exceed 300 words)";
            // 
            // ReportTextBox
            // 
            ReportTextBox.Location = new Point(134, 216);
            ReportTextBox.Name = "ReportTextBox";
            ReportTextBox.Size = new Size(790, 218);
            ReportTextBox.TabIndex = 1;
            ReportTextBox.Text = "";
            // 
            // ReportBtn
            // 
            ReportBtn.BackColor = Color.FromArgb(0, 64, 64);
            ReportBtn.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportBtn.ForeColor = SystemColors.ActiveCaption;
            ReportBtn.Location = new Point(134, 479);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(790, 48);
            ReportBtn.TabIndex = 2;
            ReportBtn.Text = "Submit your report ";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // ReportsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReportBtn);
            Controls.Add(ReportTextBox);
            Controls.Add(label1);
            Name = "ReportsUserControl";
            Size = new Size(959, 614);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox ReportTextBox;
        private Button ReportBtn;
    }
}
