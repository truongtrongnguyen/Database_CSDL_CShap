using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class DichVu
{
    public string MaDv { get; set; } = null!;

    public string? TenDv { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<DichVuKhachHang> DichVuKhachHangs { get; } = new List<DichVuKhachHang>();
}
