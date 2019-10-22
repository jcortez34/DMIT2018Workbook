<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//A) List all the customer company names for those with more than 5 orders.

from buyer in Customers
where buyer.Orders.Count() > 5
select buyer.CompanyName