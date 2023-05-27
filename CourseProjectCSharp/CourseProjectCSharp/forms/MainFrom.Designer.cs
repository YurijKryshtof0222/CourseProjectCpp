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
            button1 = new Button();
            removeBtn = new Button();
            AddPersonBtn = new Button();
            panel2 = new Panel();
            displayWithSpecifiedBtn = new Button();
            toIndexTB = new TextBox();
            fromIndexTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            editorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(750, 340);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(768, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 340);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(3, 84);
            button1.Name = "button1";
            button1.Size = new Size(216, 45);
            button1.TabIndex = 3;
            button1.Text = "Sort queue by decreasing waiting time";
            button1.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(3, 54);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(214, 24);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove person";
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // AddPersonBtn
            // 
            AddPersonBtn.Location = new Point(5, 25);
            AddPersonBtn.Name = "AddPersonBtn";
            AddPersonBtn.Size = new Size(214, 23);
            AddPersonBtn.TabIndex = 1;
            AddPersonBtn.Text = "Add new person";
            AddPersonBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
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
            panel2.Paint += panel2_Paint_1;
            // 
            // displayWithSpecifiedBtn
            // 
            displayWithSpecifiedBtn.Location = new Point(144, 29);
            displayWithSpecifiedBtn.Name = "displayWithSpecifiedBtn";
            displayWithSpecifiedBtn.Size = new Size(72, 56);
            displayWithSpecifiedBtn.TabIndex = 8;
            displayWithSpecifiedBtn.Text = "Display";
            displayWithSpecifiedBtn.UseVisualStyleBackColor = true;
            displayWithSpecifiedBtn.Click += button1_Click;
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
            fromIndexTB.TextChanged += textBox1_TextChanged;
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
            // button2
            // 
            button2.Location = new Point(5, 275);
            button2.Name = "button2";
            button2.Size = new Size(214, 27);
            button2.TabIndex = 5;
            button2.Text = "Late binding Demo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(5, 308);
            button3.Name = "button3";
            button3.Size = new Size(216, 23);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 11);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 0;
            label4.Text = "XML file";
            // 
            // button4
            // 
            button4.Location = new Point(63, 5);
            button4.Name = "button4";
            button4.Size = new Size(74, 25);
            button4.TabIndex = 1;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(144, 5);
            button5.Name = "button5";
            button5.Size = new Size(72, 23);
            button5.TabIndex = 2;
            button5.Text = "Write";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 35);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(editorLabel);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(removeBtn);
            panel4.Controls.Add(AddPersonBtn);
            panel4.Location = new Point(3, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 132);
            panel4.TabIndex = 8;
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
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 359);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "MainFrom";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button removeBtn;
        private Button AddPersonBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private Label editorLabel;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Label label4;
    }
}