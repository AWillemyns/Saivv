using System.Collections.Generic;

namespace Saivv.DomainModel
{
    public class CostBenefit
    {
        public long Id { get; set; }
        private decimal totalCost;

        public decimal TotalCost
        {
            get {
                var costLines = this.Lines.FindAll(x => x.CostOrSaving == CostOrSaving.C);
                // To-do: return sum of lines.Amount;
                return 500;
            }
        }

        private decimal totalBenefit;
        public decimal TotalBenefit
        {
            get
            {
                var costLines = this.Lines.FindAll(x => x.CostOrSaving == CostOrSaving.S);
                // To-do: return sum of lines.Amount;
                return 1000;
            }
        }
        public List<CostBenefitLine> Lines { get; set; }

        public decimal GetCostBenefitRatio()
        {
            return this.totalBenefit/ this.totalCost;
        }
    }

    public class CostBenefitLine
    {
        public long Id { get; set; }
        public CostOrSaving CostOrSaving { get; set; }
        public decimal Amount { get; set; }

        public string Category { get; set; }

    }

    public enum CostOrSaving
    {
        C,
        S
    }
}
