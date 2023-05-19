using System;
using System.Collections.Generic;

namespace UdemySwagger.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime? Date { get; set; }

    public string? Category { get; set; }
}
