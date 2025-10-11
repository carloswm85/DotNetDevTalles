using CsBases.Fundamentals;

/// <summary>
/// Get information from a database, external API or file
/// </summary>
public class ProductRepository
{
	public async Task<Product> GetProduct(int id)
	{
		WriteLine("Searching product...");

		await Task.Delay(2000);
		return new Product("Producto simulado", 500);
	}
}