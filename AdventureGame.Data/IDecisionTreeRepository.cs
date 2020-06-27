using System;
using System.Collections.Generic;
using System.Text;
using AdventureGame.Core;
using System.Linq;

namespace AdventureGame.Data
{
    public interface IDecisionTreeRepository
    {
        IEnumerable<DecisionTree> GetAll();
        DecisionTree Get(Guid id);
    }

    public class InMemoryDecisionTreeRepository : IDecisionTreeRepository
    {
        public readonly List<DecisionTree> decisionTrees;
        public InMemoryDecisionTreeRepository()
        {
            decisionTrees = new List<DecisionTree>()
            {
                new DecisionTree("Do you want a Doughnut?",
                    new DecisionTree("Do I deserve it",
                         new DecisionTree("Are you sure",
                                   new DecisionTree("Get it.") {Id = Guid.NewGuid() },
                                   new DecisionTree("Do jumping jacks first") {Id = Guid.NewGuid() }
                                   ) {Id = Guid.NewGuid() },
                         new DecisionTree("Is it a good doughnut?",
                                    new DecisionTree("What are you waiting for? Grab it now") {Id = Guid.NewGuid() },
                                    new DecisionTree("Wait 'til you find a sinful, unforgettable doughbut"){Id = Guid.NewGuid() }
                                    ) {Id = Guid.NewGuid() }
                         ) {Id = Guid.NewGuid() },
                    new DecisionTree("Maybe you want an apple?") {Id = Guid.NewGuid() }
                    ) {Id = Guid.NewGuid(), IsRoot = true },

                new DecisionTree("Do you want to work in Lobster Ink?",
                    new DecisionTree("Are you Brave, Caring, Tenacious, Inventive, and Purposeful?",
                         new DecisionTree("Are you skilled at C#, .NET, and Angular?",
                                   new DecisionTree("Great, we were looking for you!") {Id = Guid.NewGuid() },
                                   new DecisionTree("Learn and try again!") {Id = Guid.NewGuid() }
                                   ) {Id = Guid.NewGuid() },
                         new DecisionTree("We may not an ideal match!") {Id = Guid.NewGuid() }
                         ) {Id = Guid.NewGuid() },
                    new DecisionTree("Maybe you want to work in Google :)?") {Id = Guid.NewGuid() }
                    ) {Id = Guid.NewGuid(), IsRoot = true },
            };
        }
        public IEnumerable<DecisionTree> GetAll()
        {
            return decisionTrees;
        }

        public DecisionTree Get(Guid id)
        {
            return decisionTrees.FirstOrDefault(t => t.Id == id);
        }
    }
}
