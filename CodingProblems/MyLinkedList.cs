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
  public class MyLinkedList
  {
    private MyLinkedListNode startNode;
    private MyLinkedListNode endNode;
    private int itemCount;

    public MyLinkedList()
    {
      this.startNode = null;
    }

    public void Append(string value)
    {
      if (this.startNode == null)
      {
        this.startNode = new MyLinkedListNode() { Next = null, Value = value };
        this.endNode = this.startNode;
      }
      else
      {
        MyLinkedListNode newNode = new MyLinkedListNode(){ Next = null, Value = value };
        endNode.Next = newNode;
        endNode = newNode;
      }
      itemCount++;
    }

    /// <summary>
    /// Removes node with first occurrence of value
    /// </summary>
    /// <param name="value">value to remove</param>
    public void RemoveElement(string value)
    {
      MyLinkedListNode currNode = this.startNode;
      while (startNode.Next != null && currNode.Value != value)
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
      MyLinkedListNode currNode = this.startNode;
      while (k > 0)
      {
        currNode = currNode.Next;
        k--;
      }

      MyLinkedListNode deleteNode = this.startNode;
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
    private void RemoveNode(ref MyLinkedListNode deleteNode)
    {
      if (this.endNode != deleteNode)
      {
        MyLinkedListNode nextNode = deleteNode.Next;
        deleteNode.Value = nextNode.Value;
        deleteNode.Next = nextNode.Next;
        nextNode.Next = null;
        itemCount--;
      }

    }

    public string[] GetElements()
    {
      string[] elements = new string[itemCount];

      MyLinkedListNode currentNode = this.startNode;
      for(int i = 0; i < itemCount; i++)
      {
        elements[i] = currentNode.Value;
        currentNode = currentNode.Next;
      }

      return elements;
    }
  }

  public class MyLinkedListNode
  {
    public MyLinkedListNode Next {get; set;}
    public string Value {get; set;}
  }
}
