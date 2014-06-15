using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingProblems;
using System.Collections.Generic;

namespace CodingProblemsTests
{
  [TestClass]
  public class SimpleFBGraphTests
  {
    [TestMethod]
    public void GetDegrees_OneMember_ReturnsEmptyList()
    {
      FBMember member = new FBMember();
      member.Name = "hi there";
      member.Email = "friend@gmail.com";
      member.Friends = new List<FBMember>();

      var result = SimpleFBGraph.GetFriendDegrees(member);

      Assert.AreEqual(null, result);
    }

    [TestMethod]
    public void GetDegrees_VerifyDegrees_TwoLevels()
    {
      FBMember member = new FBMember();
      member.Name = "hi there";
      member.Email = "friend@gmail.com";
      member.Friends = new List<FBMember>();

      member.Friends.Add(new FBMember() { Name = "hi there", Email = "there@gmail.com", Friends = new List<FBMember>() });
      member.Friends.Add(new FBMember() { Name = "hi there2", Email = "there2@gmail.com", Friends = new List<FBMember>() });
      member.Friends.Add(new FBMember() { Name = "hi there3", Email = "there3@gmail.com", Friends = new List<FBMember>() });

      var result = SimpleFBGraph.GetFriendDegrees(member);

      Assert.AreEqual(result[1][0].Email, "there@gmail.com");
      Assert.AreEqual(result[1][1].Email, "there2@gmail.com");
      Assert.AreEqual(result[1][2].Email, "there3@gmail.com");
    }

    [TestMethod]
    public void GetDegrees_VerifyDegrees_ThreeLevels()
    {
      FBMember member = new FBMember();
      member.Name = "hi there";
      member.Email = "friend@gmail.com";
      member.Friends = new List<FBMember>();

      member.Friends.Add(new FBMember() { Name = "hi there", Email = "there@gmail.com", Friends = new List<FBMember>() });
      member.Friends.Add(new FBMember() { Name = "hi there2", Email = "there2@gmail.com", Friends = new List<FBMember>() });
      member.Friends.Add(new FBMember() { Name = "hi there3", Email = "there3@gmail.com", Friends = new List<FBMember>() });

      member.Friends[0].Friends = new List<FBMember>() { new FBMember() { Name = "hi there4", Email = "there4@gmail.com", Friends = new List<FBMember>() } };
      member.Friends[1].Friends = new List<FBMember>() { new FBMember() { Name = "hi there5", Email = "there5@gmail.com", Friends = new List<FBMember>() } };
      member.Friends[2].Friends = new List<FBMember>() { new FBMember() { Name = "hi there6", Email = "there6@gmail.com", Friends = new List<FBMember>() } };
      var result = SimpleFBGraph.GetFriendDegrees(member);

      Assert.AreEqual(result[1][0].Email, "there@gmail.com");
      Assert.AreEqual(result[1][1].Email, "there2@gmail.com");
      Assert.AreEqual(result[1][2].Email, "there3@gmail.com");
      Assert.AreEqual(result[2][0].Email, "there4@gmail.com");
      Assert.AreEqual(result[2][1].Email, "there5@gmail.com");
      Assert.AreEqual(result[2][2].Email, "there6@gmail.com");
    }

    [TestMethod]
    public void GetDegrees_VerifyDegrees_FourLevels()
    {
      FBMember member = new FBMember();
      member.Name = "hi there";
      member.Email = "friend@gmail.com";
      member.Friends = new List<FBMember>();

      member.Friends.Add(new FBMember() { Name = "hi there", Email = "there@gmail.com", Friends = new List<FBMember>() });
      member.Friends.Add(new FBMember() { Name = "hi there2", Email = "there2@gmail.com", Friends = new List<FBMember>() });
      member.Friends.Add(new FBMember() { Name = "hi there3", Email = "there3@gmail.com", Friends = new List<FBMember>() });

      member.Friends[0].Friends = new List<FBMember>() { new FBMember() { Name = "hi there4", Email = "there4@gmail.com", Friends = new List<FBMember>() } };
      member.Friends[1].Friends = new List<FBMember>() { new FBMember() { Name = "hi there5", Email = "there5@gmail.com", Friends = new List<FBMember>() } };
      member.Friends[2].Friends = new List<FBMember>() { new FBMember() { Name = "hi there6", Email = "there6@gmail.com", Friends = new List<FBMember>() } };

      member.Friends[0].Friends[0].Friends = new List<FBMember>() { new FBMember() { Name = "hi there7", Email = "there7@gmail.com", Friends = new List<FBMember>() } };
      member.Friends[1].Friends[0].Friends = new List<FBMember>() { new FBMember() { Name = "hi there8", Email = "there8@gmail.com", Friends = new List<FBMember>() } };
      member.Friends[2].Friends[0].Friends = new List<FBMember>() { new FBMember() { Name = "hi there9", Email = "there9@gmail.com", Friends = new List<FBMember>() } };
      var result = SimpleFBGraph.GetFriendDegrees(member);

      Assert.AreEqual(result[1][0].Email, "there@gmail.com");
      Assert.AreEqual(result[1][1].Email, "there2@gmail.com");
      Assert.AreEqual(result[1][2].Email, "there3@gmail.com");
      Assert.AreEqual(result[2][0].Email, "there4@gmail.com");
      Assert.AreEqual(result[2][1].Email, "there5@gmail.com");
      Assert.AreEqual(result[2][2].Email, "there6@gmail.com");
      Assert.AreEqual(result[3][0].Email, "there7@gmail.com");
      Assert.AreEqual(result[3][1].Email, "there8@gmail.com");
      Assert.AreEqual(result[3][2].Email, "there9@gmail.com");
    }
  }
}
