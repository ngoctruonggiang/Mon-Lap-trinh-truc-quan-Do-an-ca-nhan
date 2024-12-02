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
                    worksheet.Cells[row, 4].Value = sinhVien.birthDate.Date;
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
                        bool isValid = true;
                        // Ghi dữ liệu sinh viên vào các ô
                        if (worksheet.Cells[dong, 1].Value is string)
                        {
                            sinhVien.id = (string)worksheet.Cells[dong, 1].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("ID trong dong " + dong + " khong la kieu string");
                            isValid = false;

                        }
                        if (worksheet.Cells[dong, 2].Value is string)
                        {
                            sinhVien.firstName = (string)worksheet.Cells[dong, 2].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("First Name trong dong " + dong + " khong la kieu string");
                            isValid = false;

                        }
                        if (worksheet.Cells[dong, 3].Value is string)
                        {
                            sinhVien.lastName = (string)worksheet.Cells[dong, 3].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("Last Name trong dong " + dong + " khong la kieu string");
                            isValid = false;

                        }
                        if (worksheet.Cells[dong, 4].Value is DateTime)
                        {
                            sinhVien.birthDate = (DateTime)worksheet.Cells[dong, 4].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("Birth Day trong dong " + dong + " khong la kieu DateTime");
                            isValid = false;
                        }
                        if (worksheet.Cells[dong, 5].Value is string)
                        {
                            sinhVien.gender = (string)worksheet.Cells[dong, 5].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("Gioi Tinh trong dong " + dong + "  khong la kieu string");
                            isValid = false;
                        }
                        if (worksheet.Cells[dong, 6].Value is string)
                        {
                            sinhVien.phoneNumber = (string)worksheet.Cells[dong, 6].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("Phone Number trong dong " + dong + " khong la kieu string");
                            isValid = false;
                        }
                        if (worksheet.Cells[dong, 7].Value is string)
                        {
                            sinhVien.address = (string)worksheet.Cells[dong, 7].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("Address trong excel khong la kieu string");
                            isValid = false;
                        }
                        if (worksheet.Cells[dong, 8].Value is string)
                        {
                            sinhVien.picture = (string)worksheet.Cells[dong, 8].Value;
                        }
                        else
                        {
                            // Xử lý lỗi hoặc gán giá trị mặc định
                            MessageBox.Show("Picture trong dong " + dong + " khong la kieu string");
                                isValid = false;
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
    }
}
