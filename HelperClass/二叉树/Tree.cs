#region license

// <copyright company="ZAN LLC" file="Tree.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace HelperClass.二叉树
{
    #region region

    using System;

    #endregion

    /// <summary>
    /// The tree.
    /// </summary>
    /// <typeparam name="TItem">
    /// </typeparam>
    public class Tree<TItem>
        where TItem : IComparable<TItem>
    {
        /// <summary>
        /// The left tree.
        /// </summary>
        private Tree<TItem> LeftTree; // 左孩子

        /// <summary>
        /// The node data.
        /// </summary>
        private readonly TItem NodeData; // 节点

        /// <summary>
        /// The right tree.
        /// </summary>
        private Tree<TItem> RightTree; // 右孩

        /// <summary>
        /// Initializes a new instance of the <see cref="Tree{TItem}"/> class.
        /// </summary>
        /// <param name="nodeValue">
        /// The node value.
        /// </param>
        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue; // 泛型数据
            this.LeftTree = null; // 左孩子
            this.RightTree = null; // 右孩子
        }

        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="newItem">
        /// The new item.
        /// </param>
        public void Insert(TItem newItem)
        {
            // 树的插入操作实现二叉排序树
            var currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null) this.LeftTree = new Tree<TItem>(newItem);
                else this.LeftTree.Insert(newItem);
            }
            else
            {
                if (this.RightTree == null) this.RightTree = new Tree<TItem>(newItem);
                else this.RightTree.Insert(newItem);
            }
        }

        /// <summary>
        /// The walk tree.
        /// </summary>
        public void WalkTree()
        {
            // 树的遍历
            if (this.LeftTree != null) this.LeftTree.WalkTree();

            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null) this.RightTree.WalkTree();
        }
    }
}