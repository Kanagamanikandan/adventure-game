using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AdventureGame.WebAPI.Controllers;
using AdventureGame.Data;

namespace AdventureGame.Tests
{
    public class DecisionTreeController_Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }


        [Test]
        public void DecisionTreeController_ConstructorInjection_ShouldPass()
        {
            IDecisionTreeRepository decisionTreeRepository = new InMemoryDecisionTreeRepository();
            var controller = new DecisionTreeController(decisionTreeRepository);
            Assert.Pass();
        }
    }
}
