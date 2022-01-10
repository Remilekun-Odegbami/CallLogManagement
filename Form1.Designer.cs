
namespace CallLogManagement
{
    partial class Form1
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
            this.Surname = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Name = new System.Windows.Forms.Label();
            this.CallDetails = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.Label();
            this.textDuration = new System.Windows.Forms.TextBox();
            this.Remarks = new System.Windows.Forms.Label();
            this.textRemarks = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 134);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(54, 15);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Surname";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(12, 164);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(44, 15);
            this.Mobile.TabIndex = 2;
            this.Mobile.Text = "Mobile";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(93, 98);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(144, 23);
            this.textName.TabIndex = 3;
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(93, 131);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(144, 23);
            this.textSurname.TabIndex = 4;
            this.textSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSurname_KeyDown);

            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);

            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(17, 204);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(49, 15);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(93, 204);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(144, 75);
            this.textAddress.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 297);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 15);
            this.Status.TabIndex = 8;
            this.Status.Text = "Status";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 101);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 10;
            this.Name.Text = "Name";
            // 
            // CallDetails
            // 
            this.CallDetails.AutoSize = true;
            this.CallDetails.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CallDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CallDetails.Location = new System.Drawing.Point(209, 44);
            this.CallDetails.Name = "CallDetails";
            this.CallDetails.Size = new System.Drawing.Size(152, 23);
            this.CallDetails.TabIndex = 11;
            this.CallDetails.Text = "CALL DETAILS";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(288, 104);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 12;
            this.Date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(282, 139);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(33, 15);
            this.Time.TabIndex = 14;
            this.Time.Text = "Time";
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(341, 131);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(171, 23);
            this.textTime.TabIndex = 15;
            this.textTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTime_KeyDown);

            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(282, 172);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(53, 15);
            this.Duration.TabIndex = 16;
            this.Duration.Text = "Duration";
            // 
            // textDuration
            // 
            this.textDuration.Location = new System.Drawing.Point(341, 169);
            this.textDuration.Name = "textDuration";
            this.textDuration.Size = new System.Drawing.Size(171, 23);
            this.textDuration.TabIndex = 17;
            this.textDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDuration_KeyDown);

            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Location = new System.Drawing.Point(282, 207);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(52, 15);
            this.Remarks.TabIndex = 18;
            this.Remarks.Text = "Remarks";
            // 
            // textRemarks
            // 
            this.textRemarks.Location = new System.Drawing.Point(341, 204);
            this.textRemarks.Multiline = true;
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.Size = new System.Drawing.Size(171, 114);
            this.textRemarks.TabIndex = 19;

            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(246, 344);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 30);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
            this.statusBox.Location = new System.Drawing.Point(93, 289);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(144, 23);
            this.statusBox.TabIndex = 21;
            this.statusBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.statusBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textRemarks);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.textDuration);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CallDetails);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Surname);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label CallDetails;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TextBox textDuration;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.TextBox textRemarks;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox statusBox;
    }
}

