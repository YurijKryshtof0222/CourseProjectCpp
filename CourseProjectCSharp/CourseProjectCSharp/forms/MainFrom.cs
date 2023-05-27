using CourseProjectCSharp.classes;
using System.ComponentModel;

namespace CourseProjectCSharp
{
    public partial class MainFrom : Form
    {
        BuildingsQueue queue = new BuildingsQueue();

        BindingList<Person> bindingList;

        public MainFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Date date1 = new Date(24, 4, 2024);
            Date date2 = new Date(15, 10, 2025);
            Date date3 = new Date(17, 5, 2023);
            Date date4 = new Date(17, 3, 2024);

            Person person1 = new Person(new Date(28, 9, 1997), "Oleksii", "Pryadko", "software engineer", true, 20000, date1);
            Person person2 = new Person(new Date(15, 10, 1985), "Oleh", "Vynnyk", "SEO", true, 40000, date2);
            Person person3 = new Person(new Date(23, 11, 1993), "Vitalii", "Tsal'", "mechainic", true, 12000, date3);
            Person person4 = new Person(new Date(16, 6, 2000), "Yana", "Zyst", "hairdresser", false, 13000, date4);

            queue.Add(person1);
            queue.Add(person2);
            queue.Add(person3);
            queue.Add(person4);

            bindingList = new BindingList<Person>(queue);

            dataGridView1.DataSource = bindingList;
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}