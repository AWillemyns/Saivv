using System;
using System.Collections.Generic;
using System.Text;

namespace Saivv.DomainModel
{
    public class CostBenefit
    {
        public long Id { get; set; }
        public decimal Cost { get; set; }
        public decimal Benefit { get; set; }

        public decimal GetCostBenefitRatio()
        {
            return this.Benefit / this.Cost;
        }
    }
}
