<Query Kind="Expression">
  <Connection>
    <ID>b5c596cc-b08b-4f56-8b29-bee27cfd44dc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who are managers.
from person in Employees
//   thing      thing[] 
where person.ReportsToChildren.Count > 0
//     thing    thing[]
select new
{
  Name = person.FirstName + " " + person.LastName,
  Subordinates = from sub in person.ReportsToChildren 
  				 select sub.FirstName + " " + sub.LastName
}