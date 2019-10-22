<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// E) Group all customers by city. Output the city name, aalong with the company name, contact name and title, and the phone number.

from company in Customers
group company by company.Address.City into customersByCity
select new 
{
	City = customersByCity.Key,
	Customers = from buyer in customersByCity
				select new
				{
					buyer.CompanyName,
					buyer.ContactName,
					buyer.ContactTitle,
					buyer.Phone
				}
}