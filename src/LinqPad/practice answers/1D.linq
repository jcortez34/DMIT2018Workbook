<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//D) List all the regions and the number of territories in each region

from place in Regions
select new
{
	Region = place.RegionDescription,
	TerritoryCount = place.Territories.Count()
}