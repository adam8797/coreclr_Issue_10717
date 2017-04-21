using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ManagerReports.Interfaces;

namespace ManagerReports.Data
{
    public class ManagerReport : IUpdatable
    {
        public ManagerReport()
        {
            Managers = new Managers();
            Attendance = new Attendance();
            TellerShifts = new TellerShifts();
        }

        public Guid Id { get; set; }
        
        [Column(TypeName = "datetime2")]
        public DateTime ForDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }

        public bool Closed { get; set; }

        [MaxLength(50)]
        public string ClosedBy { get; set; }

        [MaxLength(150)]
        public string WeatherConditions { get; set; }

        public decimal TodaysHandle { get; set; }

        public Managers Managers { get; set; }

        public Attendance Attendance { get; set; }

        public TellerShifts TellerShifts { get; set; }

        public virtual IList<DepartmentNote> DepartmentNotes { get; set; }

        public virtual Location Location { get; set; }
    }

    [ComplexType]
    public class Managers
    {
        [MaxLength(100)]
        public string AM { get; set; }

        [MaxLength(100)]
        public string PM { get; set; }

        [MaxLength(100)]
        public string MidDay { get; set; }
    }

    [ComplexType]
    public class Attendance
    {
        public int Day { get; set; }
        public int Night { get; set; }
    }

    [ComplexType]
    public class TellerShifts
    {
        public decimal Day { get; set; }
        public decimal Night { get; set; }
    }
}
