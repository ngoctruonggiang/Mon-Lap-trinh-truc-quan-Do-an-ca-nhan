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
    public partial class FormEditAndRemove : Form
    {
        string duongDanHinhAnh;

        public FormEditAndRemove()
        {
            InitializeComponent();
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
                duongDanHinhAnh = openFileDialogStudentImage.FileName;
                //Chep duong dan hinh anh nay vao picture box
                PictureBox.Image = Image.FromFile(duongDanHinhAnh);
            }
        }

        private void GenderGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
