<Query Kind="Expression">
  <Connection>
    <ID>b5c596cc-b08b-4f56-8b29-bee27cfd44dc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who do not have a manager
// (i.e.: they do not report to anyone).
from person in Employees
//   thing      thing[] 
where person.ReportsToEmployee == null
//   thing     thing 
select new
{
  Name = person.FirstName + " " + person.LastName
}