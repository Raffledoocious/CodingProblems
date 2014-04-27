using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{

  /// <summary>
  /// Problem 8.6
  /// </summary>
  public class BuildingManager
  {
    private Stack<Building> canSeeSun;
    private List<Building> allBuildings;

    public BuildingManager()
    {
      canSeeSun = new Stack<Building>();
      allBuildings = new List<Building>();
    }

    public void AddBuilding(int height, int id)
    {
      Building newBuilding = new Building(height, id);
      if (canSeeSun.Count == 0 || canSeeSun.Peek().GetHeight() < height)
      {
        newBuilding.CanSeeSun = true;
        canSeeSun.Push(newBuilding);
      }
      else
      {
        newBuilding.CanSeeSun = false;
      }

      allBuildings.Add(newBuilding);
    }

    public List<Building> GetAllBuildings()
    {
      return allBuildings;
    }

    public Stack<Building> GetSunSeeingBuildings()
    {
      return canSeeSun;
    }
  }

  public class Building
  {
    private int height;
    private int id;

    public bool CanSeeSun { get; set; }

    public int GetHeight()
    {
      return height;
    }

    public int GetID()
    {
      return id;
    }

    public Building(int height, int id)
    {
      this.height = height;
      this.id = id;
    }
  }
}
