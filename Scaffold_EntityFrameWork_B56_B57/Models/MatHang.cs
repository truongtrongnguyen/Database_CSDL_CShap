using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class MatHang
{
    public string MaHang { get; set; } = null!;

    public string? TenHang { get; set; }

    public string? MaCty { get; set; }

    public string? MaLoaiHang { get; set; }

    public int? SoLuong { get; set; }

    public string? DonViTinh { get; set; }

    public double? GiaNhap { get; set; }

    public double? GiaBan { get; set; }

    public virtual ICollection<ChiTietDathang> ChiTietDathangs { get; } = new List<ChiTietDathang>();

    public virtual NhaCungCap? MaCtyNavigation { get; set; }

    public virtual LoaiHang? MaLoaiHangNavigation { get; set; }
}
