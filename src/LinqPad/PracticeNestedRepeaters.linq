<Query Kind="Program">
  <Connection>
    <ID>b5c596cc-b08b-4f56-8b29-bee27cfd44dc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

void Main()
{
	
	var result = from supplier in Suppliers
	select new 
	{
		Company = supplier.CompanyName,
		Contact = supplier.ContactName,
		Phone = supplier.Phone,
		Products = from product in Products
		select new
		{
			Product = product.ProductName,
			Category = from category in Categories where category.CategoryID == product.CategoryID select category.CategoryName,
			Price = product.UnitPrice,
			Quantity = product.QuantityPerUnit		
		}
	};
	result.Dump();
}

// Define other methods and classes here
public class SupplierInfo
{
	public string Company {get; set;}
	public string Contact {get; set;}
	public string Phone {get;set;}
	public IEnumerable <ProductSummary> Products {get; set;}
}

public class ProductSummary
{
	public string Product {get;set;}
	public string Category{get; set;}
	public decimal Price {get;set;}
	public string Quantity{get;set;} 
}