using System;

namespace CsBases.Fundamentals;

public interface IProduct
{
	void Deconstruct(out string? name, out decimal price);
	void ApplyDiscount(decimal discount);
	string GetDescription();
}
