namespace CourseProjectCSharp
{
    partial class MainFrom
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel4 = new Panel();
            updateDateTimeBtn = new Button();
            changePersonBtn = new Button();
            editorLabel = new Label();
            sortBtn = new Button();
            removePersonBtn = new Button();
            addPersonBtn = new Button();
            panel3 = new Panel();
            writeXMLbtn = new Button();
            loadXMLBtn = new Button();
            label4 = new Label();
            exitBtn = new Button();
            lateBindingDemoBtn = new Button();
            panel2 = new Panel();
            displayWithSpecifiedBtn = new Button();
            toIndexTB = new TextBox();
            fromIndexTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(813, 414);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(lateBindingDemoBtn);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(831, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 414);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(updateDateTimeBtn);
            panel4.Controls.Add(changePersonBtn);
            panel4.Controls.Add(editorLabel);
            panel4.Controls.Add(sortBtn);
            panel4.Controls.Add(removePersonBtn);
            panel4.Controls.Add(addPersonBtn);
            panel4.Location = new Point(3, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 206);
            panel4.TabIndex = 8;
            // 
            // updateDateTimeBtn
            // 
            updateDateTimeBtn.Location = new Point(6, 116);
            updateDateTimeBtn.Name = "updateDateTimeBtn";
            updateDateTimeBtn.Size = new Size(207, 25);
            updateDateTimeBtn.TabIndex = 6;
            updateDateTimeBtn.Text = "Update person waiting time";
            updateDateTimeBtn.UseVisualStyleBackColor = true;
            updateDateTimeBtn.Click += UpdateDateTimeBtn_Click;
            // 
            // changePersonBtn
            // 
            changePersonBtn.Location = new Point(7, 54);
            changePersonBtn.Name = "changePersonBtn";
            changePersonBtn.Size = new Size(211, 26);
            changePersonBtn.TabIndex = 5;
            changePersonBtn.Text = "Change person info";
            changePersonBtn.UseVisualStyleBackColor = true;
            changePersonBtn.Click += ChangePersonBtn_Click;
            // 
            // editorLabel
            // 
            editorLabel.AutoSize = true;
            editorLabel.Location = new Point(7, 7);
            editorLabel.Name = "editorLabel";
            editorLabel.Size = new Size(43, 17);
            editorLabel.TabIndex = 4;
            editorLabel.Text = "Editor";
            // 
            // sortBtn
            // 
            sortBtn.Location = new Point(5, 147);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(208, 54);
            sortBtn.TabIndex = 3;
            sortBtn.Text = "Sort queue by decreasing waiting time";
            sortBtn.UseVisualStyleBackColor = true;
            sortBtn.Click += SortBtn_Click;
            // 
            // removePersonBtn
            // 
            removePersonBtn.Location = new Point(7, 86);
            removePersonBtn.Name = "removePersonBtn";
            removePersonBtn.Size = new Size(208, 24);
            removePersonBtn.TabIndex = 2;
            removePersonBtn.Text = "Remove person";
            removePersonBtn.UseVisualStyleBackColor = true;
            removePersonBtn.Click += RemovePersonBtn_Click;
            // 
            // addPersonBtn
            // 
            addPersonBtn.Location = new Point(5, 25);
            addPersonBtn.Name = "addPersonBtn";
            addPersonBtn.Size = new Size(210, 23);
            addPersonBtn.TabIndex = 1;
            addPersonBtn.Text = "Add new person";
            addPersonBtn.UseVisualStyleBackColor = true;
            addPersonBtn.Click += AddPersonBtn_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(writeXMLbtn);
            panel3.Controls.Add(loadXMLBtn);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 35);
            panel3.TabIndex = 7;
            // 
            // writeXMLbtn
            // 
            writeXMLbtn.Location = new Point(145, 5);
            writeXMLbtn.Name = "writeXMLbtn";
            writeXMLbtn.Size = new Size(72, 25);
            writeXMLbtn.TabIndex = 2;
            writeXMLbtn.Text = "Write";
            writeXMLbtn.UseVisualStyleBackColor = true;
            writeXMLbtn.Click += WriteXMLbtn_Click;
            // 
            // loadXMLBtn
            // 
            loadXMLBtn.Location = new Point(65, 5);
            loadXMLBtn.Name = "loadXMLBtn";
            loadXMLBtn.Size = new Size(74, 25);
            loadXMLBtn.TabIndex = 1;
            loadXMLBtn.Text = "Load";
            loadXMLBtn.UseVisualStyleBackColor = true;
            loadXMLBtn.Click += LoadXMLBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 0;
            label4.Text = "XML file";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(5, 382);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(216, 23);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += ExitBtn_Click;
            // 
            // lateBindingDemoBtn
            // 
            lateBindingDemoBtn.Location = new Point(6, 349);
            lateBindingDemoBtn.Name = "lateBindingDemoBtn";
            lateBindingDemoBtn.Size = new Size(214, 27);
            lateBindingDemoBtn.TabIndex = 5;
            lateBindingDemoBtn.Text = "Late binding Demo";
            lateBindingDemoBtn.UseVisualStyleBackColor = true;
            lateBindingDemoBtn.Click += LateBindingDemoBtn_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(displayWithSpecifiedBtn);
            panel2.Controls.Add(toIndexTB);
            panel2.Controls.Add(fromIndexTB);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 95);
            panel2.TabIndex = 0;
            // 
            // displayWithSpecifiedBtn
            // 
            displayWithSpecifiedBtn.Location = new Point(144, 29);
            displayWithSpecifiedBtn.Name = "displayWithSpecifiedBtn";
            displayWithSpecifiedBtn.Size = new Size(72, 56);
            displayWithSpecifiedBtn.TabIndex = 8;
            displayWithSpecifiedBtn.Text = "Display";
            displayWithSpecifiedBtn.UseVisualStyleBackColor = true;
            displayWithSpecifiedBtn.Click += DisplayBtn_Click;
            // 
            // toIndexTB
            // 
            toIndexTB.Location = new Point(52, 60);
            toIndexTB.Name = "toIndexTB";
            toIndexTB.Size = new Size(85, 25);
            toIndexTB.TabIndex = 7;
            // 
            // fromIndexTB
            // 
            fromIndexTB.Location = new Point(52, 29);
            fromIndexTB.Name = "fromIndexTB";
            fromIndexTB.Size = new Size(85, 25);
            fromIndexTB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 9);
            label3.Name = "label3";
            label3.Size = new Size(195, 17);
            label3.TabIndex = 6;
            label3.Text = "Show with specified index range";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 68);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 5;
            label2.Text = "to:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 1;
            label1.Text = "from:";
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 438);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrom";
            Text = "Builidngs Queue Demo";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox fromIndexTB;
        private TextBox toIndexTB;
        private Button displayWithSpecifiedBtn;
        private Button removePersonBtn;
        private Button addPersonBtn;
        private Button sortBtn;
        private Button lateBindingDemoBtn;
        private Button exitBtn;
        private Panel panel4;
        private Label editorLabel;
        private Panel panel3;
        private Button writeXMLbtn;
        private Button loadXMLBtn;
        private Label label4;
        private Button changePersonBtn;
        private Button updateDateTimeBtn;
    }
}