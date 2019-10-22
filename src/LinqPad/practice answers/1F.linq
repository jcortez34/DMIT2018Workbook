<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// F) List all the region and territory names as an "object graph"
 from place in Regions
 select new
 {
 	Region = place.RegionDescription,
	Territories = from area in place.Territories
				select area.TerritoryDescription
 }