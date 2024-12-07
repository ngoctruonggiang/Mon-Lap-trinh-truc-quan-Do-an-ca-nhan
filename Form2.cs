using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Student_Managed_app
{
    public partial class AddStudentForm : Form
    {
        string duongDanHinhAnh;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderLable_Click(object sender, EventArgs e)
        {

        }

        private void BirthDateLable_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumberLable_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        public void UploadImageButton_Click(object sender, EventArgs e)
        {
            //Thiet lap thuoc tinh cho openFileDialog
            openFileDialogStudentImage.Filter = "File hinh anh (*.png, *.jpeg, *.jpg) | *.png; *.jpeg; *.jpg";
            openFileDialogStudentImage.Title = "Chon anh sinh vien";
            //Hien thi openFileDialog
            if (openFileDialogStudentImage.ShowDialog() == DialogResult.OK)
            {
                //Lay duong dan den file hinh anh
                duongDanHinhAnh = openFileDialogStudentImage.FileName;
                //Chep duong dan hinh anh nay vao picture box
                PictureBox.Image = Image.FromFile(duongDanHinhAnh);
            }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            //add new student
            Student student = new Student();
            ExcelHelper updateExcel = new ExcelHelper();
            string id = textBoxID.Text;
            string fname = FirstNameTextBox.Text;
            string lname = LastNameTextBox.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            string gender = "Male";
            if(FemaleRadioButton.Checked) 
            { gender = "Female"; }
            //we need to check the age of the student
            //the student age must be over 18
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if(this_year - born_year < 18) 
            {
                MessageBox.Show("Invalid, The student age must be over 18");
            }
            else if(verif() == true) 
            {
                //tao doi tuong student voi cac thuoc tinh 
                student.id = id;
                student.firstName = fname;
                student.lastName = lname;
                student.birthDate = bdate;
                student.gender = gender;
                student.phoneNumber = phone;
                student.address = address;
                student.picture = duongDanHinhAnh;
                //Goi ham ThemSinhVienVaoExcel trong excelHelper de chuyen thong tin cua doi tuong student nay vao trong excel 
                updateExcel.ThemSinhVienVaoExcel("D:\\Tai lieu mon hoc 2024\\Lập trình trực quan\\Do an thuc hanh cuoi ky\\" +
                    "WinForms_Student_Managed_app\\WinForms_Student_Managed_app\\data_SinhVien.xlsx", student);
                MessageBox.Show("Student have been added to Excel");
           
            }
            else { MessageBox.Show("Invalid, Because lack of student information"); }
        }

        //create a funtion to verify data
        bool verif()
        {
            if ((FirstNameTextBox.Text.Trim() == " ") ||
                (LastNameTextBox.Text.Trim() == " ") ||
                (PhoneTextBox.Text.Trim() == " ") ||
                (AddressTextBox.Text.Trim() == " ") ||
                (PictureBox.Image == null))
            {
                return false;
            }
            else { return true; }
        }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenderGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LastNameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
