using System.Collections.Generic;

namespace Places.Models
{
  public class Item
{
  public string Description { get; set; }
  public string Date { get; set;}
  public string Location { get; set; }
  public string Duration { get; set; }
  public string Companion { get; set; }
  public int Id { get; }
  private static List<Item> _instances = new List<Item> {};

    public Item(string description, string date, string location, string duration, string companion)
    {
      Description = description;
      Date = date;
      Location = location;
      Duration = duration;
      Companion = companion;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}