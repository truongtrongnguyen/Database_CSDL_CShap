using System;
using System.Collections.Generic;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class NhaCungCap
{
    public string MaCty { get; set; } = null!;

    public string? TenCty { get; set; }

    public string? TenGdich { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<MatHang> MatHangs { get; } = new List<MatHang>();
}
