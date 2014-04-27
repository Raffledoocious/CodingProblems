using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Currently in progress
  /// </summary>
  /// <typeparam name="T">data type of the stack</typeparam>
  public class MaxQueue<T> where T : IComparable
  {
    private Queue<T> queue;
    
    // this approach will not work
    private Stack<T> stack;

    public MaxQueue()
    {
      queue = new Queue<T>();
      stack = new Stack<T>();
    }

    public void Enque(T element)
    {
      queue.Enqueue(element);

      if (stack.Count == 0 || stack.Peek().CompareTo(element) <= 0)
      {
        stack.Push(element);
      }
    }

    public T Dequeue()
    {
      T element = queue.Dequeue();
      if (stack.Peek().Equals(element))
      {
        stack.Pop();
      }

      return element;
    }

    public T GetMax()
    {
      return stack.Peek();
    }
  }
}
