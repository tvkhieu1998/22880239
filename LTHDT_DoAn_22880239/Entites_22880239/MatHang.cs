namespace Entites_22880239
{
    public class MatHang
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string HanDung { get; set; }
        public string CongTySX { get; set; }
        public int NamSX {  get; set; }
        public string LoaiHang { get; set; }
        public MatHang(string tenSP, string hanDung, string congTySX, int namSx, string loaiHang)
        {
            if (string.IsNullOrEmpty(tenSP))
            {
                throw new Exception("Ten khong hop le");
            }
            if (string.IsNullOrEmpty(hanDung))
            {
                throw new Exception("Han dung khong hop le");
            }
            if (string.IsNullOrEmpty(congTySX))
            {
                throw new Exception("Ten cong ty khong hop le");
            }
            if (namSx <= 0)
            {
                throw new Exception("Nam nhap khong hop le");
            }
            if (string.IsNullOrEmpty(loaiHang))
            {
                throw new Exception("Loai hang khong hop le");
            }
            TenSP = tenSP;
            HanDung = hanDung;
            CongTySX = congTySX;
            NamSX = namSx;
            LoaiHang = loaiHang;
        }
        public MatHang(string s)
        {
            string[] m = s.Split(',');
            MaSP = int.Parse(m[0]);
            TenSP = m[1];
            HanDung = m[2];
            CongTySX = m[3];
            NamSX = int.Parse(m[4]);
            LoaiHang = m[5];
        }
    }
}