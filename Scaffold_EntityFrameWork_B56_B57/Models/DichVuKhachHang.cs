using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class DichVuKhachHang
{
    public string MaDv { get; set; } = null!;

    public string MaLoaiKh { get; set; } = null!;

    public DateTime? NgayApDung { get; set; }

    public virtual DichVu MaDvNavigation { get; set; } = null!;

    public virtual LoaiKhachHang MaLoaiKhNavigation { get; set; } = null!;
}
