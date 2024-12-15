using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;

namespace WinForms_Student_Managed_app
{
    public partial class FormManage : Form
    {
        int dongClick;
        string duongDanHinhAnh;
        string IDBeforeEdit;//Trong truong hop sua ID thi biet la dong muon sua la dong co ID truoc khi sua
        public FormManage()
        {
            InitializeComponent();
            FormStudentsList_Load();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public string FilePath = @"D:\Tai lieu mon hoc 2024\Lập trình trực quan\Do an thuc hanh cuoi ky\WinForms_Student_Managed_app\WinForms_Student_Managed_app\data_SinhVien.xlsx";

        private void FormStudentsList_Load()
        {
            try
            {
                ExcelHelper excelHelper = new ExcelHelper();
                List<Student> listSinhVien = excelHelper.ChooseAllStudents(FilePath);
                dataGridViewManage.DataSource = listSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message);
            }
        }


        private void dataGridViewManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dongClick = dataGridViewManage.CurrentCell.RowIndex;
            //MessageBox.Show("dong hien tai la: " + dongClick.ToString());
            this.textBoxID.Text = dataGridViewManage.CurrentRow.Cells[0].Value.ToString();
            IDBeforeEdit = this.textBoxID.Text;
            this.textBoxFirstName.Text = dataGridViewManage.CurrentRow.Cells[1].Value.ToString();
            this.textBoxLastName.Text = dataGridViewManage.CurrentRow.Cells[2].Value.ToString();
            this.dateTimePickerBirthDay.Value = (DateTime)dataGridViewManage.CurrentRow.Cells[3].Value;
            //gender
            if (dataGridViewManage.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                this.radioButtonFemale.Checked = true;
            }
            this.textBoxPhone.Text = dataGridViewManage.CurrentRow.Cells[5].Value.ToString();
            this.textBoxAddress.Text = dataGridViewManage.CurrentRow.Cells[6].Value.ToString();
            duongDanHinhAnh = dataGridViewManage.CurrentRow.Cells[7].Value.ToString();
            //Lay duong dan den file hinh anh
            this.pictureBox1.Image = Image.FromFile(duongDanHinhAnh);
        }

