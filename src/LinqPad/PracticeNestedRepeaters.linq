<Query Kind="Expression">
  <Connection>
    <ID>b5c596cc-b08b-4f56-8b29-bee27cfd44dc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

from supplier in Suppliers
select new 
{
	Company = supplier.CompanyName,
	Contact = supplier.ContactName,
	Phone = supplier.Phone,
	ProductSummary = from product in Products
	select new
	{
		Product = product.ProductName,
		Category = from category in Categories where category.CategoryID == product.CategoryID select category.CategoryName,
		Price = product.UnitPrice,
		Quantity = product.QuantityPerUnit		
	}
}
