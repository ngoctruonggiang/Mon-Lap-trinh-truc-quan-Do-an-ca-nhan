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
        public string FilePath = @"D:\Tai lieu mon hoc 2024\Lập trình trực quan\Do an thuc hanh cuoi ky\WinForms_Student_Managed_app\WinForms_Student_Managed_app\data_SinhVien.xlsx";

        public FormStudentsList()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormStudentsList_Load);
        }

        private void FormStudentsList_Load(object sender, EventArgs e)
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


        private void dataGridViewListStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditAndRemove formEditAndRemove = new FormEditAndRemove();
            formEditAndRemove.dongHT = dataGridViewListStudents.CurrentCell.RowIndex;
            formEditAndRemove.textBoxID.Text = dataGridViewListStudents.CurrentRow.Cells[0].Value.ToString();
            formEditAndRemove.FirstNameTextBox.Text = dataGridViewListStudents.CurrentRow.Cells[1].Value.ToString();
            formEditAndRemove.LastNameTextBox.Text = dataGridViewListStudents.CurrentRow.Cells[2].Value.ToString();
            formEditAndRemove.dateTimePicker1.Value = (DateTime)dataGridViewListStudents.CurrentRow.Cells[3].Value;
            //gender
            if (dataGridViewListStudents.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                formEditAndRemove.FemaleRadioButton.Checked = true;
            }
            formEditAndRemove.PhoneTextBox.Text = dataGridViewListStudents.CurrentRow.Cells[5].Value.ToString();
            formEditAndRemove.AddressTextBox.Text = dataGridViewListStudents.CurrentRow.Cells[6].Value.ToString();
            string duongDanHinhAnh;
            duongDanHinhAnh = dataGridViewListStudents.CurrentRow.Cells[7].Value.ToString();
            //Lay duong dan den file hinh anh
            formEditAndRemove.PictureBox.Image = Image.FromFile(duongDanHinhAnh);
            formEditAndRemove.linkHinhAnh = duongDanHinhAnh.Trim();
            //Chep duong dan hinh anh nay vao picture box
            formEditAndRemove.Show();
        }
    }
}
