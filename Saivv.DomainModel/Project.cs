using System;
using System.Collections.Generic;
using System.Text;

namespace Saivv.DomainModel
{
    public class Project
    {
        public long id { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public CostBenefit CostBenefit { get; set; }

    }
}
