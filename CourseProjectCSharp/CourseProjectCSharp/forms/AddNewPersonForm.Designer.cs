namespace CourseProjectCSharp.forms
{
    partial class AddNewPersonForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstnameTB = new TextBox();
            lastnameTB = new TextBox();
            occupationTB = new TextBox();
            SalaryTB = new TextBox();
            genderCB = new ComboBox();
            panel1 = new Panel();
            birthdateYearTB = new TextBox();
            birthdateMonthTB = new TextBox();
            birthdateDayTB = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            waitingTimeYearTB = new TextBox();
            label12 = new Label();
            waitingTimeMonthTB = new TextBox();
            label13 = new Label();
            waitingTimeDayTB = new TextBox();
            label14 = new Label();
            label8 = new Label();
            cancelBtn = new Button();
            addBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Firstname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 79);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 2;
            label3.Text = "Occupation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 144);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 4;
            label5.Text = "Salary:";
            // 
            // firstnameTB
            // 
            firstnameTB.Location = new Point(105, 6);
            firstnameTB.Name = "firstnameTB";
            firstnameTB.Size = new Size(99, 25);
            firstnameTB.TabIndex = 5;
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(105, 38);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.Size = new Size(100, 25);
            lastnameTB.TabIndex = 6;
            // 
            // occupationTB
            // 
            occupationTB.Location = new Point(105, 71);
            occupationTB.Name = "occupationTB";
            occupationTB.Size = new Size(100, 25);
            occupationTB.TabIndex = 7;
            // 
            // SalaryTB
            // 
            SalaryTB.Location = new Point(105, 136);
            SalaryTB.Name = "SalaryTB";
            SalaryTB.Size = new Size(100, 25);
            SalaryTB.TabIndex = 8;
            // 
            // genderCB
            // 
            genderCB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCB.FormattingEnabled = true;
            genderCB.Location = new Point(105, 105);
            genderCB.Name = "genderCB";
            genderCB.Size = new Size(99, 25);
            genderCB.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(birthdateYearTB);
            panel1.Controls.Add(birthdateMonthTB);
            panel1.Controls.Add(birthdateDayTB);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(214, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 108);
            panel1.TabIndex = 11;
            // 
            // birthdateYearTB
            // 
            birthdateYearTB.Location = new Point(97, 80);
            birthdateYearTB.Name = "birthdateYearTB";
            birthdateYearTB.Size = new Size(100, 25);
            birthdateYearTB.TabIndex = 6;
            // 
            // birthdateMonthTB
            // 
            birthdateMonthTB.Location = new Point(97, 49);
            birthdateMonthTB.Name = "birthdateMonthTB";
            birthdateMonthTB.Size = new Size(100, 25);
            birthdateMonthTB.TabIndex = 5;
            // 
            // birthdateDayTB
            // 
            birthdateDayTB.Location = new Point(97, 17);
            birthdateDayTB.Name = "birthdateDayTB";
            birthdateDayTB.Size = new Size(100, 25);
            birthdateDayTB.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 83);
            label11.Name = "label11";
            label11.Size = new Size(36, 17);
            label11.TabIndex = 3;
            label11.Text = "Year:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 55);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 2;
            label10.Text = "Month:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 25);
            label9.Name = "label9";
            label9.Size = new Size(33, 17);
            label9.TabIndex = 1;
            label9.Text = "Day:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 3);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 0;
            label7.Text = "Birthdate";
            // 
            // panel2
            // 
            panel2.Controls.Add(waitingTimeYearTB);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(waitingTimeMonthTB);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(waitingTimeDayTB);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(420, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 108);
            panel2.TabIndex = 12;
            // 
            // waitingTimeYearTB
            // 
            waitingTimeYearTB.Location = new Point(88, 80);
            waitingTimeYearTB.Name = "waitingTimeYearTB";
            waitingTimeYearTB.Size = new Size(100, 25);
            waitingTimeYearTB.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 83);
            label12.Name = "label12";
            label12.Size = new Size(36, 17);
            label12.TabIndex = 6;
            label12.Text = "Year:";
            // 
            // waitingTimeMonthTB
            // 
            waitingTimeMonthTB.Location = new Point(88, 47);
            waitingTimeMonthTB.Name = "waitingTimeMonthTB";
            waitingTimeMonthTB.Size = new Size(100, 25);
            waitingTimeMonthTB.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 55);
            label13.Name = "label13";
            label13.Size = new Size(49, 17);
            label13.TabIndex = 5;
            label13.Text = "Month:";
            // 
            // waitingTimeDayTB
            // 
            waitingTimeDayTB.Location = new Point(88, 17);
            waitingTimeDayTB.Name = "waitingTimeDayTB";
            waitingTimeDayTB.Size = new Size(100, 25);
            waitingTimeDayTB.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 25);
            label14.Name = "label14";
            label14.Size = new Size(33, 17);
            label14.TabIndex = 4;
            label14.Text = "Day:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 3);
            label8.Name = "label8";
            label8.Size = new Size(110, 17);
            label8.TabIndex = 0;
            label8.Text = "Waiting time date";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(461, 136);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 31);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(542, 136);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 31);
            addBtn.TabIndex = 14;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // AddNewPersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 176);
            Controls.Add(addBtn);
            Controls.Add(cancelBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(genderCB);
            Controls.Add(SalaryTB);
            Controls.Add(occupationTB);
            Controls.Add(lastnameTB);
            Controls.Add(firstnameTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewPersonForm";
            Text = "Add new person";
            Load += AddNewPersonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstnameTB;
        private TextBox lastnameTB;
        private TextBox occupationTB;
        private TextBox SalaryTB;
        private ComboBox genderCB;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private TextBox birthdateYearTB;
        private TextBox birthdateMonthTB;
        private TextBox birthdateDayTB;
        private Label label11;
        private Label label10;
        private TextBox waitingTimeYearTB;
        private Label label12;
        private TextBox waitingTimeMonthTB;
        private Label label13;
        private TextBox waitingTimeDayTB;
        private Label label14;
        private Button cancelBtn;
        private Button addBtn;
    }
}