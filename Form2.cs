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

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            //Thiet lap thuoc tinh cho openFileDialog
            openFileDialogStudentImage.Filter = "File hinh anh (*.png, *.jpeg, *.jpg) | *.png; *.jpeg; *.jpg";
            openFileDialogStudentImage.Title = "Chon anh sinh vien";
            //Hien thi openFileDialog
            if (openFileDialogStudentImage.ShowDialog() == DialogResult.OK)
            {
                //Lay duong dan den file hinh anh
                string shinhAnh = openFileDialogStudentImage.FileName;
                //Chep duong dan hinh anh nay vao picture box
                PictureBox.Image = Image.FromFile(shinhAnh);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

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

        }

        private void LastNameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
