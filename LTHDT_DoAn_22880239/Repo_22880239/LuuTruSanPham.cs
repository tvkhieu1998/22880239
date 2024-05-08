using Entites_22880239;

namespace Repo_22880239
{
    public class LuuTruSanPham: ILuuTruSanPham
    {
        private string _filePath = "E:\\GITHUB DATA\\22880239_2\\dssp.txt";
        public List<MatHang> DocDanhSachSanPham()
        {
            List<MatHang> dsSanPham = new List<MatHang>();
            StreamReader file = new StreamReader(_filePath);
            int n;
            string s = file.ReadLine();
            n = int.Parse(s);
            for (int i = 0; i < n; i++)
            {
                s = file.ReadLine();
                dsSanPham.Add(new MatHang(s));
            }

            file.Close();
            return dsSanPham;
        }
        public List<MatHang> LuuDanhSachSanPham(List<MatHang> danhSachSP)
        {
            StreamWriter file = new StreamWriter(_filePath);
            file.WriteLine(danhSachSP.Count);
            foreach (var sp in danhSachSP)
            {
                file.WriteLine($"{sp.MaSP},{sp.TenSP},{sp.HanDung},{sp.CongTySX},{sp.NamSX},{sp.LoaiHang}");
            }
            file.Close();
            return danhSachSP;
        }

        public void ThemSanPham(MatHang sanPham)
        {
            var dssp = DocDanhSachSanPham();
            dssp.Add(sanPham);
            LuuDanhSachSanPham(dssp);
        }
        public List<MatHang>? DocChiTietSanPham(int masp)
        {
            List<MatHang> mh = DocDanhSachSanPham();
            foreach(MatHang s in mh)
            {
                if(s.MaSP == masp)
                {
                    return s;
                }
            }
            return null;
        }
        public void SuaSanPham(MatHang sanPham)
        {
            var mh = DocDanhSachSanPham();
            for(int i = 0; i< mh.Count; i++)
            {
                if (mh[i].MaSP == sanPham.MaSP)
                {
                    mh[i] = sanPham;
                }
            }
            LuuDanhSachSanPham(mh);
        }
        
    }
}