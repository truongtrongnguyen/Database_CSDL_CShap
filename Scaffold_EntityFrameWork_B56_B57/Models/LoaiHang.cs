using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class LoaiHang
{
    public string MaLoaiHang { get; set; } = null!;

    public string? TenLoaiHang { get; set; }

    public virtual ICollection<MatHang> MatHangs { get; } = new List<MatHang>();
}
