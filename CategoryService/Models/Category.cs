using System;
using System.Collections.Generic;

namespace CategoryService.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public decimal BasePrice { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
