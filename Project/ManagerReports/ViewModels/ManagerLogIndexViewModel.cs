using System;
using System.Collections.Generic;
using ManagerReports.Data;

namespace ManagerReports.ViewModels
{
    public class ManagerLogIndexViewModel 
    {
        public Dictionary<Location, ManagerReport> Reports { get; set; }
        public List<Location> Locations { get; set; }
        public DateTime ForDate { get; set; }
    }
}
