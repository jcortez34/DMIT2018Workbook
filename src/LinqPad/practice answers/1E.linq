<Query Kind="Expression">
  <Connection>
    <ID>d8357bfc-d0e0-4d51-8157-7c2ff8de9bdb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//E) List all the region and territory names in a "flat" list
from place in Territories
select new 
{
	Region = place.Region.RegionDescription,
	Territory = place.TerritoryDescription
}