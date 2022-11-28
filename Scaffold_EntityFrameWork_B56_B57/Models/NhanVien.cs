using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public DateTime? NgayLamViec { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public double? LuongCb { get; set; }

    public double? PhuCap { get; set; }

    public string? HoTen { get; set; }

    public string? PassWordd { get; set; }

    public virtual ICollection<DonDatHang> DonDatHangs { get; } = new List<DonDatHang>();
}
