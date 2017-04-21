using System.ComponentModel.DataAnnotations;

namespace ManagerReports.Data
{
    public class Location
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public bool Closed { get; set; }

    }
}