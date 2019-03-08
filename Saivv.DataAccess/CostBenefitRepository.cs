using Saivv.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saivv.DataAccess
{
    public class CostBenefitRepository
    {
        public List<CostBenefit> CostBenefits { get; set; }
        public CostBenefitRepository()
        {
            this.CostBenefits = new List<CostBenefit>();
            //this.CostBenefits.Add(new CostBenefit() { Id = 1, Benefit = 100, Cost = 250 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 2, Benefit = 345, Cost = 486 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 3, Benefit = 424, Cost = 400 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 4, Benefit = 134, Cost = 50 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 5, Benefit = 40, Cost = 34 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 6, Benefit = 450, Cost = 364 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 7, Benefit = 80, Cost = 120 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 8, Benefit = 568, Cost = 234 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 9, Benefit = 745, Cost = 456 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 10, Benefit = 34, Cost = 42 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 11, Benefit = 354, Cost = 465 });
            //this.CostBenefits.Add(new CostBenefit() { Id = 12, Benefit = 827, Cost = 293 });
        }

        public CostBenefit GetCostBenefitById(long id)
        {
            return this.CostBenefits.Find(x => x.Id == id);
        }

        public List<CostBenefit> GetAllCostBenefits() {
            return this.CostBenefits;
        }
        
    }
}
