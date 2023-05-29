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
    public partial class AddNewPersonForm : Form
    {
        public BuildingsQueue Queue { get; set; }

        public AddNewPersonForm()
        {
            InitializeComponent();
        }

        private void AddNewPersonForm_Load(object sender, EventArgs e)
        {
            genderCB.Items.Add("Male");
            genderCB.Items.Add("Female");

            genderCB.Text = "Male";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int birthDateDay = int.Parse(birthdateDayTB.Text);
                int birthDateMonth = int.Parse(birthdateMonthTB.Text);
                int birthDateYear = int.Parse(birthdateYearTB.Text);

                int wtDateDay = int.Parse(waitingTimeDayTB.Text);
                int wtDateMonth = int.Parse(waitingTimeMonthTB.Text);
                int wtDateYear = int.Parse(waitingTimeYearTB.Text);

                int salary = int.Parse(SalaryTB.Text);

                Queue.Add(new Person(
                    new Date(birthDateDay, birthDateMonth, birthDateYear),
                    firstnameTB.Text,
                    lastnameTB.Text,
                    occupationTB.Text,
                    genderCB.Text.Equals("Male") ? Gender.Male : Gender.Female,
                    salary,
                    new Date(wtDateDay, wtDateMonth, wtDateYear)
                ));

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}