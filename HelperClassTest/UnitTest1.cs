// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="">
//   
// </copyright>
// <summary>
//   The tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region license

// <copyright company="ZAN LLC" file="UnitTest1.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>

#endregion

namespace HelperClassTest
{
    #region region

    using System;

    using HelperClass.StringClass;
    using HelperClass.������;

    using NUnit.Framework;

    #endregion

    /// <summary>
    ///     The tests.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// The test 1.
        /// </summary>
        /// <param name="str">
        /// The str.
        /// </param>
        [Test]
        [TestCase("abc")]
        [TestCase("hello")]
        public void Test1(string str)
        {
            str = str.Reverse();
            Console.WriteLine(str);
            Assert.Pass();
        }

        /// <summary>
        /// ������
        /// </summary>
        [Test]
        public void Test12()
        {
            var tree = new Tree<long>(1);
            tree.Insert(2);
            tree.Insert(-1);
            tree.Insert(3);
            tree.Insert(-3);
            tree.Insert(-2);
            tree.WalkTree(); // �������ı���
            Assert.Pass();
        }
    }
}