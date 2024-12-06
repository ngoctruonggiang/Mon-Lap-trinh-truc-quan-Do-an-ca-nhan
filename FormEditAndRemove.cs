using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Student_Managed_app
{
    public partial class FormEditAndRemove : Form
    {
        public string linkHinhAnh;
        public int dongHT;
        public string linkFileEX = "D:\\Tai lieu mon hoc 2024\\Lập trình trực quan\\Do an thuc hanh cuoi ky\\" +
            "WinForms_Student_Managed_app\\WinForms_Student_Managed_app\\data_SinhVien.xlsx";
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
                linkHinhAnh = openFileDialogStudentImage.FileName;
                //Chep duong dan hinh anh nay vao picture box
                PictureBox.Image = Image.FromFile(linkHinhAnh);
            }
        }

        private void GenderGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonEdit_Click_1(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.linkFileEX);

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                //Cap nhat cac o trong excel bang thong tin trong textbox khi nhap vao FormEditAndRemove
                worksheet.Cells[dongHT + 2, 1].Value = this.textBoxID.Text;
                worksheet.Cells[dongHT + 2, 2].Value = this.FirstNameTextBox.Text;
                worksheet.Cells[dongHT + 2, 3].Value = this.LastNameTextBox.Text;
                worksheet.Cells[dongHT + 2, 4].Value = this.dateTimePicker1.Value;
                if (this.MaleRadioButton.Checked == true)
                {
                    worksheet.Cells[dongHT + 2, 5].Value = "Male";
                }
                else { worksheet.Cells[dongHT + 2, 5].Value = "Female"; }
                worksheet.Cells[dongHT + 2, 6].Value = this.PhoneTextBox.Text;
                worksheet.Cells[dongHT + 2, 7].Value = this.AddressTextBox.Text;
                worksheet.Cells[dongHT + 2, 8].Value = this.linkHinhAnh;
                MessageBox.Show("dong bi thay doi trong excel la: " + (dongHT + 2).ToString());

                // Lưu file Excel
                package.Save();
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string ID = this.textBoxID.Text;
            // Xac dinh dong can tim
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            FileInfo file = new FileInfo(linkFileEX);
            using (ExcelPackage package = new ExcelPackage(file)) 
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                {
                    if (worksheet.Cells[i, 1].Value.ToString() == ID)
                    {
                        dongHT = i - 2;
                        break;
                    }
                }
                this.textBoxID.Text = ID;
                this.FirstNameTextBox.Text = worksheet.Cells[dongHT + 2, 2].Value.ToString();
                this.LastNameTextBox.Text = worksheet.Cells[dongHT + 2, 3].Value.ToString();
                this.dateTimePicker1.Value = (DateTime)worksheet.Cells[dongHT + 2, 4].Value;
                if (worksheet.Cells[dongHT + 2, 5].Value.ToString() == "Male")
                {
                    this.MaleRadioButton.Checked = true;
                }
                else 
                {
                    this.FemaleRadioButton.Checked = true;
                }
                this.PhoneTextBox.Text = worksheet.Cells[dongHT + 2, 6].Value.ToString();
                this.AddressTextBox.Text = worksheet.Cells[dongHT + 2, 7].Value.ToString();
                //dongHT la thuoc tinh cua datagridview ma dong cua datagridview bat dau tu 0 ma excel bat dau tu 1 ma dong dau trong excel la ten thuoc tinh
                linkHinhAnh = worksheet.Cells[dongHT + 2, 8].Value.ToString();
                this.PictureBox.Image = Image.FromFile(linkHinhAnh);
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(linkFileEX);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                worksheet.DeleteRow(dongHT + 2); //do dongHT la cua datagridview bat dau tu 0 con excel bat dau tu 1, +1 ghi ten cot
                MessageBox.Show("Da xoa dong" + (dongHT + 2).ToString() + "trong excel");
                package.Save();
            }
        }
    }
}
