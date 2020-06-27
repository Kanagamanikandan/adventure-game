using Microsoft.EntityFrameworkCore;
using System;
using AdventureGame.Core;

namespace AdventureGame.Data
{
    public class AdventureGameDBContext : DbContext
    {
        public DbSet<DecisionTree> DecisionTrees { get; set; }

    }
}
