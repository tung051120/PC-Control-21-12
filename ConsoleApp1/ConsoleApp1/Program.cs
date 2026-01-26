using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HeThongSensor
{
    class Program
    {
        // Sử dụng Dictionary để quản lý danh sách sensor
        static Dictionary<string, bool> sensorStatus = new Dictionary<string, bool>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Setup: Khởi tạo danh sách các sensor
            sensorStatus.Add("S001", true); // Sensor đang online
            sensorStatus.Add("S002", false); // Sensor bị ngắt kết nối

            Console.WriteLine("--- HỆ THỐNG GHI LOG SENSOR ĐA LUỒNG ---");

            // Giả lập ghi log cho Sensor S001
            LogSensorData("S001", "36.5");

            // Giả lập ghi log cho Sensor S002 (Sẽ gây lỗi Disconnected)
            LogSensorData("S002", "37.0");

            Console.ReadLine();
        }

        static void LogSensorData(string sensorId, string readingValue)
        {
            try
            {
                // 2. Xử lý Exception: Sensor disconnected
                if (!sensorStatus.ContainsKey(sensorId) || !sensorStatus[sensorId])
                {
                    throw new Exception($"Sensor {sensorId} is disconnected!");
                }

                // 3. Tạo tên file theo format: sensor_[ID]_[date].csv
                string date = DateTime.Now.ToString("yyyyMMdd");
                string FileName = $"sensor_{sensorId}_{date}.csv";

                // 4. KHAI BÁO FileInfo để quản lý file
                FileInfo myFile = new FileInfo(FileName);

                // 5. Sử dụng StringBuilder để xây dựng dòng dữ liệu (Thread-safe logging mô phỏng)
                StringBuilder sb = new StringBuilder();

                // Nếu file mới, tạo Header cho Excel
                if (!myFile.Exists)
                {
                    sb.AppendLine("Time,SensorID,Value");
                }

                sb.Append(DateTime.Now.ToString("HH:mm:ss"));
                sb.Append(",");
                sb.Append(sensorId);
                sb.Append(",");
                sb.Append(readingValue);

                // 6. Kiểm tra kích thước file để tự động nén (Rotate files by size 10MB)
                if (myFile.Exists && myFile.Length > 10 * 1024 * 1024)
                {
                    Console.WriteLine($"[Cảnh báo] File {FileName} dat 10MB. Dang thuc hien auto-compress...");
                    // Tại đây sẽ thực hiện lệnh nén file cũ
                }

                // 7. Ghi vào file (Xử lý Exception: file locked)
                using (StreamWriter sw = myFile.AppendText())
                {
                    sw.WriteLine(sb.ToString());
                }

                Console.WriteLine($"[Thành công] Đã ghi log cho {sensorId}");
            }
            catch (IOException)
            {
                // Xử lý lỗi file locked (khi đang mở Excel) hoặc disk full
                Console.WriteLine("[Lỗi] Khong the ghi file: File locked hoac Disk full!");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi sensor disconnected hoặc lỗi khác
                Console.WriteLine($"[Lỗi Hệ Thống] {ex.Message}");
            }
        }
    }
}