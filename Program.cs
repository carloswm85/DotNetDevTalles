// See https://aka.ms/new-console-template for more information

using CsBases.Fundamentals;

class Program
{
	static void Main(string[] args)
	{
		var laptop = new Product("Laptop", 1500m);
		WriteLine(laptop.GetDescription());
		var support = new ServiceProduct("Technical Support", 300m, 30);
		WriteLine(support.GetDescription());

		var product = new Product("Mouse Gamer", 300);
		var productDto = ProductAdapter.ToDto(product);

		WriteLine($"Product DTO - Name: {productDto.Name}, Price: {productDto.Price}, Code: {productDto.Code}");
	}
}