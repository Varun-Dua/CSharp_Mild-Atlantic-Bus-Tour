namespace Assignment2
{
    partial class BusForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.DiscountBox = new System.Windows.Forms.TextBox();
            this.StudentBox = new System.Windows.Forms.TextBox();
            this.FullFareBox = new System.Windows.Forms.TextBox();
            this.DriverBox = new System.Windows.Forms.TextBox();
            this.BevelLine = new System.Windows.Forms.Label();
            this.FullFareLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DriverLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.TotalReceiptLabel = new System.Windows.Forms.Label();
            this.TotalPassengerLabel = new System.Windows.Forms.Label();
            this.DriverDataLabel = new System.Windows.Forms.Label();
            this.DriverData = new System.Windows.Forms.Label();
            this.AverageData = new System.Windows.Forms.Label();
            this.ReceiptData = new System.Windows.Forms.Label();
            this.PassengerData = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InfoPanel.SuspendLayout();
            this.DataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(157, 50);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(261, 29);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Daily Tours Summary";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.DiscountBox);
            this.InfoPanel.Controls.Add(this.StudentBox);
            this.InfoPanel.Controls.Add(this.FullFareBox);
            this.InfoPanel.Controls.Add(this.DriverBox);
            this.InfoPanel.Controls.Add(this.BevelLine);
            this.InfoPanel.Controls.Add(this.FullFareLabel);
            this.InfoPanel.Controls.Add(this.StudentLabel);
            this.InfoPanel.Controls.Add(this.DiscountLabel);
            this.InfoPanel.Controls.Add(this.DriverLabel);
            this.InfoPanel.Location = new System.Drawing.Point(77, 110);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(435, 227);
            this.InfoPanel.TabIndex = 1;
            // 
            // DiscountBox
            // 
            this.DiscountBox.Location = new System.Drawing.Point(255, 186);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(100, 22);
            this.DiscountBox.TabIndex = 8;
            this.DiscountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentBox
            // 
            this.StudentBox.Location = new System.Drawing.Point(255, 147);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(100, 22);
            this.StudentBox.TabIndex = 7;
            this.StudentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullFareBox
            // 
            this.FullFareBox.Location = new System.Drawing.Point(255, 111);
            this.FullFareBox.Name = "FullFareBox";
            this.FullFareBox.Size = new System.Drawing.Size(100, 22);
            this.FullFareBox.TabIndex = 6;
            this.FullFareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DriverBox
            // 
            this.DriverBox.Location = new System.Drawing.Point(233, 39);
            this.DriverBox.Name = "DriverBox";
            this.DriverBox.Size = new System.Drawing.Size(134, 22);
            this.DriverBox.TabIndex = 5;
            this.DriverBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BevelLine
            // 
            this.BevelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BevelLine.Location = new System.Drawing.Point(42, 78);
            this.BevelLine.Name = "BevelLine";
            this.BevelLine.Size = new System.Drawing.Size(350, 2);
            this.BevelLine.TabIndex = 4;
            this.BevelLine.Text = "label5";
            // 
            // FullFareLabel
            // 
            this.FullFareLabel.AutoSize = true;
            this.FullFareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareLabel.Location = new System.Drawing.Point(82, 111);
            this.FullFareLabel.Name = "FullFareLabel";
            this.FullFareLabel.Size = new System.Drawing.Size(124, 17);
            this.FullFareLabel.TabIndex = 3;
            this.FullFareLabel.Text = "Full Fare Riders";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(82, 147);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(116, 17);
            this.StudentLabel.TabIndex = 2;
            this.StudentLabel.Text = "Student Riders";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(82, 186);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(123, 17);
            this.DiscountLabel.TabIndex = 1;
            this.DiscountLabel.Text = "Discount Riders";
            // 
            // DriverLabel
            // 
            this.DriverLabel.AutoSize = true;
            this.DriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverLabel.Location = new System.Drawing.Point(64, 39);
            this.DriverLabel.Name = "DriverLabel";
            this.DriverLabel.Size = new System.Drawing.Size(110, 17);
            this.DriverLabel.TabIndex = 0;
            this.DriverLabel.Text = "Driver\'s Name";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CalculateButton.Location = new System.Drawing.Point(77, 372);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(90, 50);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "C&alculate";
            this.ToolTip.SetToolTip(this.CalculateButton, "Press to Calculate Driver Summary");
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Location = new System.Drawing.Point(194, 372);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(90, 50);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear";
            this.ToolTip.SetToolTip(this.ClearButton, "Press to Clear");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.Info;
            this.SummaryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SummaryButton.Location = new System.Drawing.Point(311, 372);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(90, 50);
            this.SummaryButton.TabIndex = 4;
            this.SummaryButton.Text = "&Summary";
            this.ToolTip.SetToolTip(this.SummaryButton, "Press for Company Summary Data");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Info;
            this.ExitButton.Location = new System.Drawing.Point(422, 372);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 50);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "E&xit";
            this.ToolTip.SetToolTip(this.ExitButton, "Press to Exit");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.AverageLabel);
            this.DataGroup.Controls.Add(this.TotalReceiptLabel);
            this.DataGroup.Controls.Add(this.TotalPassengerLabel);
            this.DataGroup.Controls.Add(this.DriverDataLabel);
            this.DataGroup.Controls.Add(this.DriverData);
            this.DataGroup.Controls.Add(this.AverageData);
            this.DataGroup.Controls.Add(this.ReceiptData);
            this.DataGroup.Controls.Add(this.PassengerData);
            this.DataGroup.Location = new System.Drawing.Point(77, 478);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(435, 243);
            this.DataGroup.TabIndex = 6;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Driver Summary Data";
            // 
            // AverageLabel
            // 
            this.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageLabel.Location = new System.Drawing.Point(278, 198);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(120, 20);
            this.AverageLabel.TabIndex = 7;
            this.AverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalReceiptLabel
            // 
            this.TotalReceiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalReceiptLabel.Location = new System.Drawing.Point(278, 147);
            this.TotalReceiptLabel.Name = "TotalReceiptLabel";
            this.TotalReceiptLabel.Size = new System.Drawing.Size(120, 20);
            this.TotalReceiptLabel.TabIndex = 6;
            this.TotalReceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPassengerLabel
            // 
            this.TotalPassengerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPassengerLabel.Location = new System.Drawing.Point(278, 99);
            this.TotalPassengerLabel.Name = "TotalPassengerLabel";
            this.TotalPassengerLabel.Size = new System.Drawing.Size(120, 20);
            this.TotalPassengerLabel.TabIndex = 5;
            this.TotalPassengerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverDataLabel
            // 
            this.DriverDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriverDataLabel.Location = new System.Drawing.Point(278, 46);
            this.DriverDataLabel.Name = "DriverDataLabel";
            this.DriverDataLabel.Size = new System.Drawing.Size(120, 20);
            this.DriverDataLabel.TabIndex = 4;
            this.DriverDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriverData
            // 
            this.DriverData.AutoSize = true;
            this.DriverData.Location = new System.Drawing.Point(55, 46);
            this.DriverData.Name = "DriverData";
            this.DriverData.Size = new System.Drawing.Size(87, 17);
            this.DriverData.TabIndex = 3;
            this.DriverData.Text = "Driver Name";
            // 
            // AverageData
            // 
            this.AverageData.AutoSize = true;
            this.AverageData.Location = new System.Drawing.Point(55, 198);
            this.AverageData.Name = "AverageData";
            this.AverageData.Size = new System.Drawing.Size(156, 17);
            this.AverageData.TabIndex = 2;
            this.AverageData.Text = "Avg Passenger Receipt";
            // 
            // ReceiptData
            // 
            this.ReceiptData.AutoSize = true;
            this.ReceiptData.Location = new System.Drawing.Point(55, 147);
            this.ReceiptData.Name = "ReceiptData";
            this.ReceiptData.Size = new System.Drawing.Size(99, 17);
            this.ReceiptData.TabIndex = 1;
            this.ReceiptData.Text = "Total Receipts";
            // 
            // PassengerData
            // 
            this.PassengerData.AutoSize = true;
            this.PassengerData.Location = new System.Drawing.Point(55, 99);
            this.PassengerData.Name = "PassengerData";
            this.PassengerData.Size = new System.Drawing.Size(119, 17);
            this.PassengerData.TabIndex = 0;
            this.PassengerData.Text = "Total Passengers";
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.DataGroup);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.HeaderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mild Atlantic Bus Tours";
            this.Load += new System.EventHandler(this.BusForm_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.DataGroup.ResumeLayout(false);
            this.DataGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox DiscountBox;
        private System.Windows.Forms.TextBox StudentBox;
        private System.Windows.Forms.TextBox FullFareBox;
        private System.Windows.Forms.TextBox DriverBox;
        private System.Windows.Forms.Label BevelLine;
        private System.Windows.Forms.Label FullFareLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label DriverLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox DataGroup;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label TotalReceiptLabel;
        private System.Windows.Forms.Label TotalPassengerLabel;
        private System.Windows.Forms.Label DriverDataLabel;
        private System.Windows.Forms.Label DriverData;
        private System.Windows.Forms.Label AverageData;
        private System.Windows.Forms.Label ReceiptData;
        private System.Windows.Forms.Label PassengerData;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

