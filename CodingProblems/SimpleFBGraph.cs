using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  public class SimpleFBGraph
  {
    public List<FBMember> getFriendDegress(FBMember m)
    {
      Queue<FBMember> toVisitMembers = new Queue<FBMember>();
      List<FBMember> membersWithDeg = new List<FBMember>();

      //initialize each element to -1
      foreach (FBMember member in m.Friends)
      {
        member.Degree = 1;
        toVisitMembers.Enqueue(member);
        membersWithDeg.Add(member);
      }

      while (toVisitMembers.Count > 0)
      {
        FBMember currentFriend = toVisitMembers.Dequeue();
        membersWithDeg.Add(currentFriend);
        foreach (FBMember member in m.Friends)
        {
          if (member.Degree == -1)
          {
            member.Degree = currentFriend.Degree++;
            toVisitMembers.Enqueue(member);
          }
        }
      }

      return membersWithDeg;
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
