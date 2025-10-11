// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using CsBases.Fundamentals;

class Program
{
	static async Task Main(string[] args)
	{
		var laptop = new Product("Laptop", 1500m);
		WriteLine(laptop.GetDescription());
		var support = new ServiceProduct("Technical Support", 300m, 30);
		WriteLine(support.GetDescription());

		var product = new Product("Mouse Gamer", 300);
		var productDto = ProductAdapter.ToDto(product);

		WriteLine($"Product DTO - Name: {productDto.Name}, Price: {productDto.Price}, Code: {productDto.Code}");

		// INYECCIÓN DE DEPENDENCIA
		WriteLine(">>> INYECCIÓN DE DEPENDENCIA");
		ILabelService labelService = new LabelService();
		var manager = new ProductManager(labelService);
		var monitor = new Product("Monitor", 100);
		var installation = new ServiceProduct("Instalación de monitor", 20, 30);

		manager.PrintLabel(monitor);
		manager.PrintLabel(installation);

		// MÉTODOS ASÍNCRONOS
		var firstProduct = await new ProductRepository().GetProduct(1);
		firstProduct.Description = "This is the description of the first product";

		AttributeProcessor.ApplyUpperCase(firstProduct);
		WriteLine($"{firstProduct.Name} - {firstProduct.Price:C} - {firstProduct.Description}");
	}
}