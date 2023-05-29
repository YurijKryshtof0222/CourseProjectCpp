using CourseProjectCSharp.classes;
using CourseProjectCSharp.forms;
using System.ComponentModel;

namespace CourseProjectCSharp
{
    public partial class MainFrom : Form
    {
        BuildingsQueue Queue { get; set; }
        BindingList<Person> Persons { get; set; }

        public MainFrom()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            Persons = new BindingList<Person>(Queue);
            dataGridView1.DataSource = Persons;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Queue = new BuildingsQueue();

            Date waitingTimeDate1 = new Date(24, 4, 2024);
            Date waitingTimeDate2 = new Date(15, 10, 2025);
            Date waitingTimeDate3 = new Date(17, 5, 2023);
            Date waitingTimeDate4 = new Date(17, 3, 2024);

            Person person1 = new Person(new Date(28, 9, 1997), "Oleksii", "Pryadko", "software engineer", gender.Male, 20000, waitingTimeDate1);
            Person person2 = new Person(new Date(15, 10, 1985), "Oleh", "Vynnyk", "SEO", gender.Male, 40000, waitingTimeDate2);
            Person person3 = new Person(new Date(23, 11, 1993), "Vitalii", "Tsal'", "mechainic", gender.Male, 12000, waitingTimeDate3);
            Person person4 = new Person(new Date(16, 6, 2000), "Yana", "Zyst", "hairdresser", gender.Female, 13000, waitingTimeDate4);

            Queue.Add(person1);
            Queue.Add(person2);
            Queue.Add(person3);
            Queue.Add(person4);

            Persons = new BindingList<Person>(Queue);
            dataGridView1.DataSource = Persons;
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            AddNewPersonForm addNewPersonForm = new AddNewPersonForm();
            addNewPersonForm.Persons = Persons;
            addNewPersonForm.ShowDialog();

            RefreshDataGridView();
        }

        private void changePersonBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                ChangePersonInfoForm changePersonInfoForm = new ChangePersonInfoForm();

                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int index = dataGridView1.Rows[selectedCell.RowIndex].Index;

                changePersonInfoForm.Person = Persons[index];
                changePersonInfoForm.ShowDialog();

                Persons[index] = changePersonInfoForm.Person;
            }
        }

        private void lateBindingDemoBtn_Click(object sender, EventArgs e)
        {
            IDate date1 = new Date(15, 11, 1990);
            IDate date2 = new Person();

            MessageBox.Show($"Date string format from Date: {date1.DateToString()}\nDate string format from Person Birthdate: {date2.DateToString()}", 
                "Late binding demo", MessageBoxButtons.OK, MessageBoxIcon.Information);             
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadXMLBtn_Click(object sender, EventArgs e)
        {

        }

        private void writeXMLbtn_Click(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            Queue.SortByDecrasingWaitingTime();
            RefreshDataGridView();
        }

        private void removePersonBtn_Click(object sender, EventArgs e)
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

    }

}