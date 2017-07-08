using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public class SimpleFBGraph
  {
    public static Dictionary<int, List<FBMember>> GetFriendDegrees(FBMember m)
    {
      Queue<FBMember> toVisitMembers = new Queue<FBMember>();
      Dictionary<int, List<FBMember>> degreeDict = new Dictionary<int, List<FBMember>>();
      Dictionary<string, int> visitedMembers = new Dictionary<string, int>();

      // visit all first level members
      // setting their degree and marking as visited
      foreach (FBMember member in m.Friends)
      {
        member.Degree = 1;
        toVisitMembers.Enqueue(member);  
        visitedMembers.Add(member.Email, 1);
      }

      while (toVisitMembers.Count > 0)
      {
        FBMember currentFriend = toVisitMembers.Dequeue();
        
        if (!degreeDict.ContainsKey(currentFriend.Degree))
        {
          degreeDict[currentFriend.Degree] = new List<FBMember>() { currentFriend };
        }
        else
        {
          degreeDict[currentFriend.Degree].Add(currentFriend);
        }

        foreach (FBMember member in currentFriend.Friends)
        {
          if (!visitedMembers.ContainsKey(member.Email))
          {
            member.Degree = currentFriend.Degree + 1;
            toVisitMembers.Enqueue(member);
          }
        }
      }

      if (degreeDict.Count == 0)
      {
        return null;
      }
      else
      {
        return degreeDict;
      }
    }   
  }

  public class FBMember
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public List<FBMember> Friends { get; set; }
    public int Degree { get; set; }
  }
}
