namespace CsBases.Fundamentals;

public class Product : IProduct
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public decimal Price { get; set; }
	public bool IsAvailable { get; set; }
	public DateTime CreatedAt { get; set; }
	public DateTime? UpdatedAt { get; set; }
	public Guid UniqueCode { get; set; }

	public Product(string name, decimal price)
	{
		Name = name;
		Price = price;
		CreatedAt = DateTime.Now;
		UniqueCode = Guid.NewGuid();
	}
	public void Deconstruct(out string? name, out decimal price)
	{
		name = Name;
		price = Price;
	}
	public void ApplyDiscount(decimal discount)
	{
		var discountAmount = Price * discount / 100;
		Price -= discountAmount;
	}
	public string GetDescription()
	{
		return $"Name: {Name}, Price: {Price:C}, Available: {IsAvailable}, Created At: {CreatedAt}, Updated At: {UpdatedAt}, Unique Code: {UniqueCode}";
	}
}
