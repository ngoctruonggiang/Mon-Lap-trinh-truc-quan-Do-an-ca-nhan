using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using System.Windows.Forms;

namespace WinForms_Student_Managed_app
{
    public class ExcelHelper
    {
        //public static List<Student> listSinhVien;
        public void ThemSinhVienVaoExcel(string filePath, Student sinhVien)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo file = new FileInfo(filePath);

            try
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên

                    // Tìm dòng trống tiếp theo để chèn dữ liệu
                    int row = worksheet.Dimension != null ? worksheet.Dimension.End.Row + 1 : 1;

                    // Ghi dữ liệu sinh viên vào các ô
                    worksheet.Cells[row, 1].Value = sinhVien.id;
                    worksheet.Cells[row, 2].Value = sinhVien.firstName;
                    worksheet.Cells[row, 3].Value = sinhVien.lastName; // Định dạng ngày tháng
                    worksheet.Cells[row, 4].Value = sinhVien.birthDate;
                    worksheet.Cells[row, 5].Value = sinhVien.gender;
                    worksheet.Cells[row, 6].Value = sinhVien.phoneNumber;
                    worksheet.Cells[row, 7].Value = sinhVien.address;
                    worksheet.Cells[row, 8].Value = sinhVien.picture;

                    // Lưu file Excel
                    package.Save();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi thêm sinh viên vào file Excel: " + ex.Message);
            }
        }

        public List<Student> ChooseAllStudents(string filePath)
        {
            List<Student> listSinhVien = new List<Student>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo file = new FileInfo(filePath);

            try
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                    if (worksheet.Dimension == null)
                    {
                        // Xử lý trường hợp sheet trống, ví dụ: throw exception hoặc return danh sách rỗng
                        throw new Exception("Sheet không có dữ liệu.");
                    }
                    for (int dong = worksheet.Dimension.Start.Row + 1; dong <= worksheet.Dimension.End.Row; dong++) 
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
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi hiển thị tất cả sinh viên trong file Excel: " + ex.Message);
            }
            return listSinhVien;
        }

        public void CapNhatDuLieuExcel(string filePath, int dongHienTai, FormEditAndRemove formEdit)
        {
            FileInfo file = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                //Cap nhat cac o trong excel bang thong tin trong textbox khi nhap vao FormEditAndRemove
                worksheet.Cells[dongHienTai, 1].Value = formEdit.textBoxID.Text;
                worksheet.Cells[dongHienTai, 2].Value = formEdit.FirstNameTextBox.Text;
                worksheet.Cells[dongHienTai, 3].Value = formEdit.LastNameTextBox.Text;
                worksheet.Cells[dongHienTai, 4].Value = formEdit.dateTimePicker1.Value;
                if (formEdit.MaleRadioButton.Checked == true) 
                {
                    worksheet.Cells[dongHienTai, 5].Value = "Male";
                }
                else { worksheet.Cells[dongHienTai, 5].Value = "Female"; }
                worksheet.Cells[dongHienTai, 6].Value = formEdit.PhoneTextBox.Text;
                worksheet.Cells[dongHienTai, 7].Value = formEdit.AddressTextBox.Text;
               // worksheet.Cells[dongHienTai, 8].Value = formEdit.duongDanHinhAnh;

                // Lưu file Excel
                package.Save();
            }
        }
    }
}
