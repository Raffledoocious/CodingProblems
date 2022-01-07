using CodingProblems.Models;
using System;
using System.Collections.Generic;

namespace CodingProblems
{
	class MaxDepthBinaryTree
	{
		public int MaxDepth(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}

			Queue<KeyValuePair<TreeNode, int>> nodesToVisit = new();
			int maxDepth = 0;
			nodesToVisit.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));

			while (nodesToVisit.Count > 0)
			{
				var current = nodesToVisit.Dequeue();
				var currentNode = current.Key;
				var currentDepth = current.Value;

				maxDepth = Math.Max(maxDepth, currentDepth);

				if (currentNode.left != null)
				{
					nodesToVisit.Enqueue(new KeyValuePair<TreeNode, int>(currentNode.left, currentDepth + 1));
				}
				if (currentNode.right != null)
				{
					nodesToVisit.Enqueue(new KeyValuePair<TreeNode, int>(currentNode.right, currentDepth + 1));
				}
			}

			return maxDepth;
		}

		public int MaxDepthRecursive(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}

			return Math.Max(MaxDepthRecursive(root.left), MaxDepthRecursive(root.right)) + 1;
		}
	}
}
