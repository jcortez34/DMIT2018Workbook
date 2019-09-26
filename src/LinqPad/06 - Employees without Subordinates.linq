<Query Kind="Expression">
  <Connection>
    <ID>b5c596cc-b08b-4f56-8b29-bee27cfd44dc</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who do not manage anyone.
from person in Employees
//   Employee      Table<Employee>
where person.ReportsToChildren.Count == 0
//     Employee    IEnumerable<Employee>
select new
{
  Name = person.FirstName + " " + person.LastName,
  Manager = person.ReportsToEmployee.FirstName + " " + person.ReportsToEmployee.LastName
}