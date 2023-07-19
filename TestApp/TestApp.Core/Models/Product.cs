using System.ComponentModel.DataAnnotations;

namespace TestApp.Models;

public class Product
{
    [Key]
    public int Id  { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}