using Entites_22880239;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_22880239
{
    public interface ILuuTruSanPham
    {
        List<SanPham> DocDanhSachSanPham();
        void ThemSanPham(SanPham sanPham);
    }
}
