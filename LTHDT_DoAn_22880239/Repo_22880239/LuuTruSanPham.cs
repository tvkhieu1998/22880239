using Entites_22880239;

namespace Repo_22880239
{
    public class LuuTruSanPham: ILuuTruSanPham
    {
        private string _filePath = "E:\\22880239\\dssp.txt";
        public List<SanPham> DocDanhSachSanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            StreamReader file = new StreamReader(_filePath);
            int n;
            string s = file.ReadLine();
            n = int.Parse(s);
            for (int i = 0; i < n; i++)
            {
                s = file.ReadLine();
                dsSanPham.Add(new SanPham(s));
            }

            file.Close();
            return dsSanPham;
        }
        public List<SanPham> LuuDanhSachSanPham(List<SanPham> danhSachSP)
        {
            StreamWriter file = new StreamWriter(_filePath);
            file.WriteLine(danhSachSP.Count);
            foreach (var sp in danhSachSP)
            {
                file.WriteLine($"{sp.MaSP}, {sp.TenSP}, {sp.Gia}");
            }
            file.Close();
            return danhSachSP;
        }

        public void ThemSanPham(SanPham sanPham)
        {
            var dssp = DocDanhSachSanPham();
            dssp.Add(sanPham);
            LuuDanhSachSanPham(dssp);
        }
    }
}