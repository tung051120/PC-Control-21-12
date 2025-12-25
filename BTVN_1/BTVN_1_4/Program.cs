namespace BTVN_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toTien = 500;
            // BOXING TIEN VAO PHONG BI DE MUNG CUOI BAN CHIEN
            object phongBi = toTien; // boxing      
            // BAY GIO BAN CHIEN MUON DI MUA AO
            Console.WriteLine("nhap vao gia tri chiec ao: ");
            int tienMuaAo = Convert.ToInt32(Console.ReadLine());
            // BAN CHIEN CAN UNBOXING DE LAY TIEN RA MUA AO
            int soTienConLai = (int)phongBi - tienMuaAo; // unboxing

            Console.WriteLine("So tien con lai sau khi mua ao: "+soTienConLai);

        }
    }
}
