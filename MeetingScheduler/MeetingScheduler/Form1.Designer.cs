namespace MeetingScheduler
{
    partial class Form1
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
            this.ScheduleMeeting = new System.Windows.Forms.Button();
            this.StaffMember = new System.Windows.Forms.GroupBox();
            this.AttendeAddButton = new System.Windows.Forms.Button();
            this.AttendeeListComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MeetingTimeListBox = new System.Windows.Forms.ListBox();
            this.MeetingTimeSchedule = new System.Windows.Forms.DateTimePicker();
            this.AttendeeRemoveButton = new System.Windows.Forms.Button();
            this.AttendeeListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectUserButton = new System.Windows.Forms.Button();
            this.SelectUserComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.TimeSlotsDateTime = new System.Windows.Forms.DateTimePicker();
            this.ExcludedTimeSlotsListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PrefRemoveButton = new System.Windows.Forms.Button();
            this.PrefAddButton = new System.Windows.Forms.Button();
            this.ExcRemoveButton = new System.Windows.Forms.Button();
            this.ExcAddButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PreferredTimeSlotsListBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AvailiableTimeSlotsListBox = new System.Windows.Forms.ListBox();
            this.StaffMember.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScheduleMeeting
            // 
            this.ScheduleMeeting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScheduleMeeting.Location = new System.Drawing.Point(251, 413);
            this.ScheduleMeeting.Name = "ScheduleMeeting";
            this.ScheduleMeeting.Size = new System.Drawing.Size(136, 134);
            this.ScheduleMeeting.TabIndex = 0;
            this.ScheduleMeeting.Text = "Schedule Meeting";
            this.ScheduleMeeting.UseVisualStyleBackColor = false;
            this.ScheduleMeeting.Click += new System.EventHandler(this.ScheduleMeetingButton_Click);
            // 
            // StaffMember
            // 
            this.StaffMember.Controls.Add(this.AttendeAddButton);
            this.StaffMember.Controls.Add(this.AttendeeListComboBox);
            this.StaffMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffMember.Location = new System.Drawing.Point(245, 199);
            this.StaffMember.Name = "StaffMember";
            this.StaffMember.Size = new System.Drawing.Size(136, 99);
            this.StaffMember.TabIndex = 3;
            this.StaffMember.TabStop = false;
            this.StaffMember.Text = "Staff Member";
            // 
            // AttendeAddButton
            // 
            this.AttendeAddButton.Location = new System.Drawing.Point(6, 62);
            this.AttendeAddButton.Name = "AttendeAddButton";
            this.AttendeAddButton.Size = new System.Drawing.Size(121, 23);
            this.AttendeAddButton.TabIndex = 1;
            this.AttendeAddButton.Text = "Add";
            this.AttendeAddButton.UseVisualStyleBackColor = true;
            this.AttendeAddButton.Click += new System.EventHandler(this.AttendeAddButton_Click);
            // 
            // AttendeeListComboBox
            // 
            this.AttendeeListComboBox.FormattingEnabled = true;
            this.AttendeeListComboBox.Items.AddRange(new object[] {
            "Mehmet",
            "Jing",
            "Mike",
            "Babak"});
            this.AttendeeListComboBox.Location = new System.Drawing.Point(6, 32);
            this.AttendeeListComboBox.Name = "AttendeeListComboBox";
            this.AttendeeListComboBox.Size = new System.Drawing.Size(121, 24);
            this.AttendeeListComboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MeetingTimeListBox);
            this.groupBox1.Controls.Add(this.MeetingTimeSchedule);
            this.groupBox1.Controls.Add(this.AttendeeRemoveButton);
            this.groupBox1.Controls.Add(this.AttendeeListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 348);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Meeting";
            // 
            // MeetingTimeListBox
            // 
            this.MeetingTimeListBox.FormattingEnabled = true;
            this.MeetingTimeListBox.ItemHeight = 16;
            this.MeetingTimeListBox.Items.AddRange(new object[] {
            "09:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "13:00 - 14:00",
            "14:00 - 15:00",
            "15:00 - 16:00",
            "16:00 - 17:00"});
            this.MeetingTimeListBox.Location = new System.Drawing.Point(7, 164);
            this.MeetingTimeListBox.Name = "MeetingTimeListBox";
            this.MeetingTimeListBox.Size = new System.Drawing.Size(214, 84);
            this.MeetingTimeListBox.TabIndex = 2;
            // 
            // MeetingTimeSchedule
            // 
            this.MeetingTimeSchedule.Location = new System.Drawing.Point(6, 135);
            this.MeetingTimeSchedule.Name = "MeetingTimeSchedule";
            this.MeetingTimeSchedule.Size = new System.Drawing.Size(215, 23);
            this.MeetingTimeSchedule.TabIndex = 0;
            // 
            // AttendeeRemoveButton
            // 
            this.AttendeeRemoveButton.Location = new System.Drawing.Point(7, 106);
            this.AttendeeRemoveButton.Name = "AttendeeRemoveButton";
            this.AttendeeRemoveButton.Size = new System.Drawing.Size(215, 23);
            this.AttendeeRemoveButton.TabIndex = 1;
            this.AttendeeRemoveButton.Text = "Remove";
            this.AttendeeRemoveButton.UseVisualStyleBackColor = true;
            this.AttendeeRemoveButton.Click += new System.EventHandler(this.AttendeeRemoveButton_Click);
            // 
            // AttendeeListBox
            // 
            this.AttendeeListBox.FormattingEnabled = true;
            this.AttendeeListBox.ItemHeight = 16;
            this.AttendeeListBox.Location = new System.Drawing.Point(6, 32);
            this.AttendeeListBox.Name = "AttendeeListBox";
            this.AttendeeListBox.Size = new System.Drawing.Size(215, 68);
            this.AttendeeListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectUserButton);
            this.groupBox2.Controls.Add(this.SelectUserComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select User";
            // 
            // SelectUserButton
            // 
            this.SelectUserButton.Location = new System.Drawing.Point(7, 53);
            this.SelectUserButton.Name = "SelectUserButton";
            this.SelectUserButton.Size = new System.Drawing.Size(214, 36);
            this.SelectUserButton.TabIndex = 1;
            this.SelectUserButton.Text = "Select ";
            this.SelectUserButton.UseVisualStyleBackColor = true;
            this.SelectUserButton.Click += new System.EventHandler(this.SelectUserButton_Click);
            // 
            // SelectUserComboBox
            // 
            this.SelectUserComboBox.FormattingEnabled = true;
            this.SelectUserComboBox.Items.AddRange(new object[] {
            "Mehmet",
            "Jing",
            "Mike",
            "Babak"});
            this.SelectUserComboBox.Location = new System.Drawing.Point(7, 23);
            this.SelectUserComboBox.Name = "SelectUserComboBox";
            this.SelectUserComboBox.Size = new System.Drawing.Size(214, 24);
            this.SelectUserComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "M.S.S";
            // 
            // CurrentUserLabel
            // 
            this.CurrentUserLabel.AutoSize = true;
            this.CurrentUserLabel.Location = new System.Drawing.Point(80, 67);
            this.CurrentUserLabel.Name = "CurrentUserLabel";
            this.CurrentUserLabel.Size = new System.Drawing.Size(46, 13);
            this.CurrentUserLabel.TabIndex = 7;
            this.CurrentUserLabel.Text = "No User";
            // 
            // TimeSlotsDateTime
            // 
            this.TimeSlotsDateTime.Location = new System.Drawing.Point(6, 27);
            this.TimeSlotsDateTime.Name = "TimeSlotsDateTime";
            this.TimeSlotsDateTime.Size = new System.Drawing.Size(200, 20);
            this.TimeSlotsDateTime.TabIndex = 8;
            // 
            // ExcludedTimeSlotsListBox
            // 
            this.ExcludedTimeSlotsListBox.FormattingEnabled = true;
            this.ExcludedTimeSlotsListBox.Location = new System.Drawing.Point(6, 19);
            this.ExcludedTimeSlotsListBox.Name = "ExcludedTimeSlotsListBox";
            this.ExcludedTimeSlotsListBox.Size = new System.Drawing.Size(200, 95);
            this.ExcludedTimeSlotsListBox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PrefRemoveButton);
            this.groupBox3.Controls.Add(this.PrefAddButton);
            this.groupBox3.Controls.Add(this.ExcRemoveButton);
            this.groupBox3.Controls.Add(this.ExcAddButton);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(441, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 535);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Slots";
            // 
            // PrefRemoveButton
            // 
            this.PrefRemoveButton.Location = new System.Drawing.Point(121, 489);
            this.PrefRemoveButton.Name = "PrefRemoveButton";
            this.PrefRemoveButton.Size = new System.Drawing.Size(100, 23);
            this.PrefRemoveButton.TabIndex = 19;
            this.PrefRemoveButton.Text = "Remove";
            this.PrefRemoveButton.UseVisualStyleBackColor = true;
            this.PrefRemoveButton.Click += new System.EventHandler(this.PrefRemoveButton_Click);
            // 
            // PrefAddButton
            // 
            this.PrefAddButton.Location = new System.Drawing.Point(7, 489);
            this.PrefAddButton.Name = "PrefAddButton";
            this.PrefAddButton.Size = new System.Drawing.Size(99, 23);
            this.PrefAddButton.TabIndex = 18;
            this.PrefAddButton.Text = "Add";
            this.PrefAddButton.UseVisualStyleBackColor = true;
            this.PrefAddButton.Click += new System.EventHandler(this.PrefAddButton_Click);
            // 
            // ExcRemoveButton
            // 
            this.ExcRemoveButton.Location = new System.Drawing.Point(121, 322);
            this.ExcRemoveButton.Name = "ExcRemoveButton";
            this.ExcRemoveButton.Size = new System.Drawing.Size(100, 23);
            this.ExcRemoveButton.TabIndex = 17;
            this.ExcRemoveButton.Text = "Remove";
            this.ExcRemoveButton.UseVisualStyleBackColor = true;
            this.ExcRemoveButton.Click += new System.EventHandler(this.ExcRemoveButton_Click);
            // 
            // ExcAddButton
            // 
            this.ExcAddButton.Location = new System.Drawing.Point(7, 322);
            this.ExcAddButton.Name = "ExcAddButton";
            this.ExcAddButton.Size = new System.Drawing.Size(99, 23);
            this.ExcAddButton.TabIndex = 16;
            this.ExcAddButton.Text = "Add";
            this.ExcAddButton.UseVisualStyleBackColor = true;
            this.ExcAddButton.Click += new System.EventHandler(this.ExcAddButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PreferredTimeSlotsListBox);
            this.groupBox6.Location = new System.Drawing.Point(6, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 130);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Preferred";
            // 
            // PreferredTimeSlotsListBox
            // 
            this.PreferredTimeSlotsListBox.FormattingEnabled = true;
            this.PreferredTimeSlotsListBox.Location = new System.Drawing.Point(6, 19);
            this.PreferredTimeSlotsListBox.Name = "PreferredTimeSlotsListBox";
            this.PreferredTimeSlotsListBox.Size = new System.Drawing.Size(200, 95);
            this.PreferredTimeSlotsListBox.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ExcludedTimeSlotsListBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 129);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Excluded";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AvailiableTimeSlotsListBox);
            this.groupBox4.Controls.Add(this.TimeSlotsDateTime);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 159);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time Slots";
            // 
            // AvailiableTimeSlotsListBox
            // 
            this.AvailiableTimeSlotsListBox.FormattingEnabled = true;
            this.AvailiableTimeSlotsListBox.Location = new System.Drawing.Point(6, 53);
            this.AvailiableTimeSlotsListBox.Name = "AvailiableTimeSlotsListBox";
            this.AvailiableTimeSlotsListBox.Size = new System.Drawing.Size(200, 95);
            this.AvailiableTimeSlotsListBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 559);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CurrentUserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StaffMember);
            this.Controls.Add(this.ScheduleMeeting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StaffMember.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ScheduleMeeting;
        private System.Windows.Forms.GroupBox StaffMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker MeetingTimeSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SelectUserButton;
        private System.Windows.Forms.ComboBox SelectUserComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentUserLabel;
        private System.Windows.Forms.ListBox AttendeeListBox;
        private System.Windows.Forms.Button AttendeAddButton;
        private System.Windows.Forms.ComboBox AttendeeListComboBox;
        private System.Windows.Forms.Button AttendeeRemoveButton;
        private System.Windows.Forms.ListBox MeetingTimeListBox;
        private System.Windows.Forms.DateTimePicker TimeSlotsDateTime;
        private System.Windows.Forms.ListBox ExcludedTimeSlotsListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox AvailiableTimeSlotsListBox;
        private System.Windows.Forms.ListBox PreferredTimeSlotsListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button PrefRemoveButton;
        private System.Windows.Forms.Button PrefAddButton;
        private System.Windows.Forms.Button ExcRemoveButton;
        private System.Windows.Forms.Button ExcAddButton;
    }
}

