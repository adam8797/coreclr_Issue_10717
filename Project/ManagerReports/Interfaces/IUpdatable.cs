using System;

namespace ManagerReports.Interfaces
{
    public interface IUpdatable
    {
        DateTime LastUpdated { get; set; }
        string LastUpdatedBy { get; set; }
    }
}
