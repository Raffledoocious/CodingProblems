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
  class Rectangle
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
      int x = Math.Max(this.X, rect.X);
      int y = Math.Max(this.Y, rect.Y);
      int width = x + Math.Min( (this.X + this.Width), (rect.X + rect.Width) );
      int height = y + Math.Min( (this.Y + this.Height), (rect.Y + rect.Height) );
      return new Rectangle(x, y, width, height);       
    }
  }
}
