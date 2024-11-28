using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Student_Managed_app;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_Student_Managed_app
{
    public partial class FormStudentsList : Form
    {
        public string FilePath = @"D:\Tai lieu mon hoc 2024\Lap trinh truc quan\Do an thuc hanh cuoi ky\Du Lieu Sinh Vien.xlsx";

        public FormStudentsList()
        {
            InitializeComponent();
            FormStudentsList_Load();
        }

        public void FormStudentsList_Load()
        {
            try
            {
                ExcelHelper excelHelper = new ExcelHelper();
                List<Student> listSinhVien = excelHelper.ChooseAllStudents(FilePath);
                dataGridViewListStudents.DataSource = listSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message);
            }
        }

        private void dataGridViewListStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
