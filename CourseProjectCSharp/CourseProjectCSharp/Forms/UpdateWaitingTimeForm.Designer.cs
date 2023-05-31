namespace CourseProjectCSharp.forms
{
    partial class UpdateWaitingTimeForm
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
            personDatalabel = new Label();
            button1 = new Button();
            updateBtn = new Button();
            label2 = new Label();
            daysTB = new TextBox();
            SuspendLayout();
            // 
            // personDatalabel
            // 
            personDatalabel.AutoSize = true;
            personDatalabel.Location = new Point(12, 9);
            personDatalabel.Name = "personDatalabel";
            personDatalabel.Size = new Size(79, 17);
            personDatalabel.TabIndex = 0;
            personDatalabel.Text = "person data";
            // 
            // button1
            // 
            button1.Location = new Point(12, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CancelBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(106, 46);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 28);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += UpdateBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(388, 17);
            label2.TabIndex = 3;
            label2.Text = "Enter days you want to increment/decrement person waiting time";
            // 
            // daysTB
            // 
            daysTB.Location = new Point(406, 23);
            daysTB.Name = "daysTB";
            daysTB.Size = new Size(140, 25);
            daysTB.TabIndex = 4;
            // 
            // UpdateWaitingTimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 81);
            Controls.Add(daysTB);
            Controls.Add(label2);
            Controls.Add(updateBtn);
            Controls.Add(button1);
            Controls.Add(personDatalabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateWaitingTimeForm";
            Text = "UpdateWaitingTime";
            Load += UpdateWaitingTimeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label personDatalabel;
        private Button button1;
        private Button updateBtn;
        private Label label2;
        private TextBox daysTB;
    }
}