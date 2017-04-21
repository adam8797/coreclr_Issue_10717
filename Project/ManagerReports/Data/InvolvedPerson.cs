using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ManagerReports.Interfaces;

namespace ManagerReports.Data
{
    public class InvolvedPerson : IUpdatable
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string Name => FirstName + " " + LastName;

        public byte[] Image { get; set; }

        [MaxLength(30)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string State { get; set; }

        [MaxLength(10)]
        public string Zip { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string EmailAddress { get; set; }


        [MaxLength(50)]
        public string Occupation { get; set; }
        [MaxLength(50)]
        public string Employer { get; set; }
        public DateTime? BirthDate { get; set; }

        [MaxLength(20)]
        public string Pshrc { get; set; }

        [MaxLength(10)]
        public string EyeColor { get; set; }
        [MaxLength(10)]
        public string HairColor { get; set; }
        [MaxLength(10)]
        public string Weight { get; set; }

        [MaxLength(10)]
        public string Height { get; set; }

        /// <summary>
        /// true = male; false = female
        /// </summary>
        public bool? Sex { get; set; }

        [MaxLength(10)]
        public string Race { get; set; }

        [MaxLength(200)]
        public string Marks { get; set; }

        public virtual List<IncidentReport> InvolvedReports { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        [MaxLength(50)]
        public string LastUpdatedBy { get; set; }
    }
}