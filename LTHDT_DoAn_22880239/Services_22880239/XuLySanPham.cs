using Entites_22880239;
using Repo_22880239;

namespace Services_22880239
{
    public class XuLySanPham: IXuLySanPham
    {
        private ILuuTruSanPham _luuTruSanPham = new LuuTruSanPham();
        public List<SanPham> DocDanhSachSanPham(string TuKhoa = "")
        {
            List<SanPham> kq = new List<SanPham>();
            var dssp = _luuTruSanPham.DocDanhSachSanPham();
            foreach (var sp in dssp)
            {
                if (sp.TenSP.Contains(TuKhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
        public void ThemSanPham(SanPham sanPham)
        {
            var dssp = _luuTruSanPham.DocDanhSachSanPham();
            int maxID = 0;
            foreach (var sp in dssp)
            {
                if (sp.MaSP > maxID)
                {
                    maxID = sp.MaSP;
                }
            }
            sanPham.MaSP = maxID + 1;
            _luuTruSanPham.ThemSanPham(sanPham);
        }
    }
}