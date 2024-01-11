using System;
using System.Collections.Generic;

namespace ConsoleApp.Data.EfCore;

public partial class ProductAdet
{
    public string ProductId { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? Adet { get; set; }
}
