using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
  /// <summary>
  /// Problem 7.7 and 7.8
  /// 
  /// Uses a very simple linked list class which only supports appending and removing elements
  /// The problem was more focused on removal so append is not heavily tested.
  /// </summary>
  public class MyLinkedList<T>
  {
    private MyLinkedListNode<T> startNode;
    private MyLinkedListNode<T> endNode;
    private int itemCount;

    public MyLinkedList()
    {
      this.startNode = null;
    }

    public void Append(T value)
    {
      if (this.startNode == null)
      {
        this.startNode = new MyLinkedListNode<T>() { Next = null, Value = value, JumpOrder = -1 };
        this.endNode = this.startNode;
      }
      else
      {
        MyLinkedListNode<T> newNode = new MyLinkedListNode<T>(){ Next = null, Value = value, JumpOrder = -1};
        endNode.Next = newNode;
        endNode = newNode;
      }
      itemCount++;
    }
    
    /// <summary>
    /// First appends the node and then assigns its jump value 
    /// to the given node with 0 being the first node.
    /// </summary>
    /// <param name="value">value for new node</param>
    /// <param name="jumpNode">the node (based on index) to assign as the jump node</param>
    public void SetJumpNode(int nodeIndex, int jumpNodeIndex)
    {
      MyLinkedListNode<T> currNode = this.startNode;
      for (int i = 0; i < nodeIndex; i++)
      {
        currNode = currNode.Next;
      }

      MyLinkedListNode<T> jumpNode = this.startNode;
      for (int i = 0; i < jumpNodeIndex; i++)
      {
        jumpNode = jumpNode.Next;
      }

      currNode.Jump = jumpNode;
    }

    /// <summary>
    /// Removes node with first occurrence of value
    /// </summary>
    /// <param name="value">value to remove</param>
    public void RemoveElement(T value)
    {
      MyLinkedListNode<T> currNode = this.startNode;
      while (startNode.Next != null && !currNode.Value.Equals(value))
      {
        currNode = currNode.Next;
      }
      RemoveNode(ref currNode);
    }

    /// <summary>
    /// Removes node kth from the end of linked list
    /// </summary>
    /// <param name="k"></param>
    public void RemoveKthElementFromEnd(int k)
    {
      MyLinkedListNode<T> currNode = this.startNode;
      while (k > 0)
      {
        currNode = currNode.Next;
        k--;
      }

      MyLinkedListNode<T> deleteNode = this.startNode;
      while (currNode.Next != null)
      {
        deleteNode = deleteNode.Next;
        currNode = currNode.Next;
      }

      RemoveNode(ref deleteNode);
    }

    /// <summary>
    /// Removes a given node
    /// </summary>
    /// <param name="deleteNode">node to remove</param>
    private void RemoveNode(ref MyLinkedListNode<T> deleteNode)
    {
      if (this.endNode != deleteNode)
      {
        MyLinkedListNode<T> nextNode = deleteNode.Next;
        deleteNode.Value = nextNode.Value;
        deleteNode.Next = nextNode.Next;
        nextNode.Next = null;
        itemCount--;
      }

    }

    public T[] GetElements()
    {
      T[] elements = new T[itemCount];

      MyLinkedListNode<T> currentNode = this.startNode;
      for(int i = 0; i < itemCount; i++)
      {
        elements[i] = currentNode.Value;
        currentNode = currentNode.Next;
      }

      return elements;
    }

    public void ComputeJumpOrder()
    {     
      ResetNodeJumpOrders();
      Stack<MyLinkedListNode<T>> stack = new Stack<MyLinkedListNode<T>>();
      MyLinkedListNode<T> currNode = this.startNode;

      // initialize the stack
      if (currNode.Next != null)
      {
        stack.Push(currNode.Next);
      }
      stack.Push(currNode.Jump);

      int order = 1;
      currNode.JumpOrder = order;
      order++;

      while(stack.Count != 0)
      {

        currNode = stack.Pop();

        // only update non visited nodes
        if (currNode.JumpOrder == -1)
        { 
          currNode.JumpOrder = order;
          order++;
        }
        
        // push the next node and then jump node as stack is FIFO
        if (currNode.Next != null && currNode.Next.JumpOrder == -1)
        {
          stack.Push(currNode.Next);
        }
        if (currNode.Jump.JumpOrder == -1)
        {
          stack.Push(currNode.Jump);
        }
      }
    }

    /// <summary>
    /// Resets the order field for jump order 
    /// </summary>
    private void ResetNodeJumpOrders()
    {
      MyLinkedListNode<T> currNode = this.startNode;
      while (currNode != null)
      {
        currNode.JumpOrder = -1;
        currNode = currNode.Next;
      }
    }

    public MyLinkedListNode<T>[] GetNodeElements()
    {
      MyLinkedListNode<T>[] array = new MyLinkedListNode<T>[itemCount];
      MyLinkedListNode<T> currNode = this.startNode;
      for (int i = 0; i < itemCount; i++)
      {
        array[i] = currNode;
        currNode = currNode.Next;
      }

      return array;
    }
  }

  public class MyLinkedListNode<T>
  {
    public MyLinkedListNode<T> Next {get; set;}
    public T Value {get; set;}
    public MyLinkedListNode<T> Jump { get; set; }
    public int JumpOrder { get; set; }
  }
}
