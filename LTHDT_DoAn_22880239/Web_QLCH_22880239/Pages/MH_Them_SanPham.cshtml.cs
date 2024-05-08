using Entites_22880239;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services_22880239;

namespace Web_QLCH_22880239.Pages
{
    public class MH_Them_SanPhamModel : PageModel
    {
        [BindProperty]
        public string TenSP { get; set; }
        [BindProperty]
        public string HanDung { get; set; }

        [BindProperty]
        public string CongTySX { get; set; }
        [BindProperty]
        public int NamSX { get; set; }
        [BindProperty]
        public string LoaiHang { get; set; }
        public string Chuoi { get; set; } = string.Empty;
        private IXuLySanPham _xuLySanPham = new XuLySanPham();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {
                var sp = new MatHang(TenSP, HanDung, CongTySX, NamSX, LoaiHang);
                _xuLySanPham.ThemSanPham(sp);
                Response.Redirect("/MH_DanhSach_SanPham");
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
    }
}
