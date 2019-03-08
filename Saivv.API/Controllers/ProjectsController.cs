using Microsoft.AspNetCore.Mvc;
using Saivv.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saivv.API.Controllers
{
    [Route("api/[controller])")]
    [ApiController]
    public class ProjectsController
    {
        public ActionResult<IEnumerable<Project>> Get()
        {
            return new Project[] {
                new Project(){id = 1, ProjectDescription = "Some description", ProjectTitle = "Project 1"},
                new Project(){id = 2, ProjectDescription = "Some other description", ProjectTitle = "Project 2"},
                new Project(){id = 3, ProjectDescription = "And even a better description", ProjectTitle = "Project 3"}
            };
        }
    }
}
