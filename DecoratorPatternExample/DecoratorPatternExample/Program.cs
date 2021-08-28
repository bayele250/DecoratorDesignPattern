using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface IMembership
    {
        double GetFee();
        string GetBenefits();
    }

    public class GoldMembership: IMembership
    {
        public double fee { get; set; }
        public string GetBenefits()
        {
            return "30 % Reservation discount for each person \n";
        }

        public double GetFee()
        {
            this.fee = 200;
            return this.fee;
        }
    }
    public class SilverMembership : IMembership
    {
        public double fee { get; set; }
        public string GetBenefits()
        {
            return "15 % Reservation discount for each person \n";
        }

        public double GetFee()
        {
            this.fee = 150;
            return this.fee;
        }
    }
    public class PlatinumMembership : IMembership
    {
        public double fee { get; set; }
        public string GetBenefits()
        {
            return "40 % Reservation discount for each person \n";
        }

        public double GetFee()
        {
            this.fee = 250;
            return this.fee;
        }
    }

    public abstract class MembershipDecorator: IMembership
    {
        public IMembership _membership;
        public MembershipDecorator(IMembership membership)
        {
            this._membership = membership;
        }
        public virtual double GetFee()
        {
            return _membership.GetFee();
        }

        public virtual string GetBenefits()
        {
            return _membership.GetBenefits();
        }

    }

    public class AnnualFeeDecorator : MembershipDecorator
    {
        public AnnualFeeDecorator(IMembership membership) : base(membership) { }

        public override double GetFee()
        {
            return base.GetFee() + 10 ;
        }
    }

    public class InitialFeeDecorator : MembershipDecorator
    {
        public InitialFeeDecorator(IMembership membership) : base(membership) { }

        public override double GetFee()
        {
            return base.GetFee() + 5.50;
        }
    }

    public class ParkingFeeDecorator : MembershipDecorator
    {
        public ParkingFeeDecorator(IMembership membership) : base(membership) { }

        public override double GetFee()
        {
            return base.GetFee() + 7;
        }
    }

    public class CacelationBenefitDecorator: MembershipDecorator
    {
        public CacelationBenefitDecorator(IMembership membership):base(membership) { }

        public override string GetBenefits()
        {
            return base.GetBenefits() + "\n Free Reservation Cancelation \n";
        }
    }

    public class MealBenefitDecorator : MembershipDecorator
    {
        public MealBenefitDecorator(IMembership membership) : base(membership) { }

        public override string GetBenefits()
        {
            return base.GetBenefits() + "\n Free Meal for breakfast, luch and dinner. \n";
        }
    }

    public class ShuttleBenefitDecorator : MembershipDecorator
    {
        public ShuttleBenefitDecorator(IMembership membership) : base(membership) { }

        public override string GetBenefits()
        {
            return base.GetBenefits() + "\n Free shuttle from and to airport, during shopping. \n";
        }
    }

}
