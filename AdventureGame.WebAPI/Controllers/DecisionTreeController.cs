using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdventureGame.Core;
using AdventureGame.Data;

namespace AdventureGame.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DecisionTreeController : ControllerBase
    {
        private readonly IDecisionTreeRepository treeRepository;

        public DecisionTreeController(IDecisionTreeRepository treeRepository)
        {
            this.treeRepository = treeRepository ?? throw new ArgumentNullException(nameof(treeRepository));
        }

        [HttpGet]
        public ActionResult<IEnumerable<DecisionTree>> GetAll()
        {
            return Ok(treeRepository.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<DecisionTree> Get(Guid id)
        {
            var decisionTree = treeRepository.Get(id);
            if (decisionTree == null)
                return NotFound();
            return decisionTree;
        }
        
    }
}