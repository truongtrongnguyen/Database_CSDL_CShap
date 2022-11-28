using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class ChiTietDathang
{
    public string SoHd { get; set; } = null!;

    public string MaHang { get; set; } = null!;

    public int? SoLuong { get; set; }

    public double? MucGiamGia { get; set; }

    public virtual MatHang MaHangNavigation { get; set; } = null!;

    public virtual DonDatHang SoHdNavigation { get; set; } = null!;
}
