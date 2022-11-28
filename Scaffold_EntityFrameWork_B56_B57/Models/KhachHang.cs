using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string? TenCty { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public string? Fax { get; set; }

    public string? HoTenKH { get; set; }

    public string? MaLoaiKh { get; set; }

    public int? DiemTichLuy { get; set; }

    public virtual ICollection<DonDatHang> DonDatHangs { get; } = new List<DonDatHang>();
}
