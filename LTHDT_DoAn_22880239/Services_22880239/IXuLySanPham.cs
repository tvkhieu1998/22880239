using Entites_22880239;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_22880239
{
    public interface IXuLySanPham
    {
        List<MatHang> DocDanhSachSanPham(string tukhoa = "");
        void ThemSanPham(MatHang sanPham);
    }
}
