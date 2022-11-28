using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class DonDatHang
{
    public string SoHd { get; set; } = null!;

    public string? MaKh { get; set; }

    public string? MaNv { get; set; }

    public DateTime? NgayDatHang { get; set; }

    public DateTime? NgayGiaoHang { get; set; }

    public DateTime? NgayChuyenHang { get; set; }

    public string? NoiGiaoHang { get; set; }

    public virtual ICollection<ChiTietDathang> ChiTietDathangs { get; } = new List<ChiTietDathang>();

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual NhanVien? MaNvNavigation { get; set; }
}
