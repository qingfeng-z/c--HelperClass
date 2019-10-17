
#region license
// <copyright company="ZAN LLC" file="HelperClassTest.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace HelperClassTest
{
    #region region

    using System;

    using HelperClass.StringClass;

    using NUnit.Framework;

    #endregion

    /// <summary>
    /// The tests.
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

    }
}