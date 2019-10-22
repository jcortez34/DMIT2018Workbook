<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//H) List all the discontinued products, specifying the product name and unit price.

from item in Products
where item.Discontinued
select new 
{
	item.ProductName,
	item.UnitPrice
}