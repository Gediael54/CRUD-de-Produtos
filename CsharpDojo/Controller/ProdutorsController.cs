using CsharpDojo.Data;
using CsharpDojo.DTOs;
using CsharpDojo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CsharpDojo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductControllers : ControllerBase
{
  private readonly IProductService _service;
  public ProductControllers(IProductService service)
  {
    _service = service;
  }

  [HttpGet]
  public IActionResult ListProducts()
  {
    return Ok(_service.ListProducts());
  }

  [HttpGet("{id}")]
  public IActionResult ProductById(int id)
  {
    return Ok(_service.ProductById(id));
  }

  [HttpPost]
  public IActionResult CreateProduct(ProductRequestDto requestDto)
  {
    return Ok(_service.CreateProduct(requestDto));
  }
  [HttpPut("{id}")]
  public IActionResult UpdateProduct(int id, ProductRequestDto requestDto)
  {
    return Ok(_service.UpdateProduct(id, requestDto));
  }
  [HttpDelete("{id}")]
  public IActionResult DeleteProduct(int id)
  {
    return Ok(_service.DeleteProduct(id));
  }
}