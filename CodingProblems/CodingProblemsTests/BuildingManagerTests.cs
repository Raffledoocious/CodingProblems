using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;

using System.Collections.Generic;

namespace CodingProblemsTests
{
  [TestClass]
  public class BuildingManagerTests
  {
    [TestMethod]
    public void CanSeeSun_AllBuildingsSameHeight_OnlyOneCanSeeSun()
    {
      BuildingManager manager = new BuildingManager();
      manager.AddBuilding(10, 1);
      manager.AddBuilding(10, 2);
      manager.AddBuilding(10, 3);
      manager.AddBuilding(10, 4);

      List<Building> canSeeBuildings = manager.GetSunSeeingBuildings();

      Assert.AreEqual(1, canSeeBuildings.Count);
      Assert.AreEqual(1, canSeeBuildings[0].GetID());
    }

    [TestMethod]
    public void CanSeeSun_FirstBuildingIsTallest_FirstBuildingIsReturned()
    {
      BuildingManager manager = new BuildingManager();
      manager.AddBuilding(11, 1);
      manager.AddBuilding(10, 2);
      manager.AddBuilding(10, 3);
      manager.AddBuilding(10, 4);

      List<Building> canSeeBuildings = manager.GetSunSeeingBuildings();

      Assert.AreEqual(1, canSeeBuildings.Count);
      Assert.AreEqual(1, canSeeBuildings[0].GetID());
    }

    [TestMethod]
    public void CanSeeSun_BuildingsInAscendingOrder_AllCanSee()
    {
      BuildingManager manager = new BuildingManager();
      manager.AddBuilding(11, 1);
      manager.AddBuilding(12, 2);
      manager.AddBuilding(13, 3);
      manager.AddBuilding(14, 4);

      List<Building> canSeeBuildings = manager.GetSunSeeingBuildings();

      Assert.AreEqual(4, canSeeBuildings.Count);
      Assert.AreEqual(4, canSeeBuildings[0].GetID());
      Assert.AreEqual(3, canSeeBuildings[1].GetID());
      Assert.AreEqual(2, canSeeBuildings[2].GetID());
      Assert.AreEqual(1, canSeeBuildings[3].GetID());
    }

    [TestMethod]
    public void CanSeeSun_TallestBuilidingInMiddle_OnlyFirstBuildingsCanSee()
    {
      BuildingManager manager = new BuildingManager();
      manager.AddBuilding(11, 1);
      manager.AddBuilding(12, 2);
      manager.AddBuilding(13, 3);
      manager.AddBuilding(9, 4);
      manager.AddBuilding(8, 5);

      List<Building> canSeeBuildings = manager.GetSunSeeingBuildings();

      Assert.AreEqual(3, canSeeBuildings.Count);
      Assert.AreEqual(3, canSeeBuildings[0].GetID());
      Assert.AreEqual(2, canSeeBuildings[1].GetID());
      Assert.AreEqual(1, canSeeBuildings[2].GetID());
    }
  }
}
