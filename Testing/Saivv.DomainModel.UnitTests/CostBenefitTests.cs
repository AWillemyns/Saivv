using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saivv.DomainModel.UnitTests
{
    [TestFixture]
    public class CostBenefitTests
    {
        public CostBenefit CostBenefit { get; set; }
        [SetUp]
        public void Setup()
        {
            this.CostBenefit = new CostBenefit();
        }
        [Test]
        public void CreateCostBenefit()
        {
            Assert.IsNotNull(this.CostBenefit);
        }

        [Test]
        public void TestCostBenefitRatio()
        {
            this.CostBenefit.Cost = 250;
            this.CostBenefit.Benefit = 500;
            decimal costBenefitRatio = this.CostBenefit.GetCostBenefitRatio();
            Assert.AreEqual(2, costBenefitRatio);
        }

        [Test]
        public void CreateCostBenefitLine()
        {
            CostBenefitLine line = new CostBenefitLine();
            line.CostOrSaving = CostOrSaving.C;
            line.Amount = 250;
            line.Category = "Expendables";
            line.Id = 1;
            Assert.IsNotNull(line);
        }


    }



}
