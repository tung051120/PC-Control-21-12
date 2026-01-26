using OfficeOpenXml;
namespace BTVN_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.License.SetNonCommercialPersonal("DinhTung");
            List<string> mahs = new List<string>();
            List<string> tenhs = new List<string>();
            List<double> toan = new List<double>();
            List<double> van = new List<double>();
            List<double> anh = new List<double>();
            List<double> trungbinhdiem = new List<double>();
            List<string> xeploai = new List<string>();
            string fileinput = "D:\\PC Control 2112\\module 1\\BTVN_8\\BTVN_8\\input.xlsx";
            string fileoutput = "D:\\PC Control 2112\\module 1\\BTVN_8\\BTVN_8\\output.xlsx";
            try
            {
                FileInfo existing = new FileInfo(fileinput);
                using (ExcelPackage package = new ExcelPackage(existing))
                {
                    ExcelWorksheet ws = package.Workbook.Worksheets["HocSinh"];
                    int rowcount = ws.Dimension.Rows;
                    for (int row = 2; row <= rowcount; row++)
                    {
                        mahs.Add(ws.Cells[row, 1].Value?.ToString());
                        tenhs.Add(ws.Cells[row, 2].Value?.ToString());
                        try
                        {
                            toan.Add(Convert.ToDouble(ws.Cells[row, 3].Value));
                        }
                        catch
                        {
                            toan.Add(0);
                        }
                        try
                        {
                            van.Add(Convert.ToDouble(ws.Cells[row, 4].Value));
                        }
                        catch
                        {
                            van.Add(0);
                        }
                        try
                        {
                            anh.Add(Convert.ToDouble(ws.Cells[row, 5].Value));
                        }
                        catch
                        {
                            anh.Add(0);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("khong tim thay sheet hoac sheet khong co du lieu");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file khong ton tai");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"loi doc file: {ex.Message}");
            }
            for(int i=0; i<mahs.Count;i++)
            {
                double tb = (toan[i] + van[i] + anh[i]) / 3;
                trungbinhdiem.Add(Math.Round(tb, 2));
                if (tb >= 8) xeploai.Add("gioi");
                else if (tb >= 6) xeploai.Add("kha");
                else if (tb >= 4) xeploai.Add("trung binh");
                else xeploai.Add("yeu");
                switch(tb)
                {
                    case 10:
                     xeploai.Add("hoan hao");
                     break;
                }

            }
            Console.WriteLine("---KET QUA HOC TAP---");
            int a = 0;
            while(a<mahs.Count)
            {
                Console.WriteLine($"{mahs[a]}   {tenhs[a]}  {trungbinhdiem[a]}  {xeploai[a]}");
                a++;
            }
            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    
                    ExcelWorksheet ws = package.Workbook.Worksheets.Add("KetQua");

                    
                    ws.Cells[1, 1].Value = "ma hs";
                    ws.Cells[1, 2].Value = "ten hs";
                    ws.Cells[1, 3].Value = "trung binh";
                    ws.Cells[1, 4].Value = "xep loai";

                    
                    for (int i = 0; i < mahs.Count; i++)
                    {
                        ws.Cells[i + 2, 1].Value = mahs[i];
                        ws.Cells[i + 2, 2].Value = tenhs[i];
                        ws.Cells[i + 2, 3].Value = trungbinhdiem[i];
                        ws.Cells[i + 2, 4].Value = xeploai[i];
                    }

                   
                    package.SaveAs(new FileInfo(fileoutput));
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("loi ghi file: " + ex.Message);
            }
        }
    }
}
