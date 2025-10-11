namespace CsBases.Fundamentals;

public class Product : IProduct
{
	public int Id { get; set; }

	[UpperCase]
	public string? Name { get; set; }
	public string? Description { get; set; }
	public decimal Price { get; set; }
	public bool IsAvailable { get; set; }
	public DateTime CreatedAt { get; set; }
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
	public virtual string GetDescription()
	{

		return $"Name: {Name}, Price: {Price:C}, Available: {IsAvailable}, Created At: {CreatedAt}, Unique Code: {UniqueCode}";
	}
}

class ServiceProduct : Product
{
	public int DurationInDays { get; set; }

	public ServiceProduct(string name, decimal price, int duration) : base(name, price)
	{
		DurationInDays = duration;
	}

	public override string GetDescription()
	{
		return $"{base.GetDescription()}, Duration: {DurationInDays} days";
	}
}