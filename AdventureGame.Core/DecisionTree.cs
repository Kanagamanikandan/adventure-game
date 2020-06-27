using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureGame.Core
{
    public class DecisionTree
    {
        public DecisionTree(string statement)
        {
            Statement = statement;
        }

        public DecisionTree(string statement, DecisionTree positive, DecisionTree negative)
        {
            
            Statement = statement;
            Positive = positive ?? throw new ArgumentNullException(nameof(positive));
            Negative = negative ?? throw new ArgumentNullException(nameof(negative));
        }
        public Guid Id { get; set; }
        public string Statement { get; private set; }
        public bool IsRoot { get; set; }

        public virtual DecisionTree Positive { get; private set; }
        public virtual DecisionTree Negative { get; private set; }
    }
}
