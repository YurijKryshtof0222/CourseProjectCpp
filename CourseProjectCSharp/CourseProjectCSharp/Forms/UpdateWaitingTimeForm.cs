using CourseProjectCSharp.classes;
using System;
using System.Collections;
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
    public partial class UpdateWaitingTimeForm : Form
    {
        public Person SelectedPerson { get; set; }

        public UpdateWaitingTimeForm()
        {
            InitializeComponent();
        }

        private void UpdateWaitingTimeForm_Load(object sender, EventArgs e)
        {
            personDatalabel.Text = $"Person: {SelectedPerson.Fullname}, Waiting Time: {SelectedPerson.WaitingTime}";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int days = int.Parse(daysTB.Text);

                Date newDate = new Date(SelectedPerson.WaitingTime);
                newDate += days;
                DialogResult dialogResult = MessageBox.Show("Are you sure to update person waiting time? " +
                    $"\n Current Waiting Time {SelectedPerson.WaitingTime}" +
                    $"\n Waiting time to be updated {newDate}", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SelectedPerson.WaitingTime = newDate;
                    MessageBox.Show("Person date has been updated successfully!", "Inforamtion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, make sure that days field is filled with numeric value!", "Exclamation",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
