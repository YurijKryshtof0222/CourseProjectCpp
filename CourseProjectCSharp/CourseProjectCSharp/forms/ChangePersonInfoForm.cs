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
    public partial class ChangePersonInfoForm : Form
    {
        public Person Person { get; set; }

        public ChangePersonInfoForm()
        {
            InitializeComponent();
        }

        private void ChangePersonInfoForm_Load(object sender, EventArgs e)
        {
            genderCB.Items.Add("Male");
            genderCB.Items.Add("Female");

            firstnameTB.Text = Person.Firstname;
            lastnameTB.Text = Person.Lastname;
            occupationTB.Text = Person.Occupation;
            genderCB.Text = Person.Gender == Gender.Male ? "Male" : "Female";
            SalaryTB.Text = Person.Salary.ToString();

            birthdateDayTB.Text = Person.Birthdate.Day.ToString();
            birthdateMonthTB.Text = Person.Birthdate.Month.ToString();
            birthdateYearTB.Text = Person.Birthdate.Year.ToString();

            waitingTimeDayTB.Text = Person.WaitingTime.Day.ToString();
            waitingTimeMonthTB.Text = Person.WaitingTime.Month.ToString();
            waitingTimeYearTB.Text = Person.WaitingTime.Year.ToString();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure to change {Person.Firstname + " " + Person.Lastname} person data?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int birthDateDay = int.Parse(birthdateDayTB.Text);
                    int birthDateMonth = int.Parse(birthdateMonthTB.Text);
                    int birthDateYear = int.Parse(birthdateYearTB.Text);

                    int wtDateDay = int.Parse(waitingTimeDayTB.Text);
                    int wtDateMonth = int.Parse(waitingTimeMonthTB.Text);
                    int wtDateYear = int.Parse(waitingTimeYearTB.Text);

                    Person.Birthdate = new Date(birthDateDay, birthDateMonth, birthDateYear);
                    Person.Firstname = firstnameTB.Text;
                    Person.Lastname = lastnameTB.Text;
                    Person.Salary = int.Parse(SalaryTB.Text);
                    Person.Gender = genderCB.Text == "Male" ? Gender.Male : Gender.Female;
                    Person.WaitingTime = new Date(wtDateDay, wtDateMonth, wtDateYear);

                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Make sure that date and salary fields are filled with numeric values", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Make sure that date fields are filled with its correct ranges\n" + ex.ParamName, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Make sure that text fields are filled", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
