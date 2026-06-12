using CsharpDojo.Data;
using CsharpDojo.DTOs;
using CsharpDojo.Interfaces;
using CsharpDojo.Models;

namespace CsharpDojo.Services;

public class ProductService : IProductService
{
  private readonly AppDbContext _context;

  public ProductService(AppDbContext context)
  {
        _context = context;

  }
  public List<ProductResponseDto> ListProducts()
  {
    return _context.Products.ToList().Select(p => new ProductResponseDto {
      Id = p.Id,
      Name = p.Name,
      Price = p.Price,
      CreatedAt = p.CreatedAt,
      Inventory = p.Inventory
     }).ToList();
  }

  public ProductResponseDto? ProductById(int Id)
  {
    var product = _context.Products.Find(Id);
    if (product == null) {
      return null;
    }
    return new ProductResponseDto
    {
      Id = product.Id,
      Name = product.Name,
      Price = product.Price,
      CreatedAt = product.CreatedAt,
      Inventory = product.Inventory
    };
  }

  public ProductResponseDto CreateProduct(ProductRequestDto requestDto)
  {
    var product = new Product
    {
      Name = requestDto.Name,
      Price = requestDto.Price,
      CreatedAt = DateTime.Now,
      Inventory = requestDto.Inventory
    };
    _context.Products.Add(product);
    _context.SaveChanges();
    return new ProductResponseDto
    {
      Id = product.Id,
      Name = product.Name,
      Price = product.Price,
      CreatedAt = product.CreatedAt,
      Inventory = product.Inventory
    };
  }

  public ProductResponseDto? UpdateProduct(int id, ProductRequestDto requestDto)
  {
    var product = _context.Products.Find(id);
    if (product == null )
    {
      return null;
    }
    
    product.Name = requestDto.Name;
    product.Price = requestDto.Price;
    product.Inventory = requestDto.Inventory;

    _context.Products.Update(product);
    _context.SaveChanges(); 
    return new ProductResponseDto
    {
      Id = product.Id,
      Name = product.Name,
      Price = product.Price,
      CreatedAt = product.CreatedAt,
      Inventory = product.Inventory
    };
  }
  

  public ProductResponseDto? DeleteProduct(int id)
  {
    var product = _context.Products.Find(id);
    if (product == null)
    {
      return null;
    }
    _context.Products.Remove(product);
    _context.SaveChanges(); 
    return new ProductResponseDto
    {
      Id = product.Id,
      Name = product.Name,
      Price = product.Price,
      CreatedAt = product.CreatedAt,
      Inventory = product.Inventory
    };
  }
}