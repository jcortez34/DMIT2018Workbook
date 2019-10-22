<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// A) Group employees by region and show the results in this format:
/* ----------------------------------------------
 * | REGION        | EMPLOYEES                  |
 * ----------------------------------------------
 * | Eastern       | ------------------------   |
 * |               | | Nancy Devalio        |   |
 * |               | | Fred Flintstone      |   |
 * |               | | Bill Murray          |   |
 * |               | ------------------------   |
 * |---------------|----------------------------|
 * | ...           |                            |
 * 
 */
 
 from place in Regions
 select new
 {
 	Region = place.RegionDescription,
	Employees = (from area in place.Territories
				from manager in area.EmployeeTerritories
				select manager.Employee.FirstName + " " + manager.Employee.LastName)
				.Distinct(),
	Employees2 = from area in place.Territories
				from manager in area.EmployeeTerritories
				group manager by manager.Employee into areaManagers
				select areaManagers.Key.FirstName + " " + areaManagers.Key.LastName
 }