namespace CsharpDojo.DTOs;

public class ProductRequestDto
{
  public required string  Name { get; set; }
  public decimal Price { get; set; }
  public int Inventory { get; set; }
}