using NUnit.Framework;
using AdventureGame.Core;
using System;

namespace AdventureGame.Tests
{
    public class DecisionTree_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor1_String_Passes()
        {
            var decisonTree = new DecisionTree("Do you want a doughtnut?");
            Assert.Pass();
        }



        [Test]
        public void Constructor2_ShouldNotAllowNulls_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => new DecisionTree("Do you want a doughnut?", null, null));
        }
    }
}