using System.Collections.Generic;

namespace PlacesList.Models
{
  public class Place
  {
    private string _name;
    private string _picture;
    private string _time;

    private static List<string> _instances = new List<string> {};

    // Contstructor
    public Place (string name, string picture, string time)
    {
      _name = name;
      _picture = picture;
      _time = time;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPicture()
    {
      return _picture;
    }
    public void SetPicture(string newPicture)
    {
      _picture = newPicture;
    }
    public string GetTime()
    {
      return _time;
    }
    public void SetTime(string newTime)
    {
      _time = newTime;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(("You went to " + _name + " | A link to a picture from the trip: " + _picture + " | You stayed there for " + _time + " days."));
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
