using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class LoaiKhachHang
{
    public string MaLoaiKh { get; set; } = null!;

    public string? TenLoaiKh { get; set; }

    public int? DiemTichLuy { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<DichVuKhachHang> DichVuKhachHangs { get; } = new List<DichVuKhachHang>();
}
