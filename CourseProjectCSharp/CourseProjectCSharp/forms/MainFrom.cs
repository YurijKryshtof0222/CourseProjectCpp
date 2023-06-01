using CourseProjectCSharp.classes;
using CourseProjectCSharp.Classes;
using CourseProjectCSharp.forms;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CourseProjectCSharp
{
    public partial class MainFrom : Form
    {
        BuildingsQueue Queue { get; set; }

        public MainFrom()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = new BindingList<Abonent>(Queue);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Queue = new BuildingsQueue();

            //dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.DataSource = new BindingList<Abonent>(Queue);
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int from = int.Parse(fromIndexTB.Text) - 1;
                int to = int.Parse(toIndexTB.Text) - 1;

                ShowWithSpecifiedIndexRangeForm form = new ShowWithSpecifiedIndexRangeForm();

                for (; from <= to; from++)
                {
                    form.Queue.Add(Queue[from]);
                }

                form.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"The entered index range is out of range of this queue!", "Exclamation",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException)
            {
                MessageBox.Show("Make sure that index range fields are filled with numeric values!", "Exclamation",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadXMLBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = Application.StartupPath;
                    ofd.Filter = "XML Files (*.xml)|*.xml";
                    ofd.FilterIndex = 2;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Queue = Queue.ReadFromXML(ofd.FileName);
                    }
                }
                RefreshDataGridView();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Cannot read file: " + ex.Message, "Exclamation",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WriteXMLbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "XML Files (*.xml)|*.xml";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Queue.WriteToXML(sfd.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)
        {
            AddNewPersonForm addNewPersonForm = new AddNewPersonForm();
            addNewPersonForm.Queue = Queue;
            addNewPersonForm.ShowDialog();

            RefreshDataGridView();
        }

        private void ChangePersonBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                ChangePersonInfoForm changePersonInfoForm = new ChangePersonInfoForm();

                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int index = dataGridView1.Rows[selectedCell.RowIndex].Index;

                changePersonInfoForm.Person = Queue[index];
                changePersonInfoForm.ShowDialog();

                Queue[index] = changePersonInfoForm.Person;
                RefreshDataGridView();
            }
        }

        private void RemovePersonBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this person from queue?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                    int index = dataGridView1.Rows[selectedCell.RowIndex].Index;
                    Queue.RemoveAt(index);
                }
                RefreshDataGridView();
            }

        }

        private void UpdateDateTimeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int index = dataGridView1.Rows[selectedCell.RowIndex].Index;

                UpdateWaitingTimeForm form = new UpdateWaitingTimeForm();
                form.SelectedPerson = Queue[index];
                form.ShowDialog();

                RefreshDataGridView();
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            Queue.SortByDecrasingWaitingTime();
            RefreshDataGridView();
        }

        private void LateBindingDemoBtn_Click(object sender, EventArgs e)
        {
            IDateStringFormatRetriever date1 = new Date(15, 11, 1990);
            IDateStringFormatRetriever date2 = new Person();

            MessageBox.Show($"Date string format from Date: {date1.DateToString()}\nDate string format from Person Birthdate: {date2.DateToString()}",
                "Late binding demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}