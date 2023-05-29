using CourseProjectCSharp.classes;
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
            dataGridView1.DataSource = new BindingList<Person>(Queue);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Queue = new BuildingsQueue();

            //dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.DataSource = new BindingList<Person>(Queue);
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            AddNewPersonForm addNewPersonForm = new AddNewPersonForm();
            addNewPersonForm.Queue = Queue;
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

                changePersonInfoForm.Person = Queue[index];
                changePersonInfoForm.ShowDialog();

                Queue[index] = changePersonInfoForm.Person;
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
            /*var fileContent = string.Empty;
            var filePath = string.Empty;*/

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Filter = "XML Files (*.xml)|*.xml";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    //filePath = ofd.FileName;

                    Queue = Queue.ReadFromXML(ofd.FileName);
                }
            }
            RefreshDataGridView();
        }

        private void writeXMLbtn_Click(object sender, EventArgs e)
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