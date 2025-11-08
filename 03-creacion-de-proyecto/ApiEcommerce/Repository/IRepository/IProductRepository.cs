/*
=============
🏆 Ejercicio 
=============
*/
// 1. Crear una interfaz llamada IProductRepository.
//
// 2. Incluir los siguientes métodos en la interfaz:
//
//    - GetProducts
//        → Devuelve todos los productos
//          en ICollection del tipo Product.
//
//    - GetProductsForCategory
//        → Recibe un categoryId y devuelve los productos
//          de esa categoría en ICollection del tipo Product.
//
//    - SearchProduct
//        → Recibe un nombre y devuelve los productos
//          que coincidan en ICollection del tipo Product.
//
//    - GetProduct
//        → Recibe un id y 
//          devuelve un solo objeto Product
//          o null si no se encuentra.
//
//    - BuyProduct
//        → Recibe el nombre del producto y una cantidad,
//          y devuelve un bool indicando si la compra fue exitosa.
//
//    - ProductExists (por id)
//        → Recibe un id y devuelve un bool
//          indicando si existe el producto.
//
//    - ProductExists (por nombre)
//        → Recibe un nombre y devuelve un bool
//          indicando si existe el producto.
//
//    - CreateProduct
//        → Recibe un objeto Product 
//          y devuelve un bool indicando si la creación fue exitosa.
//
//    - UpdateProduct
//        → Recibe un objeto Product
//          y devuelve un bool indicando si la actualización fue exitosa.
//
//    - DeleteProduct
//        → Recibe un objeto Product
//          y devuelve un bool indicando si la eliminación fue exitosa.
//
//    - Save
//        → Devuelve un bool indicando
//          si los cambios se guardaron correctamente.
using ApiEcommerce.Models;

namespace ApiEcommerce.Repository.IRepository;

public interface IProductRepository
{
	ICollection<Product> GetProducts();
	ICollection<Product>? GetProductsForCategory(int categoryId);
	ICollection<Product> SearchProducts(string searchTerm);

	Product? GetProduct(int id);
	bool BuyProduct(string name, int quantity);
	bool ProductExists(int id);
	bool ProductExists(string name);
	bool CreateProduct(Product product);
	bool UpdateProduct(Product product);
	bool DeleteProduct(Product product);

	bool Save();
}