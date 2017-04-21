using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerReports.Data
{
    public class RacingFormSalesNote : DepartmentNote
    {
        public RacingFormSalesNote()
        {
            RacingForms = new RacingFormType();
            SportsEye = new RacingFormType();
            RacingCharts = new RacingFormType();
            Specials = new RacingFormType();
            Other = new RacingFormType();
        }

        public RacingFormType RacingForms { get; set; }
        public RacingFormType SportsEye { get; set; }
        public RacingFormType RacingCharts { get; set; }
        public RacingFormType Specials { get; set; }
        public RacingFormType Other { get; set; }
    }

    [ComplexType]
    public class RacingFormType
    {
        public decimal Draw { get; set; }
        public decimal Return { get; set; }
        public decimal Sold { get; set; }
        public decimal Comps { get; set; }
        public decimal Adv { get; set; }
    }
}