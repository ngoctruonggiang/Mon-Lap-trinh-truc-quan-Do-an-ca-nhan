using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
namespace WinForms_Student_Managed_app
{
    public partial class FormStatistics : Form
    {
        public int tongSinhVien = 0;
        public int soSVNam = 0;
        public int soSVNu = 0;
        public string linkFileEX = "D:\\Tai lieu mon hoc 2024\\Lập trình trực quan\\Do an thuc hanh cuoi ky" +
            "\\WinForms_Student_Managed_app\\WinForms_Student_Managed_app\\data_SinhVien.xlsx";
        public FormStatistics()
        {
            InitializeComponent();
            ThongKeSV();

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Tao ham tinh tinh tong sinh vien, so sinh vien nam, so sinh vien nu
        public void ThongKeSV()
        {
            double tyLeNam;
            double tyLeNu;
            FileInfo File = new FileInfo(linkFileEX);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(File)) 
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int dong = worksheet.Dimension.Start.Row + 1; dong <= worksheet.Dimension.End.Row; dong++) 
                {
                    if (worksheet.Cells[dong, 5].Value.ToString() == "Male")
                    {
                        tongSinhVien++;
                        soSVNam++;
                    }
                    else if (worksheet.Cells[dong, 5].Value.ToString() == "Female")
                    {
                        tongSinhVien++;
                        soSVNu++;
                    }
                    else { }
                    //tinh ty le nam, nu
                    tyLeNam = soSVNam * 100 / tongSinhVien;
                    tyLeNu = soSVNu * 100 / tongSinhVien;
                    labelTotalStudents.Text = "Tong so sinh vien: " + tongSinhVien.ToString();
                    labelMaleRatio.Text = "% Nam : " + tyLeNam.ToString() + " %";
                    labelFemaleRatio.Text = "% Nu : " + tyLeNu.ToString() + " %";
                    ExcelWorksheet worksheet1 = package.Workbook.Worksheets[1];
                    worksheet1.Cells[2, 1].Value = tongSinhVien;
                    worksheet1.Cells[2,2].Value = tyLeNam;
                    worksheet1.Cells[2, 3].Value = tyLeNu;

                }
                package.Save();
            }
        }
    }
}
