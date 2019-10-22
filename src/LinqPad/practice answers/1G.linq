<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//G) List all the product names that contain the word "chef" in the name.

from item in Products
where item.ProductName.Contains("chef")
select item.ProductName