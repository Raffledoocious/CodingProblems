using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Problem 5.12
  /// </summary>
  public class Rectangle
  {
    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectangle(int x, int y, int width, int height)
    {
      this.X = x;
      this.Y = y;
      this.Width = width;
      this.Height = height;
    }

    private bool IsPointWithinRectangle(int x, int y)
    {
      return (x >= this.X && x <= (this.X + this.Width) &&
              y >= this.Y && y <= (this.Y + this.Height) );
    }

    public Rectangle GetIntersection(Rectangle rect)
    {
      if (IsPointWithinRectangle(rect.X, rect.Y) || IsPointWithinRectangle(rect.X + rect.Width, rect.Y)  || 
          IsPointWithinRectangle(rect.X, rect.Y + rect.Height) || IsPointWithinRectangle(rect.X + rect.Width, rect.Y + rect.Height))
      {
        int x = Math.Max(this.X, rect.X);
        int y = Math.Max(this.Y, rect.Y);
        int width = Math.Min( (this.X + this.Width), (rect.X + rect.Width)) - x;
        int height = Math.Min( (this.Y + this.Height), (rect.Y + rect.Height)) - y;
        return new Rectangle(x, y, width, height);       
      }
      else
      {
        return null;
      }

    }
  }
}