        private void buttonUploadImg_Click(object sender, EventArgs e)
        {
            //Thiet lap thuoc tinh cho openFileDialog
            openFileDialogManage.Filter = "File hinh anh (*.png, *.jpeg, *.jpg) | *.png; *.jpeg; *.jpg";
            openFileDialogManage.Title = "Chon anh sinh vien";
            //Hien thi openFileDialog
            if (openFileDialogManage.ShowDialog() == DialogResult.OK)
            {
                //Lay duong dan den file hinh anh
                duongDanHinhAnh = openFileDialogManage.FileName;
                //Chep duong dan hinh anh nay vao picture box
                pictureBox1.Image = Image.FromFile(duongDanHinhAnh);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewManage.DataSource = null;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            FileInfo file = new FileInfo(FilePath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                List<Student> listSinhVien = new List<Student>();
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int dong = worksheet.Dimension.Start.Row + 1; dong <= worksheet.Dimension.End.Row; dong++)
                {
                    for (int cot = worksheet.Dimension.Start.Column; cot <= worksheet.Dimension.End.Column; cot++)
                    {
                        if (worksheet.Cells[dong, cot].Value.ToString() == this.textBoxSearch.Text)
                        {

                            Student sinhVien = new Student();
                            // Ghi dữ liệu sinh viên vào các ô
                            if (worksheet.Cells[dong, 1].Value is string)
                            {
                                sinhVien.id = (string)worksheet.Cells[dong, 1].Value;
                            }

                            if (worksheet.Cells[dong, 2].Value is string)
                            {
                                sinhVien.firstName = (string)worksheet.Cells[dong, 2].Value;
                            }

                            if (worksheet.Cells[dong, 3].Value is string)
                            {
                                sinhVien.lastName = (string)worksheet.Cells[dong, 3].Value;
                            }

                            if (worksheet.Cells[dong, 4].Value is DateTime)
                            {
                                sinhVien.birthDate = (DateTime)worksheet.Cells[dong, 4].Value;
                            }

                            if (worksheet.Cells[dong, 5].Value is string)
                            {
                                sinhVien.gender = (string)worksheet.Cells[dong, 5].Value;
                            }

                            if (worksheet.Cells[dong, 6].Value is string)
                            {
                                sinhVien.phoneNumber = (string)worksheet.Cells[dong, 6].Value;
                            }

                            if (worksheet.Cells[dong, 7].Value is string)
                            {
                                sinhVien.address = (string)worksheet.Cells[dong, 7].Value;
                            }

                            if (worksheet.Cells[dong, 8].Value is string)
                            {
                                sinhVien.picture = (string)worksheet.Cells[dong, 8].Value;
                            }

                            //Luu sinh vien nay vao listSinhVien
                            listSinhVien.Add(sinhVien);
                        }
                    }
                }
                dataGridViewManage.DataSource = listSinhVien;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.FilePath);

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                int dongSua;
                for (dongSua = worksheet.Dimension.Start.Row; dongSua < worksheet.Dimension.End.Row; dongSua++)
                {
                    if (worksheet.Cells[dongSua, 1].Value.ToString() == IDBeforeEdit)
                    {
                        break;
                    }
                }
                //Cap nhat cac o trong excel bang thong tin trong textbox khi nhap vao FormEditAndRemove
                worksheet.Cells[dongSua, 1].Value = this.textBoxID.Text;
                worksheet.Cells[dongSua, 2].Value = this.textBoxFirstName.Text;
                worksheet.Cells[dongSua, 3].Value = this.textBoxLastName.Text;
                worksheet.Cells[dongSua, 4].Value = this.dateTimePickerBirthDay.Value;
                if (this.radioButtonMale.Checked == true)
                {
                    worksheet.Cells[dongSua, 5].Value = "Male";
                }
                else { worksheet.Cells[dongSua, 5].Value = "Female"; }
                worksheet.Cells[dongSua, 6].Value = this.textBoxPhone.Text;
                worksheet.Cells[dongSua, 7].Value = this.textBoxAddress.Text;
                //Lay duong dan hinh anh ban dau hoac sau khi click upload button
                worksheet.Cells[dongSua, 8].Value = this.duongDanHinhAnh;
                MessageBox.Show("dong bi thay doi trong excel la: " + (dongSua).ToString());

                // Lưu file Excel
                package.Save();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewManage.DataSource = null;
            FormStudentsList_Load();
            //hien tong sinh vien o lable Total Students
            FileInfo file = new FileInfo(FilePath);
            using (ExcelPackage package = new ExcelPackage(file)) 
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int tongSV = worksheet.Dimension.End.Row - 1;
                this.labelTotalStudents.Text = "Total Students: " + tongSV.ToString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(FilePath);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                //worksheet.DeleteRow(dongHT + 2); //do dongHT la cua datagridview bat dau tu 0 con excel bat dau tu 1, +1 ghi ten cot
                //MessageBox.Show("Da xoa dong" + (dongHT + 2).ToString() + "trong excel");
                string IDXoa = this.textBoxID.Text;
                int dongXoa;
                for (dongXoa = worksheet.Dimension.Start.Row; dongXoa < worksheet.Dimension.End.Row; dongXoa++) 
                {
                    if (worksheet.Cells[dongXoa, 1].Value.ToString() == IDXoa)
                    {
                        break;
                    }
                }
                worksheet.DeleteRow(dongXoa); //do dongHT la cua datagridview bat dau tu 0 con excel bat dau tu 1, +1 ghi ten cot
                MessageBox.Show("Da xoa dong" + (dongXoa).ToString() + "trong excel");
                package.Save();
            }
        }
    }
}
