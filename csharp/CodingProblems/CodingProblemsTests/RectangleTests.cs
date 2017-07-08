using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingProblems;

namespace CodingProblemsTests
{
  [TestClass]
  public class RectangleTests
  {
    private Rectangle rect = new Rectangle(10, 10, 10, 10);

    [TestMethod]
    public void Rectangle_IntersectAtSinglePoint_ShouldReturnHeightWidthAsZero()
    {
      Rectangle compareRect = new Rectangle(0, 0, 10, 10);
      Rectangle intersection = rect.GetIntersection(compareRect);
      AssertRectangleHasTheFollowingValues(intersection, 10, 10, 0, 0);
    }

    [TestMethod]
    public void Rectangle_IntersectOnHorizontalLine_ShouldReturnHeightZero_SameWidth()
    {
      Rectangle compareRect = new Rectangle(10, 8, 10, 2);
      Rectangle intersection = rect.GetIntersection(compareRect);
      AssertRectangleHasTheFollowingValues(intersection, 10, 10, 10, 0);
    }

    [TestMethod]
    public void Rectangle_IntersectOnVerticalLine_Should_ReturnWidthZero_SameHeight()
    {
      Rectangle compareRect = new Rectangle(0, 10, 10, 10);
      Rectangle intersection = rect.GetIntersection(compareRect);
      AssertRectangleHasTheFollowingValues(intersection, 10, 10, 0, 10);
    }

    [TestMethod]
    public void Rectangle_IntersectionIsCompletelyWithinRectangle_ShouldReturnSmallerRectangle()
    {
      Rectangle compareRect = new Rectangle(11, 11, 6, 6);
      Rectangle intersection = rect.GetIntersection(compareRect);
      AssertRectangleHasTheFollowingValues(intersection, 11, 11, 6, 6);
    }

    [TestMethod]
    public void Rectangle_IntersectsTwoPoints_ReturnsCorrectIntersection()
    {
      Rectangle compareRect = new Rectangle(8, 11, 10, 3);
      Rectangle intersection = rect.GetIntersection(compareRect);
      AssertRectangleHasTheFollowingValues(intersection, 10, 11, 8, 3);
    }

    [TestMethod]
    public void Rectangle_IntersectsOnePoint_ReturnsCorrectIntersection()
    {
      Rectangle compareRect = new Rectangle(17, 17, 20, 20);
      Rectangle intersection = rect.GetIntersection(compareRect);
      AssertRectangleHasTheFollowingValues(intersection, 17, 17, 3, 3);
    }

    [TestMethod]
    public void Rectangle_NoIntersection_ReturnsNull()
    {
      Rectangle compareRect = new Rectangle(1, 1, 1, 1);
      Rectangle intersection = rect.GetIntersection(compareRect);
      Assert.IsNull(intersection);
    }

    private void AssertRectangleHasTheFollowingValues(Rectangle rect, int x, int y, int width, int height)
    {
      Assert.AreEqual(x, rect.X);
      Assert.AreEqual(y, rect.Y);
      Assert.AreEqual(height, rect.Height);
      Assert.AreEqual(width, rect.Width);
    }

  }
}
