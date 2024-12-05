namespace WinForms_Student_Managed_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentsList studentsList = new FormStudentsList();
            studentsList.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditAndRemove formER = new FormEditAndRemove();
            formER.Show();
        }
    }
}
