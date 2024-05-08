using Entites_22880239;
using Repo_22880239;

namespace Services_22880239
{
    public class XuLySanPham: IXuLySanPham
    {
        private ILuuTruSanPham _luuTruSanPham = new LuuTruSanPham();
        public List<MatHang> DocDanhSachSanPham(string TuKhoa = "")
        {
            List<MatHang> kq = new List<MatHang>();
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
        public void ThemSanPham(MatHang sanPham)
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
        public void SuaSanPham(MatHang sanPham)
        {
            _luuTruSanPham.SuaSanPham(sanPham);
        }
    }
}