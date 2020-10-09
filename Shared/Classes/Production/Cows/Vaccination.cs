using System;
using System.ComponentModel.DataAnnotations;

namespace AUI.Shared.Classes.Production.Cows
{
    public class Vaccination
    {
        public long ID { get; set; }
        public int FarmID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string Purpose { get; set; }
        [StringLength(20, ErrorMessage = "Drug Name too long, try initials (20 character limit).")]
        public string DrugName { get; set; }
        [StringLength(20, ErrorMessage = "Its too long (20 character limit).")]
        public string Detail { get; set; }
        [Range(0, 1000000000, ErrorMessage = "Drug Quality overated, chose right unit (0-100000).")]
        public int ? DrugQuality { get; set; }
        public string DrugUnits { get; set; }
        [StringLength(50, ErrorMessage = "Explaination too long (50 character limit).")]
        public string Remark { get; set; }
        [Required]
        [StringLength(7)]
        public string Done { get; set; }
    }
}
