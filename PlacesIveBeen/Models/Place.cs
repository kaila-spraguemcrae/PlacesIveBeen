using System.Collections.Generic;

namespace PlacesIveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Durration { get; set; }
    public List<string> PeopleList { get; set; }
    public string Description { get; set; }
    private static List<Place> _instances = new List<Place> {};

    public Place(string cityName, int durration, List<string> peopleList, string description)
    {
      CityName = cityName;
      Durration = durration;
      PeopleList = peopleList;
      Description = description;
      _instances.Add(this);
    }
    
    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}