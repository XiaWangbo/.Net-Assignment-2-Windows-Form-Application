namespace Assignment_2
{
    partial class NewUserScreen
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
            this.RuserName = new System.Windows.Forms.Label();
            this.RpassWord = new System.Windows.Forms.Label();
            this.ReEnPassword = new System.Windows.Forms.Label();
            this.RuName = new System.Windows.Forms.TextBox();
            this.RpWord = new System.Windows.Forms.TextBox();
            this.RconPassWord = new System.Windows.Forms.TextBox();
            this.RfirstName = new System.Windows.Forms.Label();
            this.RfName = new System.Windows.Forms.TextBox();
            this.RlastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDayTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.SubmissionBtn = new System.Windows.Forms.Button();
            this.RCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RuserName
            // 
            this.RuserName.AutoSize = true;
            this.RuserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuserName.Location = new System.Drawing.Point(91, 50);
            this.RuserName.Name = "RuserName";
            this.RuserName.Size = new System.Drawing.Size(134, 29);
            this.RuserName.TabIndex = 0;
            this.RuserName.Text = "Username:";
            // 
            // RpassWord
            // 
            this.RpassWord.AutoSize = true;
            this.RpassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RpassWord.Location = new System.Drawing.Point(91, 152);
            this.RpassWord.Name = "RpassWord";
            this.RpassWord.Size = new System.Drawing.Size(133, 29);
            this.RpassWord.TabIndex = 1;
            this.RpassWord.Text = "Password:";
            // 
            // ReEnPassword
            // 
            this.ReEnPassword.AutoSize = true;
            this.ReEnPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReEnPassword.Location = new System.Drawing.Point(92, 248);
            this.ReEnPassword.Name = "ReEnPassword";
            this.ReEnPassword.Size = new System.Drawing.Size(232, 29);
            this.ReEnPassword.TabIndex = 2;
            this.ReEnPassword.Text = "Confirm Password:";
            this.ReEnPassword.Click += new System.EventHandler(this.ReEnPassword_Click);
            // 
            // RuName
            // 
            this.RuName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuName.Location = new System.Drawing.Point(96, 82);
            this.RuName.Name = "RuName";
            this.RuName.Size = new System.Drawing.Size(281, 40);
            this.RuName.TabIndex = 3;
            // 
            // RpWord
            // 
            this.RpWord.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RpWord.Location = new System.Drawing.Point(97, 184);
            this.RpWord.Name = "RpWord";
            this.RpWord.Size = new System.Drawing.Size(280, 40);
            this.RpWord.TabIndex = 4;
            this.RpWord.UseSystemPasswordChar = true;
            // 
            // RconPassWord
            // 
            this.RconPassWord.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RconPassWord.Location = new System.Drawing.Point(96, 280);
            this.RconPassWord.Name = "RconPassWord";
            this.RconPassWord.Size = new System.Drawing.Size(280, 40);
            this.RconPassWord.TabIndex = 5;
            this.RconPassWord.UseSystemPasswordChar = true;
            // 
            // RfirstName
            // 
            this.RfirstName.AutoSize = true;
            this.RfirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RfirstName.Location = new System.Drawing.Point(92, 340);
            this.RfirstName.Name = "RfirstName";
            this.RfirstName.Size = new System.Drawing.Size(143, 29);
            this.RfirstName.TabIndex = 6;
            this.RfirstName.Text = "First Name:";
            // 
            // RfName
            // 
            this.RfName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RfName.Location = new System.Drawing.Point(95, 372);
            this.RfName.Name = "RfName";
            this.RfName.Size = new System.Drawing.Size(281, 40);
            this.RfName.TabIndex = 7;
            // 
            // RlastName
            // 
            this.RlastName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlastName.Location = new System.Drawing.Point(95, 473);
            this.RlastName.Name = "RlastName";
            this.RlastName.Size = new System.Drawing.Size(281, 40);
            this.RlastName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Name:";
            // 
            // BirthDayTime
            // 
            this.BirthDayTime.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDayTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDayTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDayTime.Location = new System.Drawing.Point(420, 82);
            this.BirthDayTime.Name = "BirthDayTime";
            this.BirthDayTime.Size = new System.Drawing.Size(188, 35);
            this.BirthDayTime.TabIndex = 10;
            this.BirthDayTime.Value = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.BirthDayTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "User-Type";
            // 
            // UserType
            // 
            this.UserType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.UserType.Location = new System.Drawing.Point(420, 184);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(122, 37);
            this.UserType.TabIndex = 13;
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // SubmissionBtn
            // 
            this.SubmissionBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmissionBtn.Location = new System.Drawing.Point(422, 468);
            this.SubmissionBtn.Name = "SubmissionBtn";
            this.SubmissionBtn.Size = new System.Drawing.Size(129, 50);
            this.SubmissionBtn.TabIndex = 14;
            this.SubmissionBtn.Text = "Submit";
            this.SubmissionBtn.UseVisualStyleBackColor = true;
            this.SubmissionBtn.Click += new System.EventHandler(this.SubmissionBtn_Click);
            // 
            // RCancel
            // 
            this.RCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCancel.Location = new System.Drawing.Point(587, 468);
            this.RCancel.Name = "RCancel";
            this.RCancel.Size = new System.Drawing.Size(129, 50);
            this.RCancel.TabIndex = 15;
            this.RCancel.Text = "Cancel";
            this.RCancel.UseVisualStyleBackColor = true;
            this.RCancel.Click += new System.EventHandler(this.RCancel_Click);
            // 
            // NewUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 574);
            this.Controls.Add(this.RCancel);
            this.Controls.Add(this.SubmissionBtn);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirthDayTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RlastName);
            this.Controls.Add(this.RfName);
            this.Controls.Add(this.RfirstName);
            this.Controls.Add(this.RconPassWord);
            this.Controls.Add(this.RpWord);
            this.Controls.Add(this.RuName);
            this.Controls.Add(this.ReEnPassword);
            this.Controls.Add(this.RpassWord);
            this.Controls.Add(this.RuserName);
            this.Name = "NewUserScreen";
            this.Text = "User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RuserName;
        private System.Windows.Forms.Label RpassWord;
        private System.Windows.Forms.Label ReEnPassword;
        private System.Windows.Forms.TextBox RuName;
        private System.Windows.Forms.TextBox RpWord;
        private System.Windows.Forms.TextBox RconPassWord;
        private System.Windows.Forms.Label RfirstName;
        private System.Windows.Forms.TextBox RfName;
        private System.Windows.Forms.TextBox RlastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Button SubmissionBtn;
        private System.Windows.Forms.Button RCancel;
        private System.Windows.Forms.DateTimePicker BirthDayTime;
    }
}