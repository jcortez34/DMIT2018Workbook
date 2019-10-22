<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// B) List all the Customers by Company Name. Include the Customer's company name, contact name, and other contact information in the result.
from company in Customers
select new
{
	CompanyName = company.CompanyName,
	Contact = new 
				{
				
					Name = company.ContactName,
					Title = company.ContactTitle,
					Email = company.ContactEmail,
					Phone = company.Phone,
					Fax = company.Fax
				}
}