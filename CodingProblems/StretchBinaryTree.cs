using CodingProblems.Models;
using System;

namespace CodingProblems
{
	class StretchBinaryTree
	{
		public enum Direction
		{
			Left,
			Right
		}

		public void Stretch(TreeNode root, int factor)
		{
			StretchChildren(root, factor);
			StretchSingleNode(root, factor, Direction.Left);
		}

		private void StretchChildren(TreeNode node, int factor)
		{
			if (node == null)
			{
				return;
			}

			// navigates us to the node recursively
			StretchChildren(node.left, factor);
			StretchChildren(node.right, factor);

			if (node.left != null)
			{
				StretchSingleNode(node.left, factor, Direction.Left);
			}
			if (node.right != null)
			{
				StretchSingleNode(node.right, factor, Direction.Right);
			}
		}

		private void StretchSingleNode(TreeNode node, int factor, Direction direction)
		{
			TreeNode children = direction == Direction.Left ? node.left : node.right;
			int stretchVal = node.val / factor;
			node.val = stretchVal;

			if (direction == Direction.Left)
			{
				ExtendLeft(node, factor, stretchVal);
				node.left = children;
			}
			else if (direction == Direction.Right)
			{
				ExtendRight(node, factor, stretchVal);
				node.right = children;
			}
		}

		private void ExtendLeft(TreeNode node, int factor, int stretchVal)
		{
			for (int i = 0; i < factor; i++)
			{
				node.left = new TreeNode(stretchVal);
				node = node.left;
			}
		}

		private void ExtendRight(TreeNode node, int factor, int stretchVal)
		{
			for (int i = 0; i < factor; i++)
			{
				node.right = new TreeNode(stretchVal);
				node = node.right;
			}
		}
	}
}
