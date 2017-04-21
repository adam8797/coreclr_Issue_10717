using System;
using System.ComponentModel.DataAnnotations;
using ManagerReports.Interfaces;

namespace ManagerReports.Data
{
    public abstract class DepartmentNote : IUpdatable
    {
        public Guid Id { get; set; }

        public Department Department { get; set; }

        public string Notes { get; set; }

        public virtual ManagerReport Report { get; set; }

        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }

        public DateTime LastUpdated { get; set; }
    }

    public class BasicDepartmentNote : DepartmentNote
    {

    }

}