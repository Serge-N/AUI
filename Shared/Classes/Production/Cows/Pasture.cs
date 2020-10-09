using System;
using System.ComponentModel.DataAnnotations;

namespace AUI.Shared.Classes.Production.Cows
{
    public class Pasture
    {
        public long ID { get; set; }
        public long FarmID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime StopDate { get; set; }
        [Required]
        public string FeedType { get; set; }
        [Range(0, 1000000000, ErrorMessage = "0 for Natural free foods, this value is not acceptable. Try (0-10000000).")]
        public int? Cost { get; set; }
    }
}
