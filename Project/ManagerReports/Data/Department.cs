using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagerReports.Data
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string NotesType { get; set; }

        public virtual IList<DepartmentNote> Notes { get; set; }
    }
}