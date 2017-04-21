using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ManagerReports.Interfaces;

namespace ManagerReports.Data
{
    public class IncidentReport : IUpdatable
    {
        public IncidentReport()
        {
            InvolvedPersons = new List<InvolvedPerson>();
        }

        public Guid Id { get; set; }

        public DateTime DateTime { get; set; }

        public virtual Location Location { get; set; }

        [MaxLength(50)]
        public string Reporter { get; set; }

        [MaxLength(150)]
        public string WeatherConditions { get; set; }

        [MaxLength(20)]
        public string IncidentType { get; set; }

        [DefaultValue(false)]
        public bool Called911 { get; set; }

        [DefaultValue(false)]
        public bool NotificationFormSigned { get; set; }

        [DefaultValue(false)]
        public bool TreatmentRefused { get; set; }

        [DefaultValue(false)]
        public bool PhysicianListProvided { get; set; }

        public string Details { get; set; }

        [MaxLength(100)]
        public string ChiefComplaint { get; set; }

        public Mutuel Mutuel { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }

        public virtual List<InvolvedPerson> InvolvedPersons { get; set; }

    }

    [ComplexType]
    public class Mutuel
    {

        [MaxLength(50)]
        public string Category { get; set; }

        [MaxLength(50)]
        public string TellerName { get; set; }

        [MaxLength(50)]
        public string Bet { get; set; }

        [MaxLength(50)]
        public string TicketNumber { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(50)]
        public string Terminal { get; set; }

        [MaxLength(50)]
        public string Decision { get; set; }
    }
}