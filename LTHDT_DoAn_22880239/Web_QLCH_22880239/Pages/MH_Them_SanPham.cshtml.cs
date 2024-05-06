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
        public int Gia { get; set; }
        public string Chuoi { get; set; } = string.Empty;
        private IXuLySanPham _xuLySanPham = new XuLySanPham();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {
                var sp = new SanPham(TenSP, Gia);
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
