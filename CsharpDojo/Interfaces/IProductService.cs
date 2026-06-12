using CsharpDojo.DTOs;

namespace CsharpDojo.Interfaces;
public interface IProductService
{
  List<ProductResponseDto> ListProducts();
  ProductResponseDto? ProductById(int id);
  ProductResponseDto CreateProduct(ProductRequestDto requestDto);
  ProductResponseDto? UpdateProduct(int id, ProductRequestDto requestDto);
  ProductResponseDto? DeleteProduct(int id);

}