using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Implements a simple stack class using queues
  /// </summary>
  /// <typeparam name="T">object type help in stack</typeparam>
  public class StackUsingQueue<T>
  {
    private Queue<T> queue1;
    private Queue<T> queue2;
    private Queue<T> currentQueue;

    public StackUsingQueue()
    {
      queue1 = new Queue<T>();
      queue2 = new Queue<T>();
      currentQueue = queue1;
    }

    /// <summary>
    /// Pushes item onto the stack
    /// </summary>
    /// <param name="item">item to push</param>
    public void Push(T item)
    {
      if (queue1.Count == 0)
      {
        queue1.Enqueue(item);
        while (queue2.Count != 0)
        {
          queue1.Enqueue(queue2.Dequeue());
        }
      }
      else
      {
        queue2.Enqueue(item);
        while (queue1.Count != 0)
        {
          queue2.Enqueue(queue1.Dequeue());
        }
      }   
    }

    /// <summary>
    /// Returns first item in the stack. If stack is empty exception is thrown.
    /// </summary>
    /// <returns>top item of the stack</returns>
    public T Pop()
    {
      if (queue1.Count != 0)
      {
        return queue1.Dequeue();
      }
      else
      {
        return queue2.Dequeue();
      }
    }

    /// <summary>
    /// Returns the top item of the stack without removing it.
    /// If the stack is empty, exception is thrown.
    /// </summary>
    /// <returns>the top item of the stack</returns>
    public T Peek()
    {
      if (queue1.Count > 0)
      {
        return queue1.Peek();
      }
      else
      {
        return queue2.Peek();
      }
    }

    /// <summary>
    /// Returns true iff the stack is empty
    /// </summary>
    /// <returns>true iff stack is empty</returns>
    public bool IsEmpty()
    {
      return queue1.Count == 0 && queue2.Count == 0;
    }
  }
}
