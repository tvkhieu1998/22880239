using Entites_22880239;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services_22880239;

namespace Web_QLCH_22880239.Pages
{
    public class MH_DanhSach_SanPhamModel : PageModel
    {
        private IXuLySanPham _xuLySanPham = new XuLySanPham();
        public List<SanPham> DanhSachSanPham;
        [BindProperty]

        public string Tukhoa { get; set; }
        public void OnGet()
        {
            DanhSachSanPham = _xuLySanPham.DocDanhSachSanPham();
        }
        public void OnPost()
        {
            DanhSachSanPham = _xuLySanPham.DocDanhSachSanPham(Tukhoa);
        }
    }
}
