using System;
namespace ChallengeSets
{
    public class Business
    {
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }

        private Business parentCompany;

        public Business GetParentCompany()
        {
            return ParentCompany;
        }

        public void SetParentCompany(Business value)
        {
            ParentCompany = value;
        }

        public int Length { get; internal set; }
        public Business ParentCompany { get => ParentCompany1; set => ParentCompany1 = value; }
        public Business ParentCompany1 { get => parentCompany; set => parentCompany = value; }

        internal string ToString(object p)
        {
            throw new NotImplementedException();
        }
    }
}
