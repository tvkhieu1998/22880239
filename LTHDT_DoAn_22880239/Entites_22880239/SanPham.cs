namespace Entites_22880239
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int Gia { get; set; }
        public SanPham(string tenSP, int gia)
        {
            if (string.IsNullOrEmpty(tenSP))
            {
                throw new Exception("Ten khong hop le");
            }
            if (gia <= 0)
            {
                throw new Exception("Gia khong hop le");
            }
            TenSP = tenSP;
            Gia = gia;
        }
        public SanPham(string s)
        {
            string[] m = s.Split(',');
            MaSP = int.Parse(m[0]);
            TenSP = m[1];
            Gia = int.Parse(m[2]);
        }
    }
}