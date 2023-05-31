using CourseProjectCSharp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectCSharp.forms
{
    public partial class ShowWithSpecifiedIndexRangeForm : Form
    {
        public BuildingsQueue Queue { get; set; }

        public ShowWithSpecifiedIndexRangeForm()
        {
            InitializeComponent();

            Queue = new BuildingsQueue();

        }

        private void ShowWithSpecifiedIndexRangeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Queue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}